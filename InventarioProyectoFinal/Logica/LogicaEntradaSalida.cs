using InventarioProyectoFinal.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventarioProyectoFinal.ModelosAuxiliares;

namespace InventarioProyectoFinal.Logica
{
    //Clase logica de entrada y salida, guarda toda la informacion de los productos que entran y salen del inventario 
    //creadas como clases estaticas porque kas mismas no necesitan instancia debido a que solo sirven para leer y escribiri el txt

    public class LogicaEntradaSalida
    {
        public static void RegistrarSalida(List<CarritoItem> carrito, string usuario)
        {
            using var context = new StoreBPGContext();

            foreach (var item in carrito)
            {
                var salida = new Salida
                {
                    CodigoProducto = item.CodigoProducto,
                    Cantidad = item.Cantidad,
                    Subtotal = (decimal)item.Subtotal,
                    Fecha = DateTime.Now,
                    NombreUsuario = usuario
                };

                context.Salida.Add(salida);

                var producto = context.Productos.Find(item.CodigoProducto);
                if (producto != null)
                {
                    producto.StockCantidad -= item.Cantidad;
                    producto.FechaActualizacion = DateTime.Now;
                }
            }

            context.SaveChanges();
        }

        public static void RegistrarEntrada(List<CarritoItem> carrito, string usuario)
        {
            using var context = new StoreBPGContext();

            foreach (var item in carrito)
            {
                var entrada = new Entrada
                {
                    CodigoProducto = item.CodigoProducto,
                    Cantidad = item.Cantidad,
                    Fecha = DateTime.Now,
                    NombreUsuario = usuario
                };

                context.Entrada.Add(entrada);

                var producto = context.Productos.Find(item.CodigoProducto);
                if (producto != null)
                {
                    producto.StockCantidad += item.Cantidad;
                    producto.FechaActualizacion = DateTime.Now;
                }
            }

            context.SaveChanges();
        }
    }
}
