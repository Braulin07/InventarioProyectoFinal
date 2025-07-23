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
        string RutaArchivo = GestorArchivos.ObtenerRutaCategoria();

        public List<CategoriaProducto> CargarCategorias()
        {
            List<CategoriaProducto> listaCategorias = new List<CategoriaProducto>();

            if (!File.Exists(RutaArchivo))
                return listaCategorias; // Si no existe, devuelve lista vacía.

            foreach (var linea in File.ReadAllLines(RutaArchivo))
            {
                var dividir = linea.Split('|');
                if (dividir.Length >= 2)
                {
                    listaCategorias.Add(new CategoriaProducto
                    {
                        IdCategoria = dividir[0].Trim(),
                        NombreCategoria = dividir[1].Trim()
                    });
                }
            }

            return listaCategorias;
        }
    }
}
