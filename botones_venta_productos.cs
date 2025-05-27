using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketPal
{
    public partial class botones_venta_productos : Form
    {
        public string ProductoKey { get; set; }

        public botones_venta_productos()
        {
            InitializeComponent();
        }

        private void botones_venta_productos_Load(object sender, EventArgs e)
        {

        }

        private void btn_agregar_producto_Click(object sender, EventArgs e)
        {
            var parentForm = Owner as seccion_venta_productos;

            if (parentForm != null && ProductoKey != null &&
                parentForm.productosCargados.TryGetValue(ProductoKey, out Producto producto))
            {
                int cantidadEnCarrito = (int)parentForm.ObtenerCantidadEnCarrito(producto.Descripcion);

                if (cantidadEnCarrito < producto.CantidadExistencia)
                {
                    string unidadMedida = parentForm.categoriasCargadas[producto.idCategoria].UnidadMedida;

                    parentForm.AgregarProductoAlCarrito(
                        producto.Descripcion,
                        producto.PrecioVenta,
                        parentForm.ConvertirBase64AImagen(producto.ImagenBase64),
                        producto.Descuento,
                        unidadMedida
                    );

                    parentForm.ValidarEstadoBotonesFlotantes(ProductoKey);
                }
            }
        }

        private void btn_eliminar_producto_Click(object sender, EventArgs e)
        {
            var parentForm = Owner as seccion_venta_productos;
            if (parentForm != null && ProductoKey != null &&
                parentForm.productosCargados.TryGetValue(ProductoKey, out Producto producto))
            {
                foreach (DataGridViewRow fila in parentForm.dataGridViewCarrito.Rows)
                {
                    if (!fila.IsNewRow && fila.Cells["colProducto"].Value?.ToString() == producto.Descripcion)
                    {
                        int cantidad = (int)parentForm.ObtenerCantidadEnCarrito(producto.Descripcion);

                        if (cantidad > 1)
                        {
                            cantidad--;
                            fila.Cells["colCantidad"].Value = $"{cantidad} {(cantidad > 1 ? "uds." : "ud.")}";

                            decimal precio = producto.PrecioVenta;
                            decimal descuentoAplicado = Math.Round(precio * ((decimal)producto.Descuento / 100), 2, MidpointRounding.AwayFromZero);
                            decimal precioFinal = precio - descuentoAplicado;
                            fila.Cells["colPrecioFinal"].Value = $"MXN {(cantidad * precioFinal):N2}";

                            parentForm.ActualizarTotalCarrito();
                        }
                        else
                        {
                            parentForm.dataGridViewCarrito.Rows.Remove(fila);
                            parentForm.ActualizarTotalCarrito();
                        }

                        parentForm.ValidarEstadoBotonesFlotantes(ProductoKey);
                        return;
                    }
                }
            }
        }

        private void btn_eliminar_producto_MouseHover(object sender, EventArgs e)
        {
            var parentForm = (seccion_venta_productos)Owner;
            parentForm.timerBotones.Stop();
        }

        private void btn_eliminar_producto_MouseLeave(object sender, EventArgs e)
        {
            var parentForm = (seccion_venta_productos)Owner;
            parentForm.timerBotones.Start();
        }

        private void btn_agregar_producto_MouseHover(object sender, EventArgs e)
        {
            var parentForm = (seccion_venta_productos)Owner;
            parentForm.timerBotones.Stop();
        }

        private void btn_agregar_producto_MouseLeave(object sender, EventArgs e)
        {
            var parentForm = (seccion_venta_productos)Owner;
            parentForm.timerBotones.Start();
        }
    }
}
