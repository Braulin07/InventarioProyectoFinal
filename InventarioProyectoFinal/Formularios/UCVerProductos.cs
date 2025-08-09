using InventarioProyectoFinal.Interfaces;
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
    public partial class UCVerProductos : UserControl
    {
        private Producto productoActual;

        public UCVerProductos()
        {
            InitializeComponent();
        }

        private void UCVerProductos_Load(object sender, EventArgs e)
        {
            CargarProductosEnTarjetas();
            panelEditorProducto.Visible = false;
        }

        private void MostrarPanelEditor(Producto producto)
        {
            // Activar el panel que ya creaste
            panelEditorProducto.Visible = true;

            // Asigna los valores a los controles existentes
            txtNombre.Text = producto.NombreProducto;
            txtCodigo.Text = producto.CodigoProducto;
            txtPrecioCompra.Text = producto.PrecioCompra.ToString();
            txtPrecioVenta.Text = producto.PrecioVenta.ToString();
            chkActivo.Checked = producto.Disponible;

            // Imagen
            picProducto.ImageLocation = producto.RutaImagen;
            picProducto.Tag = producto.RutaImagen; // Para cambiarla luego si se desea

            // Guarda el producto actual en una variable global si necesitas actualizar luego
            productoActual = producto;
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            var logica = new LogicaProducto();
            var lista = logica.CargarListaProductos();

            var prod = lista.FirstOrDefault(p => p.CodigoProducto == productoActual.CodigoProducto);
            if (prod != null)
            {
                prod.NombreProducto = txtNombre.Text;
                prod.CodigoProducto = txtCodigo.Text;
                prod.PrecioCompra = double.Parse(txtPrecioCompra.Text);
                prod.PrecioVenta = double.Parse(txtPrecioVenta.Text);
                prod.Disponible = chkActivo.Checked;
                prod.RutaImagen = picProducto.Tag?.ToString() ?? productoActual.RutaImagen;
            }

            logica.GuardarProducto(prod);
            MessageBox.Show("Producto actualizado");
            panelEditorProducto.Visible = false;
            CargarProductosEnTarjetas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog { Filter = "Imágenes|*.jpg;*.png" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string rutaDestino = Path.Combine("ImagenesProductos", Path.GetFileName(ofd.FileName));
                    File.Copy(ofd.FileName, rutaDestino, true);
                    picProducto.ImageLocation = rutaDestino;
                    picProducto.Tag = rutaDestino;
                }
            }
        }

        private void CargarProductosEnTarjetas()
        {
            flowProductos.Controls.Clear();
            var lista = new LogicaProducto().CargarListaProductos();

            foreach (var p in lista)
            {
                var boton = new Button
                {
                    Text = p.NombreProducto,
                    Width = 150,
                    Height = 80,
                    BackColor = Color.LightGray,
                    Tag = p, // guarda el producto para usarlo al hacer clic
                    Font = new Font("Century Gothic", 10, FontStyle.Bold),
                };

                boton.Click += (s, e) =>
                {
                    var producto = (Producto)((Button)s).Tag;
                    MostrarPanelEditor(producto);
                };

                flowProductos.Controls.Add(boton);
            }
        }

    }
}
