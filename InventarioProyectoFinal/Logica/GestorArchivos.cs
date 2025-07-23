using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioProyectoFinal.Logica
{

    //en esta clase centralice el manejo y acceso a los documentos para no hacer hardcoding
    //decubri que los txt de sobreescriben en el ejecutable que se almacena en la carpeta bin mas no los del proyecto
    public class GestorArchivos
    {

        public static string ObtenerRutaProducto()
        {
            
            return Path.Combine("BaseDeDatos", "Producto.txt");
        }

        public static string ObtenerRutaCategoria()
        {
            
            return Path.Combine("BaseDeDatos", "CategoriaProducto.txt");
        }

        public static string ObtenerRutaUsuario()
        {
            //VerificarOCrearCarpetaBase();
            return Path.Combine("BaseDeDatos", "Usuario.txt");
        }

        public static string ObtenerRutaLogSesion()
        {
            //VerificarOCrearCarpetaBase();
            return Path.Combine("BaseDeDatos", "LogSesion.txt");
        }

        public static string ObtenerRutaSalida()
        {
            //VerificarOCrearCarpetaBase();
            return Path.Combine("BaseDeDatos", "Salidas.txt");
        }

        public static string ObtenerRutaEntrada()
        {
            //VerificarOCrearCarpetaBase();
            return Path.Combine("BaseDeDatos", "Entradas.txt");
        }

    }
}
