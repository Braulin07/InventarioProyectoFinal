using InventarioProyectoFinal.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioProyectoFinal.Logica
{
    public class LogicaCategoria
    {
        public List<Categoria> CargarCategorias()
        {
            using var context = new StoreBPGContext();
            return context.Categoria.ToList();
        }
    }
}
