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
    public class LogicaUsuario
    {
        public bool ValidarLogin(string usuarioIngresado, string contraseñaIngresada)
        {
            using var context = new StoreBPGContext();
            return context.Usuarios.Any(u =>
                u.NombreUsuario == usuarioIngresado &&
                u.Contraseña == contraseñaIngresada &&
                u.UsuarioActivo);
        }

        public List<Usuario> CargarUsuarios()
        {
            using var context = new StoreBPGContext();
            return context.Usuarios.ToList();
        }

       /* public static void RegistrarSalidaSistema(string usuario)
        {
            using var context = new StoreBPGContext();
            var log = new LogSesione
            {
                Usuario = usuario,
                FechaIngreso = DateTime.Now
            };
            context.LogSesiones.Add(log);
            context.SaveChanges();
        }*/

        public static void GuardarListaUsuarios(List<Usuario> usuarios)
        {
            using var context = new StoreBPGContext();
            foreach (var user in usuarios)
            {
                var existente = context.Usuarios.Find(user.NombreUsuario);
                if (existente == null)
                {
                    context.Usuarios.Add(user);
                }
                else
                {
                    context.Entry(existente).CurrentValues.SetValues(user);
                }
            }
            context.SaveChanges();
        }
    }

}
