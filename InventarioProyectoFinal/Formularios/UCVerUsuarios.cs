using Guna.UI2.WinForms;
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
    public partial class UCVerUsuarios : UserControl
    {
        private LogicaUsuario logicaUsuario = new LogicaUsuario();

        public UCVerUsuarios()
        {
            InitializeComponent();
        }

        private void UCVerUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuariosEnTarjetas();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            flowUsuarios.Controls.Clear();

            var listaUsuarios = logicaUsuario.CargarUsuarios();
            string criterio = txtBuscar.Text;

            var filtrados = listaUsuarios
                .Where(u => u.NombreUsuario.IndexOf(criterio, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            foreach (var usuario in filtrados)
            {
                var tarjeta = new UCResultadoBusquedaUsuario();
                tarjeta.CargarDatos(usuario);
                tarjeta.UsuarioSeleccionado += (s, e) => MostrarPanelEditor(e.Usuario);
                flowUsuarios.Controls.Add(tarjeta);
            }
        }

        private void CargarUsuariosEnTarjetas()
        {
            flowUsuarios.Controls.Clear();

            var listaUsuarios = logicaUsuario.CargarUsuarios();

            foreach (var usuario in listaUsuarios)
            {
                var tarjeta = new UCResultadoBusquedaUsuario();
                tarjeta.CargarDatos(usuario);
                tarjeta.UsuarioSeleccionado += (s, e) => MostrarPanelEditor(e.Usuario);

                flowUsuarios.Controls.Add(tarjeta);
            }
        }

        //Creado con Chat GPT para que el panel sea visible solo cuando el usuario sea seleccionado
        //asi no se ve el panel desorganizado cuando abrimos el UCVerUsuario
        private void MostrarPanelEditor(Usuario usuario)
        {
            panelEditorUsuario.Controls.Clear();

            Guna2CirclePictureBox picFoto = new Guna2CirclePictureBox
            {
                
                ImageLocation = usuario.RutaImagen,
                Size = new Size(100, 100),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point(85, 3),
                BackColor = Color.Transparent

            };

            

            Label lblNombre = new Label
            {
                Text = $"Usuario: {usuario.NombreUsuario}",
                Font = new Font("Arial", 10, FontStyle.Bold),
                Location = new Point(90, 105),
                BackColor = Color.Transparent,
                Size = new Size(150, 35)
            };

            CheckBox chkActivo = new CheckBox
            {
                Text = "Activo",
                Checked = usuario.UsuarioActivo,
                Location = new Point(110, 130),
                BackColor = Color.Transparent,
                Size = new Size(100, 25)
            };

            Guna2TextBox txtRol = new Guna2TextBox
            {
                Text = usuario.Rol,
                Font = new Font("Century Gothic", 10, FontStyle.Regular),
                Location = new Point(38, 160),
                Size = new Size(205, 35),
            };

            Guna2Button btnGuardar = new Guna2Button
            {
                Text = "Guardar Cambios",
                Location = new Point(40, 200),
                Size = new Size(200, 43),
                AutoRoundedCorners = true,
                BackColor = Color.Transparent,
                FillColor = Color.Black,
                Font = new Font("Century Gothic", 9, FontStyle.Bold),
            };
            btnGuardar.Click += (s, e) => GuardarCambiosUsuario(usuario, txtRol.Text, chkActivo.Checked);

            Guna2Button btnCancelar = new Guna2Button
            {
                Text = "Cancelar",
                Location = new Point(40, 245),
                Size = new Size(200, 43),
                AutoRoundedCorners = true,
                BackColor = Color.Transparent,
                FillColor = Color.Black,
                Font = new Font("Century Gothic", 9, FontStyle.Bold),
            };
            btnCancelar.Click += (s, e) => panelEditorUsuario.Visible = false;

            // Agrega los controles al panel
            panelEditorUsuario.Controls.Add(btnGuardar);
            panelEditorUsuario.Controls.Add(btnCancelar);
            panelEditorUsuario.Controls.Add(chkActivo);
            panelEditorUsuario.Controls.Add(txtRol);
            panelEditorUsuario.Controls.Add(lblNombre);
            panelEditorUsuario.Controls.Add(picFoto);

            panelEditorUsuario.Visible = true;
        }



        private void GuardarCambiosUsuario(Usuario usuario, string nuevoRol, bool nuevoEstado)
        {
            var usuarios = logicaUsuario.CargarUsuarios();
            var modificado = usuarios.FirstOrDefault(u => u.NombreUsuario == usuario.NombreUsuario);

            if (modificado != null)
            {
                modificado.Rol = nuevoRol;
                modificado.UsuarioActivo = nuevoEstado;
            }

            LogicaUsuario.GuardarListaUsuarios(usuarios);

            MessageBox.Show("Cambios guardados correctamente");
            CargarUsuariosEnTarjetas();
            panelEditorUsuario.Visible = false;
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            UCCrearUsuario UCCrearUsuario = new UCCrearUsuario();

            var formularioPrincipal = this.FindForm() as FrmMenuPrincipal;

            formularioPrincipal.PanelMainAccessor.Controls.Clear();
            formularioPrincipal.PanelMainAccessor.Controls.Add(UCCrearUsuario);
            UCCrearUsuario.Dock = DockStyle.Fill;
        }

      
    }
}
