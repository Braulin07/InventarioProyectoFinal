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
    public partial class UCCrearCategoria : UserControl
    {
        List<CategoriaProducto> categorias = new List<CategoriaProducto>();
        string rutaArchivo = @"BaseDeDatos\CategoriaProducto.txt";
        public UCCrearCategoria()
        {
            InitializeComponent();
        }

        private void UCCrearCategoria_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void CargarCategorias()
        {
            dgvCategorias.Rows.Clear();
            categorias.Clear();

            if (!File.Exists(rutaArchivo))
            {
                File.Create(rutaArchivo).Close();
            }

            foreach (var linea in File.ReadLines(rutaArchivo))
            {
                var partes = linea.Split('|');
                if (partes.Length >= 2)
                {
                    var categoria = new CategoriaProducto
                    {
                        IdCategoria = partes[0].Trim(),
                        NombreCategoria = partes[1].Trim(),
                    };
                    categorias.Add(categoria);
                    dgvCategorias.Rows.Add(categoria.IdCategoria, categoria.NombreCategoria);
                }
            }
        }

        private void btnGuardarCategoria_Click(object sender, EventArgs e)
        {
            string id = txtIdCategoria.Text.Trim();
            string nombre = txtNombreCategoria.Text.Trim();

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Debe completar todos los campos.");
                return;
            }

            if (categorias.Any(c => c.IdCategoria == id))
            {
                MessageBox.Show("Ya existe una categoría con ese ID.");
                return;
            }

            string linea = $"{id}|{nombre}";
            File.AppendAllText(rutaArchivo, Environment.NewLine + linea);

            MessageBox.Show("Categoría guardada correctamente.");
            LimpiarCampos();
            CargarCategorias();
        }

        private void LimpiarCampos()
        {
            txtIdCategoria.Clear();
            txtNombreCategoria.Clear();
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
