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
        private StoreBPGContext dbContext;

        public UCCrearCategoria()
        {
            InitializeComponent();
            dbContext = new StoreBPGContext(); // Inicializa el DbContext
        }

        private void UCCrearCategoria_Load(object sender, EventArgs e)
        {
            CargarCategoriasDesdeBD();
        }

        private void CargarCategoriasDesdeBD()
        {
            dgvCategorias.Rows.Clear();

            var categoriasBD = dbContext.Categoria.ToList(); // Obtiene todas las categorías

            foreach (var categoria in categoriasBD)
            {
                dgvCategorias.Rows.Add(categoria.CategoriaId, categoria.NombreCategoria);
            }
        }

        private void btnGuardarCategoria_Click(object sender, EventArgs e)
        {
            string idTexto = txtIdCategoria.Text.Trim();
            string nombre = txtNombreCategoria.Text.Trim();

            if (string.IsNullOrEmpty(idTexto) || string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Debe completar todos los campos.");
                return;
            }

            if (!int.TryParse(idTexto, out int id))
            {
                MessageBox.Show("El ID debe ser un número entero.");
                return;
            }

            // Verificar si ya existe una categoría con el mismo ID
            bool existe = dbContext.Categoria.Any(c => c.CategoriaId == id);

            if (existe)
            {
                MessageBox.Show("Ya existe una categoría con ese ID.");
                return;
            }

            // Crear nueva categoría
            var nuevaCategoria = new Categoria
            {
                CategoriaId = id,
                NombreCategoria = nombre
            };

            dbContext.Categoria.Add(nuevaCategoria);
            dbContext.SaveChanges(); // Guarda en la base de datos

            MessageBox.Show("Categoría guardada correctamente.");
            LimpiarCampos();
            CargarCategoriasDesdeBD();
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
