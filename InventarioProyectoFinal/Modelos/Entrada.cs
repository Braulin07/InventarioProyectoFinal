using System;
using System.Collections.Generic;

namespace InventarioProyectoFinal.Modelos;

public partial class Entrada
{
    public int EntradaId { get; set; }

    public string CodigoProducto { get; set; } = null!;

    public double Cantidad { get; set; }

    public DateTime? Fecha { get; set; }

    public string NombreUsuario { get; set; } = null!;

    public virtual Producto CodigoProductoNavigation { get; set; } = null!;
}
