using InventarioProyectoFinal.Interfaces;
using InventarioProyectoFinal.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioProyectoFinal.Logica
{
    //En esta calse logica usuario manejo todo lo logico con respecto a los usuarios y como se almacenan, desde el log in hasta el manejo de las listas
    public class LogicaUsuario : IUsuario
    {
        string RutaArchivo = GestorArchivos.ObtenerRutaUsuario();
        Usuario usuario = new Usuario();
        
        //Validar el Log in al momento de iniciar sesion
        public bool ValidarLogin(string usuarioIngresado, string contraseñaIngresada)
        {

            foreach (var linea in File.ReadLines(RutaArchivo))
            {
                var dividir = linea.Split('|');

                usuario.NombreUsuario = dividir[0].Trim();
                usuario.Contraseña = dividir[1].Trim();
                usuario.UsuarioActivo = Convert.ToBoolean(dividir[2].Trim());

                if (usuario.NombreUsuario == usuarioIngresado && usuario.Contraseña == contraseñaIngresada && usuario.UsuarioActivo)
                {
                    return true;
                }
            }

            return false;

        }
        //  Carga los usuarios 
        public List<Usuario> CargarUsuarios()
        {
            string rutaArchivo = @"BaseDeDatos\Usuario.txt";
            var lista = new List<Usuario>();

            foreach (var linea in File.ReadAllLines(rutaArchivo))
            {
                var datos = linea.Split('|');
                if (datos.Length >= 6)
                {
                    lista.Add(new Usuario
                    {
                        NombreUsuario = datos[0],
                        Contraseña = datos[1],
                        UsuarioActivo = datos[2].Equals("True", StringComparison.OrdinalIgnoreCase) || datos[2] == "1",
                        FechaCreacion = datos[3],
                        Rol = datos[4],
                        RutaImagen = datos[5]
                    });
                }
            }

            return lista;
        }


        //Registra la salida de el usuario del sistema
        //escrito manualmente debido a que son statis y no pueden ser declaradas en la interfaz
        public static void RegistrarSalidaSistema(string usuario)
        {
            string log = $"{usuario}|{DateTime.Now}";
            File.AppendAllText(@"BaseDeDatos\LogSesion.txt", log + Environment.NewLine);
        }

        public static void GuardarListaUsuarios(List<Usuario> usuarios)
        {
            string ruta = @"BaseDeDatos\Usuario.txt";
            File.WriteAllText(ruta, string.Empty); // Limpia el archivo para que se almacene la lista completa y no se duplique

            foreach (var u in usuarios)
            {
                string linea = $"{u.NombreUsuario}|{u.Contraseña}|{u.UsuarioActivo}|{u.FechaCreacion}|{u.Rol}|{u.RutaImagen}";
                File.AppendAllText(ruta, linea + Environment.NewLine);
            }
        }

    }

}
