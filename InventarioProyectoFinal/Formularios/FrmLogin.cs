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
            InicializarArchivosBase();
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

        private void InicializarArchivosBase()
        {
            string rutaBase = Path.Combine(Application.StartupPath, "BaseDeDatos");
            string rutaImagenes = Path.Combine(Application.StartupPath, "ImagenesProductos");

            // Crear carpetas si no existen
            if (!Directory.Exists(rutaBase))
                Directory.CreateDirectory(rutaBase);

            if (!Directory.Exists(rutaImagenes))
                Directory.CreateDirectory(rutaImagenes);

            // Datos predeterminados
            string rutaUsuarios = Path.Combine(rutaBase, "Usuario.txt");
            if (!File.Exists(rutaUsuarios))
            {
                var usuariosiniciales = new List<string>
                {
                    "admin|adminpass|true|25/06/2025|ADMIN|ImagenesUsuarios\adminimage.png",
                    "anthony|12345|true|25/06/2025/ADMIN|ImagenesUsuarios\anthony.png",
                };

                File.WriteAllLines(rutaUsuarios, usuariosiniciales);
            }

            string rutaCategorias = Path.Combine(rutaBase, "Categoria.txt");
            if (!File.Exists(rutaCategorias))
            {
                var categoriaIniciales = new List<string>
                {
                    "C001|Periféricos",
                    "C002|Monitores",
                    "C003|Cámaras",
                    "C004|Almacenamiento",
                    "C005|Portátiles",
                    "C006|Accesorios",
                    "C007|Impresoras",
                    "C008|Redes",
                    "C009|Software",
                    "C010|Gaming",
                };
                File.WriteAllLines(rutaCategorias, categoriaIniciales);
            }

            string rutaProductos = Path.Combine(rutaBase, "Producto.txt");
            if (!File.Exists(rutaProductos))
            {
                var productosIniciales = new List<string>
                {
                    "P001|Teclado Mecánico|C001|30.00|45.00|15|True|ImagenesProductos\\teclado.jpg|2024-12-01|2025-07-01",
                    "P002|Mouse Inalámbrico|C001|12.00|20.00|10|True|ImagenesProductos\\mouse.jpg|2025-01-15|2025-07-02",
                    "P003|Monitor 24 pulgadas|C002|100.00|150.00|5|True|ImagenesProductos\\monitor.jpg|2025-02-10|2025-07-01",
                    "P004|Webcam HD|C003|18.00|30.00|0|False|ImagenesProductos\\webcam.jpg|2025-01-25|2025-06-28",
                    "P005|Memoria RAM 8GB|C004|25.00|40.00|8|True|ImagenesProductos\\ram.jpg|2025-03-20|2025-07-05",
                    "P006|Disco SSD 512GB|C004|35.00|60.00|3|True|ImagenesProductos\\ssd.jpg|2025-01-10|2025-07-02",
                    "P007|Laptop Lenovo|C005|400.00|550.00|2|True|ImagenesProductos\\laptop.jpg|2025-04-15|2025-07-03",
                    "P008|Cable HDMI|C006|3.00|6.00|25|True|ImagenesProductos\\hdmi.jpg|2025-05-01|2025-07-07",
                    "P009|Base para Laptop|C006|10.00|15.00|12|True|ImagenesProductos\\base.jpg|2025-04-30|2025-07-06",
                    "P010|Impresora HP|C007|120.00|180.00|4|False|ImagenesProductos\\impresora.jpg|2024-11-15|2025-07-04",
                };
                File.WriteAllLines(rutaProductos, productosIniciales);
            }

            string rutaEntradas = Path.Combine(rutaBase, "Entradas.txt");
            if (!File.Exists(rutaEntradas))
            {
                File.WriteAllLines(rutaEntradas, new[]
                {
                    "P001|5|150.00|2025-06-01 10:15:00|admin",
                    "P002|3|60.00|2025-06-02 14:30:00|admin",
                    "P003|2|300.00|2025-06-03 09:45:00|admin",
                    "P005|4|160.00|2025-06-04 13:10:00|admin",
                    "P006|3|180.00|2025-06-05 11:00:00|admin",
                    "P008|10|60.00|2025-06-06 16:20:00|admin",
                    "P009|6|90.00|2025-06-07 15:05:00|admin",
                    "P004|5|150.00|2025-06-08 17:25:00|admin",
                    "P007|1|400.00|2025-06-09 18:15:00|admin",
                    "P010|2|240.00|2025-06-10 12:00:00|admin",
                });
            }

            string rutaSalidas = Path.Combine(rutaBase, "Salidas.txt");
            if (!File.Exists(rutaSalidas))
            {
                File.WriteAllLines(rutaSalidas, new[]
                {
                    "P001|2|90.00|2025-06-15 10:30:00|admin",
                    "P002|1|20.00|2025-06-16 14:00:00|admin",
                    "P003|1|150.00|2025-06-17 12:45:00|admin",
                    "P005|2|80.00|2025-06-18 16:10:00|admin",
                    "P006|1|60.00|2025-06-19 11:00:00|admin",
                    "P008|5|30.00|2025-06-20 09:25:00|admin",
                    "P009|2|30.00|2025-06-21 13:15:00|admin",
                    "P004|5|150.00|2025-06-22 10:05:00|admin",
                    "P007|1|550.00|2025-06-23 17:50:00|admin",
                    "P010|1|180.00|2025-06-24 12:30:00|admin",
                 });
            }
        }


    }
}
