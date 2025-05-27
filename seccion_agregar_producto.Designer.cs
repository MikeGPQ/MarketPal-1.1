namespace MarketPal
{
    partial class seccion_agregar_producto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_crear_categoria = new Label();
            btn_agregar_imagen = new Button();
            label_codigo_producto = new Label();
            textbox_codigo_producto = new TextBox();
            label_mensaje_error_imagen = new Label();
            label_descripcion_producto = new Label();
            textbox_descripcion = new TextBox();
            label_contador_caracteres_codigo = new Label();
            label_contador_caracteres_descripcion = new Label();
            combobox_categoria_producto = new ComboBox();
            label_categoria_producto = new Label();
            label_subcategoria_producto = new Label();
            combobox_subcategoria_producto = new ComboBox();
            label_mensaje_no_subcategorias = new Label();
            label_indicacion_imagen = new Label();
            btn_cambiar_imagen = new Button();
            label_cantidad_existencia = new Label();
            textbox_cantidad_existencia = new TextBox();
            label_unidad_existencia = new Label();
            label_unidad_minima = new Label();
            label_cantidad_minima = new Label();
            textbox_cantidad_minima = new TextBox();
            label_precio_venta_pesos = new Label();
            label_precio_venta = new Label();
            textbox_precio_venta = new TextBox();
            label_costo_pesos = new Label();
            label_costo_producto = new Label();
            textbox_costo_producto = new TextBox();
            label_descuento_producto = new Label();
            btn_cancelar_producto = new Button();
            btn_agregar_producto = new Button();
            label_mensaje_error_codigo = new Label();
            label_mensaje_error_descripcion = new Label();
            textbox_descuento_producto = new TextBox();
            label_mensaje_error_descuento = new Label();
            label_descuento_signo = new Label();
            SuspendLayout();
            // 
            // label_crear_categoria
            // 
            label_crear_categoria.BackColor = Color.FromArgb(250, 146, 31);
            label_crear_categoria.BorderStyle = BorderStyle.FixedSingle;
            label_crear_categoria.Font = new Font("Lucida Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_crear_categoria.ForeColor = SystemColors.ControlText;
            label_crear_categoria.Location = new Point(-3, 0);
            label_crear_categoria.Name = "label_crear_categoria";
            label_crear_categoria.Size = new Size(657, 29);
            label_crear_categoria.TabIndex = 3;
            label_crear_categoria.Text = " Agregar un producto";
            label_crear_categoria.TextAlign = ContentAlignment.MiddleLeft;
            label_crear_categoria.Click += label_crear_categoria_Click;
            // 
            // btn_agregar_imagen
            // 
            btn_agregar_imagen.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_agregar_imagen.BackColor = Color.Transparent;
            btn_agregar_imagen.FlatAppearance.BorderColor = Color.FromArgb(250, 146, 31);
            btn_agregar_imagen.FlatAppearance.MouseDownBackColor = SystemColors.ScrollBar;
            btn_agregar_imagen.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            btn_agregar_imagen.FlatStyle = FlatStyle.Flat;
            btn_agregar_imagen.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_agregar_imagen.ForeColor = SystemColors.ControlText;
            btn_agregar_imagen.Image = Properties.Resources.galeria_de_fotos__1_;
            btn_agregar_imagen.ImageAlign = ContentAlignment.BottomCenter;
            btn_agregar_imagen.Location = new Point(12, 102);
            btn_agregar_imagen.Margin = new Padding(3, 2, 3, 2);
            btn_agregar_imagen.Name = "btn_agregar_imagen";
            btn_agregar_imagen.Size = new Size(175, 150);
            btn_agregar_imagen.TabIndex = 18;
            btn_agregar_imagen.Text = "Agregar imagen";
            btn_agregar_imagen.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_agregar_imagen.UseVisualStyleBackColor = false;
            btn_agregar_imagen.Click += btn_agregar_imagen_Click;
            // 
            // label_codigo_producto
            // 
            label_codigo_producto.AutoSize = true;
            label_codigo_producto.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_codigo_producto.ForeColor = SystemColors.ControlText;
            label_codigo_producto.Location = new Point(208, 38);
            label_codigo_producto.Name = "label_codigo_producto";
            label_codigo_producto.Size = new Size(56, 16);
            label_codigo_producto.TabIndex = 20;
            label_codigo_producto.Text = "Código";
            label_codigo_producto.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textbox_codigo_producto
            // 
            textbox_codigo_producto.BackColor = SystemColors.ButtonHighlight;
            textbox_codigo_producto.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_codigo_producto.ForeColor = SystemColors.GrayText;
            textbox_codigo_producto.Location = new Point(209, 56);
            textbox_codigo_producto.Margin = new Padding(3, 2, 3, 2);
            textbox_codigo_producto.MaxLength = 14;
            textbox_codigo_producto.Name = "textbox_codigo_producto";
            textbox_codigo_producto.Size = new Size(424, 24);
            textbox_codigo_producto.TabIndex = 19;
            textbox_codigo_producto.TextChanged += textbox_codigo_producto_TextChanged;
            textbox_codigo_producto.KeyPress += textbox_codigo_producto_KeyPress;
            // 
            // label_mensaje_error_imagen
            // 
            label_mensaje_error_imagen.Font = new Font("Lucida Sans", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_mensaje_error_imagen.ForeColor = Color.Red;
            label_mensaje_error_imagen.Location = new Point(12, 259);
            label_mensaje_error_imagen.Name = "label_mensaje_error_imagen";
            label_mensaje_error_imagen.Size = new Size(175, 34);
            label_mensaje_error_imagen.TabIndex = 21;
            label_mensaje_error_imagen.Text = "La imagen seleccionada excede el límite de tamaño permitido.";
            label_mensaje_error_imagen.TextAlign = ContentAlignment.MiddleLeft;
            label_mensaje_error_imagen.Visible = false;
            label_mensaje_error_imagen.Click += label_mensaje_error_imagen_Click;
            // 
            // label_descripcion_producto
            // 
            label_descripcion_producto.AutoSize = true;
            label_descripcion_producto.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_descripcion_producto.ForeColor = SystemColors.ControlText;
            label_descripcion_producto.Location = new Point(208, 91);
            label_descripcion_producto.Name = "label_descripcion_producto";
            label_descripcion_producto.Size = new Size(85, 16);
            label_descripcion_producto.TabIndex = 23;
            label_descripcion_producto.Text = "Descripción";
            label_descripcion_producto.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textbox_descripcion
            // 
            textbox_descripcion.BackColor = SystemColors.ButtonHighlight;
            textbox_descripcion.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_descripcion.ForeColor = SystemColors.GrayText;
            textbox_descripcion.Location = new Point(209, 110);
            textbox_descripcion.Margin = new Padding(3, 2, 3, 2);
            textbox_descripcion.MaxLength = 80;
            textbox_descripcion.Name = "textbox_descripcion";
            textbox_descripcion.Size = new Size(424, 24);
            textbox_descripcion.TabIndex = 22;
            textbox_descripcion.TextChanged += textbox_descripcion_TextChanged;
            textbox_descripcion.KeyPress += textbox_descripcion_KeyPress;
            // 
            // label_contador_caracteres_codigo
            // 
            label_contador_caracteres_codigo.AutoSize = true;
            label_contador_caracteres_codigo.Font = new Font("Lucida Sans", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_contador_caracteres_codigo.ForeColor = SystemColors.GrayText;
            label_contador_caracteres_codigo.Location = new Point(532, 40);
            label_contador_caracteres_codigo.Name = "label_contador_caracteres_codigo";
            label_contador_caracteres_codigo.Size = new Size(0, 14);
            label_contador_caracteres_codigo.TabIndex = 24;
            label_contador_caracteres_codigo.TextAlign = ContentAlignment.MiddleLeft;
            label_contador_caracteres_codigo.Click += label_contador_caracteres_codigo_Click;
            // 
            // label_contador_caracteres_descripcion
            // 
            label_contador_caracteres_descripcion.AutoSize = true;
            label_contador_caracteres_descripcion.Font = new Font("Lucida Sans", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_contador_caracteres_descripcion.ForeColor = SystemColors.GrayText;
            label_contador_caracteres_descripcion.Location = new Point(532, 93);
            label_contador_caracteres_descripcion.Name = "label_contador_caracteres_descripcion";
            label_contador_caracteres_descripcion.Size = new Size(0, 14);
            label_contador_caracteres_descripcion.TabIndex = 25;
            label_contador_caracteres_descripcion.TextAlign = ContentAlignment.MiddleLeft;
            label_contador_caracteres_descripcion.Click += label_contador_caracteres_descripcion_Click;
            // 
            // combobox_categoria_producto
            // 
            combobox_categoria_producto.BackColor = SystemColors.ButtonHighlight;
            combobox_categoria_producto.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            combobox_categoria_producto.ForeColor = Color.Black;
            combobox_categoria_producto.FormattingEnabled = true;
            combobox_categoria_producto.Location = new Point(209, 164);
            combobox_categoria_producto.Margin = new Padding(3, 2, 3, 2);
            combobox_categoria_producto.Name = "combobox_categoria_producto";
            combobox_categoria_producto.Size = new Size(200, 24);
            combobox_categoria_producto.TabIndex = 26;
            combobox_categoria_producto.SelectedIndexChanged += combobox_categoria_producto_SelectedIndexChanged;
            // 
            // label_categoria_producto
            // 
            label_categoria_producto.AutoSize = true;
            label_categoria_producto.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_categoria_producto.ForeColor = SystemColors.ControlText;
            label_categoria_producto.Location = new Point(208, 144);
            label_categoria_producto.Name = "label_categoria_producto";
            label_categoria_producto.Size = new Size(72, 16);
            label_categoria_producto.TabIndex = 28;
            label_categoria_producto.Text = "Categoría";
            label_categoria_producto.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_subcategoria_producto
            // 
            label_subcategoria_producto.AutoSize = true;
            label_subcategoria_producto.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_subcategoria_producto.ForeColor = SystemColors.ControlText;
            label_subcategoria_producto.Location = new Point(434, 144);
            label_subcategoria_producto.Name = "label_subcategoria_producto";
            label_subcategoria_producto.Size = new Size(166, 16);
            label_subcategoria_producto.TabIndex = 30;
            label_subcategoria_producto.Text = "Subcategoría (opcional)";
            label_subcategoria_producto.TextAlign = ContentAlignment.MiddleLeft;
            label_subcategoria_producto.Visible = false;
            // 
            // combobox_subcategoria_producto
            // 
            combobox_subcategoria_producto.BackColor = SystemColors.ButtonHighlight;
            combobox_subcategoria_producto.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            combobox_subcategoria_producto.ForeColor = Color.Black;
            combobox_subcategoria_producto.FormattingEnabled = true;
            combobox_subcategoria_producto.Location = new Point(434, 164);
            combobox_subcategoria_producto.Margin = new Padding(3, 2, 3, 2);
            combobox_subcategoria_producto.Name = "combobox_subcategoria_producto";
            combobox_subcategoria_producto.Size = new Size(199, 24);
            combobox_subcategoria_producto.TabIndex = 29;
            combobox_subcategoria_producto.Visible = false;
            combobox_subcategoria_producto.SelectedIndexChanged += combobox_subcategoria_producto_SelectedIndexChanged;
            // 
            // label_mensaje_no_subcategorias
            // 
            label_mensaje_no_subcategorias.AutoSize = true;
            label_mensaje_no_subcategorias.BackColor = Color.Transparent;
            label_mensaje_no_subcategorias.Font = new Font("Lucida Sans", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_mensaje_no_subcategorias.ForeColor = SystemColors.GrayText;
            label_mensaje_no_subcategorias.Location = new Point(351, 146);
            label_mensaje_no_subcategorias.Name = "label_mensaje_no_subcategorias";
            label_mensaje_no_subcategorias.Size = new Size(280, 14);
            label_mensaje_no_subcategorias.TabIndex = 31;
            label_mensaje_no_subcategorias.Text = "Esta categoría no tiene subcategorías disponibles.";
            label_mensaje_no_subcategorias.TextAlign = ContentAlignment.MiddleLeft;
            label_mensaje_no_subcategorias.Visible = false;
            label_mensaje_no_subcategorias.Click += label_mensaje_no_subcategorias_Click;
            // 
            // label_indicacion_imagen
            // 
            label_indicacion_imagen.BackColor = Color.Transparent;
            label_indicacion_imagen.Font = new Font("Lucida Sans", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_indicacion_imagen.ForeColor = SystemColors.GrayText;
            label_indicacion_imagen.Location = new Point(12, 38);
            label_indicacion_imagen.Name = "label_indicacion_imagen";
            label_indicacion_imagen.Size = new Size(175, 59);
            label_indicacion_imagen.TabIndex = 32;
            label_indicacion_imagen.Text = "Solo se aceptan imágenes en formato JPG o PNG. Tamaño máximo permitido: 2 MB después de redimensionar a 200x200 píxeles.";
            label_indicacion_imagen.Click += label_indicacion_imagen_Click;
            // 
            // btn_cambiar_imagen
            // 
            btn_cambiar_imagen.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cambiar_imagen.BackColor = Color.Transparent;
            btn_cambiar_imagen.FlatAppearance.BorderColor = Color.FromArgb(250, 146, 31);
            btn_cambiar_imagen.FlatAppearance.BorderSize = 0;
            btn_cambiar_imagen.FlatAppearance.MouseDownBackColor = SystemColors.ScrollBar;
            btn_cambiar_imagen.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            btn_cambiar_imagen.FlatStyle = FlatStyle.Flat;
            btn_cambiar_imagen.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cambiar_imagen.ForeColor = SystemColors.ControlText;
            btn_cambiar_imagen.Image = Properties.Resources.reemplazar__3_;
            btn_cambiar_imagen.Location = new Point(152, 104);
            btn_cambiar_imagen.Margin = new Padding(3, 2, 3, 2);
            btn_cambiar_imagen.Name = "btn_cambiar_imagen";
            btn_cambiar_imagen.Size = new Size(32, 27);
            btn_cambiar_imagen.TabIndex = 33;
            btn_cambiar_imagen.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_cambiar_imagen.UseVisualStyleBackColor = false;
            btn_cambiar_imagen.Visible = false;
            btn_cambiar_imagen.Click += btn_cambiar_imagen_Click;
            // 
            // label_cantidad_existencia
            // 
            label_cantidad_existencia.AutoSize = true;
            label_cantidad_existencia.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_cantidad_existencia.ForeColor = SystemColors.ControlText;
            label_cantidad_existencia.Location = new Point(208, 307);
            label_cantidad_existencia.Name = "label_cantidad_existencia";
            label_cantidad_existencia.Size = new Size(157, 16);
            label_cantidad_existencia.TabIndex = 35;
            label_cantidad_existencia.Text = "Cantidad en existencia";
            label_cantidad_existencia.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textbox_cantidad_existencia
            // 
            textbox_cantidad_existencia.BackColor = SystemColors.ButtonHighlight;
            textbox_cantidad_existencia.Enabled = false;
            textbox_cantidad_existencia.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_cantidad_existencia.ForeColor = SystemColors.GrayText;
            textbox_cantidad_existencia.Location = new Point(209, 326);
            textbox_cantidad_existencia.Margin = new Padding(3, 2, 3, 2);
            textbox_cantidad_existencia.Name = "textbox_cantidad_existencia";
            textbox_cantidad_existencia.Size = new Size(164, 24);
            textbox_cantidad_existencia.TabIndex = 34;
            textbox_cantidad_existencia.TextChanged += textbox_cantidad_existencia_TextChanged;
            textbox_cantidad_existencia.KeyPress += textbox_cantidad_existencia_KeyPress;
            // 
            // label_unidad_existencia
            // 
            label_unidad_existencia.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_unidad_existencia.ForeColor = SystemColors.GrayText;
            label_unidad_existencia.Location = new Point(374, 328);
            label_unidad_existencia.Name = "label_unidad_existencia";
            label_unidad_existencia.Size = new Size(39, 14);
            label_unidad_existencia.TabIndex = 36;
            label_unidad_existencia.Text = "N/A";
            label_unidad_existencia.TextAlign = ContentAlignment.MiddleCenter;
            label_unidad_existencia.Click += label_unidad_existencia_Click;
            // 
            // label_unidad_minima
            // 
            label_unidad_minima.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_unidad_minima.ForeColor = SystemColors.GrayText;
            label_unidad_minima.Location = new Point(599, 328);
            label_unidad_minima.Name = "label_unidad_minima";
            label_unidad_minima.Size = new Size(39, 14);
            label_unidad_minima.TabIndex = 39;
            label_unidad_minima.Text = "N/A";
            label_unidad_minima.TextAlign = ContentAlignment.MiddleCenter;
            label_unidad_minima.Click += label_unidad_minima_Click;
            // 
            // label_cantidad_minima
            // 
            label_cantidad_minima.AutoSize = true;
            label_cantidad_minima.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_cantidad_minima.ForeColor = SystemColors.ControlText;
            label_cantidad_minima.Location = new Point(434, 307);
            label_cantidad_minima.Name = "label_cantidad_minima";
            label_cantidad_minima.Size = new Size(115, 16);
            label_cantidad_minima.TabIndex = 38;
            label_cantidad_minima.Text = "Cantidad mínima";
            label_cantidad_minima.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textbox_cantidad_minima
            // 
            textbox_cantidad_minima.BackColor = SystemColors.ButtonHighlight;
            textbox_cantidad_minima.Enabled = false;
            textbox_cantidad_minima.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_cantidad_minima.ForeColor = SystemColors.GrayText;
            textbox_cantidad_minima.Location = new Point(434, 326);
            textbox_cantidad_minima.Margin = new Padding(3, 2, 3, 2);
            textbox_cantidad_minima.Name = "textbox_cantidad_minima";
            textbox_cantidad_minima.Size = new Size(164, 24);
            textbox_cantidad_minima.TabIndex = 37;
            textbox_cantidad_minima.TextChanged += textbox_cantidad_minima_TextChanged;
            textbox_cantidad_minima.KeyPress += textbox_cantidad_minima_KeyPress;
            // 
            // label_precio_venta_pesos
            // 
            label_precio_venta_pesos.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_precio_venta_pesos.ForeColor = SystemColors.GrayText;
            label_precio_venta_pesos.Location = new Point(598, 219);
            label_precio_venta_pesos.Name = "label_precio_venta_pesos";
            label_precio_venta_pesos.Size = new Size(46, 14);
            label_precio_venta_pesos.TabIndex = 45;
            label_precio_venta_pesos.Text = "MXN";
            label_precio_venta_pesos.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_precio_venta
            // 
            label_precio_venta.AutoSize = true;
            label_precio_venta.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_precio_venta.ForeColor = SystemColors.ControlText;
            label_precio_venta.Location = new Point(434, 198);
            label_precio_venta.Name = "label_precio_venta";
            label_precio_venta.Size = new Size(110, 16);
            label_precio_venta.TabIndex = 44;
            label_precio_venta.Text = "Precio de venta";
            label_precio_venta.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textbox_precio_venta
            // 
            textbox_precio_venta.BackColor = SystemColors.ButtonHighlight;
            textbox_precio_venta.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_precio_venta.ForeColor = SystemColors.GrayText;
            textbox_precio_venta.Location = new Point(434, 217);
            textbox_precio_venta.Margin = new Padding(3, 2, 3, 2);
            textbox_precio_venta.Name = "textbox_precio_venta";
            textbox_precio_venta.Size = new Size(164, 24);
            textbox_precio_venta.TabIndex = 43;
            textbox_precio_venta.TextChanged += textbox_precio_venta_TextChanged;
            textbox_precio_venta.KeyPress += textbox_precio_venta_KeyPress;
            // 
            // label_costo_pesos
            // 
            label_costo_pesos.BackColor = Color.Transparent;
            label_costo_pesos.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_costo_pesos.ForeColor = SystemColors.GrayText;
            label_costo_pesos.Location = new Point(373, 219);
            label_costo_pesos.Name = "label_costo_pesos";
            label_costo_pesos.Size = new Size(46, 14);
            label_costo_pesos.TabIndex = 42;
            label_costo_pesos.Text = "MXN";
            label_costo_pesos.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_costo_producto
            // 
            label_costo_producto.AutoSize = true;
            label_costo_producto.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_costo_producto.ForeColor = SystemColors.ControlText;
            label_costo_producto.Location = new Point(208, 198);
            label_costo_producto.Name = "label_costo_producto";
            label_costo_producto.Size = new Size(47, 16);
            label_costo_producto.TabIndex = 41;
            label_costo_producto.Text = "Costo";
            label_costo_producto.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textbox_costo_producto
            // 
            textbox_costo_producto.BackColor = SystemColors.ButtonHighlight;
            textbox_costo_producto.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_costo_producto.ForeColor = SystemColors.GrayText;
            textbox_costo_producto.Location = new Point(209, 217);
            textbox_costo_producto.Margin = new Padding(3, 2, 3, 2);
            textbox_costo_producto.Name = "textbox_costo_producto";
            textbox_costo_producto.Size = new Size(164, 24);
            textbox_costo_producto.TabIndex = 40;
            textbox_costo_producto.TextChanged += textbox_costo_producto_TextChanged;
            textbox_costo_producto.KeyPress += textbox_costo_producto_KeyPress;
            // 
            // label_descuento_producto
            // 
            label_descuento_producto.AutoSize = true;
            label_descuento_producto.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_descuento_producto.ForeColor = SystemColors.ControlText;
            label_descuento_producto.Location = new Point(208, 252);
            label_descuento_producto.Name = "label_descuento_producto";
            label_descuento_producto.Size = new Size(78, 16);
            label_descuento_producto.TabIndex = 48;
            label_descuento_producto.Text = "Descuento";
            label_descuento_producto.TextAlign = ContentAlignment.MiddleLeft;
            label_descuento_producto.Click += label_descuento_producto_Click;
            // 
            // btn_cancelar_producto
            // 
            btn_cancelar_producto.Anchor = AnchorStyles.Right;
            btn_cancelar_producto.BackColor = Color.Transparent;
            btn_cancelar_producto.FlatAppearance.BorderColor = Color.FromArgb(250, 146, 31);
            btn_cancelar_producto.FlatAppearance.MouseDownBackColor = SystemColors.ScrollBar;
            btn_cancelar_producto.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            btn_cancelar_producto.FlatStyle = FlatStyle.Flat;
            btn_cancelar_producto.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cancelar_producto.ForeColor = Color.FromArgb(250, 146, 31);
            btn_cancelar_producto.Location = new Point(541, 379);
            btn_cancelar_producto.Margin = new Padding(3, 2, 3, 2);
            btn_cancelar_producto.Name = "btn_cancelar_producto";
            btn_cancelar_producto.Size = new Size(92, 22);
            btn_cancelar_producto.TabIndex = 50;
            btn_cancelar_producto.Text = "Cancelar";
            btn_cancelar_producto.UseVisualStyleBackColor = false;
            btn_cancelar_producto.Click += btn_cancelar_producto_Click;
            // 
            // btn_agregar_producto
            // 
            btn_agregar_producto.Anchor = AnchorStyles.Right;
            btn_agregar_producto.BackColor = Color.FromArgb(250, 146, 31);
            btn_agregar_producto.Enabled = false;
            btn_agregar_producto.FlatAppearance.BorderColor = Color.Black;
            btn_agregar_producto.FlatAppearance.MouseDownBackColor = Color.FromArgb(211, 113, 3);
            btn_agregar_producto.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 119, 4);
            btn_agregar_producto.FlatStyle = FlatStyle.Flat;
            btn_agregar_producto.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_agregar_producto.Location = new Point(436, 379);
            btn_agregar_producto.Margin = new Padding(3, 2, 3, 2);
            btn_agregar_producto.Name = "btn_agregar_producto";
            btn_agregar_producto.Size = new Size(92, 22);
            btn_agregar_producto.TabIndex = 49;
            btn_agregar_producto.Text = "Agregar";
            btn_agregar_producto.UseVisualStyleBackColor = false;
            btn_agregar_producto.Click += btn_agregar_producto_Click;
            // 
            // label_mensaje_error_codigo
            // 
            label_mensaje_error_codigo.AutoSize = true;
            label_mensaje_error_codigo.Font = new Font("Lucida Sans", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_mensaje_error_codigo.ForeColor = Color.Red;
            label_mensaje_error_codigo.Location = new Point(429, 80);
            label_mensaje_error_codigo.Name = "label_mensaje_error_codigo";
            label_mensaje_error_codigo.Size = new Size(199, 14);
            label_mensaje_error_codigo.TabIndex = 51;
            label_mensaje_error_codigo.Text = "El código ingresado ya está en uso.";
            label_mensaje_error_codigo.TextAlign = ContentAlignment.MiddleLeft;
            label_mensaje_error_codigo.Visible = false;
            label_mensaje_error_codigo.Click += label_mensaje_error_codigo_Click;
            // 
            // label_mensaje_error_descripcion
            // 
            label_mensaje_error_descripcion.AutoSize = true;
            label_mensaje_error_descripcion.Font = new Font("Lucida Sans", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_mensaje_error_descripcion.ForeColor = Color.Red;
            label_mensaje_error_descripcion.Location = new Point(402, 133);
            label_mensaje_error_descripcion.Name = "label_mensaje_error_descripcion";
            label_mensaje_error_descripcion.Size = new Size(228, 14);
            label_mensaje_error_descripcion.TabIndex = 52;
            label_mensaje_error_descripcion.Text = "La descripción ingresada ya está en uso.";
            label_mensaje_error_descripcion.TextAlign = ContentAlignment.MiddleLeft;
            label_mensaje_error_descripcion.Visible = false;
            label_mensaje_error_descripcion.Click += label_mensaje_error_descripcion_Click;
            // 
            // textbox_descuento_producto
            // 
            textbox_descuento_producto.BackColor = SystemColors.ButtonHighlight;
            textbox_descuento_producto.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_descuento_producto.ForeColor = SystemColors.GrayText;
            textbox_descuento_producto.Location = new Point(208, 271);
            textbox_descuento_producto.Margin = new Padding(3, 2, 3, 2);
            textbox_descuento_producto.MaxLength = 3;
            textbox_descuento_producto.Name = "textbox_descuento_producto";
            textbox_descuento_producto.Size = new Size(407, 24);
            textbox_descuento_producto.TabIndex = 53;
            textbox_descuento_producto.Text = "0";
            textbox_descuento_producto.TextChanged += textbox_descuento_producto_TextChanged;
            textbox_descuento_producto.KeyPress += textbox_descuento_producto_KeyPress;
            // 
            // label_mensaje_error_descuento
            // 
            label_mensaje_error_descuento.AutoSize = true;
            label_mensaje_error_descuento.Font = new Font("Lucida Sans", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_mensaje_error_descuento.ForeColor = Color.Red;
            label_mensaje_error_descuento.Location = new Point(208, 294);
            label_mensaje_error_descuento.Name = "label_mensaje_error_descuento";
            label_mensaje_error_descuento.Size = new Size(269, 14);
            label_mensaje_error_descuento.TabIndex = 54;
            label_mensaje_error_descuento.Text = "El descuento debe ser un número entre 0 y 100.";
            label_mensaje_error_descuento.TextAlign = ContentAlignment.MiddleLeft;
            label_mensaje_error_descuento.Visible = false;
            label_mensaje_error_descuento.Click += label_mensaje_error_descuento_Click;
            // 
            // label_descuento_signo
            // 
            label_descuento_signo.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_descuento_signo.ForeColor = SystemColors.GrayText;
            label_descuento_signo.Location = new Point(617, 273);
            label_descuento_signo.Name = "label_descuento_signo";
            label_descuento_signo.Size = new Size(17, 14);
            label_descuento_signo.TabIndex = 95;
            label_descuento_signo.Text = "%";
            label_descuento_signo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // seccion_agregar_producto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(645, 412);
            Controls.Add(label_descuento_signo);
            Controls.Add(label_mensaje_error_descuento);
            Controls.Add(label_mensaje_error_descripcion);
            Controls.Add(label_mensaje_error_codigo);
            Controls.Add(btn_cancelar_producto);
            Controls.Add(btn_agregar_producto);
            Controls.Add(label_descuento_producto);
            Controls.Add(label_precio_venta_pesos);
            Controls.Add(label_precio_venta);
            Controls.Add(textbox_precio_venta);
            Controls.Add(label_costo_pesos);
            Controls.Add(label_costo_producto);
            Controls.Add(textbox_costo_producto);
            Controls.Add(label_unidad_minima);
            Controls.Add(label_cantidad_minima);
            Controls.Add(textbox_cantidad_minima);
            Controls.Add(label_unidad_existencia);
            Controls.Add(label_cantidad_existencia);
            Controls.Add(textbox_cantidad_existencia);
            Controls.Add(btn_cambiar_imagen);
            Controls.Add(label_indicacion_imagen);
            Controls.Add(label_mensaje_no_subcategorias);
            Controls.Add(label_subcategoria_producto);
            Controls.Add(combobox_subcategoria_producto);
            Controls.Add(label_categoria_producto);
            Controls.Add(combobox_categoria_producto);
            Controls.Add(label_contador_caracteres_descripcion);
            Controls.Add(label_contador_caracteres_codigo);
            Controls.Add(label_descripcion_producto);
            Controls.Add(textbox_descripcion);
            Controls.Add(label_mensaje_error_imagen);
            Controls.Add(label_codigo_producto);
            Controls.Add(textbox_codigo_producto);
            Controls.Add(btn_agregar_imagen);
            Controls.Add(label_crear_categoria);
            Controls.Add(textbox_descuento_producto);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "seccion_agregar_producto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "seccion_agregar_producto";
            Load += seccion_agregar_producto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_crear_categoria;
        private Button btn_agregar_imagen;
        private Label label_codigo_producto;
        private TextBox textbox_codigo_producto;
        private Label label_mensaje_error_imagen;
        private Label label_descripcion_producto;
        private TextBox textbox_descripcion;
        private Label label_contador_caracteres_codigo;
        private Label label_contador_caracteres_descripcion;
        private ComboBox combobox_categoria_producto;
        private Label label_categoria_producto;
        private Label label_subcategoria_producto;
        private ComboBox combobox_subcategoria_producto;
        private Label label_mensaje_no_subcategorias;
        private Label label_indicacion_imagen;
        private Button btn_cambiar_imagen;
        private Label label_cantidad_existencia;
        private TextBox textbox_cantidad_existencia;
        private Label label_unidad_existencia;
        private Label label_unidad_minima;
        private Label label_cantidad_minima;
        private TextBox textbox_cantidad_minima;
        private Label label_precio_venta_pesos;
        private Label label_precio_venta;
        private TextBox textbox_precio_venta;
        private Label label_costo_pesos;
        private Label label_costo_producto;
        private TextBox textbox_costo_producto;
        private Label label_descuento_producto;
        private Button btn_cancelar_producto;
        private Button btn_agregar_producto;
        private Label label_mensaje_error_codigo;
        private Label label_mensaje_error_descripcion;
        private TextBox textbox_descuento_producto;
        private Label label_mensaje_error_descuento;
        private Label label_descuento_signo;
    }
}