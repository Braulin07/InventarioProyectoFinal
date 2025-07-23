using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioProyectoFinal.Modelos
{
    //Clase modelo para los datos del usuario
    public class Usuario
    {
        public string NombreUsuario { get; set; }
        
        public string Contraseña { get; set; }
        public bool UsuarioActivo { get; set; }
        public string FechaCreacion { get; set; }

        public string Rol { get; set; }
        public string RutaImagen { get; set; }

    }
}
