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
using Microsoft.EntityFrameworkCore;
using InventarioProyectoFinal.Modelos;
using System.Globalization;


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
                    using (var db = new StoreBPGContext())
                    {
                        var productos = db.Productos.Include(p => p.Categoria).ToList();

                        var lines = new List<string>
                {
                    "Código|Nombre|Categoría|Precio Compra|Precio Venta|Stock|Activo|Imagen|Fecha Creación|Fecha Actualización"
                };

                        foreach (var p in productos)
                        {
                            string categoria = p.Categoria?.NombreCategoria ?? "Sin categoría";

                            lines.Add($"{p.CodigoProducto}|{p.NombreProducto}|{categoria}|{p.PrecioCompra}|{p.PrecioVenta}|{p.StockCantidad}|{(p.Disponible ? "Activo" : "Inactivo")}|{p.RutaImagen}|{p.FechaCreacion}|{p.FechaActualizacion}");
                        }

                        File.WriteAllLines(sfd.FileName, lines);
                        MessageBox.Show("Reporte CSV generado correctamente.");
                    }
                }
            }
        }


        private void CargarDatos()
        {
            using (var db = new StoreBPGContext())
            {
                DateTime desde = dtpDesde.Value.Date;
                DateTime hasta = dtpHasta.Value.Date.AddDays(1).AddTicks(-1);
                string campo = cmbCampoFiltro.Text;
                string valor = txtValorFiltro.Text.Trim().ToLower();

                var movimientos = db.MovimientoProductos
                    .Where(m => m.Fecha >= desde && m.Fecha <= hasta)
                    .ToList();

                if (!string.IsNullOrEmpty(valor) && !string.IsNullOrEmpty(campo))
                {
                    if (campo == "Código")
                        movimientos = movimientos.Where(m => m.CodigoProducto.ToLower().Contains(valor)).ToList();
                    else if (campo == "Usuario")
                        movimientos = movimientos.Where(m => m.NombreUsuario.ToLower().Contains(valor)).ToList();
                }

                LlenarDataGridView(movimientos);
                GenerarGraficos(movimientos);
            }
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
            using (var db = new StoreBPGContext())
            {
                dgvMovimientos.Rows.Clear();

                foreach (var m in movimientos)
                {
                    dgvMovimientos.Rows.Add(m.CodigoProducto, m.TipoMovimiento, m.Cantidad, m.Subtotal, m.Fecha.HasValue ? m.Fecha.Value.ToString("dd/MM/yyyy HH:mm") : "", m.NombreUsuario);
                }

                                        decimal totalVentas = movimientos
                            .Where(x => x.TipoMovimiento == "Salida")
                            .Sum(x => x.Subtotal ?? 0); // Convierte nulo a 0

                lblStock.Text = "Stock: " + db.Productos.Sum(p => p.StockCantidad);
                lblVendido.Text = "Vendido: " + movimientos.Where(x => x.TipoMovimiento == "Salida").Sum(x => x.Cantidad);
                lblVentas.Text = "Ventas: " + totalVentas.ToString("C", CultureInfo.CreateSpecificCulture("es-DO"));
                lblRangoFechas.Text = $"Del {dtpDesde.Value:dd/MM/yyyy} al {dtpHasta.Value:dd/MM/yyyy}";
            }
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
