using InventarioProyectoFinal.Formularios;
using InventarioProyectoFinal.Interfaces;
using InventarioProyectoFinal.Logica;
using System.Security.Cryptography.X509Certificates;

namespace InventarioProyectoFinal
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           FrmLogin frmLogin = new FrmLogin();

            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal();
                frmMenuPrincipal.UsuarioActual = frmLogin.UsuarioAutenticado; // PASAS EL USUARIO
                Application.Run(frmMenuPrincipal);
            }
        }
    }
}