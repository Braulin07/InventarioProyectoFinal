using System;
using System.Collections.Generic;

namespace InventarioProyectoFinal.Modelos;

public partial class Categoria
{
    public int CategoriaId { get; set; }

    public string NombreCategoria { get; set; } = null!;

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
