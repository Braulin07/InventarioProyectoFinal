using InventarioProyectoFinal.Interfaces;
using InventarioProyectoFinal.Logica;
using InventarioProyectoFinal.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioProyectoFinal.Formularios
{
    public partial class UCResultadoBusquedaUsuario : UserControl
    {
        public UCResultadoBusquedaUsuario()
        {
            InitializeComponent();
        }

        private void UCResultadoBusquedaUsuario_Load(object sender, EventArgs e)
        {

        }

        public void CargarDatos(Usuario usuario)
        {

            lblUsuarioBusqueda.Text = usuario.NombreUsuario;
            lblRolBusqueda.Text = usuario.Rol;
            lblEstadoBusqueda.Text = usuario.UsuarioActivo ? "Activo" : "Inactivo";

            if (!string.IsNullOrEmpty(usuario.RutaImagen) && File.Exists(usuario.RutaImagen))
            {
                ImagenBusqueda.Image = Image.FromFile(usuario.RutaImagen);
            }
            else
            {
                ImagenBusqueda.Image = Properties.Resources.boy_avatar_icon;
            }

            this.Usuario = usuario; // Guarda el objeto para usar en el click
        }

        public event EventHandler<UsuarioSeleccionadoEvento> UsuarioSeleccionado;
        private void UCResultadoBusquedaUsuario_Click(object sender, EventArgs e)
        {
            UsuarioSeleccionado?.Invoke(this, new UsuarioSeleccionadoEvento { Usuario = this.Usuario });
        }

        public Usuario Usuario { get; private set; }

        


    }


}
