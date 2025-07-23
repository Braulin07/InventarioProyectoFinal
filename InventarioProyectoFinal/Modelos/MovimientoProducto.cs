using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioProyectoFinal.Modelos
{
    public class MovimientoProducto
    {
        public string CodigoProducto { get; set; }
        public string TipoMovimiento { get; set; } // "Entrada" o "Salida"
        public decimal Cantidad { get; set; }
        public decimal Subtotal { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
    }
}
