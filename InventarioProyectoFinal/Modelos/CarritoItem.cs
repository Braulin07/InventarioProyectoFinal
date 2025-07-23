using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioProyectoFinal.Modelos
{
    public class CarritoItem
    {
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public double PrecioVenta { get; set; }
        public double Subtotal { get; set; }
    }
}
