using FireSharp.Interfaces;
using FireSharp.Response;
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
    public partial class detalles_categoria : Form
    {
        private string sucursalActual;
        public string categoriaId;
        private string nombreOriginal;
        private string unidadOriginal;
        private Dictionary<string, (string abreviatura, bool aceptaDecimales)> unidadesDeMedida;
        private bool formularioCargado = false;
        private seccion_categorias mainForm;
        private IFirebaseClient firebaseClient;

        public detalles_categoria(seccion_categorias mainForm, string sucursal)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            sucursalActual = sucursal;
        }

        private void detalles_categoria_Load(object sender, EventArgs e)
        {

        }

        public async void ConfigurarDatosCategoria(string id, string nombre, string unidad, Dictionary<string, (string abreviatura, bool aceptaDecimales)> unidades, IFirebaseClient client)
        {
            formularioCargado = false;

            categoriaId = id;
            nombreOriginal = nombre.Trim();
            unidadOriginal = unidad;
            unidadesDeMedida = unidades;
            firebaseClient = client;

            await VerificarRestriccionesEdicion();

            textbox_nombre_categoria.Text = nombreOriginal;
            CargarUnidadesDeMedida();
            ActualizarContadorCaracteres();

            formularioCargado = true;
            textbox_nombre_categoria.Enabled = false;
            combobox_unidad_medida.Enabled = false;
            btn_eliminar_categoria.Visible = true;
            btn_cancelar_cambios_categoria.Visible = false;
            btn_guardar_detalles_categoria.Visible = false;
            btn_guardar_detalles_categoria.Enabled = false;
        }

        private void CargarUnidadesDeMedida()
        {
            combobox_unidad_medida.Items.Clear();
            foreach (var unidad in unidadesDeMedida.Keys)
            {
                combobox_unidad_medida.Items.Add(unidad);
            }

            if (!string.IsNullOrEmpty(unidadOriginal))
            {
                string unidadCompleta = unidadesDeMedida.FirstOrDefault(x => x.Value.abreviatura == unidadOriginal).Key;
                if (!string.IsNullOrEmpty(unidadCompleta))
                {
                    combobox_unidad_medida.SelectedItem = unidadCompleta;
                }
            }
        }

        private async Task VerificarRestriccionesEdicion()
        {
            int subcategorias = await ContarSubcategorias();
            label_numero_subcategorias.Text = $"Número de subcategorías asociadas: {subcategorias}";

            bool tieneSubcategorias = subcategorias > 0;
            bool tieneProductosConCategoria = false;

            try
            {
                FirebaseResponse responseProductos = await firebaseClient.GetAsync($"/Productos/{sucursalActual}");
                Dictionary<string, Producto> productos = responseProductos.ResultAs<Dictionary<string, Producto>>();

                if (productos != null)
                {
                    tieneProductosConCategoria = productos.Values.Any(p => p.idCategoria == categoriaId);
                }
            }
            catch (Exception ex)
            {

            }

            if (tieneSubcategorias || tieneProductosConCategoria)
            {
                btn_editar_detalles_categoria.Visible = false;
            }
            else
            {
                btn_editar_detalles_categoria.Visible = true;
            }
        }

        private async Task<int> ContarSubcategorias()
        {
            FirebaseResponse response = await firebaseClient.GetAsync($"/Categorias/{sucursalActual}/{categoriaId}/Subcategorias");
            Dictionary<string, object> subcategorias = response.ResultAs<Dictionary<string, object>>();
            return subcategorias?.Count ?? 0;
        }

        private void ActualizarContadorCaracteres()
        {
            label_contador_caracteres_nombre_categoria.Text = $"{textbox_nombre_categoria.Text.Length}/50 caracteres.";
        }

        private void btn_editar_detalles_categoria_Click(object sender, EventArgs e)
        {
            ModoEdicion(true);
        }

        private void ModoEdicion(bool habilitar)
        {
            textbox_nombre_categoria.Enabled = habilitar;
            combobox_unidad_medida.Enabled = habilitar;
            btn_guardar_detalles_categoria.Visible = habilitar;
            btn_cancelar_cambios_categoria.Visible = habilitar;
            btn_editar_detalles_categoria.Visible = !habilitar;
            btn_eliminar_categoria.Visible = !habilitar;
        }

        private void btn_cancelar_cambios_categoria_Click(object sender, EventArgs e)
        {
            textbox_nombre_categoria.Text = nombreOriginal;
            combobox_unidad_medida.SelectedItem = unidadesDeMedida.FirstOrDefault(x => x.Value.abreviatura == unidadOriginal).Key;
            ModoEdicion(false);
            label_mensaje_error_nombre_categoria.Visible = false;
            ActualizarContadorCaracteres();
        }

        private async void btn_guardar_detalles_categoria_Click(object sender, EventArgs e)
        {
            string nuevoNombre = textbox_nombre_categoria.Text.Trim();
            string nuevaUnidad = combobox_unidad_medida.SelectedItem.ToString();

            if (await NombreEsUnico(nuevoNombre))
            {
                try
                {
                    FirebaseResponse subcategoriasResponse = await firebaseClient.GetAsync($"/Categorias/{sucursalActual}/{categoriaId}/Subcategorias");
                    Dictionary<string, Subcategoria> subcategoriasActuales = subcategoriasResponse.ResultAs<Dictionary<string, Subcategoria>>();

                    var categoriaActualizada = new Categoria(nuevoNombre, unidadesDeMedida[nuevaUnidad].abreviatura, unidadesDeMedida[nuevaUnidad].aceptaDecimales)
                    {
                        Subcategorias = subcategoriasActuales ?? new Dictionary<string, Subcategoria>()
                    };

                    await firebaseClient.UpdateAsync($"/Categorias/{sucursalActual}/{categoriaId}", categoriaActualizada);

                    mainForm.MostrarMensajeAviso("Los cambios se han guardado exitosamente.", true);
                    nombreOriginal = nuevoNombre;
                    unidadOriginal = unidadesDeMedida[nuevaUnidad].abreviatura;
                    mainForm.CargarCategoriasEnTreeView();

                    ModoEdicion(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar los detalles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                label_mensaje_error_nombre_categoria.Visible = true;
            }
        }

        private async Task<bool> NombreEsUnico(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre) || nombre.Equals(nombreOriginal, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            FirebaseResponse response = await firebaseClient.GetAsync($"/Categorias/{sucursalActual}");
            Dictionary<string, Categoria> categorias = response.ResultAs<Dictionary<string, Categoria>>();

            return categorias == null || !categorias.Values.Any(c => c.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase) && c.Nombre != nombreOriginal);
        }

        private void textbox_nombre_categoria_TextChanged(object sender, EventArgs e)
        {
            if (!formularioCargado) return;

            string nombreActual = textbox_nombre_categoria.Text.Trim();
            ActualizarContadorCaracteres();

            bool cambiosDetectados = (!nombreActual.Equals(nombreOriginal, StringComparison.OrdinalIgnoreCase) ||
                                      combobox_unidad_medida.SelectedItem.ToString() != unidadesDeMedida.FirstOrDefault(x => x.Value.abreviatura == unidadOriginal).Key)
                                      && nombreActual.Length > 0;

            btn_guardar_detalles_categoria.Enabled = cambiosDetectados;

            if (label_mensaje_error_nombre_categoria.Visible)
            {
                label_mensaje_error_nombre_categoria.Visible = false;
            }
        }

        private void textbox_nombre_categoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void combobox_unidad_medida_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!formularioCargado) return;

            string nombreActual = textbox_nombre_categoria.Text.Trim();

            bool cambiosDetectados = (!nombreActual.Equals(nombreOriginal, StringComparison.OrdinalIgnoreCase) ||
                                      combobox_unidad_medida.SelectedItem.ToString() != unidadesDeMedida.FirstOrDefault(x => x.Value.abreviatura == unidadOriginal).Key)
                                      && nombreActual.Length > 0;

            btn_guardar_detalles_categoria.Enabled = cambiosDetectados;
        }

        private async void btn_eliminar_categoria_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar esta categoría?",
                                                "Confirmar eliminación",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    FirebaseResponse response = await firebaseClient.GetAsync($"/Productos/{sucursalActual}");
                    Dictionary<string, Producto> productos = response.ResultAs<Dictionary<string, Producto>>();

                    if (productos != null && productos.Values.Any(p => p.idCategoria == categoriaId))
                    {
                        var result = MessageBox.Show(
                            "Existen productos asociados a esta categoría. Debe cambiar la categoría de los productos antes de poder eliminarla. " +
                            "¿Desea continuar para modificar los productos asociados?",
                            "Productos asociados",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            var gestionInventario = (seccion_gestion_inventario)Application.OpenForms["seccion_gestion_inventario"];
                            if (gestionInventario != null)
                            {
                                gestionInventario.MostrarFormularioEnPanel(
                                    new seccion_productos(sucursalActual, categoriaId, null, gestionInventario.rolUsuario),
                                    gestionInventario.btn_productos
                                );
                            }
                        }
                    }
                    else
                    {
                        await firebaseClient.DeleteAsync($"/Categorias/{sucursalActual}/{categoriaId}");
                        mainForm.CargarCategoriasEnTreeView();
                        mainForm.CargarFormularioEnPanel(new aviso_seleccion_categoria_subcategoria());
                        mainForm.MostrarMensajeAviso("La categoría se ha eliminado exitosamente.", true);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la categoría: " + ex.Message);
                }
            }
        }

        private void label_detalles_categoria_Click(object sender, EventArgs e)
        {

        }

        private void label_nombre_categoria_Click(object sender, EventArgs e)
        {

        }

        private void label_contador_caracteres_nombre_categoria_Click(object sender, EventArgs e)
        {

        }

        private void label_unidad_medida_categoria_Click(object sender, EventArgs e)
        {

        }

        private void label_mensaje_error_nombre_categoria_Click(object sender, EventArgs e)
        {

        }

        private void label_numero_subcategorias_Click(object sender, EventArgs e)
        {

        }
    }
}
