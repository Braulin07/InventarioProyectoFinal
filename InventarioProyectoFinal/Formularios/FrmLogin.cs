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
            string Contrase�aIngresada = txtContrase�a.Text;

            var usuarios = LogicaUsuario.CargarUsuarios();
            var usuarioValido = usuarios.FirstOrDefault(u =>
                u.NombreUsuario == UsuarioIngresado &&
                u.Contrase�a == Contrase�aIngresada &&
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
            else if (txtContrase�a.Text == string.Empty)
            {
                txtContrase�a.Focus();
                errorContrase�aVacia.SetError(txtContrase�a, "Escriba una contrase�a");
            }
            else
            {
                lblMensajeError.Text = "Usuario y/o Contrase�a son incorrectos";
            }
        }

    }
}
