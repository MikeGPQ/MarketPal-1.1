using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json.Linq;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketPal
{
    public partial class seccion_productos : Form
    {
        private string sucursalActual;
        private IFirebaseClient firebaseClient;
        private Dictionary<string, Producto> productosCargados;
        private CancellationTokenSource mensajeTokenSource;
        private Dictionary<string, Producto> productosFiltrados = new Dictionary<string, Producto>();
        private bool ignorarEventos = false;
        private string sucursalSeleccionada;
        private List<(string Id, string Nombre)> sucursalesDisponibles = new List<(string Id, string Nombre)>();
        private Dictionary<string, Categoria> categoriasDisponibles = new Dictionary<string, Categoria>();
        private CancellationTokenSource cargaProductosTokenSource;
        private CancellationTokenSource mensajeAvisoTokenSource;
        private Dictionary<string, Producto> productosBajosInventario = new Dictionary<string, Producto>();
        private Dictionary<string, Producto> productosAgotados = new Dictionary<string, Producto>();
        private string filtroActivo = "";
        private CancellationTokenSource mensajeExportacionTokenSource;
        private string filtroIdCategoria;
        private string filtroIdSubcategoria;
        private bool filtroAutomaticoAplicado = false;
        private int cantidadElementosMostrados = 0;
        private string rolUsuario; 

        public seccion_productos(string sucursal, string idCategoria = null, string idSubcategoria = null, string rolUsuario = null)
        {
            InitializeComponent();
            ConfigurarFirebase();
            sucursalActual = sucursal;
            sucursalSeleccionada = sucursal;
            filtroIdCategoria = idCategoria;
            filtroIdSubcategoria = idSubcategoria;
            this.rolUsuario = rolUsuario;
        }

        private void ActualizarCantidadElementosLabel()
        {
            label_cantidad_elementos.Text = $"Elementos mostrados: {cantidadElementosMostrados}.";
        }

        private void ActualizarCantidadProductosBajosLabel()
        {
            if (productosBajosInventario.Count > 0)
            {
                label_cantidad_productos_bajos.Visible = true;
                label_cantidad_productos_bajos.Text = productosBajosInventario.Count.ToString();
            }
            else
            {
                label_cantidad_productos_bajos.Visible = false;
            }
        }

        private void ActualizarCantidadProductosAgotadosLabel()
        {
            if (productosAgotados.Count > 0)
            {
                label_cantidad_productos_agotados.Visible = true;
                label_cantidad_productos_agotados.Text = productosAgotados.Count.ToString();
            }
            else
            {
                label_cantidad_productos_agotados.Visible = false;
            }
        }

        private async void seccion_productos_Load(object sender, EventArgs e)
        {
            if (firebaseClient == null)
            {
                MessageBox.Show("La conexión a Firebase no está configurada.");
                return;
            }
            foreach (DataGridViewColumn col in datagrid_productos.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            await CargarProductos(sucursalSeleccionada);
        }

        private async void VerificarCategorias()
        {
            try
            {
                FirebaseResponse response = await firebaseClient.GetAsync($"Categorias/{sucursalSeleccionada}");
                Dictionary<string, Categoria> categorias = response.ResultAs<Dictionary<string, Categoria>>();

                btn_agregar_producto.Enabled = categorias != null && categorias.Count > 0 && sucursalSeleccionada == sucursalActual && rolUsuario == "Administrador";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar categorías: " + ex.Message);
                btn_agregar_producto.Enabled = false;
            }
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

        private async Task CargarProductos(string sucursalId)
        {
            cargaProductosTokenSource?.Cancel();
            cargaProductosTokenSource = new CancellationTokenSource();
            var token = cargaProductosTokenSource.Token;

            try
            {
                ignorarEventos = true;
                ReiniciarOrdenacion();
                textbox_busqueda_codigo.Clear();
                combobox_filtro_categoria.SelectedIndex = -1;
                combobox_filtro_subcategoria.SelectedIndex = -1;
                filtroActivo = "";
                btn_productos_bajos_inventario.BackColor = Color.FromArgb(250, 146, 31);
                btn_productos_agotados.BackColor = Color.FromArgb(250, 146, 31);
                label_aviso_productos.Visible = false;
                btn_agregar_producto.Enabled = false;
                textbox_busqueda_codigo.Enabled = false;
                combobox_filtro_sucursal.Enabled = false;
                btn_exportar_productos.Enabled = false;
                combobox_filtro_categoria.Enabled = false;
                combobox_filtro_subcategoria.Enabled = false;
                btn_borrar_busqueda.Visible = false;
                btn_cancelar_filtro_sucursal.Visible = sucursalSeleccionada != sucursalActual;
                btn_cancelar_filtro_categoria.Visible = false;
                btn_cancelar_filtro_subcategoria.Visible = false;
                label_buscar_codigo.Visible = true;
                btn_productos_bajos_inventario.Enabled = false;
                btn_productos_agotados.Enabled = false;


                MostrarMensajeCarga("Cargando productos...", false);

                datagrid_productos.Columns["Eliminar"].Visible = sucursalId == sucursalActual && rolUsuario == "Administrador";

                await CargarProductosDesdeBaseDatos(sucursalId);
                await ActualizarTablaProductos(token);
                await ConfigurarEstadoControles();

                if (productosCargados == null || productosCargados.Count == 0)
                {
                    label_aviso_productos.Text = "No hay productos disponibles.";
                    label_aviso_productos.Visible = true;
                }
                else
                {
                    label_aviso_productos.Visible = false;
                }

                MostrarMensajeCarga("Carga completada.", true, true);

                ignorarEventos = false;

                if (!filtroAutomaticoAplicado && (!string.IsNullOrEmpty(filtroIdCategoria) || !string.IsNullOrEmpty(filtroIdSubcategoria)))
                {
                    filtroAutomaticoAplicado = true;

                    if (!string.IsNullOrEmpty(filtroIdCategoria))
                    {
                        combobox_filtro_categoria.SelectedIndex = categoriasDisponibles
                            .Keys
                            .ToList()
                            .IndexOf(filtroIdCategoria);

                        if (!string.IsNullOrEmpty(filtroIdSubcategoria))
                        {
                            combobox_filtro_subcategoria.SelectedIndex = categoriasDisponibles[filtroIdCategoria].Subcategorias
                                .Keys
                                .ToList()
                                .IndexOf(filtroIdSubcategoria);
                        }
                    }
                }
            }
            catch (OperationCanceledException)
            {

            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }

        private async Task ConfigurarEstadoControles()
        {
            VerificarCategorias();

            textbox_busqueda_codigo.Enabled = true;
            btn_productos_bajos_inventario.Enabled = true;
            btn_productos_agotados.Enabled = true;

            if (sucursalesDisponibles == null || sucursalesDisponibles.Count == 0)
            {
                await CargarSucursales();
            }

            if (sucursalesDisponibles.Count <= 1)
            {
                combobox_filtro_sucursal.Enabled = false;
                combobox_filtro_sucursal.Items.Clear();

                if (sucursalesDisponibles.Count == 1)
                {
                    var sucursalActualNombre = sucursalesDisponibles.First().Nombre;
                    combobox_filtro_sucursal.Items.Add($"{sucursalActualNombre} (Esta sucursal)");
                }
                combobox_filtro_sucursal.SelectedIndex = 0;
            }
            else
            {
                combobox_filtro_sucursal.Enabled = true;
                combobox_filtro_sucursal.Items.Clear();

                foreach (var sucursal in sucursalesDisponibles)
                {
                    string item = sucursal.Id == sucursalActual
                        ? $"{sucursal.Nombre} (Esta sucursal)"
                        : sucursal.Nombre;
                    combobox_filtro_sucursal.Items.Add(item);
                }

                combobox_filtro_sucursal.SelectedIndex = sucursalesDisponibles
                    .FindIndex(s => s.Id == sucursalSeleccionada);
            }

            var categoriasLista = await CargarCategorias();
            combobox_filtro_categoria.Items.Clear();

            if (categoriasLista.Count == 0)
            {
                combobox_filtro_categoria.Enabled = false;
            }
            else
            {
                combobox_filtro_categoria.Enabled = true;
                combobox_filtro_categoria.Items.AddRange(categoriasLista.Select(c => c.Nombre).ToArray());
            }

            combobox_filtro_subcategoria.Items.Clear();
        }

        private async Task CargarSucursales()
        {
            try
            {
                FirebaseResponse response = await firebaseClient.GetAsync("/Sucursales");
                var sucursalesData = response.ResultAs<Dictionary<string, Sucursal>>();

                sucursalesDisponibles = new List<(string Id, string Nombre)>();
                if (sucursalesData != null)
                {
                    foreach (var sucursal in sucursalesData)
                    {
                        sucursalesDisponibles.Add((sucursal.Key, sucursal.Value.Nombre));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar sucursales: " + ex.Message);
                sucursalesDisponibles = new List<(string Id, string Nombre)>();
            }
        }

        private async Task<List<Categoria>> CargarCategorias()
        {
            try
            {
                FirebaseResponse response = await firebaseClient.GetAsync($"/Categorias/{sucursalSeleccionada}");
                categoriasDisponibles = response.ResultAs<Dictionary<string, Categoria>>() ?? new Dictionary<string, Categoria>();
                return categoriasDisponibles.Values.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message);
                categoriasDisponibles = new Dictionary<string, Categoria>();
                return new List<Categoria>();
            }
        }

        private async Task CargarProductosDesdeBaseDatos(string sucursalId)
        {
            try
            {
                var responseProductos = await firebaseClient.GetAsync($"/Productos/{sucursalId}");
                productosCargados = responseProductos.ResultAs<Dictionary<string, Producto>>();
                cantidadElementosMostrados = productosCargados?.Count ?? 0;

                productosBajosInventario = productosCargados?.Where(p => p.Value.CantidadExistencia <= p.Value.CantidadMinima && p.Value.CantidadExistencia > 0)
                    .ToDictionary(p => p.Key, p => p.Value) ?? new Dictionary<string, Producto>();

                productosAgotados = productosCargados?.Where(p => p.Value.CantidadExistencia == 0)
                    .ToDictionary(p => p.Key, p => p.Value) ?? new Dictionary<string, Producto>();

                ActualizarCantidadElementosLabel();
                ActualizarCantidadProductosBajosLabel();
                ActualizarCantidadProductosAgotadosLabel();
            }
            catch (OperationCanceledException)
            {

            }
            catch (Exception ex)
            {
            }
        }

        private async Task ActualizarTablaProductos(CancellationToken token)
        {
            try
            {
                datagrid_productos.Rows.Clear();
                productosFiltrados.Clear();

                if (productosCargados != null)
                {
                    foreach (var productoKey in productosCargados.Keys)
                    {
                        var producto = productosCargados[productoKey];
                        productosFiltrados[productoKey] = producto;
                        int indiceFila = datagrid_productos.Rows.Add();
                        DataGridViewRow fila = datagrid_productos.Rows[indiceFila];
                        await ConfigurarFila(fila, producto, productoKey, token);
                    }
                }

                btn_exportar_productos.Invoke((Action)(() =>
                {
                    btn_exportar_productos.Enabled = datagrid_productos.Rows.Count > 0;
                }));
            }
            catch (OperationCanceledException)
            {

            }
            catch (Exception ex)
            {

            }
        }

        private Image ConvertirBase64AImagen(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms);
            }
        }

        private async Task<(string Nombre, string Unidad)> ObtenerNombreYCategoriaUnidad(string categoriaId)
        {
            var response = await firebaseClient.GetAsync($"/Categorias/{sucursalSeleccionada}/{categoriaId}");
            var categoriaData = response.ResultAs<Categoria>();

            return (categoriaData.Nombre, categoriaData.UnidadMedida);
        }

        private async Task<string> ObtenerNombreSubcategoria(string categoriaId, string subcategoriaId)
        {
            if (string.IsNullOrEmpty(subcategoriaId)) return null;
            var response = await firebaseClient.GetAsync($"/Categorias/{sucursalSeleccionada}/{categoriaId}/Subcategorias/{subcategoriaId}/Nombre");
            return response.ResultAs<string>();
        }

        private string FormatearCantidadConUnidad(decimal cantidad, string unidad)
        {
            string unidadTexto = unidad == "uds." && cantidad == 1 ? "ud." : unidad;
            return $"{cantidad:N2} {unidadTexto}";
        }

        private void btn_agregar_producto_Click(object sender, EventArgs e)
        {
            using (var agregarProductoForm = new seccion_agregar_producto(this, sucursalSeleccionada))
            {
                var resultado = agregarProductoForm.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    CargarProductos(sucursalSeleccionada);
                }
            }
        }

        private void datagrid_productos_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 &&
                (e.ColumnIndex == datagrid_productos.Columns["Detalles"].Index ||
                 e.ColumnIndex == datagrid_productos.Columns["Eliminar"].Index))
            {
                var cellValue = datagrid_productos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (cellValue is Image)
                {
                    datagrid_productos.Cursor = Cursors.Hand;
                }
            }
        }

        private void datagrid_productos_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            datagrid_productos.Cursor = Cursors.Default;
        }

        private async void datagrid_productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == datagrid_productos.Columns["Detalles"].Index)
                {
                    string productoKey = datagrid_productos.Rows[e.RowIndex].Tag.ToString();

                    if (productosCargados.TryGetValue(productoKey, out Producto productoSeleccionado))
                    {
                        var detallesForm = new seccion_detalles_producto(productoSeleccionado, productoKey, this, sucursalSeleccionada);

                        detallesForm.btn_editar_producto.Visible = sucursalSeleccionada == sucursalActual && rolUsuario == "Administrador";
                        detallesForm.btn_eliminar_producto.Visible = sucursalSeleccionada == sucursalActual && rolUsuario == "Administrador";

                        detallesForm.ProductoGuardado += async () =>
                        {
                            await CargarProductos(sucursalSeleccionada);
                        };

                        var resultado = detallesForm.ShowDialog();

                        if (resultado == DialogResult.OK)
                        {
                            CargarProductos(sucursalSeleccionada);
                        }
                    }
                }
                else if (e.ColumnIndex == datagrid_productos.Columns["Eliminar"].Index)
                {
                    string productoKey = datagrid_productos.Rows[e.RowIndex].Tag.ToString();

                    var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        try
                        {
                            await firebaseClient.DeleteAsync($"Productos/{sucursalSeleccionada}/{productoKey}");
                            MostrarMensajeAviso("El producto se ha eliminado exitosamente.", true);
                            await CargarProductos(sucursalSeleccionada);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al eliminar el producto: " + ex.Message);
                        }
                    }
                }
            }
        }

        public void MostrarMensajeAviso(string mensaje, bool esExito)
        {
            mensajeAvisoTokenSource?.Cancel();
            mensajeAvisoTokenSource = new CancellationTokenSource();
            var token = mensajeAvisoTokenSource.Token;

            mensaje_aviso aviso = new mensaje_aviso();
            Color colorTexto = esExito ? Color.LimeGreen : Color.Red;
            Image imagen = esExito ? aviso.imagelist_aviso.Images[0] : aviso.imagelist_aviso.Images[1];

            aviso.TopLevel = false;
            aviso.Dock = DockStyle.Fill;
            aviso.ConfigurarAviso(mensaje, colorTexto, imagen);

            panel_mensaje_agregar_eliminar_producto.Controls.Clear();
            panel_mensaje_agregar_eliminar_producto.Controls.Add(aviso);
            panel_mensaje_agregar_eliminar_producto.Visible = true;

            aviso.Show();
            try
            {
                Task.Delay(3000, token).ContinueWith(t =>
                {
                    if (!t.IsCanceled)
                    {
                        try
                        {
                            this.Invoke((Action)(() =>
                            {
                                panel_mensaje_agregar_eliminar_producto.Visible = false;
                                panel_mensaje_agregar_eliminar_producto.Controls.Clear();
                            }));
                        }
                        catch (Exception ex) { }
                    }
                }, TaskScheduler.FromCurrentSynchronizationContext());
            }
            catch (Exception ex)
            {

            }
        }

        private void MostrarMensajeCarga(string mensaje, bool esExito, bool desaparecerAutomaticamente = false)
        {
            mensajeTokenSource?.Cancel();
            mensajeTokenSource = new CancellationTokenSource();

            mensaje_aviso aviso = new mensaje_aviso();

            Color colorTexto = esExito ? Color.LimeGreen : Color.Red;
            Image imagen = esExito ? aviso.imagelist_aviso.Images[0] : aviso.imagelist_aviso.Images[1];

            aviso.TopLevel = false;
            aviso.Dock = DockStyle.Fill;
            aviso.ConfigurarAviso(mensaje, colorTexto, imagen);
            aviso.btn_cerrar_aviso.Visible = esExito;

            panel_mensaje_aviso.Controls.Clear();
            panel_mensaje_aviso.Controls.Add(aviso);
            panel_mensaje_aviso.Visible = true;

            aviso.Show();

            if (desaparecerAutomaticamente)
            {
                try
                {
                    Task.Delay(3000, mensajeTokenSource.Token).ContinueWith(t =>
                    {
                        if (!t.IsCanceled)
                        {
                            try
                            {
                                this.Invoke((Action)(() =>
                                {
                                    panel_mensaje_aviso.Visible = false;
                                    panel_mensaje_aviso.Controls.Clear();
                                }));
                            }
                            catch { }
                        }
                    });
                }
                catch (Exception ex)
                {

                }
            }
        }

        private async Task ConfigurarFila(DataGridViewRow fila, Producto producto, string productoKey, CancellationToken token)
        {
            try
            {
                token.ThrowIfCancellationRequested();

                Image imagenProducto = ConvertirBase64AImagen(producto.ImagenBase64);
                token.ThrowIfCancellationRequested();

                var (categoriaNombre, unidadMedida) = await ObtenerNombreYCategoriaUnidad(producto.idCategoria);
                token.ThrowIfCancellationRequested();

                string subcategoriaNombre = await ObtenerNombreSubcategoria(producto.idCategoria, producto.idSubcategoria);
                token.ThrowIfCancellationRequested();

                string cantidadExistenciaTexto = FormatearCantidadConUnidad(producto.CantidadExistencia, unidadMedida);

                decimal precioVentaFinal = producto.PrecioVenta;
                if (producto.Descuento > 0)
                {
                    decimal descuentoAplicado = producto.PrecioVenta * (producto.Descuento / 100m);
                    precioVentaFinal = producto.PrecioVenta - descuentoAplicado;
                }

                fila.Cells["Imagen"].Value = imagenProducto;
                fila.Cells["Código"].Value = producto.Codigo;
                fila.Cells["Descripción"].Value = producto.Descripcion;
                fila.Cells["Categoría"].Value = categoriaNombre;
                fila.Cells["Subcategoría"].Value = subcategoriaNombre ?? "-";
                fila.Cells["Precio_Venta"].Value = $"MXN {precioVentaFinal:N2}";
                fila.Cells["Cantidad_Existencia"].Value = cantidadExistenciaTexto;

                if (producto.CantidadExistencia <= producto.CantidadMinima)
                {
                    fila.Cells["Cantidad_Existencia"].Style.ForeColor = Color.Red;
                }

                fila.Tag = productoKey;
            }
            catch (OperationCanceledException)
            {

            }
            catch (Exception ex)
            {

            }
        }

        private async Task ActualizarTablaConBusquedaYFiltros()
        {
            cargaProductosTokenSource?.Cancel();
            cargaProductosTokenSource = new CancellationTokenSource();
            var token = cargaProductosTokenSource.Token;

            try
            {
                btn_exportar_productos.Enabled = false;
                ReiniciarOrdenacion();

                Dictionary<string, Producto> productosBase;

                if (filtroActivo == "bajos")
                {
                    productosBase = productosBajosInventario;
                }
                else if (filtroActivo == "agotados")
                {
                    productosBase = productosAgotados;
                }
                else
                {
                    productosBase = productosFiltrados;
                }

                string textoBusqueda = textbox_busqueda_codigo.Text.Trim().ToUpper();
                string idCategoriaSeleccionada = combobox_filtro_categoria.SelectedIndex >= 0
                    ? categoriasDisponibles.ElementAt(combobox_filtro_categoria.SelectedIndex).Key
                    : null;
                string idSubcategoriaSeleccionada = combobox_filtro_subcategoria.SelectedIndex >= 0
                    ? categoriasDisponibles[idCategoriaSeleccionada].Subcategorias.ElementAt(combobox_filtro_subcategoria.SelectedIndex).Key
                    : null;

                var productosResultado = productosBase
                    .Where(p =>
                        (string.IsNullOrWhiteSpace(textoBusqueda) || p.Value.Codigo.Contains(textoBusqueda)) &&
                        (idCategoriaSeleccionada == null || p.Value.idCategoria == idCategoriaSeleccionada) &&
                        (idSubcategoriaSeleccionada == null || p.Value.idSubcategoria == idSubcategoriaSeleccionada))
                    .ToDictionary(p => p.Key, p => p.Value);

                datagrid_productos.Invoke((Action)(() => datagrid_productos.Rows.Clear()));

                cantidadElementosMostrados = productosResultado.Count;
                ActualizarCantidadElementosLabel();

                if (productosResultado.Count == 0)
                {
                    label_aviso_productos.Invoke((Action)(() =>
                    {
                        label_aviso_productos.Text = !string.IsNullOrWhiteSpace(textoBusqueda) || idCategoriaSeleccionada != null || idSubcategoriaSeleccionada != null
                            ? "No se encontraron resultados de búsqueda."
                            : filtroActivo == "bajos"
                                ? "No hay productos bajos en inventario."
                                : filtroActivo == "agotados"
                                    ? "No hay productos agotados."
                                    : "No hay productos disponibles.";
                        label_aviso_productos.Visible = true;
                    }));
                }
                else
                {
                    label_aviso_productos.Invoke((Action)(() => label_aviso_productos.Visible = false));

                    foreach (var productoKey in productosResultado.Keys)
                    {
                        token.ThrowIfCancellationRequested();

                        var producto = productosResultado[productoKey];
                        int indiceFila = datagrid_productos.Invoke((Func<int>)(() => datagrid_productos.Rows.Add()));
                        DataGridViewRow fila = datagrid_productos.Invoke((Func<DataGridViewRow>)(() => datagrid_productos.Rows[indiceFila]));

                        await ConfigurarFila(fila, producto, productoKey, token);
                    }
                }

                btn_exportar_productos.Invoke((Action)(() =>
                {
                    btn_exportar_productos.Enabled = datagrid_productos.Rows.Count > 0;
                }));
            }
            catch (OperationCanceledException)
            {
            }
            catch (Exception ex)
            {
            }
        }

        private void panel_mensaje_aviso_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void textbox_busqueda_codigo_TextChanged(object sender, EventArgs e)
        {
            if (ignorarEventos) return;

            try
            {
                cargaProductosTokenSource?.Cancel();
                cargaProductosTokenSource = new CancellationTokenSource();
                var token = cargaProductosTokenSource.Token;

                await Task.Delay(300, token);

                if (!token.IsCancellationRequested)
                {
                    btn_borrar_busqueda.Visible = !string.IsNullOrWhiteSpace(textbox_busqueda_codigo.Text);
                    label_buscar_codigo.Visible = string.IsNullOrWhiteSpace(textbox_busqueda_codigo.Text);

                    await ActualizarTablaConBusquedaYFiltros();
                }
            }
            catch (TaskCanceledException)
            {

            }
            catch (Exception ex)
            {

            }
        }

        private void textbox_busqueda_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void label_buscar_codigo_Click(object sender, EventArgs e)
        {
            textbox_busqueda_codigo.Focus();
        }

        private void btn_borrar_busqueda_Click(object sender, EventArgs e)
        {
            textbox_busqueda_codigo.Clear();
        }

        private async void combobox_filtro_sucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ignorarEventos) return;

            int selectedIndex = combobox_filtro_sucursal.SelectedIndex;
            if (selectedIndex < 0 || selectedIndex >= sucursalesDisponibles.Count) return;

            string nuevaSucursalId = sucursalesDisponibles[selectedIndex].Id;

            if (nuevaSucursalId != sucursalSeleccionada)
            {
                sucursalSeleccionada = nuevaSucursalId;

                await CargarProductos(sucursalSeleccionada);
            }
        }

        private async void btn_cancelar_filtro_sucursal_Click(object sender, EventArgs e)
        {
            sucursalSeleccionada = sucursalActual;
            btn_cancelar_filtro_sucursal.Visible = false;
            combobox_filtro_sucursal.SelectedIndex = sucursalesDisponibles.FindIndex(s => s.Id == sucursalSeleccionada);

            await CargarProductos(sucursalActual);
        }

        private async void combobox_filtro_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ignorarEventos) return;

            int selectedIndex = combobox_filtro_categoria.SelectedIndex;

            if (selectedIndex >= 0)
            {
                string idCategoriaSeleccionada = categoriasDisponibles.ElementAt(selectedIndex).Key;
                var subcategoriasData = categoriasDisponibles[idCategoriaSeleccionada].Subcategorias;

                combobox_filtro_subcategoria.Items.Clear();
                combobox_filtro_subcategoria.Items.AddRange(subcategoriasData.Values.Select(s => s.Nombre).ToArray());
                combobox_filtro_subcategoria.Enabled = subcategoriasData.Count > 0;

                btn_cancelar_filtro_categoria.Visible = true;
            }
            else
            {
                combobox_filtro_subcategoria.Items.Clear();
                combobox_filtro_subcategoria.Enabled = false;
                btn_cancelar_filtro_categoria.Visible = false;
            }

            await ActualizarTablaConBusquedaYFiltros();
        }

        private async void btn_cancelar_filtro_categoria_Click(object sender, EventArgs e)
        {
            combobox_filtro_categoria.SelectedIndex = -1;
            combobox_filtro_subcategoria.Items.Clear();
            combobox_filtro_subcategoria.Enabled = false;
            btn_cancelar_filtro_categoria.Visible = false;
            btn_cancelar_filtro_subcategoria.Visible = false;

            await ActualizarTablaConBusquedaYFiltros();
        }

        private async void combobox_filtro_subcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ignorarEventos) return;

            if (combobox_filtro_subcategoria.SelectedIndex >= 0)
            {
                btn_cancelar_filtro_subcategoria.Visible = true;
            }
            else
            {
                btn_cancelar_filtro_subcategoria.Visible = false;
            }

            await ActualizarTablaConBusquedaYFiltros();
        }

        private async void btn_cancelar_filtro_subcategoria_Click(object sender, EventArgs e)
        {
            combobox_filtro_subcategoria.SelectedIndex = -1;
            btn_cancelar_filtro_subcategoria.Visible = false;

            await ActualizarTablaConBusquedaYFiltros();
        }

        private async void btn_productos_bajos_inventario_Click(object sender, EventArgs e)
        {
            ReiniciarControles();

            if (filtroActivo == "bajos")
            {
                filtroActivo = "";
                btn_productos_bajos_inventario.BackColor = Color.FromArgb(250, 146, 31);
                await CargarProductos(sucursalSeleccionada);
            }
            else
            {
                filtroActivo = "bajos";
                btn_productos_bajos_inventario.BackColor = Color.FromArgb(211, 113, 3);
                btn_productos_agotados.BackColor = Color.FromArgb(250, 146, 31);

                productosBajosInventario = productosFiltrados
                    .Where(p => p.Value.CantidadExistencia <= p.Value.CantidadMinima && p.Value.CantidadExistencia > 0)
                    .ToDictionary(p => p.Key, p => p.Value);

                await ActualizarTablaConBusquedaYFiltros();
            }
        }

        private async void btn_productos_agotados_Click(object sender, EventArgs e)
        {
            ReiniciarControles();

            if (filtroActivo == "agotados")
            {
                filtroActivo = "";
                btn_productos_agotados.BackColor = Color.FromArgb(250, 146, 31);
                await CargarProductos(sucursalSeleccionada);
            }
            else
            {
                filtroActivo = "agotados";
                btn_productos_agotados.BackColor = Color.FromArgb(211, 113, 3);
                btn_productos_bajos_inventario.BackColor = Color.FromArgb(250, 146, 31);

                productosAgotados = productosFiltrados
                    .Where(p => p.Value.CantidadExistencia == 0)
                    .ToDictionary(p => p.Key, p => p.Value);

                await ActualizarTablaConBusquedaYFiltros();
            }
        }

        private void ReiniciarControles()
        {
            textbox_busqueda_codigo.Clear();
            combobox_filtro_categoria.SelectedIndex = -1;
            combobox_filtro_subcategoria.SelectedIndex = -1;
            btn_borrar_busqueda.Visible = false;
            btn_cancelar_filtro_categoria.Visible = false;
            btn_cancelar_filtro_subcategoria.Visible = false;
            label_aviso_productos.Visible = false;
            label_buscar_codigo.Visible = true;
        }

        private void datagrid_productos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn columnaSeleccionada = datagrid_productos.Columns[e.ColumnIndex];

            if (datagrid_productos.Rows.Count == 0)
            {
                return;
            }

            if (columnaSeleccionada.Name == "Descripción" || columnaSeleccionada.Name == "Precio_Venta" || columnaSeleccionada.Name == "Cantidad_Existencia")
            {
                SortOrder ordenActual = columnaSeleccionada.HeaderCell.SortGlyphDirection;
                SortOrder nuevoOrden = ordenActual == SortOrder.Ascending
                    ? SortOrder.Descending
                    : SortOrder.Ascending;

                var filas = datagrid_productos.Rows.Cast<DataGridViewRow>().ToList();

                if (columnaSeleccionada.Name == "Descripción")
                {
                    filas = nuevoOrden == SortOrder.Ascending
                        ? filas.OrderBy(f => f.Cells["Descripción"].Value?.ToString()).ToList()
                        : filas.OrderByDescending(f => f.Cells["Descripción"].Value?.ToString()).ToList();
                }
                else if (columnaSeleccionada.Name == "Precio_Venta")
                {
                    filas = nuevoOrden == SortOrder.Ascending
                        ? filas.OrderBy(f => productosCargados[f.Tag.ToString()].PrecioVenta).ToList()
                        : filas.OrderByDescending(f => productosCargados[f.Tag.ToString()].PrecioVenta).ToList();
                }
                else if (columnaSeleccionada.Name == "Cantidad_Existencia")
                {
                    filas = nuevoOrden == SortOrder.Ascending
                        ? filas.OrderBy(f => productosCargados[f.Tag.ToString()].CantidadExistencia).ToList()
                        : filas.OrderByDescending(f => productosCargados[f.Tag.ToString()].CantidadExistencia).ToList();
                }

                datagrid_productos.Rows.Clear();
                foreach (var fila in filas)
                {
                    datagrid_productos.Rows.Add(fila);
                }

                foreach (DataGridViewColumn col in datagrid_productos.Columns)
                {
                    col.HeaderCell.SortGlyphDirection = SortOrder.None;
                }

                columnaSeleccionada.HeaderCell.SortGlyphDirection = nuevoOrden;
            }
        }

        private void ReiniciarOrdenacion()
        {
            foreach (DataGridViewColumn col in datagrid_productos.Columns)
            {
                col.HeaderCell.SortGlyphDirection = SortOrder.None;
            }
        }

        private void btn_exportar_productos_Click(object sender, EventArgs e)
        {
            if (datagrid_productos.Rows.Count == 0)
            {
                return;
            }

            try
            {
                ExportarProductos();
            }
            catch (Exception ex)
            {

            }
        }

        private void ExportarProductos()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Archivo Excel (*.xlsx)|*.xlsx",
                Title = "Guardar productos",
                FileName = GenerarNombreArchivoExportacion()
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                    using (var package = new OfficeOpenXml.ExcelPackage())
                    {
                        var worksheet = package.Workbook.Worksheets.Add("Productos");

                        worksheet.Cells[1, 1].Value = "Código";
                        worksheet.Cells[1, 2].Value = "Descripción";
                        worksheet.Cells[1, 3].Value = "Categoría";
                        worksheet.Cells[1, 4].Value = "Subcategoría";
                        worksheet.Cells[1, 5].Value = "Precio Final";
                        worksheet.Cells[1, 6].Value = "Cantidad en Existencia";

                        int fila = 2;
                        foreach (DataGridViewRow row in datagrid_productos.Rows)
                        {
                            worksheet.Cells[fila, 1].Value = row.Cells["Código"].Value?.ToString();
                            worksheet.Cells[fila, 2].Value = row.Cells["Descripción"].Value?.ToString();
                            worksheet.Cells[fila, 3].Value = row.Cells["Categoría"].Value?.ToString();
                            worksheet.Cells[fila, 4].Value = row.Cells["Subcategoría"].Value?.ToString();
                            worksheet.Cells[fila, 5].Value = row.Cells["Precio_Venta"].Value?.ToString();
                            worksheet.Cells[fila, 6].Value = row.Cells["Cantidad_Existencia"].Value?.ToString();
                            fila++;
                        }

                        worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();
                        package.SaveAs(new FileInfo(saveFileDialog.FileName));

                        MostrarMensajeExportacion("Exportación completada con éxito.", true);
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
        }

        private string GenerarNombreArchivoExportacion()
        {
            return filtroActivo switch
            {
                "bajos" => "Productos_Bajos_Inventario.xlsx",
                "agotados" => "Productos_Agotados.xlsx",
                _ => "Productos_Todos.xlsx",
            };
        }

        private void MostrarMensajeExportacion(string mensaje, bool esExito)
        {
            mensajeExportacionTokenSource?.Cancel();
            mensajeExportacionTokenSource = new CancellationTokenSource();
            var token = mensajeExportacionTokenSource.Token;

            mensaje_aviso aviso = new mensaje_aviso();
            Color colorTexto = esExito ? Color.LimeGreen : Color.Red;
            Image imagen = esExito ? aviso.imagelist_aviso.Images[0] : aviso.imagelist_aviso.Images[1];

            aviso.TopLevel = false;
            aviso.Dock = DockStyle.Fill;
            aviso.ConfigurarAviso(mensaje, colorTexto, imagen);
            aviso.btn_cerrar_aviso.Visible = esExito;

            panel_mensaje_agregar_eliminar_producto.Controls.Clear();
            panel_mensaje_agregar_eliminar_producto.Controls.Add(aviso);
            panel_mensaje_agregar_eliminar_producto.Visible = true;

            aviso.Show();

            if (esExito)
            {
                try
                {
                    Task.Delay(3000, token).ContinueWith(t =>
                    {
                        if (!t.IsCanceled)
                        {
                            try
                            {
                                Invoke((Action)(() =>
                                {
                                    panel_mensaje_agregar_eliminar_producto.Visible = false;
                                    panel_mensaje_agregar_eliminar_producto.Controls.Clear();
                                }));
                            } 
                            catch (Exception ex) { }
                        }
                    });
                }
                catch (Exception ex) 
                { 
                
                }
            }
        }

        private void label_aviso_productos_Click(object sender, EventArgs e)
        {

        }

        private void seccion_productos_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void panel_mensaje_agregar_eliminar_producto_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_cantidad_elementos_Click(object sender, EventArgs e)
        {

        }
    }
}
