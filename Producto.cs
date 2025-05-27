using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPal
{
    public class Producto
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string idCategoria { get; set; }
        public string idSubcategoria { get; set; } = null;
        public decimal Costo { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal CantidadExistencia { get; set; }
        public decimal CantidadMinima { get; set; }
        public int Descuento { get; set; }
        public string ImagenBase64 { get; set; }
    }
}
