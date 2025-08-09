using InventarioProyectoFinal.Interfaces;
using InventarioProyectoFinal.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventarioProyectoFinal.ModelosAuxiliares;

namespace InventarioProyectoFinal.Logica
{
    //Clase logica usuario que maneja toda la logica de los productos que se almacenan y se crean en ek programa
    public class LogicaProducto
    {
        public List<Producto> CargarListaProductos()
        {
            using var context = new StoreBPGContext();
            return context.Productos.ToList();
        }

        public static void ActualizarStockDespuesDeSalida(List<CarritoItem> carrito)
        {
            using var context = new StoreBPGContext();
            foreach (var item in carrito)
            {
                var producto = context.Productos.Find(item.CodigoProducto);
                if (producto != null)
                {
                    producto.StockCantidad -= item.Cantidad;
                    producto.FechaActualizacion = DateTime.Now;
                }
            }
            context.SaveChanges();
        }

        public static void ActualizarStockDespuesDeEntrada(List<CarritoItem> carrito)
        {
            using var context = new StoreBPGContext();
            foreach (var item in carrito)
            {
                var producto = context.Productos.Find(item.CodigoProducto);
                if (producto != null)
                {
                    producto.StockCantidad += item.Cantidad;
                    producto.FechaActualizacion = DateTime.Now;
                }
            }
            context.SaveChanges();
        }

        public void GuardarProducto(Producto producto)
        {
            using (var context = new StoreBPGContext())
            {
                context.Productos.Update(producto);
                context.SaveChanges();
            }
        }

    }
}
