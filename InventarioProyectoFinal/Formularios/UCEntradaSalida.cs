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
    public partial class UCEntradaSalida : UserControl
    {
        LogicaProducto logicaProducto = new LogicaProducto();
        List<Producto> productos;
        List<CarritoItem> carrito = new List<CarritoItem>();
        public UCEntradaSalida()
        {
            InitializeComponent();
            
        }

        private void UCEntradaSalida_Load(object sender, EventArgs e)
        {
            productos = logicaProducto.CargarListaProductos();

            cmbProductos.DataSource = productos;
            cmbProductos.DisplayMember = "NombreProducto";
            cmbProductos.ValueMember = "CodigoProducto";
        }

        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var producto = (Producto)cmbProductos.SelectedItem;
            if (producto != null)
            {
                lblNombreVista.Text = producto.NombreProducto;
                lblPrecioVista.Text = $"Precio: {producto.PrecioVenta}";
                lblStockVista.Text = $"Stock: {producto.StockCantidad}";

                if (!string.IsNullOrEmpty(producto.RutaImagen) && File.Exists(producto.RutaImagen))
                {
                    picVistaPrevia.Image = Image.FromFile(producto.RutaImagen);
                }
                else
                {
                    //picVistaPrevia.Image = Properties.Resources.ImagenDefault;
                }

            }
        }

        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            var producto = (Producto)cmbProductos.SelectedItem;
            int cantidad = int.Parse(txtCantidad.Text);

            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a 0");
                return;
            }

            if (producto.StockCantidad < cantidad)
            {
                MessageBox.Show("Stock insuficiente");
                return;
            }

            var item = new CarritoItem
            {
                CodigoProducto = producto.CodigoProducto,
                NombreProducto = producto.NombreProducto,
                Cantidad = cantidad,
                PrecioVenta = producto.PrecioVenta,
                Subtotal = producto.PrecioVenta * cantidad
            };

            carrito.Add(item);
            dgvCarrito.Rows.Add(item.CodigoProducto, item.NombreProducto, item.Cantidad, item.PrecioVenta, item.Subtotal);

            ActualizarTotal();
        }

        private void ActualizarTotal()
        {
            double total = carrito.Sum(x => x.Subtotal);
            lblTotal.Text = $"Total: {total:C}";
        }

        private void btnConfirmarSalida_Click(object sender, EventArgs e)
        {
            foreach (var item in carrito)
            {
                var producto = productos.First(p => p.CodigoProducto == item.CodigoProducto);
                producto.StockCantidad -= item.Cantidad;
            }

            LogicaProducto.GuardarListaProductos(productos);
            File.AppendAllText(@"BaseDeDatos\Salidas.txt", GenerarLogSalida());
            MessageBox.Show("Salida registrada.");
            LimpiarFormulario();

            // Encuentra el UCInventario activo y refresca
            foreach (Control ctrl in this.Parent.Controls)
            {
                if (ctrl is UCInvertario inventario)
                {
                    inventario.RefrescarInventario();
                    break;
                }
            }
        }

        private void btnConfirmarEntrada_Click(object sender, EventArgs e)
        {
            foreach (var item in carrito)
            {
                var producto = productos.First(p => p.CodigoProducto == item.CodigoProducto);
                producto.StockCantidad += item.Cantidad;
            }

            LogicaProducto.GuardarListaProductos(productos);
            File.AppendAllText(@"BaseDeDatos\Entradas.txt", GenerarLogEntrada());
            MessageBox.Show("Entrada registrada.");
            LimpiarFormulario();

            // Encuentra el UCInventario activo y refresca
            foreach (Control ctrl in this.Parent.Controls)
            {
                if (ctrl is UCInvertario inventario)
                {
                    inventario.RefrescarInventario();
                    break;
                }
            }
        }

        private string GenerarLogSalida()
        {
            var sb = new StringBuilder();
           // string usuario = UsuarioActual; // Variable global que defines al abrir el form UCEntradaSalida
            string fecha = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            foreach (var item in carrito)
            {
                sb.AppendLine($"{item.CodigoProducto}|{item.Cantidad}|{item.Subtotal}|{fecha}|Usuario");
            }

            return sb.ToString();
        }

        private string GenerarLogEntrada()
        {
            var sb = new StringBuilder();
            //string usuario = UsuarioActual;
            string fecha = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            foreach (var item in carrito)
            {
                sb.AppendLine($"{item.CodigoProducto}|{item.Cantidad}|{item.Subtotal}|{fecha}|usuario");
            }

            return sb.ToString();
        }

        private void LimpiarFormulario()
        {
            carrito.Clear();
            dgvCarrito.Rows.Clear();
            lblTotal.Text = "Total: $0.00";
        }

        

        private void dgvCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
