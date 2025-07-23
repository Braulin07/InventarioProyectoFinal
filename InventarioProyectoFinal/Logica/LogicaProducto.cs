using InventarioProyectoFinal.Interfaces;
using InventarioProyectoFinal.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioProyectoFinal.Logica
{
    //Clase logica usuario que maneja toda la logica de los productos que se almacenan y se crean en ek programa
    public class LogicaProducto : IProducto
    {
        string RutaArchivo = GestorArchivos.ObtenerRutaProducto(); //obtiene la ruta del archivo de mi clase GESTORARCHIVOS y el metodo ObtenerRutaProducto

        public List<Producto> CargarListaProductos()
        {
            var lista = new List<Producto>();

            if (!File.Exists(RutaArchivo))
                return lista;

            foreach (var linea in File.ReadLines(RutaArchivo))
            {
                var dividir = linea.Split('|');

                if (dividir.Length >= 10)
                {
                    var producto = new Producto
                    {
                        CodigoProducto = dividir[0],
                        NombreProducto = dividir[1],
                        IdCategoria = dividir[2],
                        PrecioCompra = double.Parse(dividir[3]),
                        PrecioVenta = double.Parse(dividir[4]),
                        StockCantidad = int.Parse(dividir[5]),
                        ActivoDisponible = bool.Parse(dividir[6]),
                        RutaImagen = dividir[7],
                        FechaCreacion = DateTime.Parse(dividir[8]),
                        FechaActualizacion = DateTime.Parse(dividir[9])
                    };

                    lista.Add(producto);
                }
            }

            return lista;
        }

        public static void ActualizarStockDespuesDeSalida(List<CarritoItem> carrito)
        {
            var logica = new LogicaProducto();
            var productos = logica.CargarListaProductos();

            foreach (var item in carrito)
            {
                var prod = productos.FirstOrDefault(p => p.CodigoProducto == item.CodigoProducto);
                if (prod != null)
                {
                    prod.StockCantidad -= item.Cantidad;
                }
            }

            // Guarda de nuevo
            GuardarListaProductos(productos);
        }

        public static void ActualizarStockDespuesDeEntrada(List<CarritoItem> carrito)
        {
            var logica = new LogicaProducto();
            var productos = logica.CargarListaProductos();

            foreach (var item in carrito)
            {
                var prod = productos.FirstOrDefault(p => p.CodigoProducto == item.CodigoProducto);
                if (prod != null)
                {
                    prod.StockCantidad += item.Cantidad;
                }
            }

            GuardarListaProductos(productos);
        }

        public static void GuardarListaProductos(List<Producto> productos)
        {
            string ruta = GestorArchivos.ObtenerRutaProducto();
            File.WriteAllText(ruta, string.Empty);

            foreach (var p in productos)
            {
                string linea = $"{p.CodigoProducto}|{p.NombreProducto}|{p.IdCategoria}|{p.PrecioCompra}|{p.PrecioVenta}|{p.StockCantidad}|{p.ActivoDisponible}|{p.RutaImagen}|{p.FechaCreacion}|{p.FechaActualizacion}";
                File.AppendAllText(ruta, linea + Environment.NewLine);
            }
        }

    }
}
