using System;
using System.Collections.Generic;

namespace InventarioProyectoFinal.Modelos;

public partial class Usuario
{
    public int UsuarioId { get; set; }

    public string NombreUsuario { get; set; } = null!;

    public string Contraseña { get; set; } = null!;

    public string Rol { get; set; } = null!;

    public bool UsuarioActivo { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public string? RutaImagen { get; set; }
}
