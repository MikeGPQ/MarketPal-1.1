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
    public partial class detalles_subcategoria : Form
    {
        private string sucursalActual;
        public string subcategoriaId;
        private string nombreOriginal;
        public string categoriaPadreIdOriginal;
        private seccion_categorias mainForm;
        private IFirebaseClient firebaseClient;
        private Dictionary<string, string> categoriasDisponibles;
        private bool formularioCargado = false;

        public detalles_subcategoria(seccion_categorias mainForm, string sucursal)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            sucursalActual = sucursal;
        }

        public void ConfigurarDatosSubcategoria(string id, string nombre, string categoriaPadreId, Dictionary<string, string> categorias, IFirebaseClient client)
        {
            formularioCargado = false;

            subcategoriaId = id;
            nombreOriginal = nombre.Trim();
            categoriaPadreIdOriginal = categoriaPadreId;
            firebaseClient = client;
            categoriasDisponibles = categorias;

            textbox_nombre_subcategoria.Text = nombreOriginal;
            CargarCategoriasDisponibles();
            ActualizarContadorCaracteres();

            formularioCargado = true;
            textbox_nombre_subcategoria.Enabled = false;
            combobox_categoria_padre.Enabled = false;
            btn_editar_detalles_subcategoria.Visible = false;
            btn_eliminar_subcategoria.Visible = true;
            btn_guardar_detalles_subcategoria.Visible = false;
            btn_cancelar_cambios_subcategoria.Visible = false;
            btn_guardar_detalles_subcategoria.Enabled = false;
        }

        private void CargarCategoriasDisponibles()
        {
            combobox_categoria_padre.Items.Clear();
            foreach (var categoria in categoriasDisponibles)
            {
                combobox_categoria_padre.Items.Add(categoria.Key);
            }
            combobox_categoria_padre.SelectedItem = categoriasDisponibles.FirstOrDefault(x => x.Value == categoriaPadreIdOriginal).Key;
        }

        private void ActualizarContadorCaracteres()
        {
            label_contador_caracteres_nombre_subcategoria.Text = $"{textbox_nombre_subcategoria.Text.Length}/50 caracteres.";
        }

        private void btn_editar_detalles_subcategoria_Click(object sender, EventArgs e)
        {
            ModoEdicion(true);
        }

        private void ModoEdicion(bool habilitar)
        {
            textbox_nombre_subcategoria.Enabled = habilitar;
            combobox_categoria_padre.Enabled = habilitar;
            btn_guardar_detalles_subcategoria.Visible = habilitar;
            btn_cancelar_cambios_subcategoria.Visible = habilitar;
            btn_editar_detalles_subcategoria.Visible = !habilitar;
            btn_eliminar_subcategoria.Visible = !habilitar;
        }

        private void btn_cancelar_cambios_subcategoria_Click(object sender, EventArgs e)
        {
            textbox_nombre_subcategoria.Text = nombreOriginal;
            combobox_categoria_padre.SelectedItem = categoriasDisponibles.FirstOrDefault(x => x.Value == categoriaPadreIdOriginal).Key;
            ModoEdicion(false);
            label_mensaje_error_nombre_subcategoria.Visible = false;
            ActualizarContadorCaracteres();
        }

        private async void btn_guardar_detalles_subcategoria_Click(object sender, EventArgs e)
        {
            string nuevoNombre = textbox_nombre_subcategoria.Text.Trim();
            string nuevaCategoriaPadre = combobox_categoria_padre.SelectedItem.ToString();

            if (await NombreEsUnico(nuevoNombre, nuevaCategoriaPadre))
            {
                var subcategoriaActualizada = new Subcategoria(nuevoNombre);
                await firebaseClient.UpdateAsync($"/Categorias/{sucursalActual}/{categoriasDisponibles[nuevaCategoriaPadre]}/Subcategorias/{subcategoriaId}", subcategoriaActualizada);

                if (categoriaPadreIdOriginal != categoriasDisponibles[nuevaCategoriaPadre])
                {
                    await firebaseClient.DeleteAsync($"/Categorias/{sucursalActual}/{categoriaPadreIdOriginal}/Subcategorias/{subcategoriaId}");
                }

                mainForm.MostrarMensajeAviso("Los cambios se han guardado exitosamente.", true);

                nombreOriginal = nuevoNombre;
                categoriaPadreIdOriginal = categoriasDisponibles[nuevaCategoriaPadre];

                mainForm.CargarCategoriasEnTreeView();

                ModoEdicion(false);
            }
            else
            {
                label_mensaje_error_nombre_subcategoria.Visible = true;
            }
        }

        private async Task<bool> NombreEsUnico(string nombre, string categoriaPadreId)
        {
            if (string.IsNullOrWhiteSpace(nombre) || (nombre.Equals(nombreOriginal, StringComparison.OrdinalIgnoreCase) && categoriaPadreId == categoriaPadreIdOriginal))
            {
                return true;
            }

            FirebaseResponse response = await firebaseClient.GetAsync($"/Categorias/{sucursalActual}/{categoriasDisponibles[categoriaPadreId]}/Subcategorias");
            Dictionary<string, Subcategoria> subcategorias = response.ResultAs<Dictionary<string, Subcategoria>>();

            return subcategorias == null || !subcategorias.Values.Any(s => s.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase) && s.Nombre != nombreOriginal);
        }

        private void textbox_nombre_subcategoria_TextChanged(object sender, EventArgs e)
        {
            if (!formularioCargado) return;

            string nombreActual = textbox_nombre_subcategoria.Text.Trim();
            ActualizarContadorCaracteres();

            bool cambiosDetectados = (!nombreActual.Equals(nombreOriginal, StringComparison.OrdinalIgnoreCase) ||
                                      combobox_categoria_padre.SelectedItem.ToString() != categoriasDisponibles.FirstOrDefault(x => x.Value == categoriaPadreIdOriginal).Key)
                                      && nombreActual.Length > 0;

            btn_guardar_detalles_subcategoria.Enabled = cambiosDetectados;

            if (label_mensaje_error_nombre_subcategoria.Visible)
            {
                label_mensaje_error_nombre_subcategoria.Visible = false;
            }
        }

        private void textbox_nombre_subcategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void combobox_categoria_padre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!formularioCargado) return;

            string nombreActual = textbox_nombre_subcategoria.Text.Trim();

            bool cambiosDetectados = (!nombreActual.Equals(nombreOriginal, StringComparison.OrdinalIgnoreCase) ||
                                      combobox_categoria_padre.SelectedItem.ToString() != categoriasDisponibles.FirstOrDefault(x => x.Value == categoriaPadreIdOriginal).Key)
                                      && nombreActual.Length > 0;

            btn_guardar_detalles_subcategoria.Enabled = cambiosDetectados;
        }

        private async void btn_eliminar_subcategoria_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar esta subcategoría?",
                                                "Confirmar eliminación",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    FirebaseResponse response = await firebaseClient.GetAsync($"/Productos/{sucursalActual}");
                    Dictionary<string, Producto> productos = response.ResultAs<Dictionary<string, Producto>>();

                    if (productos != null && productos.Values.Any(p => p.idCategoria == categoriaPadreIdOriginal && p.idSubcategoria == subcategoriaId))
                    {
                        var result = MessageBox.Show(
                            "Existen productos asociados a esta subcategoría. Debe cambiar la subcategoría de los productos antes de poder eliminarla. " +
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
                                    new seccion_productos(sucursalActual, categoriaPadreIdOriginal, subcategoriaId, gestionInventario.rolUsuario),
                                    gestionInventario.btn_productos
                                );
                            }
                        }
                    }
                    else
                    {
                        await firebaseClient.DeleteAsync($"/Categorias/{sucursalActual}/{categoriaPadreIdOriginal}/Subcategorias/{subcategoriaId}");
                        mainForm.CargarCategoriasEnTreeView();
                        mainForm.CargarFormularioEnPanel(new aviso_seleccion_categoria_subcategoria());
                        mainForm.MostrarMensajeAviso("La subcategoría se ha eliminado exitosamente.", true);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la subcategoría: " + ex.Message);
                }
            }
        }

        private void detalles_subcategoria_Load(object sender, EventArgs e)
        {

        }

        private void label_detalles_subcategoria_Click(object sender, EventArgs e)
        {

        }

        private void label_nombre_subcategoria_Click(object sender, EventArgs e)
        {

        }

        private void label_contador_caracteres_nombre_subcategoria_Click(object sender, EventArgs e)
        {

        }

        private void label_categoria_padre_Click(object sender, EventArgs e)
        {

        }

        private void label_mensaje_error_nombre_subcategoria_Click(object sender, EventArgs e)
        {

        }
    }
}
