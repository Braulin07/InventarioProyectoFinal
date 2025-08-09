using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioProyectoFinal.ModelosAuxiliares
{
    public class CarritoItem
    {
        public int ProductoId { get; set; }
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public double PrecioVenta { get; set; }
        public double Subtotal { get; set; }
        public decimal Total => Cantidad * Convert.ToInt64(PrecioVenta); 
    }
}
