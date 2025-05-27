using FireSharp.Response;
using FireSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Interfaces;

namespace MarketPal
{
    public partial class seccion_agregar_producto : Form
    {
        private string sucursalActual;
        private Dictionary<string, (string id, List<(string nombre, string id)> subcategorias, string unidad, bool permiteDecimales)> categoriasDisponibles
            = new Dictionary<string, (string, List<(string, string)>, string, bool)>();
        private bool permiteDecimales = false;
        private string unidadAbreviada;
        private string idCategoriaSeleccionada;
        private string idSubcategoriaSeleccionada = null;
        private seccion_productos mainForm;
        private IFirebaseClient firebaseClient;

        public seccion_agregar_producto(seccion_productos mainForm, string sucursal)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            sucursalActual = sucursal;
            combobox_categoria_producto.Size = new Size(484, 27);
            ConfigurarFirebase();
            CargarCategoriasYSubcategorias();
            InicializarContadorCaracteres();
        }

        private void ConfigurarFirebase()
        {
            firebaseClient = new FireSharp.FirebaseClient(new FireSharp.Config.FirebaseConfig
            {
                AuthSecret = "lvGHgu8Z3EYxWpBbAI8n8rCBWVncprXedJlfzfht",
                BasePath = "https://prueba-575f7-default-rtdb.firebaseio.com/"
            });

            if (firebaseClient == null)
            {
                MessageBox.Show("No se pudo conectar a Firebase.");
            }
        }

        private void InicializarContadorCaracteres()
        {
            ActualizarContadorCaracteresCodigo();
            ActualizarContadorCaracteresDescripcion();
        }

        private void ActualizarContadorCaracteresCodigo()
        {
            int caracteresCodigo = textbox_codigo_producto.Text.Length;
            label_contador_caracteres_codigo.Text = $"{caracteresCodigo}/14 caracteres.";
        }

        private void ActualizarContadorCaracteresDescripcion()
        {
            int caracteresDescripcion = textbox_descripcion.Text.Length;
            label_contador_caracteres_descripcion.Text = $"{caracteresDescripcion}/80 caracteres.";
        }

        private void textbox_codigo_producto_TextChanged(object sender, EventArgs e)
        {
            ActualizarContadorCaracteresCodigo();
            VerificarCamposObligatorios();

            if (label_mensaje_error_codigo.Visible)
            {
                label_mensaje_error_codigo.Visible = false;
            }
        }

        private void textbox_codigo_producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }

            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textbox_descripcion_TextChanged(object sender, EventArgs e)
        {
            ActualizarContadorCaracteresDescripcion();
            VerificarCamposObligatorios();

            if (label_mensaje_error_descripcion.Visible)
            {
                label_mensaje_error_descripcion.Visible = false;
            }
        }

        private void textbox_descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) &&
                e.KeyChar != '(' && e.KeyChar != ')' && e.KeyChar != '/' && e.KeyChar != '-' &&
                e.KeyChar != '#' && e.KeyChar != '%' && e.KeyChar != '*' && e.KeyChar != '.' &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private async void CargarCategoriasYSubcategorias()
        {
            try
            {
                combobox_categoria_producto.Items.Clear();
                categoriasDisponibles.Clear();

                if (firebaseClient == null)
                {
                    MessageBox.Show("No se pudo conectar a Firebase.");
                    return;
                }

                FirebaseResponse response = await firebaseClient.GetAsync($"/Categorias/{sucursalActual}");
                Dictionary<string, Categoria> categorias = response.ResultAs<Dictionary<string, Categoria>>();

                if (categorias != null)
                {
                    foreach (var categoria in categorias)
                    {
                        string nombreCategoria = categoria.Value.Nombre;
                        string idCategoria = categoria.Key;

                        List<(string nombre, string id)> subcategoriasList = categoria.Value.Subcategorias != null
                            ? categoria.Value.Subcategorias.Select(subcat => (subcat.Value.Nombre, subcat.Key)).ToList()
                            : new List<(string, string)>();

                        string unidad = categoria.Value.UnidadMedida;
                        bool permiteDecimales = categoria.Value.AceptaDecimales;

                        categoriasDisponibles[nombreCategoria] = (idCategoria, subcategoriasList, unidad, permiteDecimales);
                        combobox_categoria_producto.Items.Add(nombreCategoria);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message);
            }
        }

        private void combobox_categoria_producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarCamposObligatorios();

            string categoriaSeleccionada = combobox_categoria_producto.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(categoriaSeleccionada))
            {
                label_subcategoria_producto.Visible = false;
                combobox_subcategoria_producto.Visible = false;
                combobox_categoria_producto.Size = new Size(484, 27);
                label_mensaje_no_subcategorias.Visible = false;
                permiteDecimales = false;
                idCategoriaSeleccionada = null;
                idSubcategoriaSeleccionada = null;
                return;
            }

            if (categoriasDisponibles.TryGetValue(categoriaSeleccionada, out var categoriaData))
            {
                idCategoriaSeleccionada = categoriaData.id;
                unidadAbreviada = categoriaData.unidad;
                permiteDecimales = categoriaData.permiteDecimales;

                ActualizarUnidadesMedida();
                textbox_cantidad_existencia.Enabled = true;
                textbox_cantidad_minima.Enabled = true;
                textbox_cantidad_existencia.Clear();
                textbox_cantidad_minima.Clear();

                if (categoriaData.subcategorias.Count > 0)
                {
                    label_subcategoria_producto.Visible = true;
                    combobox_subcategoria_producto.Visible = true;
                    combobox_subcategoria_producto.Items.Clear();

                    combobox_subcategoria_producto.Items.Add("Sin subcategoría");

                    foreach (var subcategoria in categoriaData.subcategorias)
                    {
                        combobox_subcategoria_producto.Items.Add(subcategoria.nombre);
                    }

                    combobox_subcategoria_producto.SelectedIndex = 0;
                    combobox_categoria_producto.Size = new Size(228, 27);
                    label_mensaje_no_subcategorias.Visible = false;
                    idSubcategoriaSeleccionada = null;
                }
                else
                {
                    label_subcategoria_producto.Visible = false;
                    combobox_subcategoria_producto.Visible = false;
                    combobox_categoria_producto.Size = new Size(484, 27);
                    label_mensaje_no_subcategorias.Visible = true;
                    idSubcategoriaSeleccionada = null;
                }
            }
        }

        private void ActualizarUnidadesMedida()
        {
            label_unidad_existencia.Text = unidadAbreviada;
            label_unidad_minima.Text = unidadAbreviada;
        }

        private void btn_agregar_imagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Imágenes JPG o PNG|*.jpg;*.jpeg;*.png";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Image imagenOriginal = Image.FromFile(openFileDialog.FileName);

                    Image imagenRedimensionada = RedimensionarImagen(imagenOriginal, 200, 200);

                    if (CalcularTamañoEnBytes(imagenRedimensionada) > 2 * 1024 * 1024)
                    {
                        label_mensaje_error_imagen.Visible = true;
                        return;
                    }

                    btn_agregar_imagen.Enabled = false;
                    btn_agregar_imagen.Text = string.Empty;
                    btn_agregar_imagen.Image = null;
                    btn_agregar_imagen.FlatAppearance.MouseDownBackColor = Color.Transparent;
                    btn_agregar_imagen.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    btn_agregar_imagen.BackgroundImage = imagenRedimensionada;
                    btn_agregar_imagen.BackgroundImageLayout = ImageLayout.Stretch;

                    btn_cambiar_imagen.Visible = true;
                    label_mensaje_error_imagen.Visible = false;
                }
            }

            VerificarCamposObligatorios();
        }

        private Image RedimensionarImagen(Image imagenOriginal, int ancho, int alto)
        {
            Bitmap imagenRedimensionada = new Bitmap(ancho, alto);
            using (Graphics g = Graphics.FromImage(imagenRedimensionada))
            {
                g.DrawImage(imagenOriginal, 0, 0, ancho, alto);
            }
            return imagenRedimensionada;
        }

        private long CalcularTamañoEnBytes(Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.Length;
            }
        }

        private void btn_cambiar_imagen_Click(object sender, EventArgs e)
        {
            btn_agregar_imagen_Click(sender, e);
        }

        private void textbox_costo_producto_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObligatorios();
        }

        private void textbox_costo_producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarEntradaNumericaConDecimal(e, textbox_costo_producto);
        }

        private void textbox_precio_venta_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObligatorios();
        }

        private void textbox_precio_venta_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarEntradaNumericaConDecimal(e, textbox_precio_venta);
        }

        private void ValidarEntradaNumericaConDecimal(KeyPressEventArgs e, TextBox textBox)
        {
            if (char.IsControl(e.KeyChar)) return;

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' ||
                (e.KeyChar == '.' && textBox.Text.Contains(".")))
            {
                e.Handled = true;
            }
        }

        private void textbox_cantidad_existencia_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObligatorios();
        }

        private void textbox_cantidad_existencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarEntradaNumerica(e, textbox_cantidad_existencia, permiteDecimales);
        }

        private void textbox_cantidad_minima_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObligatorios();
        }

        private void textbox_cantidad_minima_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarEntradaNumerica(e, textbox_cantidad_minima, permiteDecimales);
        }

        private void ValidarEntradaNumerica(KeyPressEventArgs e, TextBox textBox, bool aceptaDecimales)
        {
            if (char.IsControl(e.KeyChar)) return;

            if (!char.IsDigit(e.KeyChar) && (!aceptaDecimales || e.KeyChar != '.' || textBox.Text.Contains(".")))
            {
                e.Handled = true;
            }
        }

        private void combobox_subcategoria_producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string subcategoriaSeleccionada = combobox_subcategoria_producto.SelectedItem?.ToString();

            if (subcategoriaSeleccionada == "Sin subcategoría")
            {
                idSubcategoriaSeleccionada = null;
            }
            else if (subcategoriaSeleccionada != null && categoriasDisponibles.TryGetValue(combobox_categoria_producto.SelectedItem.ToString(), out var categoriaData))
            {
                var subcategoriaData = categoriaData.subcategorias.FirstOrDefault(s => s.nombre == subcategoriaSeleccionada);
                idSubcategoriaSeleccionada = subcategoriaData.id;
            }
            else
            {
                idSubcategoriaSeleccionada = null;
            }

            VerificarCamposObligatorios();
        }

        private void VerificarCamposObligatorios()
        {
            bool codigoValido = !string.IsNullOrWhiteSpace(textbox_codigo_producto.Text);
            bool descripcionValida = !string.IsNullOrWhiteSpace(textbox_descripcion.Text);
            bool costoValido = !string.IsNullOrWhiteSpace(textbox_costo_producto.Text);
            bool precioValido = !string.IsNullOrWhiteSpace(textbox_precio_venta.Text);
            bool cantidadExistenciaValida = !string.IsNullOrWhiteSpace(textbox_cantidad_existencia.Text);
            bool cantidadMinimaValida = !string.IsNullOrWhiteSpace(textbox_cantidad_minima.Text);
            bool categoriaSeleccionada = combobox_categoria_producto.SelectedIndex >= 0;
            bool imagenCargada = btn_agregar_imagen.BackgroundImage != null;
            bool descuentoLleno = !string.IsNullOrWhiteSpace(textbox_descuento_producto.Text);

            btn_agregar_producto.Enabled = codigoValido && descripcionValida && costoValido &&
                                           precioValido && cantidadExistenciaValida && cantidadMinimaValida &&
                                           categoriaSeleccionada && imagenCargada && descuentoLleno;
        }

        private string ConvertirImagenABase64(Image imagen)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return Convert.ToBase64String(ms.ToArray());
            }
        }

        private async Task GuardarProductoEnFirebase()
        {
            string codigoProducto = textbox_codigo_producto.Text.Trim();
            string descripcionProducto = textbox_descripcion.Text.Trim();

            bool tieneErrores = false;

            bool codigoExiste = await VerificarCodigoExistente(codigoProducto);
            if (codigoExiste)
            {
                label_mensaje_error_codigo.Visible = true;
                tieneErrores = true;
            }

            bool descripcionExiste = await VerificarDescripcionExistente(descripcionProducto);
            if (descripcionExiste)
            {
                label_mensaje_error_descripcion.Visible = true;
                tieneErrores = true;
            }

            if (!int.TryParse(textbox_descuento_producto.Text, out int descuento) || descuento < 0 || descuento > 100)
            {
                label_mensaje_error_descuento.Visible = true;
                tieneErrores = true;
            }

            if (tieneErrores)
            {
                return;
            }

            decimal cantidadExistencia = textbox_cantidad_existencia.Text == "."
                ? 0 : decimal.Parse(textbox_cantidad_existencia.Text, System.Globalization.NumberStyles.Currency);

            decimal cantidadMinima = textbox_cantidad_minima.Text == "."
                ? 0 : decimal.Parse(textbox_cantidad_minima.Text, System.Globalization.NumberStyles.Currency);

            decimal costo = textbox_costo_producto.Text == "."
                ? 0 : decimal.Parse(textbox_costo_producto.Text, System.Globalization.NumberStyles.Currency);

            decimal precioVenta = textbox_precio_venta.Text == "."
                ? 0 : decimal.Parse(textbox_precio_venta.Text, System.Globalization.NumberStyles.Currency);

            string IdProducto = await GenerarNuevoId();
            Producto nuevoProducto = new Producto
            {
                Codigo = codigoProducto,
                Descripcion = descripcionProducto,
                idCategoria = idCategoriaSeleccionada,
                idSubcategoria = idSubcategoriaSeleccionada,
                Costo = costo,
                PrecioVenta = precioVenta,
                CantidadExistencia = cantidadExistencia,
                CantidadMinima = cantidadMinima,
                Descuento = descuento,
                ImagenBase64 = ConvertirImagenABase64(btn_agregar_imagen.BackgroundImage)
            };

            try
            {
                SetResponse response = await firebaseClient.SetAsync($"Productos/{sucursalActual}/{IdProducto}", nuevoProducto);
                mainForm.MostrarMensajeAviso("El producto se ha agregado exitosamente.", true);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el producto: " + ex.Message);
            }
        }

        private async Task<bool> VerificarCodigoExistente(string codigo)
        {
            FirebaseResponse response = await firebaseClient.GetAsync($"Productos/{sucursalActual}");
            Dictionary<string, Producto> productosExistentes = response.ResultAs<Dictionary<string, Producto>>();

            if (productosExistentes != null)
            {
                return productosExistentes.Values.Any(p => p.Codigo.Equals(codigo, StringComparison.OrdinalIgnoreCase));
            }

            return false;
        }

        private async Task<bool> VerificarDescripcionExistente(string descripcion)
        {
            FirebaseResponse response = await firebaseClient.GetAsync($"Productos/{sucursalActual}");
            Dictionary<string, Producto> productosExistentes = response.ResultAs<Dictionary<string, Producto>>();

            if (productosExistentes != null)
            {
                return productosExistentes.Values.Any(p => p.Descripcion.Equals(descripcion, StringComparison.OrdinalIgnoreCase));
            }

            return false;
        }

        private async Task<string> GenerarNuevoId()
        {
            try
            {
                FirebaseResponse response = await firebaseClient.GetAsync($"Productos/{sucursalActual}");
                Dictionary<string, Producto> productosExistentes = response.ResultAs<Dictionary<string, Producto>>();

                int ultimoNumero = 0;

                if (productosExistentes != null)
                {
                    ultimoNumero = productosExistentes.Keys
                        .Where(key => key.StartsWith("PROD") && int.TryParse(key.Substring(4), out _))
                        .Select(key => int.Parse(key.Substring(4)))
                        .DefaultIfEmpty(0)
                        .Max();
                }

                string nuevoId = "PROD" + (ultimoNumero + 1).ToString();

                return nuevoId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el ID: " + ex.Message);
                return null;
            }
        }

        private void btn_agregar_producto_Click(object sender, EventArgs e)
        {
            GuardarProductoEnFirebase();
        }

        private void btn_cancelar_producto_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textbox_descuento_producto_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposObligatorios();

            if (label_mensaje_error_descuento.Visible)
            {
                label_mensaje_error_descuento.Visible = false;
            }
        }

        private void textbox_descuento_producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label_mensaje_error_descuento_Click(object sender, EventArgs e)
        {

        }

        private void seccion_agregar_producto_Load(object sender, EventArgs e)
        {

        }

        private void label_contador_caracteres_codigo_Click(object sender, EventArgs e)
        {

        }

        private void label_contador_caracteres_descripcion_Click(object sender, EventArgs e)
        {

        }

        private void label_mensaje_no_subcategorias_Click(object sender, EventArgs e)
        {

        }

        private void label_indicacion_imagen_Click(object sender, EventArgs e)
        {

        }

        private void label_unidad_existencia_Click(object sender, EventArgs e)
        {

        }

        private void label_unidad_minima_Click(object sender, EventArgs e)
        {

        }

        private void label_mensaje_error_imagen_Click(object sender, EventArgs e)
        {

        }

        private void label_descuento_producto_Click(object sender, EventArgs e)
        {

        }

        private void label_mensaje_error_codigo_Click(object sender, EventArgs e)
        {

        }

        private void label_mensaje_error_descripcion_Click(object sender, EventArgs e)
        {

        }

        private void label_crear_categoria_Click(object sender, EventArgs e)
        {

        }
    }
}
