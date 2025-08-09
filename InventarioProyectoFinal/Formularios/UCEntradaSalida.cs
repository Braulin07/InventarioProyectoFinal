using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text;
using InventarioProyectoFinal.Modelos;
using Microsoft.EntityFrameworkCore;
using InventarioProyectoFinal.ModelosAuxiliares;

namespace InventarioProyectoFinal.Formularios
{
    public partial class UCEntradaSalida : UserControl
    {
        private List<Producto> productos;
        private List<CarritoItem> carrito = new List<CarritoItem>();

        public UCEntradaSalida()
        {
            InitializeComponent();
        }

        private void UCEntradaSalida_Load(object sender, EventArgs e)
        {
            using var context = new StoreBPGContext();
            productos = context.Productos.ToList();

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
                    picVistaPrevia.Image = null;
                }
            }
        }

        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            var producto = (Producto)cmbProductos.SelectedItem;
            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Cantidad inválida.");
                return;
            }

            if (producto.StockCantidad < cantidad)
            {
                MessageBox.Show("Stock insuficiente.");
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
            ProcesarMovimiento("SALIDA");
        }

        private void btnConfirmarEntrada_Click(object sender, EventArgs e)
        {
            ProcesarMovimiento("ENTRADA");
        }

        private void ProcesarMovimiento(string tipo)
        {
            using var context = new StoreBPGContext();

            foreach (var item in carrito)
            {
                var producto = context.Productos.FirstOrDefault(p => p.CodigoProducto == item.CodigoProducto);
                if (producto == null)
                    continue;

                if (tipo == "ENTRADA")
                {
                    producto.StockCantidad += item.Cantidad;
                }
                else if (tipo == "SALIDA")
                {
                    if (producto.StockCantidad < item.Cantidad)
                    {
                        MessageBox.Show($"Stock insuficiente para el producto: {producto.NombreProducto}");
                        continue;
                    }

                    producto.StockCantidad -= item.Cantidad;
                }

                // Registrar el movimiento
                var movimiento = new MovimientoProducto
                {
                    CodigoProducto = producto.CodigoProducto,
                    Cantidad = item.Cantidad,
                    TipoMovimiento = tipo,
                    Fecha = DateTime.Now,
                    NombreUsuario = "usuario" // puedes reemplazar con usuario actual si lo tienes
                };

                context.MovimientoProductos.Add(movimiento);
            }

            context.SaveChanges();
            MessageBox.Show($"{tipo} registrada.");

            LimpiarFormulario();

            foreach (Control ctrl in this.Parent.Controls)
            {
                if (ctrl is UCInvertario inventario)
                {
                    inventario.RefrescarInventario();
                    break;
                }
            }
        }

        private void LimpiarFormulario()
        {
            carrito.Clear();
            dgvCarrito.Rows.Clear();
            lblTotal.Text = "Total: $0.00";
        }

        private void dgvCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Opcional: permitir eliminar elementos del carrito aquí
        }
    }
}
