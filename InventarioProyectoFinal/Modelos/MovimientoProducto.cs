using System;
using System.Collections.Generic;

namespace InventarioProyectoFinal.Modelos;

public partial class MovimientoProducto
{
    public int MovimientoProductoId { get; set; }

    public string CodigoProducto { get; set; } = null!;

    public string TipoMovimiento { get; set; } = null!;

    public double Cantidad { get; set; }

    public decimal? Subtotal { get; set; }

    public DateTime? Fecha { get; set; }

    public string? NombreUsuario { get; set; }

    public int? ProductoId { get; set; }

    public virtual Producto? Producto { get; set; }
}
