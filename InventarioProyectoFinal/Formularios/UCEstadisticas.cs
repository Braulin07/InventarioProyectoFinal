using InventarioProyectoFinal.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScottPlot;
using InventarioProyectoFinal.Modelos;

namespace InventarioProyectoFinal.Formularios
{
    public partial class UCEstadisticas : UserControl
    {
        public UCEstadisticas()
        {
            InitializeComponent();
        }

        private void UCEstadisticas_Load(object sender, EventArgs e)
        {
            cmbCampoFiltro.Items.Clear();
            cmbCampoFiltro.Items.Add("Código");
            cmbCampoFiltro.Items.Add("Usuario");
            cmbCampoFiltro.SelectedIndex = 0;

            dtpDesde.Value = DateTime.Now.AddDays(-30); // Últimos 30 días por defecto
            dtpHasta.Value = DateTime.Now;

            CargarDatos();
        }

        private void btnGenerarCSV_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog() { Filter = "CSV files|*.csv" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var productos = new LogicaProducto().CargarListaProductos();
                    var categorias = new LogicaCategoria().CargarCategorias();

                    var lines = new List<string>
            {
                "Código|Nombre|Categoría|Precio Compra|Precio Venta|Stock|Activo|Imagen|Fecha Creación|Fecha Actualización"
            };

                    foreach (var p in productos)
                    {
                        var categoria = categorias.FirstOrDefault(c => c.IdCategoria == p.IdCategoria)?.NombreCategoria ?? "Sin categoría";

                        lines.Add($"{p.CodigoProducto}|{p.NombreProducto}|{categoria}|{p.PrecioCompra}|{p.PrecioVenta}|{p.StockCantidad}|{(p.ActivoDisponible ? "Activo" : "Inactivo")}|{p.RutaImagen}|{p.FechaCreacion}|{p.FechaActualizacion}");
                    }

                    File.WriteAllLines(sfd.FileName, lines);
                    //File.AppendAllText(sfd.FileName, $"Generado por: {lblUsuario.Text} el {DateTime.Now:dd/MM/yyyy HH:mm}\n");

                    MessageBox.Show("Reporte CSV generado correctamente.");
                }
            }
        }


        private void CargarDatos()
        {
            var movimientos = new List<MovimientoProducto>();

            string[] entradas = File.Exists(@"BaseDeDatos\Entradas.txt") ? File.ReadAllLines(@"BaseDeDatos\Entradas.txt") : new string[0];
            string[] salidas = File.Exists(@"BaseDeDatos\Salidas.txt") ? File.ReadAllLines(@"BaseDeDatos\Salidas.txt") : new string[0];

            // Formato fijo para evitar errores por idioma
            var formato = "yyyy-MM-dd HH:mm:ss";
            var cultura = System.Globalization.CultureInfo.InvariantCulture;

            foreach (var linea in entradas)
            {
                var datos = linea.Split('|');
                if (datos.Length >= 5)
                {
                    movimientos.Add(new MovimientoProducto
                    {
                        CodigoProducto = datos[0],
                        TipoMovimiento = "Entrada",
                        Cantidad = decimal.TryParse(datos[1], out var cant) ? cant : 0,
                        Subtotal = decimal.TryParse(datos[2], out var sub) ? sub : 0,
                        Fecha = DateTime.ParseExact(datos[3], formato, cultura),
                        Usuario = datos[4]
                    });
                }
            }

            foreach (var linea in salidas)
            {
                var datos = linea.Split('|');
                if (datos.Length >= 5)
                {
                    movimientos.Add(new MovimientoProducto
                    {
                        CodigoProducto = datos[0],
                        TipoMovimiento = "Salida",
                        Cantidad = decimal.TryParse(datos[1], out var cant) ? cant : 0,
                        Subtotal = decimal.TryParse(datos[2], out var sub) ? sub : 0,
                        Fecha = DateTime.ParseExact(datos[3], formato, cultura),
                        Usuario = datos[4]
                    });
                }
            }

            // FILTROS
            DateTime desde = dtpDesde.Value.Date;
            DateTime hasta = dtpHasta.Value.Date.AddDays(1).AddTicks(-1);
            string campo = cmbCampoFiltro.Text;
            string valor = txtValorFiltro.Text.Trim().ToLower();

            var filtrados = movimientos
                .Where(m => m.Fecha >= desde && m.Fecha <= hasta)
                .ToList();

            if (!string.IsNullOrEmpty(valor) && !string.IsNullOrEmpty(campo))
            {
                if (campo == "Código")
                    filtrados = filtrados.Where(m => m.CodigoProducto.ToLower().Contains(valor)).ToList();
                else if (campo == "Usuario")
                    filtrados = filtrados.Where(m => m.Usuario.ToLower().Contains(valor)).ToList();
            }

            LlenarDataGridView(filtrados);
            GenerarGraficos(filtrados);
        }


        private void GenerarGraficos(List<MovimientoProducto> movimientos)
        {
            var porProducto = movimientos
                    .Where(m => m.TipoMovimiento == "Salida")
                    .GroupBy(m => m.CodigoProducto)
                    .Select(g => new
                    {
                        Codigo = g.Key,
                        Cantidad = g.Sum(x => x.Cantidad),
                        Total = g.Sum(x => x.Subtotal)
                    }).ToList();
            if (porProducto.Count > 0)
            {
                // Barras: Cantidad por producto
                scottPlotBarras.Plot.Clear();
                scottPlotBarras.Plot.AddBar(porProducto.Select(p => (double)p.Cantidad).ToArray());
                scottPlotBarras.Plot.XTicks(porProducto.Select((p, i) => (double)i).ToArray(), porProducto.Select(p => p.Codigo).ToArray());
                scottPlotBarras.Refresh();

                // Línea: Total vendido por producto
                scottPlotLineas.Plot.Clear();
                scottPlotLineas.Plot.AddScatter(
                    porProducto.Select((p, i) => (double)i).ToArray(),
                    porProducto.Select(p => (double)p.Total).ToArray());
                scottPlotLineas.Refresh();
            }
            else
            {
                scottPlotBarras.Plot.Clear();
                scottPlotLineas.Plot.Clear();
                scottPlotBarras.Refresh();
                scottPlotLineas.Refresh();
            }
        }

        private void LlenarDataGridView(List<MovimientoProducto> movimientos)
        {
            LogicaProducto logicaProducto = new LogicaProducto();
            dgvMovimientos.Rows.Clear();
            foreach (var m in movimientos)
            {
                dgvMovimientos.Rows.Add(m.CodigoProducto, m.TipoMovimiento, m.Cantidad, m.Subtotal, m.Fecha.ToString("dd/MM/yyyy HH:mm"), m.Usuario);
            }

            lblStock.Text = "Stock: " + logicaProducto.CargarListaProductos().Sum(p => p.StockCantidad);
            lblVendido.Text = "Vendido: " + movimientos.Where(x => x.TipoMovimiento == "Salida").Sum(x => x.Cantidad);
            lblVentas.Text = "Ventas: " + movimientos.Where(x => x.TipoMovimiento == "Salida").Sum(x => x.Subtotal).ToString("C");
            lblRangoFechas.Text = $"Del {dtpDesde.Value:dd/MM/yyyy} al {dtpHasta.Value:dd/MM/yyyy}";
        }

        private void txtValorFiltro_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        
    }
}
