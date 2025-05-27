using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPal
{
    public class Categoria
    {
        public string Nombre { get; set; }
        public string UnidadMedida { get; set; }
        public bool AceptaDecimales { get; set; }
        public Dictionary<string, Subcategoria> Subcategorias { get; set; } = new Dictionary<string, Subcategoria>();

        public Categoria(string nombre, string unidadMedida, bool aceptaDecimales)
        {
            Nombre = nombre;
            UnidadMedida = unidadMedida;
            AceptaDecimales = aceptaDecimales;
        }
    }
}
