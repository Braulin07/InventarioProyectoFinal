using System;
using System.Collections.Generic;

namespace InventarioProyectoFinal.Modelos;

public partial class Salida
{
    public int SalidaId { get; set; }

    public string CodigoProducto { get; set; } = null!;

    public double Cantidad { get; set; }

    public decimal Subtotal { get; set; }

    public DateTime? Fecha { get; set; }

    public virtual Producto CodigoProductoNavigation { get; set; } = null!;

    public string NombreUsuario { get; set; }
}
