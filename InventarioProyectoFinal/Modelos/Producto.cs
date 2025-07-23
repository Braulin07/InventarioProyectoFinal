using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioProyectoFinal.Modelos
{
    //Clase modelo que almacena los productos
    public class Producto
    {
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public string? IdCategoria { get; set; }
        public double PrecioCompra { get; set; }
        public double PrecioVenta { get; set; }
        public int StockCantidad { get; set; }
        public bool ActivoDisponible { get; set; }
        public string? RutaImagen { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

    }
}
