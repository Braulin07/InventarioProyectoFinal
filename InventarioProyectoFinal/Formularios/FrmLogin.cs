using InventarioProyectoFinal.Formularios;
using InventarioProyectoFinal.Logica;
using InventarioProyectoFinal.Modelos;


namespace InventarioProyectoFinal
{
    public partial class FrmLogin : Form
    {
        LogicaUsuario LogicaUsuario = new LogicaUsuario();
        public Usuario UsuarioAutenticado { get; private set; }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //InicializarArchivosBase();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string UsuarioIngresado = txtUsuario.Text;
            string ContraseñaIngresada = txtContraseña.Text;

            var usuarios = LogicaUsuario.CargarUsuarios();
            var usuarioValido = usuarios.FirstOrDefault(u =>
                u.NombreUsuario == UsuarioIngresado &&
                u.Contraseña == ContraseñaIngresada &&
                u.UsuarioActivo);

            if (usuarioValido != null)
            {
                UsuarioAutenticado = usuarioValido; // Guarda el usuario autenticado
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (txtUsuario.Text == string.Empty)
            {
                txtUsuario.Focus();
                errorUsuarioVacio.SetError(txtUsuario, "Escriba un Usuario");
            }
            else if (txtContraseña.Text == string.Empty)
            {
                txtContraseña.Focus();
                errorContraseñaVacia.SetError(txtContraseña, "Escriba una contraseña");
            }
            else
            {
                lblMensajeError.Text = "Usuario y/o Contraseña son incorrectos";
            }
        }

    }
}
