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
    public partial class UCCrearProducto : UserControl
    {

        private string rutaImagenSeleccionada;

        public UCCrearProducto()
        {
            InitializeComponent();
        }

        private void UCCrearProducto_Load(object sender, EventArgs e)
        {
            LogicaCategoria logicaCategoria = new LogicaCategoria();
            cmbCategoria.DataSource = logicaCategoria.CargarCategorias();
            cmbCategoria.DisplayMember = "NombreCategoria";
            cmbCategoria.ValueMember = "IdCategoria";

        }

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imagenes|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                rutaImagenSeleccionada = ofd.FileName;
                PictureBoxImagenProducto.Image = Image.FromFile(rutaImagenSeleccionada);
            }
        }

        private void ActualizarVistaPrevia()
        {
            lblVistaNombre.Text = txtNombreProducto.Text;
            lblVistaCodigo.Text = txtCodigoProducto.Text;
            lblVistaCategoria.Text = cmbCategoria.Text;
            lblVistaPrecioVenta.Text = $"Venta: {txtPrecioVenta.Text}";
            lblVistaPrecioCompra.Text = $"Compra: {txtPrecioCompra.Text}";
            lblVistaStock.Text = $"Stock: {NumericUpDownCantidadStock.Value}";

            if (!string.IsNullOrEmpty(rutaImagenSeleccionada) && File.Exists(rutaImagenSeleccionada))
            {
                pictureBoxVistaPrevia.Image = Image.FromFile(rutaImagenSeleccionada);
            }
        }


        private void LimpiarCampos()
        {
            txtCodigoProducto.Clear();
            txtNombreProducto.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
            NumericUpDownCantidadStock.Value = 0;
            cmbCategoria.SelectedIndex = -1;
            CheckBoxProductoDisponible.Checked = false;
            PictureBoxImagenProducto.Image = null;
            rutaImagenSeleccionada = null;
        }

        private void BtnGuardarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones
                if (string.IsNullOrWhiteSpace(txtCodigoProducto.Text) ||
                    string.IsNullOrWhiteSpace(txtNombreProducto.Text) ||
                    string.IsNullOrWhiteSpace(txtPrecioCompra.Text) ||
                    string.IsNullOrWhiteSpace(txtPrecioVenta.Text) ||
                    string.IsNullOrWhiteSpace(NumericUpDownCantidadStock.Text) ||
                    cmbCategoria.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor completa todos los campos.");
                    return;
                }

                if (!decimal.TryParse(txtPrecioCompra.Text, out decimal precioCompra) ||
                    !decimal.TryParse(txtPrecioVenta.Text, out decimal precioVenta) ||
                    !int.TryParse(NumericUpDownCantidadStock.Text, out int cantidad))
                {
                    MessageBox.Show("Precio y cantidad deben ser valores válidos.");
                    return;
                }

                // Copiar imagen si hay
                string rutaRelativa = "";
                if (!string.IsNullOrEmpty(rutaImagenSeleccionada))
                {
                    string carpetaDestino = Path.Combine(Application.StartupPath, "ImagenesProducto");
                    if (!Directory.Exists(carpetaDestino))
                        Directory.CreateDirectory(carpetaDestino);

                    string archivoDestino = Path.Combine(carpetaDestino, Path.GetFileName(rutaImagenSeleccionada));
                    File.Copy(rutaImagenSeleccionada, archivoDestino, true);

                    rutaRelativa = Path.Combine("ImagenesProducto", Path.GetFileName(rutaImagenSeleccionada));
                }

                // Cargar productos existentes
                var productos = new LogicaProducto().CargarListaProductos();

                // Crear nuevo producto
                var nuevoProducto = new Producto
                {
                    CodigoProducto = txtCodigoProducto.Text.Trim(),
                    NombreProducto = txtNombreProducto.Text.Trim(),
                    IdCategoria = cmbCategoria.SelectedValue.ToString(),
                    PrecioCompra = (double)precioCompra,
                    PrecioVenta = (double)precioVenta,
                    StockCantidad = cantidad,
                    ActivoDisponible = CheckBoxProductoDisponible.Checked,
                    RutaImagen = rutaRelativa,
                    FechaCreacion = DateTime.Now,
                    FechaActualizacion = DateTime.Now
                };

                productos.Add(nuevoProducto);

                // Guardar la lista completa
                LogicaProducto.GuardarListaProductos(productos);

                MessageBox.Show("Producto guardado correctamente.");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el producto: " + ex.Message);
            }
        }

        private void txtCodigoProducto_TextChanged(object sender, EventArgs e)
        {
            ActualizarVistaPrevia();
        }

        private void txtNombreProducto_TextChanged(object sender, EventArgs e)
        {
            ActualizarVistaPrevia();
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarVistaPrevia();
        }

        private void txtPrecioVenta_TextChanged(object sender, EventArgs e)
        {
            ActualizarVistaPrevia();
        }

        private void txtPrecioCompra_TextChanged(object sender, EventArgs e)
        {
            ActualizarVistaPrevia();
        }

        private void NumericUpDownCantidadStock_ValueChanged(object sender, EventArgs e)
        {
            ActualizarVistaPrevia();
        }

        private void pictureBoxVistaPrevia_Click(object sender, EventArgs e)
        {
            ActualizarVistaPrevia();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var cancelar = new UCInvertario();
            var formularioPrincipal = this.FindForm() as FrmMenuPrincipal;

            formularioPrincipal.PanelMainAccessor.Controls.Clear();
            formularioPrincipal.PanelMainAccessor.Controls.Add(cancelar);
            cancelar.Dock = DockStyle.Fill;
        }
    }
}
