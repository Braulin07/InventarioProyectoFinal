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
    public partial class UCInicio : UserControl
    {
        private Usuario usuarioActual;

        public UCInicio()
        {
            InitializeComponent();
        }

        public void CargarUsuario(Usuario usuario)
        {
            usuarioActual = usuario;

            // Mostrar saludo
            lblBienvenida.Text = $"Bienvenido, {usuarioActual.NombreUsuario}";
        }

        private void UCInicio_Load(object sender, EventArgs e)
        {
            
        }

        //Estadisticas boton
        private void gunaImgEstadisticas_Click(object sender, EventArgs e)
        {
            var estadisticas = new UCEstadisticas();
            CambiarVista(estadisticas);

        }

        private void gunaImgEstadisticas_MouseEnter(object sender, EventArgs e)
        {
            gunaImgEstadisticas.BackColor = Color.Gold;
            gunaImgEstadisticas.Cursor = Cursors.Hand;
        }

        private void gunaImgEstadisticas_MouseLeave(object sender, EventArgs e)
        {
            gunaImgEstadisticas.BackColor = Color.Transparent;
            gunaImgEstadisticas.Cursor = Cursors.Default;
        }

        //Inventario Boton
        private void gunaImgInventario_Click(object sender, EventArgs e)
        {
            var inventario = new UCInvertario();
            CambiarVista(inventario);
        }

        private void gunaImgInventario_MouseEnter(object sender, EventArgs e)
        {
            gunaImgEstadisticas.BackColor = Color.Gold;
            gunaImgEstadisticas.Cursor = Cursors.Hand;
        }

        private void gunaImgInventario_MouseLeave(object sender, EventArgs e)
        {
            gunaImgEstadisticas.BackColor = Color.Transparent;
            gunaImgEstadisticas.Cursor = Cursors.Default;
        }

        //Usuario Boton
        private void gunaImgUsuarios_Click(object sender, EventArgs e)
        {
            var verUsuarios = new UCVerUsuarios();
            CambiarVista(verUsuarios);
        }

        private void gunaImgUsuarios_MouseEnter(object sender, EventArgs e)
        {
            gunaImgEstadisticas.BackColor = Color.Gold;
            gunaImgEstadisticas.Cursor = Cursors.Hand;
        }

        private void gunaImgUsuarios_MouseLeave(object sender, EventArgs e)
        {
            gunaImgEstadisticas.BackColor = Color.Transparent;
            gunaImgEstadisticas.Cursor = Cursors.Default;
        }

        private void CambiarVista(UserControl control)
        {
            var formulario = this.FindForm() as FrmMenuPrincipal;
            formulario.PanelMainAccessor.Controls.Clear();
            formulario.PanelMainAccessor.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }
    }
}
