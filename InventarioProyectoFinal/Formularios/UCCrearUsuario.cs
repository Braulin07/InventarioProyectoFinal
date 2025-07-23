using InventarioProyectoFinal.Logica;
using InventarioProyectoFinal.Modelos;

namespace InventarioProyectoFinal.Formularios
{
    public partial class UCCrearUsuario : UserControl
    {
        private string rutaImagenSeleccionada = string.Empty;
        public UCCrearUsuario()
        {
            InitializeComponent();
        }

        private void UCCrearUsuario_Load(object sender, EventArgs e)
        {
            cmbRol.Items.Clear();
            cmbRol.Items.Add("ADMIN");
            cmbRol.Items.Add("USER");

        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Imagenes (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    rutaImagenSeleccionada = ofd.FileName;
                    picFotoUsuario.ImageLocation = rutaImagenSeleccionada;
                }
            }
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();
            string rol = cmbRol.Text;
            bool activo = chkActivo.Checked;
            string fechaCreacion = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            string destinoImagen = "";

            // Validaciones
            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(contraseña) || string.IsNullOrEmpty(rol))
            {
                MessageBox.Show("Completa todos los campos obligatorios.");
                return;
            }

            var logicaUsuario = new LogicaUsuario();
            var usuarios = logicaUsuario.CargarUsuarios();

            if (usuarios.Any(u => u.NombreUsuario.Equals(nombreUsuario, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("El usuario ya existe.");
                return;
            }

            // Guardar imagen si hay
            if (!string.IsNullOrEmpty(rutaImagenSeleccionada) && File.Exists(rutaImagenSeleccionada))
            {
                string carpetaDestino = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "InventarioProyectoFinal", "ImagenesUsuarios");
                Directory.CreateDirectory(carpetaDestino);

                destinoImagen = Path.Combine(carpetaDestino, Path.GetFileName(rutaImagenSeleccionada));
                File.Copy(rutaImagenSeleccionada, destinoImagen, true);
            }

            // Crear objeto
            Usuario nuevo = new Usuario
            {
                NombreUsuario = nombreUsuario,
                Contraseña = contraseña,
                UsuarioActivo = activo,
                FechaCreacion = fechaCreacion,
                Rol = rol,
                RutaImagen = destinoImagen
            };

            // Guardar
            usuarios.Add(nuevo);
            LogicaUsuario.GuardarListaUsuarios(usuarios);

            MessageBox.Show("Usuario creado correctamente.");

            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtNombreUsuario.Clear();
            txtContraseña.Clear();
            cmbRol.SelectedIndex = -1;
            chkActivo.Checked = false;
            picFotoUsuario.Image = null;
            rutaImagenSeleccionada = string.Empty;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var cancelar = new UCVerUsuarios();
            var formularioPrincipal = this.FindForm() as FrmMenuPrincipal;

            formularioPrincipal.PanelMainAccessor.Controls.Clear();
            formularioPrincipal.PanelMainAccessor.Controls.Add(cancelar);
            cancelar.Dock = DockStyle.Fill;
        }
    }
}
