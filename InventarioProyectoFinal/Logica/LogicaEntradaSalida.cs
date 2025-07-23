using InventarioProyectoFinal.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioProyectoFinal.Logica
{
    //Clase logica de entrada y salida, guarda toda la informacion de los productos que entran y salen del inventario 
    //creadas como clases estaticas porque kas mismas no necesitan instancia debido a que solo sirven para leer y escribiri el txt
    
    public class LogicaEntradaSalida
    {
        public static void RegistrarSalida(List<CarritoItem> carrito, string usuario)
        {
            string rutaSalida = GestorArchivos.ObtenerRutaSalida();
            foreach (var item in carrito)
            {
                string linea = $"{item.CodigoProducto}|{item.Cantidad}|{item.Subtotal}|{DateTime.Now}|{usuario}";
                File.AppendAllText(rutaSalida, linea + Environment.NewLine);
            }

            // Actualiza stock
            LogicaProducto.ActualizarStockDespuesDeSalida(carrito);
        }

        public static void RegistrarEntrada(List<CarritoItem> carrito, string usuario)
        {
            string rutaEntrada = GestorArchivos.ObtenerRutaEntrada();
            foreach (var item in carrito)
            {
                string linea = $"{item.CodigoProducto}|{item.Cantidad}|{DateTime.Now}|{usuario}";
                File.AppendAllText(rutaEntrada, linea + Environment.NewLine);
            }

            // Actualiza stock
            LogicaProducto.ActualizarStockDespuesDeEntrada(carrito);
        }
    }
}
