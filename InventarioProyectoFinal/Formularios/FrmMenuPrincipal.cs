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
    public partial class FrmMenuPrincipal : Form
    {

        bool sidebarExpand;
        public Usuario UsuarioActual { get; set; }


        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            if (UsuarioActual != null)
            {
                CargarPanelUsuario(UsuarioActual);
            }

            var inicio = new UCInicio();
            inicio.CargarUsuario(UsuarioActual); // usuarioActual debe estar definido al logear
            panelMain.Controls.Clear();
            panelMain.Controls.Add(inicio);
            inicio.Dock = DockStyle.Fill;

        }

        private void pictureBoxLogoMenu_Click(object sender, EventArgs e)
        {
            UCInicio uc = new UCInicio();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        //agregue un timer para el manejo de la animacion de la barra lateral 
        //el timer setea lo que es el minimo y el ancho ya preestablecido del panel
        private void slidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                // Contraer
                sidebar.Width -= 10;
                panelMain.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width && panelMain.Width == panelMain.MinimumSize.Width)
                {
                    sidebar.Width = sidebar.MinimumSize.Width;
                    panelMain.Width = panelMain.MinimumSize.Width;
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                // Expandir
                sidebar.Width += 10;
                panelMain.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width && panelMain.Width == panelMain.MaximumSize.Width)
                {
                    sidebar.Width = sidebar.MaximumSize.Width;
                    panelMain.Width = panelMain.MaximumSize.Width;
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }


        //Metodo para signar nombre e imagen en el panel lateral e identificar el usuario que esta logueado
        private void CargarPanelUsuario(Usuario usuario)
        {
            lblNombreUsuario.Text = usuario.NombreUsuario;

            if (!string.IsNullOrEmpty(usuario.RutaImagen))
            {
                string rutaCompleta = Path.Combine(Application.StartupPath, usuario.RutaImagen);

                if (File.Exists(rutaCompleta))
                {
                    pictureBoxUsuario.Image = Image.FromFile(rutaCompleta);
                }

            }

        }

        //Boton que inicializa la animacion del panel lateral
        private void MenuBoton_Click_1(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }


        //Botonoes para abrir las visat de cada User control
        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            UCEstadisticas UCEstadisticas = new UCEstadisticas();
            UCEstadisticas.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(UCEstadisticas);
        }


        private void btnInventario_Click(object sender, EventArgs e)
        {
            UCInvertario UCInventario = new UCInvertario();
            UCInventario.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(UCInventario);

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            UCVerUsuarios UCVerUsuario = new UCVerUsuarios();
            UCVerUsuario.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(UCVerUsuario);
        }

        //Boton que hace log out y termina la ejecucion del proyecto
        private void ImgLogOut_Click(object sender, EventArgs e)
        {
            // Guarda en el log
            if (UsuarioActual != null)
            {
                LogicaUsuario.RegistrarSalidaSistema(UsuarioActual.NombreUsuario);
            }

            this.Close();
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            UCAcercaDe uCAcercaDe = new UCAcercaDe();
            uCAcercaDe.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(uCAcercaDe);

        }










        //Creador de acceso al Panel Main
        public Panel PanelMainAccessor
        {
            get { return panelMain; }
        }
    }
}
