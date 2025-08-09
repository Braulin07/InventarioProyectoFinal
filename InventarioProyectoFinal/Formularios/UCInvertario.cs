using InventarioProyectoFinal.Logica;
using InventarioProyectoFinal.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioProyectoFinal.Formularios
{
    public partial class UCInvertario : UserControl
    {
        LogicaProducto LogicaProducto = new LogicaProducto();
        public UCInvertario()
        {
            InitializeComponent();
        }

        private void UCInvertario_Load(object sender, EventArgs e)
        {

            var logicaProducto = new LogicaProducto();
            var productos = logicaProducto.CargarListaProductos();

            // Lee y agrega los productos al DataGridView
            foreach (var recorrer in LogicaProducto.CargarListaProductos())
            {
                dgvInventario.Rows.Add(recorrer.CodigoProducto, recorrer.NombreProducto, recorrer.CategoriaId, recorrer.PrecioCompra,
                                        recorrer.PrecioVenta, recorrer.StockCantidad, recorrer.Disponible);
            }

            /********************Tarjetas de informacion***********************************/

            // Total de stock de los activos
            int totalStockActivos = productos
                .Where(p => p.Disponible) // Filtra solo los activos
                .Sum(p => p.StockCantidad);

            //Ganancia Estimada




            // Mostrar en el Label
            lblNumeroProductos.Text = logicaProducto.CargarListaProductos().Count.ToString();
            lblNumerosEnStock.Text = totalStockActivos.ToString();

            //lblNumerosDisponibles.Text = 

        }

        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnCrearProducto_Click(object sender, EventArgs e)
        {
            UCCrearProducto UCCrearProducto = new UCCrearProducto();

            var formularioPrincipal = this.FindForm() as FrmMenuPrincipal;

            formularioPrincipal.PanelMainAccessor.Controls.Clear();
            formularioPrincipal.PanelMainAccessor.Controls.Add(UCCrearProducto);
            UCCrearProducto.Dock = DockStyle.Fill;
        }

        private void BtnCrearCategoria_Click(object sender, EventArgs e)
        {
            UCCrearCategoria UCCrearCategoria = new UCCrearCategoria();

            var formularioPrincipal = this.FindForm() as FrmMenuPrincipal;

            formularioPrincipal.PanelMainAccessor.Controls.Clear();
            formularioPrincipal.PanelMainAccessor.Controls.Add(UCCrearCategoria);
            UCCrearCategoria.Dock = DockStyle.Fill;
        }

        private void BtnEntradaSalida_Click(object sender, EventArgs e)
        {
            UCEntradaSalida UCEntradaSalida = new UCEntradaSalida();

            var formularioPrincipal = this.FindForm() as FrmMenuPrincipal;

            formularioPrincipal.PanelMainAccessor.Controls.Clear();
            formularioPrincipal.PanelMainAccessor.Controls.Add(UCEntradaSalida);
            UCEntradaSalida.Dock = DockStyle.Fill;

        }

        public void RefrescarInventario()
        {
            dgvInventario.Rows.Clear();
            var productos = LogicaProducto.CargarListaProductos();
            foreach (var p in productos)
            {
                dgvInventario.Rows.Add(p.CodigoProducto, p.NombreProducto, p.CategoriaId, p.PrecioCompra,
                                       p.PrecioVenta, p.StockCantidad, p.Disponible);
            }
        }

        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            UCVerProductos uCVerProductos = new UCVerProductos();

            var formularioPrincipal = this.FindForm() as FrmMenuPrincipal;

            formularioPrincipal.PanelMainAccessor.Controls.Clear();
            formularioPrincipal.PanelMainAccessor.Controls.Add(uCVerProductos);
            uCVerProductos.Dock = DockStyle.Fill;

        }

        private void dgvInventario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvInventario.Columns[e.ColumnIndex].Name == "StockCantidad" && e.RowIndex >= 0)
            {
                // Toma el valor de la celda de stock
                int stock = Convert.ToInt32(dgvInventario.Rows[e.RowIndex].Cells["StockCantidad"].Value);

                // Determina el color de fondo según el stock
                if (stock == 0)
                {
                    dgvInventario.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.IndianRed;
                }
                else if (stock <= 5)
                {
                    dgvInventario.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Khaki;
                }
                else
                {
                    dgvInventario.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }

        private void FiltrarPorStock(int? minimo, int? maximo)
        {
            dgvInventario.Rows.Clear();

            var productos = LogicaProducto.CargarListaProductos();

            var filtrados = productos.Where(p =>
                (!minimo.HasValue || p.StockCantidad >= minimo.Value) &&
                (!maximo.HasValue || p.StockCantidad <= maximo.Value)).ToList();

            foreach (var p in filtrados)
            {
                dgvInventario.Rows.Add(p.CodigoProducto, p.NombreProducto, p.CategoriaId, p.PrecioCompra,
                                       p.PrecioVenta, p.StockCantidad, p.Disponible);
            }
        }


        private void btnFiltroRojo_Click(object sender, EventArgs e)
        {
            FiltrarPorStock(0, 0);
        }

        private void btnFiltroAmarillo_Click(object sender, EventArgs e)
        {
            FiltrarPorStock(1, 5);
        }

        private void btnFiltroVerde_Click(object sender, EventArgs e)
        {
            FiltrarPorStock(6, null);
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            RefrescarInventario();
        }

        private void panelTarjetasEstadisticas_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
