using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace InventarioProyectoFinal.Modelos;

public partial class StoreBPGContext : DbContext
{
    public StoreBPGContext()
    {
    }

    public StoreBPGContext(DbContextOptions<StoreBPGContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categoria> Categoria { get; set; }

    public virtual DbSet<Entrada> Entrada { get; set; }

    public virtual DbSet<MovimientoProducto> MovimientoProductos { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Salida> Salida { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

 //   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
 //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
 //        => optionsBuilder.UseSqlServer("Server=LAPTOP-EGQMSU5C\\SQLEXPRESS;Database=StoreBPG;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-EGQMSU5C\\SQLEXPRESS;Database=StoreBPG;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(e => e.CategoriaId).HasName("PK__Categori__F353C1E5CF95E4FF");

            entity.Property(e => e.CategoriaId).ValueGeneratedNever();
            entity.Property(e => e.NombreCategoria).HasMaxLength(100);
        });

        modelBuilder.Entity<Entrada>(entity =>
        {
            entity.HasKey(e => e.EntradaId).HasName("PK__Entrada__A084667401AE6C65");

            entity.Property(e => e.CodigoProducto).HasMaxLength(20);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.NombreUsuario).HasMaxLength(50);

            entity.HasOne(d => d.CodigoProductoNavigation).WithMany(p => p.Entrada)
                .HasPrincipalKey(p => p.CodigoProducto)
                .HasForeignKey(d => d.CodigoProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CodigoProducto_Entrada");
        });

        modelBuilder.Entity<MovimientoProducto>(entity =>
        {
            entity.HasKey(e => e.MovimientoProductoId).HasName("PK__Movimien__16891ED7DDE30B97");

            entity.ToTable("MovimientoProducto");

            entity.Property(e => e.MovimientoProductoId).ValueGeneratedNever();
            entity.Property(e => e.CodigoProducto).HasMaxLength(20);
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.NombreUsuario).HasMaxLength(50);
            entity.Property(e => e.Subtotal).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.TipoMovimiento).HasMaxLength(20);

            entity.HasOne(d => d.Producto).WithMany(p => p.MovimientoProductos)
                .HasForeignKey(d => d.ProductoId)
                .HasConstraintName("FK_Movimiento_Producto");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.ProductoId).HasName("PK__Producto__A430AEA3EEE3B062");

            entity.ToTable("Producto");

            entity.HasIndex(e => e.CodigoProducto, "UQ__Producto__785B009F1E4C22F5").IsUnique();

            //entity.Property(e => e.ProductoId).ValueGeneratedNever();
            entity.Property(e => e.CodigoProducto).HasMaxLength(20);
            entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.NombreProducto).HasMaxLength(100);

            entity.HasOne(d => d.Categoria).WithMany(p => p.Productos)
                .HasForeignKey(d => d.CategoriaId)
                .HasConstraintName("FK_Categorias_Productos");
        });

        modelBuilder.Entity<Salida>(entity =>
        {
            entity.HasKey(e => e.SalidaId).HasName("PK__Salida__DC9971634265F2AF");

            entity.Property(e => e.CodigoProducto).HasMaxLength(20);
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("subtotal");

            entity.HasOne(d => d.CodigoProductoNavigation).WithMany(p => p.Salida)
                .HasPrincipalKey(p => p.CodigoProducto)
                .HasForeignKey(d => d.CodigoProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CodigoProducto_Salida");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            //entity.HasKey(e => e.UsuarioId).HasName("PK__Usuario__2B3DE7B8D69491AE");

            entity.ToTable("Usuario");

           // entity.Property(e => e.UsuarioId).ValueGeneratedNever();
            entity.Property(e => e.Contraseña).HasMaxLength(100);
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.NombreUsuario).HasMaxLength(50);
            entity.Property(e => e.Rol).HasMaxLength(30);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
