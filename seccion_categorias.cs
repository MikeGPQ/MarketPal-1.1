using FireSharp.Config;
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
    public partial class seccion_categorias : Form
    {
        private string sucursalActual;
        private Dictionary<string, (string abreviatura, bool aceptaDecimales)> unidadesDeMedida = new Dictionary<string, (string, bool)>
        {
            { "Unidades (uds.)", ("uds.", false) },
            { "Kilogramos (kg)", ("kg", true) }
        };
        private IFirebaseClient firebaseClient;
        private bool creandoSubcategoria = false;
        private botones_categoria botonesFlotantes;
        private boton_subcategoria botonEliminarSubcategoria;
        private botones_creacion_subcategorias botonesConfirmacion;
        private TreeNode nodoActual;
        private TreeNode nodoPadreTemporal;
        private TextBox textBoxNombreSubcategoria;
        private CancellationTokenSource mensajeTokenSource;

        public seccion_categorias(string sucursal)
        {
            InitializeComponent();
            InicializarBotonesFlotantes();
            InicializarBotonesConfirmacion();
            InicializarBotonEliminarSubcategoria();

            this.LocationChanged += ActualizarPosicionBotonesConfirmacion;
            this.SizeChanged += ActualizarPosicionBotonesConfirmacion;

            sucursalActual = sucursal;
        }

        private void ActualizarPosicionBotonesConfirmacion(object sender, EventArgs e)
        {
            if (botonesConfirmacion != null && botonesConfirmacion.Visible)
            {
                Point posicionTextBox = textBoxNombreSubcategoria.Location;
                Point posicionBotones = new Point(
                    posicionTextBox.X + textBoxNombreSubcategoria.Width + 5,
                    posicionTextBox.Y
                );

                botonesConfirmacion.Location = treeview_arbol_categorias.PointToScreen(posicionBotones);
            }
        }

        public void ActivarScroll()
        {
            treeview_arbol_categorias.Scrollable = true;
        }

        private void InicializarBotonesFlotantes()
        {
            botonesFlotantes = new botones_categoria
            {
                Owner = this
            };
        }


        private void InicializarBotonEliminarSubcategoria()
        {
            botonEliminarSubcategoria = new boton_subcategoria
            {
                Owner = this,
            };
        }

        public void DetenerTimerOcultarBotones()
        {
            timer_ocultar_botones.Stop();
        }

        public void IniciarTimerOcultarBotones()
        {
            if (!timer_ocultar_botones.Enabled)
            {
                timer_ocultar_botones.Start();
            }
        }

        public void agregar_categoria()
        {
            if (!creandoSubcategoria)
            {
                if (nodoActual != null)
                {
                    nodoPadreTemporal = nodoActual;
                    CrearNodoTemporalParaSubcategoria(nodoPadreTemporal);
                }
                else
                {
                    MostrarMensajeAviso("Por favor, seleccione una categoría para agregar una subcategoría.", false);
                }
            }
            else if (creandoSubcategoria && nodoPadreTemporal == nodoActual)
            {
                CancelarCreacionSubcategoria();
                CrearNodoTemporalParaSubcategoria(nodoPadreTemporal);
            }
            else if (creandoSubcategoria && nodoPadreTemporal != nodoActual)
            {
                CancelarCreacionSubcategoria();
                nodoPadreTemporal = nodoActual;
                CrearNodoTemporalParaSubcategoria(nodoPadreTemporal);
            }
        }

        private void CancelarModoEdicionSiEstaActivo()
        {
            if (creandoSubcategoria)
            {
                CancelarCreacionSubcategoria();
            }
        }

        public async void eliminar_categoria()
        {
            CancelarModoEdicionSiEstaActivo();

            if (nodoActual != null)
            {
                DialogResult confirmResult = MessageBox.Show(
                    $"¿Está seguro de que desea eliminar la categoría '{nodoActual.Text}' y todas sus subcategorías?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    string categoriaId = nodoActual.Tag is object[] tagArray ? tagArray[0].ToString() : null;

                    if (!string.IsNullOrEmpty(categoriaId))
                    {
                        FirebaseResponse response = await firebaseClient.GetAsync($"/Productos/{sucursalActual}");
                        Dictionary<string, Producto> productos = response.ResultAs<Dictionary<string, Producto>>();

                        if (productos != null && productos.Values.Any(p => p.idCategoria == categoriaId))
                        {
                            DialogResult result = MessageBox.Show(
                                "Existen productos asociados a esta categoría. " +
                                "Debe cambiar la categoría de estos productos antes de poder eliminarla. " +
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
                            else
                            {
                                treeview_arbol_categorias.Scrollable = true;
                                treeview_arbol_categorias.ExpandAll();
                            }
                        }
                        else
                        {
                            try
                            {
                                await firebaseClient.DeleteAsync($"/Categorias/{sucursalActual}/{categoriaId}");
                                CargarCategoriasEnTreeView();
                                treeview_arbol_categorias.SelectedNode = null;
                                CargarFormularioEnPanel(new aviso_seleccion_categoria_subcategoria());
                                MostrarMensajeAviso("La categoría se ha eliminado exitosamente.", true);

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error al eliminar la categoría: " + ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    treeview_arbol_categorias.Scrollable = true;
                    treeview_arbol_categorias.ExpandAll();
                }
            }
        }

        public async void eliminar_subcategoria()
        {
            CancelarModoEdicionSiEstaActivo();

            if (nodoActual != null)
            {
                TreeNode parentNode = nodoActual.Parent;
                string categoriaNombre = parentNode.Text;

                DialogResult confirmResult = MessageBox.Show(
                    $"¿Está seguro de que desea eliminar la subcategoría '{nodoActual.Text}' de la categoría '{categoriaNombre}'?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    string categoriaId = parentNode.Tag is object[] tagArrayParent ? tagArrayParent[0].ToString() : null;
                    string subcategoriaId = nodoActual.Tag is object[] tagArray ? tagArray[0].ToString() : null;

                    if (!string.IsNullOrEmpty(categoriaId) && !string.IsNullOrEmpty(subcategoriaId))
                    {
                        FirebaseResponse response = await firebaseClient.GetAsync($"/Productos/{sucursalActual}");
                        Dictionary<string, Producto> productos = response.ResultAs<Dictionary<string, Producto>>();

                        if (productos != null && productos.Values.Any(p => p.idCategoria == categoriaId && p.idSubcategoria == subcategoriaId))
                        {
                            DialogResult result = MessageBox.Show(
                                "Existen productos asociados a esta subcategoría. " +
                                "Debe cambiar la subcategoría de estos productos antes de poder eliminarla. " +
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
                                        new seccion_productos(sucursalActual, categoriaId, subcategoriaId, gestionInventario.rolUsuario),
                                        gestionInventario.btn_productos
                                    );
                                }
                            }
                            else
                            {
                                treeview_arbol_categorias.Scrollable = true;
                                treeview_arbol_categorias.ExpandAll();
                            }
                        }
                        else
                        {
                            try
                            {
                                await firebaseClient.DeleteAsync($"/Categorias/{sucursalActual}/{categoriaId}/Subcategorias/{subcategoriaId}");
                                CargarCategoriasEnTreeView();
                                treeview_arbol_categorias.SelectedNode = null;
                                CargarFormularioEnPanel(new aviso_seleccion_categoria_subcategoria());
                                MostrarMensajeAviso("La subcategoría se ha eliminado exitosamente.", true);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error al eliminar la subcategoría: " + ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    treeview_arbol_categorias.Scrollable = true;
                    treeview_arbol_categorias.ExpandAll();
                }
            }
        }

        private void CrearNodoTemporalParaSubcategoria(TreeNode parentNode)
        {
            foreach (TreeNode node in treeview_arbol_categorias.Nodes)
            {
                if (node != parentNode)
                {
                    node.Collapse();
                }
            }

            treeview_arbol_categorias.Scrollable = false;

            TreeNode nodoTemporal = new TreeNode("Escribe el nombre aquí")
            {
                ImageIndex = 1,
                SelectedImageIndex = 1
            };
            parentNode.Nodes.Insert(0, nodoTemporal);
            parentNode.Expand();

            if (textBoxNombreSubcategoria == null)
            {
                textBoxNombreSubcategoria = new TextBox
                {
                    MaxLength = 50,
                    ForeColor = SystemColors.GrayText,
                };

                textBoxNombreSubcategoria.KeyPress += TextBoxNombreSubcategoria_KeyPress;
                textBoxNombreSubcategoria.TextChanged += TextBoxNombreSubcategoria_TextChanged;

                treeview_arbol_categorias.Controls.Add(textBoxNombreSubcategoria);
            }

            Rectangle nodoRect = treeview_arbol_categorias.RectangleToScreen(nodoTemporal.Bounds);
            Point posicionTextBox = treeview_arbol_categorias.PointToClient(nodoRect.Location);
            textBoxNombreSubcategoria.SetBounds(posicionTextBox.X, posicionTextBox.Y, nodoTemporal.Bounds.Width, nodoTemporal.Bounds.Height);
            textBoxNombreSubcategoria.Visible = true;
            textBoxNombreSubcategoria.Focus();

            botonesFlotantes.Hide();
            botonEliminarSubcategoria.Hide();

            Point posicionBotones = new Point(
                posicionTextBox.X + textBoxNombreSubcategoria.Width + 5,
                posicionTextBox.Y
            );

            botonesConfirmacion.Location = treeview_arbol_categorias.PointToScreen(posicionBotones);
            botonesConfirmacion.Show();

            treeview_arbol_categorias.SelectedNode = null;
            CargarFormularioEnPanel(new aviso_seleccion_categoria_subcategoria());

            creandoSubcategoria = true;
        }

        private void TextBoxNombreSubcategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void TextBoxNombreSubcategoria_TextChanged(object sender, EventArgs e)
        {
            string texto = textBoxNombreSubcategoria.Text.Trim();
            botonesConfirmacion.btn_confirmar_creacion_subcategoria.Enabled = texto.Length > 0;
        }

        private void InicializarBotonesConfirmacion()
        {
            botonesConfirmacion = new botones_creacion_subcategorias
            {
                Owner = this,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None,
                ShowInTaskbar = false
            };
        }

        private void treeview_arbol_categorias_MouseMove(object sender, MouseEventArgs e)
        {
            TreeNode nodo = treeview_arbol_categorias.GetNodeAt(e.Location);

            if (nodo == null || nodo == nodoActual)
            {
                return;
            }

            nodoActual = nodo;

            if (creandoSubcategoria && nodo.Text == "Escribe el nombre aquí")
            {
                botonesFlotantes.Hide();
                botonEliminarSubcategoria.Hide();
                return;
            }

            MostrarBotonesParaNodo(nodo);
        }

        private void MostrarBotonesParaNodo(TreeNode nodo)
        {
            Point posicionNodo = treeview_arbol_categorias.PointToScreen(nodo.Bounds.Location);

            if (nodo.Parent == null)
            {
                botonesFlotantes.Location = new Point(posicionNodo.X + nodo.Bounds.Width - 3, posicionNodo.Y);
                botonesFlotantes.Show();
                botonEliminarSubcategoria.Hide();
            }
            else
            {
                botonEliminarSubcategoria.Location = new Point(posicionNodo.X + nodo.Bounds.Width - 3, posicionNodo.Y);
                botonEliminarSubcategoria.Show();
                botonesFlotantes.Hide();
            }

            this.Focus();
        }

        private void treeview_arbol_categorias_MouseLeave(object sender, EventArgs e)
        {

        }

        private void timer_ocultar_botones_Tick(object sender, EventArgs e)
        {
            if (botonesFlotantes.Visible)
            {
                botonesFlotantes.Hide();
            }

            if (botonEliminarSubcategoria.Visible)
            {
                botonEliminarSubcategoria.Hide();
            }

            DetenerTimerOcultarBotones();
        }

        public void ConfirmarCreacionSubcategoria()
        {
            string nombreSubcategoria = textBoxNombreSubcategoria.Text.Trim();

            if (SubcategoriaExiste(nombreSubcategoria))
            {
                MostrarMensajeAviso("El nombre ingresado ya está en uso dentro de esta categoría.", false);
                return;
            }

            GuardarSubcategoriaEnFirebase(nodoPadreTemporal, nombreSubcategoria);

            treeview_arbol_categorias.SelectedNode = null;
            CargarFormularioEnPanel(new aviso_seleccion_categoria_subcategoria());
        }

        public void MostrarMensajeAviso(string mensaje, bool esExito)
        {
            mensajeTokenSource?.Cancel();
            mensajeTokenSource = new CancellationTokenSource();

            mensaje_aviso aviso = new mensaje_aviso();

            Color colorTexto = esExito ? Color.LimeGreen : Color.Red;
            Image imagen = esExito ? aviso.imagelist_aviso.Images[0] : aviso.imagelist_aviso.Images[1];

            aviso.TopLevel = false;
            aviso.Dock = DockStyle.Fill;
            aviso.ConfigurarAviso(mensaje, colorTexto, imagen);

            panel_mensaje_aviso.Controls.Clear();
            panel_mensaje_aviso.Controls.Add(aviso);
            panel_mensaje_aviso.Visible = true;

            aviso.Show();

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
                        catch (Exception ex) { }
                    }
                });
            }
            catch (Exception ex)
            {

            }
        }

        public void CancelarCreacionSubcategoria()
        {
            creandoSubcategoria = false;
            textBoxNombreSubcategoria.Clear();
            textBoxNombreSubcategoria.Visible = false;
            botonesConfirmacion.Hide();

            if (nodoPadreTemporal.FirstNode?.Text == "Escribe el nombre aquí")
            {
                nodoPadreTemporal.Nodes.Remove(nodoPadreTemporal.FirstNode);
            }
        }

        private bool SubcategoriaExiste(string nombreSubcategoria)
        {
            foreach (TreeNode subNode in nodoPadreTemporal.Nodes)
            {
                if (subNode.Tag is object[] tagArray && tagArray.Length > 1)
                {
                    string nombreExistente = tagArray[1].ToString();
                    if (nombreExistente.Equals(nombreSubcategoria, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private async void GuardarSubcategoriaEnFirebase(TreeNode parentNode, string nombreSubcategoria)
        {
            try
            {
                string categoriaId = parentNode.Tag is object[] tagArray ? tagArray[0].ToString() : null;
                if (categoriaId == null)
                {
                    MostrarMensajeAviso("Error: Categoría no encontrada.", false);
                    return;
                }

                FirebaseResponse response = await firebaseClient.GetAsync($"/Categorias/{sucursalActual}/{categoriaId}/Subcategorias");
                Dictionary<string, Subcategoria> subcategorias = response.ResultAs<Dictionary<string, Subcategoria>>() ?? new Dictionary<string, Subcategoria>();

                int maxId = subcategorias.Keys
                    .Where(key => key.StartsWith("SUBCAT"))
                    .Select(key => int.Parse(key.Substring(6)))
                    .DefaultIfEmpty(0)
                    .Max();

                string nuevoId = $"SUBCAT{maxId + 1}";
                subcategorias[nuevoId] = new Subcategoria(nombreSubcategoria);

                await firebaseClient.SetAsync($"/Categorias/{sucursalActual}/{categoriaId}/Subcategorias", subcategorias);

                CargarCategoriasEnTreeView();
                creandoSubcategoria = false;
                MostrarMensajeAviso("La subcategoría se ha creado exitosamente.", true);
                textBoxNombreSubcategoria.Clear();
                textBoxNombreSubcategoria.Visible = false;
                botonesConfirmacion.Hide();
            }
            catch (Exception ex)
            {
                MostrarMensajeAviso("Error al guardar la subcategoría.", false);
            }
        }

        private void ConfigurarFirebase()
        {
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "lvGHgu8Z3EYxWpBbAI8n8rCBWVncprXedJlfzfht",
                BasePath = "https://prueba-575f7-default-rtdb.firebaseio.com/"
            };

            firebaseClient = new FireSharp.FirebaseClient(config);

            if (firebaseClient == null)
            {
                MessageBox.Show("No se pudo conectar a Firebase.");
            }
        }

        private void seccion_categorias_Load(object sender, EventArgs e)
        {
            ConfigurarFirebase();
            CargarUnidadesDeMedida();
            CargarCategoriasEnTreeView();
            ActualizarContadorCaracteres();
            CargarFormularioEnPanel(new aviso_seleccion_categoria_subcategoria());
        }

        private void CargarUnidadesDeMedida()
        {
            foreach (var unidad in unidadesDeMedida.Keys)
            {
                combobox_unidad_medida.Items.Add(unidad);
            }

            if (combobox_unidad_medida.Items.Count > 0)
            {
                combobox_unidad_medida.SelectedIndex = 0;
            }
        }

        public async void CargarCategoriasEnTreeView()
        {
            try
            {
                CancelarModoEdicionSiEstaActivo();

                FirebaseResponse response = await firebaseClient.GetAsync($"/Categorias/{sucursalActual}");
                Dictionary<string, Categoria> categorias = response.ResultAs<Dictionary<string, Categoria>>();

                treeview_arbol_categorias.Nodes.Clear();

                if (categorias != null && categorias.Count > 0)
                {
                    label_aviso_categorias.Visible = false;

                    int categoriaIndex = 1;
                    foreach (var categoria in categorias)
                    {
                        string nombreConNumeracion = $"{categoriaIndex}. {categoria.Value.Nombre}";

                        TreeNode categoriaNode = new TreeNode(nombreConNumeracion)
                        {
                            ImageIndex = 0,
                            SelectedImageIndex = 0,
                            Tag = new object[] { categoria.Key, categoria.Value.Nombre, categoria.Value.UnidadMedida }
                        };

                        if (categoria.Value.Subcategorias != null)
                        {
                            int subcategoriaIndex = 1;
                            foreach (var subcategoria in categoria.Value.Subcategorias)
                            {
                                string nombreSubcategoriaConNumeracion = $"{categoriaIndex}.{subcategoriaIndex}. {subcategoria.Value.Nombre}";

                                TreeNode subcategoriaNode = new TreeNode(nombreSubcategoriaConNumeracion)
                                {
                                    ImageIndex = 1,
                                    SelectedImageIndex = 1,
                                    Tag = new object[] { subcategoria.Key, subcategoria.Value.Nombre }
                                };

                                categoriaNode.Nodes.Add(subcategoriaNode);
                                subcategoriaIndex++;
                            }
                        }

                        treeview_arbol_categorias.Nodes.Add(categoriaNode);
                        categoriaIndex++;
                    }
                }
                else
                {
                    label_aviso_categorias.Text = "No hay categorías disponibles.";
                    label_aviso_categorias.Visible = true;
                }

                treeview_arbol_categorias.Scrollable = true;
                treeview_arbol_categorias.ExpandAll();

                if (treeview_arbol_categorias.Nodes.Count > 0)
                {
                    treeview_arbol_categorias.SelectedNode = null;
                    treeview_arbol_categorias.TopNode = treeview_arbol_categorias.Nodes[0];
                }

                if (panel_detalles_categoria.Controls[0] is detalles_categoria detallesCategoriaForm)
                {
                    TreeNode categoriaNode = treeview_arbol_categorias.Nodes
                        .Cast<TreeNode>()
                        .FirstOrDefault(n => n.Tag is object[] tagArray && tagArray[0].ToString() == detallesCategoriaForm.categoriaId);

                    if (categoriaNode != null && categoriaNode.Tag is object[] tagArray)
                    {
                        string categoriaId = tagArray[0].ToString();
                        string nombreCategoria = tagArray[1].ToString();
                        string unidadCategoria = tagArray.Length > 2 ? tagArray[2].ToString() : string.Empty;

                        detallesCategoriaForm.ConfigurarDatosCategoria(categoriaId, nombreCategoria, unidadCategoria, unidadesDeMedida, firebaseClient);
                    }
                }
                else if (panel_detalles_categoria.Controls[0] is detalles_subcategoria detallesSubcategoriaForm)
                {
                    TreeNode subcategoriaNode = treeview_arbol_categorias.Nodes
                        .Cast<TreeNode>()
                        .SelectMany(n => n.Nodes.Cast<TreeNode>())
                        .FirstOrDefault(n => n.Tag is object[] tagArray && tagArray[0].ToString() == detallesSubcategoriaForm.subcategoriaId);

                    if (subcategoriaNode != null && subcategoriaNode.Tag is object[] tagArray)
                    {
                        string subcategoriaId = tagArray[0].ToString();
                        string nombreSubcategoria = tagArray[1].ToString();
                        string categoriaPadreId = subcategoriaNode.Parent.Tag is object[] parentTagArray ? parentTagArray[0].ToString() : null;

                        detallesSubcategoriaForm.ConfigurarDatosSubcategoria(subcategoriaId, nombreSubcategoria, categoriaPadreId, ObtenerCategoriasDisponibles(), firebaseClient);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void CargarFormularioEnPanel(Form form)
        {
            panel_detalles_categoria.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel_detalles_categoria.Controls.Add(form);
            form.Show();
        }

        private void textbox_nombre_categoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textbox_nombre_categoria_TextChanged(object sender, EventArgs e)
        {
            ActualizarContadorCaracteres();

            string nombreCategoria = textbox_nombre_categoria.Text.Trim();
            btn_crear_categoria.Enabled = nombreCategoria.Length > 0 && combobox_unidad_medida.SelectedIndex >= 0;

            if (label_mensaje_error_nombre_categoria.Visible)
            {
                label_mensaje_error_nombre_categoria.Visible = false;
            }
        }

        private void ActualizarContadorCaracteres()
        {
            int caracteres = textbox_nombre_categoria.Text.Length;
            label_contador_caracteres_nombre_categoria.Text = $"{caracteres}/50 caracteres.";
        }

        private async void btn_crear_categoria_Click(object sender, EventArgs e)
        {
            string nombreCategoria = textbox_nombre_categoria.Text.Trim();
            var unidadSeleccionada = combobox_unidad_medida.SelectedItem.ToString();
            var (abreviatura, aceptaDecimales) = unidadesDeMedida[unidadSeleccionada];

            bool existe = await ExisteCategoria(nombreCategoria);
            if (existe)
            {
                label_mensaje_error_nombre_categoria.Visible = true;
                return;
            }

            string nuevoId = await ObtenerNuevoIdCategoriaAsync();

            Categoria nuevaCategoria = new Categoria(nombreCategoria, abreviatura, aceptaDecimales);

            try
            {
                await firebaseClient.SetAsync($"/Categorias/{sucursalActual}/{nuevoId}", nuevaCategoria);
                CargarCategoriasEnTreeView();

                treeview_arbol_categorias.SelectedNode = null;
                CargarFormularioEnPanel(new aviso_seleccion_categoria_subcategoria());

                MostrarMensajeAviso("La categoría se ha creado exitosamente.", true);

                textbox_nombre_categoria.Clear();
                combobox_unidad_medida.SelectedIndex = 0;
                ActualizarContadorCaracteres();
                btn_crear_categoria.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear la categoría: " + ex.Message);
            }
        }

        private async Task<string> ObtenerNuevoIdCategoriaAsync()
        {
            FirebaseResponse response = await firebaseClient.GetAsync($"/Categorias/{sucursalActual}");
            Dictionary<string, Categoria> categorias = response.ResultAs<Dictionary<string, Categoria>>();

            if (categorias == null || categorias.Count == 0)
            {
                return "CAT1";
            }

            int maxId = categorias.Keys
                .Where(key => key.StartsWith("CAT"))
                .Select(key => int.Parse(key.Substring(3)))
                .Max();

            return $"CAT{maxId + 1}";
        }

        private async Task<bool> ExisteCategoria(string nombreCategoria)
        {
            FirebaseResponse response = await firebaseClient.GetAsync($"/Categorias/{sucursalActual}");
            Dictionary<string, Categoria> categorias = response.ResultAs<Dictionary<string, Categoria>>();

            return categorias != null && categorias.Values.Any(c => c.Nombre.Equals(nombreCategoria, StringComparison.OrdinalIgnoreCase));
        }

        private void treeview_arbol_categorias_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node?.Tag is object[] tagArray && tagArray.Length > 0)
            {
                if (e.Node.Parent == null)
                {
                    string categoriaId = tagArray[0].ToString();
                    string nombreCategoria = tagArray[1].ToString();
                    string unidadCategoria = tagArray[2].ToString();

                    detalles_categoria detallesForm = new detalles_categoria(this, sucursalActual);
                    detallesForm.ConfigurarDatosCategoria(categoriaId, nombreCategoria, unidadCategoria, unidadesDeMedida, firebaseClient);
                    CargarFormularioEnPanel(detallesForm);
                }
                else
                {
                    string subcategoriaId = tagArray[0].ToString();
                    string nombreSubcategoria = tagArray[1].ToString();
                    string categoriaPadreId = e.Node.Parent.Tag is object[] parentTagArray ? parentTagArray[0].ToString() : null;

                    detalles_subcategoria detallesForm = new detalles_subcategoria(this, sucursalActual);
                    detallesForm.ConfigurarDatosSubcategoria(subcategoriaId, nombreSubcategoria, categoriaPadreId, ObtenerCategoriasDisponibles(), firebaseClient);
                    CargarFormularioEnPanel(detallesForm);
                }
            }
            else
            {
                CargarFormularioEnPanel(new aviso_seleccion_categoria_subcategoria());
            }
        }

        public Dictionary<string, string> ObtenerCategoriasDisponibles()
        {
            Dictionary<string, string> categoriasDisponibles = new Dictionary<string, string>();
            foreach (TreeNode node in treeview_arbol_categorias.Nodes)
            {
                if (node.Tag is object[] tagArray && tagArray.Length > 1)
                {
                    string nombreCategoria = tagArray[1].ToString();
                    string categoriaId = tagArray[0].ToString();
                    categoriasDisponibles[nombreCategoria] = categoriaId;
                }
            }
            return categoriasDisponibles;
        }

        private void treeview_arbol_categorias_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (creandoSubcategoria)
            {
                e.Cancel = true;
            }
        }

        private void treeview_arbol_categorias_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            if (creandoSubcategoria)
            {
                e.Cancel = true;
            }
        }

        private void label_gestion_categorias_Click(object sender, EventArgs e)
        {

        }

        private void panel_creacion_categorias_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_crear_categoria_Click(object sender, EventArgs e)
        {

        }

        private void label_indicacion_crear_categoria_Click(object sender, EventArgs e)
        {

        }

        private void combobox_unidad_medida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label_nombre_categoria_Click(object sender, EventArgs e)
        {

        }

        private void label_unidad_medida_categoria_Click(object sender, EventArgs e)
        {

        }

        private void label_contador_caracteres_nombre_categoria_Click(object sender, EventArgs e)
        {

        }

        private void label_mensaje_error_nombre_categoria_Click(object sender, EventArgs e)
        {

        }

        private void panel_arbol_categorias_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_arbol_categorias_Click(object sender, EventArgs e)
        {

        }

        private void panel_detalles_categoria_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_mensaje_aviso_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_aviso_categorias_Click(object sender, EventArgs e)
        {

        }
    }
}
