using System;
using System.Collections.Generic;

namespace InventarioProyectoFinal.Modelos;

public partial class Producto
{
    public int ProductoId { get; set; }

    public string CodigoProducto { get; set; } = null!;

    public string NombreProducto { get; set; } = null!;

    public double PrecioCompra { get; set; }

    public double PrecioVenta { get; set; }

    public int StockCantidad { get; set; }

    public bool Disponible { get; set; }

    public string? RutaImagen { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public int? CategoriaId { get; set; }

    public virtual Categoria? Categoria { get; set; }

    public virtual ICollection<Entrada> Entrada { get; set; } = new List<Entrada>();

    public virtual ICollection<MovimientoProducto> MovimientoProductos { get; set; } = new List<MovimientoProducto>();

    public virtual ICollection<Salida> Salida { get; set; } = new List<Salida>();
}
