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
using FireSharp.Config;

namespace MarketPal
{
    public partial class seccion_detalles_producto : Form
    {
        private string sucursalActual;
        private Producto productoActual;
        private string productoKey;
        private Dictionary<string, Categoria> categoriasDisponibles;
        private bool enModoEdicion = false;
        private string idCategoriaSeleccionada;
        private string idSubcategoriaSeleccionada;
        public event Action ProductoGuardado;
        private bool permiteDecimales;
        private bool datosModificados = false;
        private bool cargandoDatos = true;
        private bool imagenCambiada = false;
        private seccion_productos mainForm;
        private IFirebaseClient firebaseClient;

        public seccion_detalles_producto(Producto producto, string productoKey, seccion_productos mainForm, string sucursal)
        {
            InitializeComponent();
            productoActual = producto;
            this.productoKey = productoKey;
            this.mainForm = mainForm;
            sucursalActual = sucursal;
        }

        private async Task RecargarDatosDesdeBaseDeDatos()
        {
            try
            {
                var response = await firebaseClient.GetAsync($"/Productos/{sucursalActual}/{productoKey}");
                productoActual = response.ResultAs<Producto>();

                if (productoActual != null)
                {
                    CargarDatosProducto();
                }
                else
                {
                    MessageBox.Show("El producto ya no existe en la base de datos.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al recargar datos desde la base de datos: " + ex.Message);
            }
        }

        private void seccion_detalles_producto_Load(object sender, EventArgs e)
        {
            combobox_categoria_producto.Size = new Size(484, 27);
            ConfigurarFirebase();
            CargarCategoriasYSubcategorias();
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

        private async Task CargarCategoriasYSubcategorias()
        {
            try
            {
                FirebaseResponse response = await firebaseClient.GetAsync($"/Categorias/{sucursalActual}");
                categoriasDisponibles = response.ResultAs<Dictionary<string, Categoria>>();

                combobox_categoria_producto.Items.Clear();

                if (categoriasDisponibles != null)
                {
                    foreach (var categoria in categoriasDisponibles.Values)
                    {
                        string nombreCategoria = categoria.Nombre;
                        combobox_categoria_producto.Items.Add(nombreCategoria);
                    }
                }

                CargarDatosProducto();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message);
            }
        }

        private void CargarDatosProducto()
        {
            cargandoDatos = true;

            textbox_codigo_producto.Text = productoActual.Codigo;
            textbox_descripcion.Text = productoActual.Descripcion;
            textbox_costo_producto.Text = productoActual.Costo.ToString("N2");
            textbox_precio_venta.Text = productoActual.PrecioVenta.ToString("N2");
            textbox_descuento_producto.Text = productoActual.Descuento.ToString();
            textbox_cantidad_existencia.Text = productoActual.CantidadExistencia.ToString("N2");
            textbox_cantidad_minima.Text = productoActual.CantidadMinima.ToString("N2");

            if (!string.IsNullOrEmpty(productoActual.ImagenBase64))
            {
                btn_agregar_imagen.BackgroundImage = ConvertirBase64AImagen(productoActual.ImagenBase64);
                btn_agregar_imagen.BackgroundImageLayout = ImageLayout.Stretch;

            }

            if (categoriasDisponibles.TryGetValue(productoActual.idCategoria, out var categoriaSeleccionada))
            {
                combobox_categoria_producto.SelectedItem = categoriaSeleccionada.Nombre;
                ConfigurarSubcategorias(categoriaSeleccionada.Nombre, productoActual.idSubcategoria);
            }
            else
            {
                MessageBox.Show("La categoría no existe para este producto.");
            }

            if (categoriaSeleccionada != null)
            {
                combobox_categoria_producto.SelectedItem = categoriaSeleccionada.Nombre;
                ConfigurarSubcategorias(categoriaSeleccionada.Nombre, productoActual.idSubcategoria);
            }

            cargandoDatos = false;
        }

        private Image ConvertirBase64AImagen(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (var ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms);
            }
        }

        private void ConfigurarSubcategorias(string categoriaNombre, string idSubcategoria)
        {
            var categoriaData = categoriasDisponibles.FirstOrDefault(c => c.Value.Nombre == categoriaNombre);

            if (categoriaData.Key != null)
            {
                idCategoriaSeleccionada = categoriaData.Key;
                idSubcategoriaSeleccionada = idSubcategoria;

                ActualizarUnidadesMedida(categoriaData.Value.UnidadMedida);

                if (categoriaData.Value.Subcategorias != null && categoriaData.Value.Subcategorias.Count > 0)
                {
                    label_mensaje_no_subcategorias.Visible = false;
                    label_subcategoria_producto.Visible = true;
                    combobox_subcategoria_producto.Visible = true;
                    combobox_categoria_producto.Size = new Size(228, 27);
                    combobox_subcategoria_producto.Items.Clear();

                    combobox_subcategoria_producto.Items.Add("Sin subcategoría");

                    foreach (var subcategoria in categoriaData.Value.Subcategorias)
                    {
                        combobox_subcategoria_producto.Items.Add(subcategoria.Value.Nombre);
                    }

                    if (!string.IsNullOrEmpty(idSubcategoria))
                    {
                        combobox_subcategoria_producto.SelectedItem = categoriaData.Value.Subcategorias
                            .FirstOrDefault(s => s.Key == idSubcategoria).Value?.Nombre;
                    }
                    else
                    {
                        combobox_subcategoria_producto.SelectedIndex = 0;
                    }
                }
                else
                {
                    if (enModoEdicion)
                    {
                        label_mensaje_no_subcategorias.Visible = true;
                    }
                    else
                    {
                        label_mensaje_no_subcategorias.Visible = false;
                    }

                    label_subcategoria_producto.Visible = false;
                    combobox_subcategoria_producto.Visible = false;
                    combobox_categoria_producto.Size = new Size(484, 27);
                }
            }
        }

        private void ActualizarUnidadesMedida(string unidad)
        {
            label_unidad_existencia.Text = unidad;
            label_unidad_minima.Text = unidad;
        }

        private void btn_editar_producto_Click(object sender, EventArgs e)
        {
            HabilitarModoEdicion();
        }

        private void HabilitarModoEdicion()
        {
            InicializarContadorCaracteres();

            textbox_codigo_producto.Enabled = true;
            textbox_descripcion.Enabled = true;
            textbox_costo_producto.Enabled = true;
            textbox_precio_venta.Enabled = true;
            textbox_descuento_producto.Enabled = true;
            textbox_cantidad_existencia.Enabled = true;
            textbox_cantidad_minima.Enabled = true;
            combobox_categoria_producto.Enabled = true;
            combobox_subcategoria_producto.Enabled = true;
            btn_cambiar_imagen.Visible = true;
            btn_guardar_cambios_producto.Visible = true;
            btn_cancelar_producto.Visible = true;
            btn_eliminar_producto.Visible = false;
            btn_editar_producto.Visible = false;
            btn_cerrar_form.Visible = false;
            label_contador_caracteres_codigo.Visible = true;
            label_contador_caracteres_descripcion.Visible = true;

            textbox_costo_producto.Text = productoActual.Costo.ToString("0.##");
            textbox_precio_venta.Text = productoActual.PrecioVenta.ToString("0.##");
            textbox_cantidad_existencia.Text = productoActual.CantidadExistencia.ToString("0.##");
            textbox_cantidad_minima.Text = productoActual.CantidadMinima.ToString("0.##");

            var categoriaSeleccionada = combobox_categoria_producto.SelectedItem?.ToString();
            var categoriaData = categoriasDisponibles.FirstOrDefault(c => c.Value.Nombre == categoriaSeleccionada);

            if (categoriaData.Key != null && categoriaData.Value.Subcategorias.Count == 0)
            {
                label_mensaje_no_subcategorias.Visible = true;
            }

            label_indicacion_imagen.Visible = true;
            enModoEdicion = true;
        }

        private void btn_cancelar_producto_Click(object sender, EventArgs e)
        {
            DeshabilitarModoEdicion();
            CargarDatosProducto();
        }

        private void DeshabilitarModoEdicion()
        {
            textbox_codigo_producto.Enabled = false;
            textbox_descripcion.Enabled = false;
            textbox_costo_producto.Enabled = false;
            textbox_precio_venta.Enabled = false;
            textbox_descuento_producto.Enabled = false;
            textbox_cantidad_existencia.Enabled = false;
            textbox_cantidad_minima.Enabled = false;
            combobox_categoria_producto.Enabled = false;
            combobox_subcategoria_producto.Enabled = false;
            btn_cambiar_imagen.Visible = false;
            btn_guardar_cambios_producto.Visible = false;
            btn_cancelar_producto.Visible = false;
            btn_editar_producto.Visible = true;
            btn_eliminar_producto.Visible = true;
            btn_cerrar_form.Visible = true;
            label_mensaje_no_subcategorias.Visible = false;
            label_indicacion_imagen.Visible = false;
            label_contador_caracteres_codigo.Visible = false;
            label_contador_caracteres_descripcion.Visible = false;
            btn_guardar_cambios_producto.Enabled = false;

            enModoEdicion = false;
        }

        private void btn_cambiar_imagen_Click(object sender, EventArgs e)
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
                    btn_agregar_imagen.BackgroundImage = imagenRedimensionada;
                    btn_agregar_imagen.BackgroundImageLayout = ImageLayout.Stretch;

                    imagenCambiada = true;
                    label_mensaje_error_imagen.Visible = false;
                }
            }

            VerificarCampos();
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

        private void combobox_categoria_producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            var categoriaSeleccionada = combobox_categoria_producto.SelectedItem?.ToString();
            var categoriaData = categoriasDisponibles.FirstOrDefault(c => c.Value.Nombre == categoriaSeleccionada);

            if (categoriaData.Key != null)
            {
                idCategoriaSeleccionada = categoriaData.Key;
                permiteDecimales = categoriaData.Value.AceptaDecimales;
                ConfigurarSubcategorias(categoriaSeleccionada, null);
                ActualizarUnidadesMedida(categoriaData.Value.UnidadMedida);
            }

            VerificarCampos();
        }

        private void combobox_subcategoria_producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string subcategoriaSeleccionada = combobox_subcategoria_producto.SelectedItem?.ToString();
            var categoriaNombre = combobox_categoria_producto.SelectedItem?.ToString();
            var categoriaData = categoriasDisponibles.FirstOrDefault(c => c.Value.Nombre == categoriaNombre);

            if (subcategoriaSeleccionada == "Sin subcategoría")
            {
                idSubcategoriaSeleccionada = null;
            }
            else if (categoriaData.Key != null && !string.IsNullOrEmpty(subcategoriaSeleccionada))
            {
                var subcategoriaData = categoriaData.Value.Subcategorias
                    .FirstOrDefault(s => s.Value.Nombre == subcategoriaSeleccionada).Value;
                idSubcategoriaSeleccionada = subcategoriaData != null
                    ? categoriaData.Value.Subcategorias.FirstOrDefault(s => s.Value.Nombre == subcategoriaSeleccionada).Key
                    : null;
            }
            else
            {
                idSubcategoriaSeleccionada = null;
            }

            VerificarCampos();
        }

        private void VerificarCampos()
        {
            if (cargandoDatos) return;

            decimal.TryParse(string.IsNullOrEmpty(textbox_costo_producto.Text.Trim()) || textbox_costo_producto.Text == "." ? "0" : textbox_costo_producto.Text.Trim(), out decimal costo);
            decimal.TryParse(string.IsNullOrEmpty(textbox_precio_venta.Text.Trim()) || textbox_precio_venta.Text == "." ? "0" : textbox_precio_venta.Text.Trim(), out decimal precioVenta);
            decimal.TryParse(string.IsNullOrEmpty(textbox_cantidad_existencia.Text.Trim()) || textbox_cantidad_existencia.Text == "." ? "0" : textbox_cantidad_existencia.Text.Trim(), out decimal cantidadExistencia);
            decimal.TryParse(string.IsNullOrEmpty(textbox_cantidad_minima.Text.Trim()) || textbox_cantidad_minima.Text == "." ? "0" : textbox_cantidad_minima.Text.Trim(), out decimal cantidadMinima);

            bool codigoModificado = textbox_codigo_producto.Text.Trim() != productoActual.Codigo;
            bool descripcionModificada = textbox_descripcion.Text.Trim() != productoActual.Descripcion;
            bool costoModificado = costo.ToString("N2") != productoActual.Costo.ToString("N2");
            bool precioModificado = precioVenta.ToString("N2") != productoActual.PrecioVenta.ToString("N2");
            bool descuentoModificado = textbox_descuento_producto.Text.Trim() != productoActual.Descuento.ToString();
            bool cantidadExistenciaModificada = cantidadExistencia.ToString("N2") != productoActual.CantidadExistencia.ToString("N2");
            bool cantidadMinimaModificada = cantidadMinima.ToString("N2") != productoActual.CantidadMinima.ToString("N2");
            bool categoriaModificada = idCategoriaSeleccionada != productoActual.idCategoria;
            bool subcategoriaModificada = idSubcategoriaSeleccionada != productoActual.idSubcategoria;

            bool imagenModificada = imagenCambiada && ConvertirImagenABase64(btn_agregar_imagen.BackgroundImage) != productoActual.ImagenBase64;

            bool descuentoValido = !string.IsNullOrWhiteSpace(textbox_descuento_producto.Text);

            bool camposCompletos =
                !string.IsNullOrWhiteSpace(textbox_codigo_producto.Text) &&
                !string.IsNullOrWhiteSpace(textbox_descripcion.Text) &&
                !string.IsNullOrWhiteSpace(textbox_costo_producto.Text) &&
                !string.IsNullOrWhiteSpace(textbox_precio_venta.Text) &&
                !string.IsNullOrWhiteSpace(textbox_cantidad_existencia.Text) &&
                !string.IsNullOrWhiteSpace(textbox_cantidad_minima.Text) &&
                descuentoValido;

            datosModificados = (codigoModificado || descripcionModificada || costoModificado || precioModificado ||
                                descuentoModificado || cantidadExistenciaModificada || cantidadMinimaModificada ||
                                categoriaModificada || subcategoriaModificada || imagenModificada) && camposCompletos;

            btn_guardar_cambios_producto.Enabled = datosModificados;
        }

        private string ConvertirImagenABase64(Image imagen)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return Convert.ToBase64String(ms.ToArray());
            }
        }

        private async void btn_guardar_cambios_producto_Click(object sender, EventArgs e)
        {
            decimal.TryParse(textbox_cantidad_existencia.Text == "." ? "0" : textbox_cantidad_existencia.Text, out decimal cantidadExistencia);
            decimal.TryParse(textbox_cantidad_minima.Text == "." ? "0" : textbox_cantidad_minima.Text, out decimal cantidadMinima);
            decimal.TryParse(textbox_costo_producto.Text == "." ? "0" : textbox_costo_producto.Text, out decimal costo);
            decimal.TryParse(textbox_precio_venta.Text == "." ? "0" : textbox_precio_venta.Text, out decimal precioVenta);

            bool tieneErrores = false;

            bool codigoExiste = await VerificarCodigoExistente(textbox_codigo_producto.Text.Trim());
            if (codigoExiste && textbox_codigo_producto.Text.Trim() != productoActual.Codigo)
            {
                label_mensaje_error_codigo.Visible = true;
                tieneErrores = true;
            }

            bool descripcionExiste = await VerificarDescripcionExistente(textbox_descripcion.Text.Trim());
            if (descripcionExiste && textbox_descripcion.Text.Trim() != productoActual.Descripcion)
            {
                label_mensaje_error_descripcion.Visible = true;
                tieneErrores = true;
            }

            if (!int.TryParse(textbox_descuento_producto.Text.Trim(), out int descuento) || descuento < 0 || descuento > 100)
            {
                label_mensaje_error_descuento.Visible = true;
                tieneErrores = true;
            }

            if (tieneErrores)
            {
                return;
            }

            Producto productoActualizado = new Producto
            {
                Codigo = textbox_codigo_producto.Text.Trim(),
                Descripcion = textbox_descripcion.Text.Trim(),
                idCategoria = idCategoriaSeleccionada,
                idSubcategoria = idSubcategoriaSeleccionada,
                Costo = costo,
                PrecioVenta = precioVenta,
                CantidadExistencia = cantidadExistencia,
                CantidadMinima = cantidadMinima,
                Descuento = descuento,
                ImagenBase64 = btn_agregar_imagen.BackgroundImage != null ? ConvertirImagenABase64(btn_agregar_imagen.BackgroundImage) : productoActual.ImagenBase64
            };

            try
            {
                await firebaseClient.UpdateAsync($"Productos/{sucursalActual}/{productoKey}", productoActualizado);
                MostrarMensajeCentrado("Los cambios se han guardado exitosamente.", true);

                DeshabilitarModoEdicion();

                await RecargarDatosDesdeBaseDeDatos();
                ProductoGuardado?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el producto: " + ex.Message);
            }
        }

        private void MostrarMensajeCentrado(string mensaje, bool esExito)
        {
            mensaje_aviso aviso = new mensaje_aviso();
            Color colorTexto = esExito ? Color.LimeGreen : Color.Red;
            Image imagen = esExito ? aviso.imagelist_aviso.Images[0] : aviso.imagelist_aviso.Images[1];

            aviso.ConfigurarAviso(mensaje, colorTexto, imagen);
            aviso.FormBorderStyle = FormBorderStyle.None;
            aviso.StartPosition = FormStartPosition.CenterParent;
            aviso.ShowInTaskbar = false;
            aviso.ShowDialog(this);
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

        private async void btn_eliminar_producto_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    await firebaseClient.DeleteAsync($"Productos/{sucursalActual}/{productoKey}");
                    mainForm.MostrarMensajeAviso("El producto se ha eliminado exitosamente.", true);
                    this.DialogResult = DialogResult.OK;
                    this.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el producto: " + ex.Message);
                }
            }
        }

        private void btn_cerrar_form_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void textbox_codigo_producto_TextChanged(object sender, EventArgs e)
        {
            if (cargandoDatos) return;

            ActualizarContadorCaracteresCodigo();
            VerificarCampos();

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
            if (cargandoDatos) return;

            ActualizarContadorCaracteresDescripcion();
            VerificarCampos();

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

        private void textbox_costo_producto_TextChanged(object sender, EventArgs e)
        {
            if (!enModoEdicion) return;

            VerificarCampos();
        }

        private void textbox_costo_producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarEntradaNumericaConDecimal(e, textbox_costo_producto);
        }

        private void textbox_precio_venta_TextChanged(object sender, EventArgs e)
        {
            if (!enModoEdicion) return;

            VerificarCampos();
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
            if (!enModoEdicion) return;

            VerificarCampos();
        }

        private void textbox_cantidad_existencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarEntradaNumerica(e, textbox_cantidad_existencia, permiteDecimales);
        }

        private void textbox_cantidad_minima_TextChanged(object sender, EventArgs e)
        {
            if (!enModoEdicion) return;

            VerificarCampos();
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

        private void textbox_descuento_producto_TextChanged(object sender, EventArgs e)
        {
            if (cargandoDatos) return;

            VerificarCampos();

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

        private void label_contador_caracteres_codigo_Click(object sender, EventArgs e)
        {

        }

        private void label_contador_caracteres_descripcion_Click(object sender, EventArgs e)
        {

        }

        private void label_mensaje_error_descuento_Click(object sender, EventArgs e)
        {

        }
    }
}
