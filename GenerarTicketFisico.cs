using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using MarketPal;

namespace MarketPal
{
    public class GenerarTicketFisico
    {
        private IFirebaseClient cliente;

        public GenerarTicketFisico()
        {
            // Configurar Firebase
            IFirebaseConfig config = new FirebaseConfig
            {
                BasePath = "https://prueba-575f7-default-rtdb.firebaseio.com/",
                AuthSecret = "lvGHgu8Z3EYxWpBbAI8n8rCBWVncprXedJlfzfht"
            };

            cliente = new FireSharp.FirebaseClient(config);
            if (cliente == null)
                throw new Exception("Error al conectar con Firebase.");
        }

        public async Task<string> generarTicketTXT(string idSucursal, string idVenta)
        {
            // Obtener información de la tienda
            FirebaseResponse respuestaTienda = await cliente.GetAsync($"Sucursales/{idSucursal}");
            var informacionTicket = respuestaTienda.ResultAs<dynamic>(); 

            // Obtener productos de la venta específica
            string ruta = $"Ventas/{idSucursal}/{idVenta}/Productos";
            FirebaseResponse respuestaProductos = await cliente.GetAsync(ruta);
            var productos = respuestaProductos.ResultAs<Dictionary<string, ProductoVenta>>();

            string rutaVentas = $"Ventas/{idSucursal}/{idVenta}";
            FirebaseResponse respuestaVentas = await cliente.GetAsync(rutaVentas);
            var venta = respuestaVentas.ResultAs<Venta>();

            if (productos == null || productos.Count == 0)
                throw new Exception("No hay productos en esta venta.");

            // Crear el contenido del ticket
 //           string numeroVenta = idVenta.Replace("VNT", "");
            StringBuilder ticket = new StringBuilder();
            ticket.AppendLine("********** TICKET DE COMPRA **********");
            ticket.AppendLine($"Tienda: {informacionTicket.Nombre}");
            ticket.AppendLine($"Dirección: {informacionTicket.Direccion}");
            ticket.AppendLine($"Teléfono: {informacionTicket.Telefono}");
            ticket.AppendLine($"Número de Venta: {idVenta.Replace("VNT", "")}");
            ticket.AppendLine($"Atendido por: {venta.UsuarioVendedor}");
            ticket.AppendLine("--------------------------------------");
            ticket.AppendLine(" Cant. | Producto       | Precio");
            ticket.AppendLine("--------------------------------------");

            //double total = 0;

            foreach (var producto in productos)
            {
                string nombre = producto.Value.DescripcionProducto;
                string cantidad = producto.Value.CantidadProducto;
                string cantidadSinUd = cantidad.Replace("ud.", "").Replace("kg","").Replace("uds.","");
                double cantidadEnDouble = double.Parse(cantidadSinUd);
                string precio = producto.Value.PrecioUnitarioProducto;
                string precioSinMoneda = precio.Replace("MXN ", "").Replace("$", "").Replace("/kg","");
                double precioEnDouble = double.Parse(precioSinMoneda);
                double subtotal = cantidadEnDouble * precioEnDouble;

                ticket.AppendLine($"  {cantidad}   | {nombre,-14} | ${subtotal:F2}");
                //total += subtotal;
            }


            
            ticket.AppendLine("--------------------------------------");
            ticket.AppendLine($"Subtotal: ${venta.SubtotalVenta:F2}");
            ticket.AppendLine($"Descuento por puntos: ${venta.DescuentoAplicadoVenta:F2}");
            ticket.AppendLine($"Total: ${venta.TotalVenta:F2}");
            ticket.AppendLine($"Monto recibido: ${venta.MontoRecibidoVenta:F2}");
            ticket.AppendLine($"Cambio: ${venta.CambioVenta:F2}");
            ticket.AppendLine("**************************************");
            ticket.AppendLine($"{informacionTicket.Mensaje}");

            // Guardar en un archivo de texto

            string rutaCarpeta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MarketPal");
            Directory.CreateDirectory(rutaCarpeta);

            string rutaArchivo = Path.Combine(rutaCarpeta, $"ticket_{idVenta}.txt");
            File.WriteAllText(rutaArchivo, ticket.ToString());

            return rutaArchivo; // Devolver la ruta del archivo
        }
    }
}