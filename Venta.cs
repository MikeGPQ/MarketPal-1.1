using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPal
{
    public class Venta
    {
        public string FechaHora { get; set; }
        public string UsuarioVendedor { get; set; }
        public string SubtotalVenta { get; set; }
        public string DescuentoAplicadoVenta { get; set; }
        public string TotalVenta { get; set; }
        public string MontoRecibidoVenta { get; set; }
        public string CambioVenta { get; set; }
        public Dictionary<string, ProductoVenta> Productos { get; set; }
    }
}
