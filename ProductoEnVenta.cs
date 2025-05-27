using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPal
{
    public class ProductoEnVenta
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string cantidad { get; set; }
        public decimal precio_unitario { get; set; }
        public decimal descuento { get; set; }
        public decimal precio_final { get; set; }
        public string imagen_base64 { get; set; }
    }

}
