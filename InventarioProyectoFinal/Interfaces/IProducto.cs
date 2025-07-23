using InventarioProyectoFinal.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioProyectoFinal.Interfaces
{
    public interface IProducto
    {
        public List<Producto> CargarListaProductos();
        
        
    }
}
