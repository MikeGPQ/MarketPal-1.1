using FireSharp.Config;
using FireSharp.Interfaces;
using MarketPal;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormsTimer = System.Windows.Forms.Timer;

namespace MarketPal
{
    public partial class seccion_venta_productos : Form
    {
        string Sucursalid;
        private IFirebaseClient firebaseClient;
        public Dictionary<string, Producto> productosCargados;
        public FormsTimer timerBotones;
        private botones_venta_productos formBotones;
        public Dictionary<string, Categoria> categoriasCargadas;

        public seccion_venta_productos(string sucursal)
        {
            Sucursalid = sucursal;

            InitializeComponent();
            ConfigurarFirebase();
            CargarProductosDesdeBaseDatos(Sucursalid);
            CargarCategoriasDesdeBaseDatos(Sucursalid);
            ActualizarTotalCarrito();

            formBotones = new botones_venta_productos
            {
                Owner = this,
                TopMost = true
            };

            timerBotones = new FormsTimer
            {
                Interval = 500
            };
            timerBotones.Tick += TimerBotones_Tick;
        }

        private void TimerBotones_Tick(object sender, EventArgs e)
        {
            formBotones.Hide();
            timerBotones.Stop();
        }

        private void seccion_venta_productos_Load(object sender, EventArgs e)
        {

        }

        private void ConfigurarFirebase()
        {
            firebaseClient = new FireSharp.FirebaseClient(new FirebaseConfig
            {
                AuthSecret = "lvGHgu8Z3EYxWpBbAI8n8rCBWVncprXedJlfzfht",
                BasePath = "https://prueba-575f7-default-rtdb.firebaseio.com/"
            });

            if (firebaseClient == null)
            {
                MessageBox.Show("No se pudo conectar a Firebase.");
            }
        }

        private async Task CargarProductosDesdeBaseDatos(string sucursalId)
        {
            try
            {
                var responseProductos = await firebaseClient.GetAsync($"/Productos/{sucursalId}");
                productosCargados = responseProductos.ResultAs<Dictionary<string, Producto>>();

                if (productosCargados != null)
                {
                    CargarProductosEnListView();
                }
            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("Operación cancelada.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar productos: {ex.Message}");
            }
        }

        private void CargarProductosEnListView()
        {
            listViewProductos.Items.Clear();
            imageListProductos.Images.Clear();

            foreach (var producto in productosCargados)
            {
                try
                {
                    Image imagenProducto = ConvertirBase64AImagen(producto.Value.ImagenBase64);
                    imageListProductos.Images.Add(producto.Key, imagenProducto);

                    decimal descuentoAplicado = producto.Value.PrecioVenta * ((decimal)producto.Value.Descuento / 100);
                    decimal precioFinal = producto.Value.PrecioVenta - descuentoAplicado;

                    string descripcionConPrecio = $"{producto.Value.Descripcion}\nMXN {precioFinal:N2}";
                    ListViewItem item = new ListViewItem(descripcionConPrecio)
                    {
                        ImageKey = producto.Key,
                        Tag = producto.Key
                    };

                    listViewProductos.Items.Add(item);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al procesar el producto {producto.Value.Descripcion}: {ex.Message}");
                }
            }
        }

        public void AgregarProductoAlCarrito(string nombre, decimal precio, Image imagen, decimal descuento, string unidadMedida = "uds.")
        {
            foreach (DataGridViewRow fila in dataGridViewCarrito.Rows)
            {
                if (!fila.IsNewRow && fila.Cells["colProducto"].Value?.ToString() == nombre)
                {
                    if (unidadMedida == "uds.")
                    {
                        string cantidadTexto = fila.Cells["colCantidad"].Value.ToString();
                        string cantidadNumerica = cantidadTexto.Split(' ')[0];
                        int cantidadActual = int.Parse(cantidadNumerica);
                        cantidadActual++;
                        fila.Cells["colCantidad"].Value = $"{cantidadActual} {(cantidadActual > 1 ? "uds." : "ud.")}";

                        decimal precioFinalUnitario = precio - (precio * (descuento / 100));
                        fila.Cells["colPrecioFinal"].Value = $"MXN {(cantidadActual * precioFinalUnitario):N2}";

                        ActualizarTotalCarrito();
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
            }

            if (unidadMedida == "kg")
            {
                var formCantidad = new cantidad_producto_carrito
                {
                    UnidadMedida = unidadMedida,
                    CantidadExistente = productosCargados.First(p => p.Value.Descripcion == nombre).Value.CantidadExistencia,
                    Owner = this
                };

                if (formCantidad.ShowDialog() == DialogResult.OK)
                {
                    decimal cantidadSeleccionada = formCantidad.CantidadSeleccionada;
                    AgregarProducto(nombre, precio, imagen, descuento, cantidadSeleccionada, unidadMedida);
                }
            }
            else
            {
                AgregarProducto(nombre, precio, imagen, descuento, 1, unidadMedida);
            }
        }

        private void AgregarProducto(string nombre, decimal precio, Image imagen, decimal descuento, decimal cantidad, string unidadMedida)
        {
            decimal descuentoAplicado = precio * (descuento / 100);
            decimal precioFinalUnitario = precio - descuentoAplicado;

            int nuevaFila = dataGridViewCarrito.Rows.Add();
            dataGridViewCarrito.Rows[nuevaFila].Cells["colImagen"].Value = imagen;
            dataGridViewCarrito.Rows[nuevaFila].Cells["colProducto"].Value = nombre;
            dataGridViewCarrito.Rows[nuevaFila].Cells["colCantidad"].Value = unidadMedida == "kg"
                ? $"{cantidad:N2} kg"
                : $"{cantidad} {(cantidad > 1 ? "uds." : "ud.")}";
            dataGridViewCarrito.Rows[nuevaFila].Cells["colPrecio"].Value = unidadMedida == "kg" ? $"MXN {precio:N2}/kg" : $"MXN {precio:N2}";
            dataGridViewCarrito.Rows[nuevaFila].Cells["colDescuento"].Value = $"MXN {descuentoAplicado:N2}";
            dataGridViewCarrito.Rows[nuevaFila].Cells["colPrecioFinal"].Value = $"MXN {(cantidad * precioFinalUnitario):N2}";

            ActualizarTotalCarrito();
        }

        public void ActualizarTotalCarrito()
        {
            decimal total = 0;

            foreach (DataGridViewRow fila in dataGridViewCarrito.Rows)
            {
                if (!fila.IsNewRow)
                {
                    string precioFinalText = fila.Cells["colPrecioFinal"].Value.ToString().Replace("MXN", "").Trim();
                    decimal precioFinal = decimal.Parse(precioFinalText);
                    total += precioFinal;
                }
            }

            label_total_carrito.Text = $"MXN {total:N2}";

            if (total == 0)
            {
                label_total_carrito.Text = "MXN 0.00";
            }
        }

        public Image ConvertirBase64AImagen(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms);
            }
        }

        private void listViewProductos_MouseMove(object sender, MouseEventArgs e)
        {
            ListViewItem item = listViewProductos.GetItemAt(e.X, e.Y);
            if (item != null)
            {
                Point posicionFormulario = CalcularPosicionFormulario(item);

                formBotones.Location = posicionFormulario;
                formBotones.ProductoKey = item.Tag?.ToString();

                if (!formBotones.Visible)
                {
                    formBotones.Show();
                }

                ValidarEstadoBotonesFlotantes(formBotones.ProductoKey);

                timerBotones.Stop();
            }
            else
            {
                timerBotones.Start();
            }
        }

        public void ValidarEstadoBotonesFlotantes(string productoKey)
        {
            if (productosCargados.TryGetValue(productoKey, out Producto producto))
            {
                int cantidadEnCarrito = (int)ObtenerCantidadEnCarrito(producto.Descripcion);

                if (categoriasCargadas[producto.idCategoria].UnidadMedida == "kg")
                {
                    if (dataGridViewCarrito.Rows.Cast<DataGridViewRow>()
                        .Any(fila => fila.Cells["colProducto"].Value?.ToString() == producto.Descripcion))
                    {
                        formBotones.btn_agregar_producto.Enabled = false;
                        formBotones.btn_eliminar_producto.Enabled = false;
                        return;
                    }
                }

                formBotones.btn_agregar_producto.Enabled = cantidadEnCarrito < producto.CantidadExistencia;
                formBotones.btn_eliminar_producto.Enabled = cantidadEnCarrito > 0;
            }
            else
            {
                formBotones.btn_agregar_producto.Enabled = false;
                formBotones.btn_eliminar_producto.Enabled = false;
            }
        }

        public decimal ObtenerCantidadEnCarrito(string nombreProducto)
        {
            foreach (DataGridViewRow fila in dataGridViewCarrito.Rows)
            {
                if (!fila.IsNewRow && fila.Cells["colProducto"].Value?.ToString() == nombreProducto)
                {
                    string cantidadTexto = fila.Cells["colCantidad"].Value.ToString();
                    string cantidadNumerica = cantidadTexto.Split(' ')[0];
                    if (decimal.TryParse(cantidadNumerica, out decimal cantidad))
                    {
                        return cantidad;
                    }
                }
            }
            return 0;
        }

        private Point CalcularPosicionFormulario(ListViewItem item)
        {
            Rectangle bounds = item.Bounds;
            Point posicion = listViewProductos.PointToScreen(new Point(bounds.X, bounds.Bottom));
            posicion.X += (bounds.Width - formBotones.Width) / 2;
            return posicion;
        }

        private void listViewProductos_MouseLeave(object sender, EventArgs e)
        {
            timerBotones.Start();
        }

        private void dataGridViewCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var fila = dataGridViewCarrito.Rows[e.RowIndex];
                string productoNombre = fila.Cells["colProducto"].Value.ToString();
                var producto = productosCargados.Values.FirstOrDefault(p => p.Descripcion == productoNombre);

                if (producto != null && categoriasCargadas[producto.idCategoria].UnidadMedida == "kg" &&
                    (dataGridViewCarrito.Columns[e.ColumnIndex].Name == "colAgregar" ||
                     dataGridViewCarrito.Columns[e.ColumnIndex].Name == "colEliminar"))
                {
                    return;
                }

                if (dataGridViewCarrito.Columns[e.ColumnIndex].Name == "colAgregar")
                {
                    string cantidadTexto = fila.Cells["colCantidad"].Value.ToString();
                    string cantidadNumerica = cantidadTexto.Split(' ')[0];
                    int cantidadActual = int.Parse(cantidadNumerica);

                    if (producto != null && cantidadActual < producto.CantidadExistencia)
                    {
                        cantidadActual++;
                        fila.Cells["colCantidad"].Value = categoriasCargadas[producto.idCategoria].UnidadMedida == "kg"
                            ? $"{cantidadActual:N2} kg"
                            : $"{cantidadActual} {(cantidadActual > 1 ? "uds." : "ud.")}";

                        decimal precio = producto.PrecioVenta;
                        decimal descuentoAplicado = Math.Round(precio * ((decimal)producto.Descuento / 100), 2, MidpointRounding.AwayFromZero);
                        decimal precioFinal = precio - descuentoAplicado;
                        fila.Cells["colPrecioFinal"].Value = $"MXN {(cantidadActual * precioFinal):N2}";

                        ActualizarTotalCarrito();
                    }
                }
                else if (dataGridViewCarrito.Columns[e.ColumnIndex].Name == "colEliminar")
                {
                    string cantidadTexto = fila.Cells["colCantidad"].Value.ToString();
                    string cantidadNumerica = cantidadTexto.Split(' ')[0];
                    int cantidadActual = int.Parse(cantidadNumerica);

                    if (producto != null && cantidadActual > 1)
                    {
                        cantidadActual--;
                        fila.Cells["colCantidad"].Value = categoriasCargadas[producto.idCategoria].UnidadMedida == "kg"
                            ? $"{cantidadActual:N2} kg"
                            : $"{cantidadActual} {(cantidadActual > 1 ? "uds." : "ud.")}";

                        decimal precio = producto.PrecioVenta;
                        decimal descuentoAplicado = Math.Round(precio * ((decimal)producto.Descuento / 100), 2, MidpointRounding.AwayFromZero);
                        decimal precioFinal = precio - descuentoAplicado;
                        fila.Cells["colPrecioFinal"].Value = $"MXN {(cantidadActual * precioFinal):N2}";

                        ActualizarTotalCarrito();
                    }
                    else if (cantidadActual == 1)
                    {
                        dataGridViewCarrito.Rows.Remove(fila);
                        ActualizarTotalCarrito();
                    }
                }
                else if (dataGridViewCarrito.Columns[e.ColumnIndex].Name == "BorrarProducto")
                {
                    dataGridViewCarrito.Rows.Remove(fila);
                    ActualizarTotalCarrito();
                }
            }
        }

        private void txtBuscarCodigo_TextChanged(object sender, EventArgs e)
        {
            string codigoBuscado = txtBuscarCodigo.Text.Trim();

            lblBuscarCodigo.Visible = string.IsNullOrEmpty(codigoBuscado);

            borrrartxtbox.Visible = !string.IsNullOrEmpty(txtBuscarCodigo.Text);
            ActualizarVistaProductos();
        }

        private void lblBuscarCodigo_Click(object sender, EventArgs e)
        {
            txtBuscarCodigo.Focus();
        }

        private void comboBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categoriaSeleccionada = comboBoxCategoria.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(categoriaSeleccionada))
            {
                var categoria = categoriasCargadas.Values.FirstOrDefault(c => c.Nombre == categoriaSeleccionada);
                comboBoxSubCategoria.Items.Clear();
                comboBoxSubCategoria.Enabled = true;
                CancelarFiltroCategoria.Visible = true;

                if (categoria != null && categoria.Subcategorias != null && categoria.Subcategorias.Count > 0)
                {
                    foreach (var subcategoria in categoria.Subcategorias)
                    {
                        comboBoxSubCategoria.Items.Add(subcategoria.Value.Nombre);
                    }
                }
                else
                {
                    comboBoxSubCategoria.Enabled = false;
                }
            }
            else
            {
                comboBoxSubCategoria.Items.Clear();
                comboBoxSubCategoria.Enabled = false;
                CancelarFiltroCategoria.Visible = false;
            }

            ActualizarVistaProductos();
        }


        private void comboBoxSubCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            CancelarFiltroSubcategoria.Visible = comboBoxSubCategoria.SelectedItem != null;
            ActualizarVistaProductos();

        }

        private void CancelarFiltroCategoria_Click(object sender, EventArgs e)
        {
            comboBoxCategoria.SelectedItem = null;
            comboBoxSubCategoria.SelectedItem = null;
            comboBoxSubCategoria.Enabled = false;

            CancelarFiltroCategoria.Visible = false;
            CancelarFiltroSubcategoria.Visible = false;

            ActualizarVistaProductos();

        }

        private void CancelarFiltroSubcategoria_Click(object sender, EventArgs e)
        {
            comboBoxSubCategoria.SelectedItem = null;
            CancelarFiltroSubcategoria.Visible = false;

            ActualizarVistaProductos();

        }

        private async Task CargarCategoriasDesdeBaseDatos(string sucursalId)
        {
            try
            {
                var responseCategorias = await firebaseClient.GetAsync($"/Categorias/{sucursalId}");
                categoriasCargadas = responseCategorias.ResultAs<Dictionary<string, Categoria>>();

                comboBoxCategoria.Items.Clear();
                comboBoxSubCategoria.Items.Clear();

                if (categoriasCargadas != null)
                {
                    foreach (var categoria in categoriasCargadas)
                    {

                        comboBoxCategoria.Items.Add(categoria.Value.Nombre);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar categorías: {ex.Message}");
            }
        }

        private void borrrartxtbox_Click(object sender, EventArgs e)
        {
            txtBuscarCodigo.Clear();
            ActualizarVistaProductos();
        }

        private void ActualizarVistaProductos()
        {
            listViewProductos.Items.Clear();
            imageListProductos.Images.Clear();

            var productosFiltrados = productosCargados.Values.AsEnumerable();
            string filtroCodigo = txtBuscarCodigo.Text.Trim();
            if (!string.IsNullOrEmpty(filtroCodigo))
            {
                productosFiltrados = productosFiltrados.Where(p => p.Codigo.IndexOf(filtroCodigo, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            string categoriaSeleccionada = comboBoxCategoria.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(categoriaSeleccionada))
            {
                var categoria = categoriasCargadas.FirstOrDefault(c => c.Value.Nombre == categoriaSeleccionada);
                if (categoria.Key != null)
                {
                    productosFiltrados = productosFiltrados.Where(p => p.idCategoria == categoria.Key);
                }
            }

            string subcategoriaSeleccionada = comboBoxSubCategoria.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(subcategoriaSeleccionada))
            {
                var categoria = categoriasCargadas.FirstOrDefault(c => c.Value.Nombre == categoriaSeleccionada);
                if (categoria.Key != null && categoria.Value.Subcategorias != null)
                {
                    var subcategoria = categoria.Value.Subcategorias.FirstOrDefault(s => s.Value.Nombre == subcategoriaSeleccionada);
                    if (subcategoria.Key != null)
                    {
                        productosFiltrados = productosFiltrados.Where(p => p.idSubcategoria == subcategoria.Key);
                    }
                }
            }

            foreach (var producto in productosFiltrados)
            {
                try
                {
                    Image imagenProducto = ConvertirBase64AImagen(producto.ImagenBase64);
                    imageListProductos.Images.Add(producto.Codigo, imagenProducto);

                    decimal descuentoAplicado = producto.PrecioVenta * ((decimal)producto.Descuento / 100);
                    decimal precioFinal = producto.PrecioVenta - descuentoAplicado;

                    string descripcionConPrecio = $"{producto.Descripcion}\nMXN {precioFinal:N2}";

                    var productoKey = productosCargados.FirstOrDefault(p => p.Value.Codigo == producto.Codigo).Key;
                    ListViewItem item = new ListViewItem(descripcionConPrecio)
                    {
                        ImageKey = producto.Codigo,
                        Tag = productoKey
                    };

                    listViewProductos.Items.Add(item);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al procesar el producto {producto.Descripcion}: {ex.Message}");
                }
            }
        }

        private void txtBuscarCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (char.IsLetter(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void dataGridViewCarrito_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = dataGridViewCarrito.Columns[e.ColumnIndex].Name;
                var fila = dataGridViewCarrito.Rows[e.RowIndex];
                string productoNombre = fila.Cells["colProducto"].Value.ToString();
                var producto = productosCargados.Values.FirstOrDefault(p => p.Descripcion == productoNombre);

                if (producto != null && categoriasCargadas[producto.idCategoria].UnidadMedida == "kg" &&
                    (columnName == "colAgregar" || columnName == "colEliminar"))
                {
                    dataGridViewCarrito.Cursor = Cursors.Default;
                }
                else if (producto != null && columnName == "colAgregar")
                {
                    int cantidad = int.Parse(fila.Cells["colCantidad"].Value.ToString().Split(' ')[0]);
                    if (cantidad >= producto.CantidadExistencia)
                    {
                        dataGridViewCarrito.Cursor = Cursors.Default;
                    }
                    else
                    {
                        dataGridViewCarrito.Cursor = Cursors.Hand;
                    }
                }
                else if (columnName == "colAgregar" || columnName == "colEliminar" || columnName == "BorrarProducto")
                {
                    dataGridViewCarrito.Cursor = Cursors.Hand;
                }
                else
                {
                    dataGridViewCarrito.Cursor = Cursors.Default;
                }
            }
        }

        private void dataGridViewCarrito_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewCarrito.Cursor = Cursors.Default;
        }

        private void dataGridViewCarrito_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewCarrito.Columns[e.ColumnIndex].Name == "colCantidad")
            {
                string productoNombre = dataGridViewCarrito.Rows[e.RowIndex].Cells["colProducto"].Value.ToString();
                string unidadMedida = categoriasCargadas[productosCargados.First(p => p.Value.Descripcion == productoNombre).Value.idCategoria].UnidadMedida;

                var formCantidad = new cantidad_producto_carrito
                {
                    UnidadMedida = unidadMedida,
                    CantidadExistente = productosCargados.First(p => p.Value.Descripcion == productoNombre).Value.CantidadExistencia,
                    CantidadInicial = Convert.ToDecimal(dataGridViewCarrito.Rows[e.RowIndex].Cells["colCantidad"].Value.ToString().Split(' ')[0]),
                    Owner = this
                };

                if (formCantidad.ShowDialog() == DialogResult.OK)
                {
                    decimal cantidadSeleccionada = formCantidad.CantidadSeleccionada;
                    dataGridViewCarrito.Rows[e.RowIndex].Cells["colCantidad"].Value = unidadMedida == "kg"
                        ? $"{cantidadSeleccionada:N2} kg"
                        : $"{cantidadSeleccionada} {(cantidadSeleccionada > 1 ? "uds." : "ud.")}";

                    var producto = productosCargados.First(p => p.Value.Descripcion == productoNombre).Value;
                    decimal precio = producto.PrecioVenta;
                    decimal descuentoAplicado = Math.Round(precio * ((decimal)producto.Descuento / 100), 2, MidpointRounding.AwayFromZero);
                    decimal precioFinalUnitario = precio - descuentoAplicado;

                    dataGridViewCarrito.Rows[e.RowIndex].Cells["colPrecioFinal"].Value = $"MXN {(cantidadSeleccionada * precioFinalUnitario):N2}";

                    ActualizarTotalCarrito();

                    dataGridViewCarrito.ClearSelection();
                    listViewProductos.Focus();
                }
            }
        }

        private void textbox_monto_recibido_TextChanged(object sender, EventArgs e)
        {
            string texto = textbox_monto_recibido.Text.Trim();
            if (texto == ".") texto = "0";

            if (decimal.TryParse(texto, out decimal monto) && monto >= 0)
            {
                btnCobrar.Enabled = true;
            }
            else
            {
                btnCobrar.Enabled = false;
            }
        }

        private void textbox_monto_recibido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '.' && textbox_monto_recibido.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textbox_monto_recibido.Text.Trim(), out decimal montoRecibido))
            {
                decimal total = decimal.Parse(label_total_carrito.Text.Replace("MXN", "").Trim());

                if (montoRecibido >= total)
                {
                    decimal cambio = montoRecibido - total;
                    label_monto_recibido.Text = $"Monto recibido: MXN {montoRecibido:N2}";
                    label_cambio.Visible = true;
                    label_cambio.Text = $"Cambio: MXN {cambio:N2}";

                    textbox_monto_recibido.Visible = false;
                    btnCobrar.Visible = false;
                    btn_siguiente_venta.Visible = true;
                }
                else
                {
                    textbox_monto_recibido.Text = "0";
                }
            }
        }

        private async void btn_siguiente_venta_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow fila in dataGridViewCarrito.Rows)
                {
                    if (!fila.IsNewRow)
                    {
                        string productoNombre = fila.Cells["colProducto"].Value.ToString();
                        decimal cantidadVendida = decimal.Parse(fila.Cells["colCantidad"].Value.ToString().Split(' ')[0]);
                        string productoKey = productosCargados.First(p => p.Value.Descripcion == productoNombre).Key;

                        if (productosCargados.TryGetValue(productoKey, out Producto producto))
                        {
                            producto.CantidadExistencia -= cantidadVendida;
                            await firebaseClient.UpdateAsync($"/Productos/{Sucursalid}/{productoKey}", producto);
                        }
                    }
                }

                dataGridViewCarrito.Rows.Clear();
                label_monto_recibido.Text = "Monto recibido:";
                label_cambio.Visible = false;
                label_cambio.Text = "Cambio:";
                textbox_monto_recibido.Text = "";
                textbox_monto_recibido.Enabled = false;
                textbox_monto_recibido.Visible = true;
                btnCobrar.Enabled = false;
                btnCobrar.Visible = true;
                btn_siguiente_venta.Visible = false;

                comboBoxCategoria.SelectedItem = null;
                comboBoxSubCategoria.SelectedItem = null;
                CancelarFiltroCategoria.Visible = false;
                CancelarFiltroSubcategoria.Visible = false;
                borrrartxtbox.Visible = false;
                txtBuscarCodigo.Clear();
                await CargarProductosDesdeBaseDatos(Sucursalid);
                await CargarCategoriasDesdeBaseDatos(Sucursalid);
                ActualizarTotalCarrito();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar inventario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewCarrito_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dataGridViewCarrito.Rows.Count > 0)
            {
                textbox_monto_recibido.Enabled = true;
                textbox_monto_recibido.Text = "0";
                btnCobrar.Enabled = true;
            }
        }

        private void dataGridViewCarrito_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dataGridViewCarrito.Rows.Count == 0)
            {
                textbox_monto_recibido.Enabled = false;
                textbox_monto_recibido.Text = "";
                btnCobrar.Enabled = false;
            }
        }

        private void lblCategoria_Click(object sender, EventArgs e)
        {

        }

        private void panel_total_carrito_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_cambio_Click(object sender, EventArgs e)
        {

        }

        private void label_monto_recibido_Click(object sender, EventArgs e)
        {

        }

        private void label_id_venta_Click(object sender, EventArgs e)
        {

        }

        private void label_total_carrito_Click(object sender, EventArgs e)
        {

        }
    }
}
