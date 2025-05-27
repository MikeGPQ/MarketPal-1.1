namespace MarketPal
{
    partial class seccion_productos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label_gestion_productos = new Label();
            datagrid_productos = new DataGridView();
            Imagen = new DataGridViewImageColumn();
            Código = new DataGridViewTextBoxColumn();
            Descripción = new DataGridViewTextBoxColumn();
            Categoría = new DataGridViewTextBoxColumn();
            Subcategoría = new DataGridViewTextBoxColumn();
            Precio_Venta = new DataGridViewTextBoxColumn();
            Cantidad_Existencia = new DataGridViewTextBoxColumn();
            Detalles = new DataGridViewImageColumn();
            Eliminar = new DataGridViewImageColumn();
            btn_agregar_producto = new Button();
            panel_opciones = new Panel();
            label_cantidad_productos_agotados = new Label();
            label_cantidad_productos_bajos = new Label();
            btn_exportar_productos = new Button();
            btn_productos_agotados = new Button();
            btn_productos_bajos_inventario = new Button();
            panel_mensaje_aviso = new Panel();
            textbox_busqueda_codigo = new TextBox();
            btn_borrar_busqueda = new Button();
            combobox_filtro_sucursal = new ComboBox();
            label_buscar_codigo = new Label();
            combobox_filtro_categoria = new ComboBox();
            combobox_filtro_subcategoria = new ComboBox();
            btn_cancelar_filtro_sucursal = new Button();
            btn_cancelar_filtro_categoria = new Button();
            btn_cancelar_filtro_subcategoria = new Button();
            label_filtro_sucursal = new Label();
            label_filtro_categoria = new Label();
            label_filtro_subcategoria = new Label();
            label_aviso_productos = new Label();
            panel_mensaje_agregar_eliminar_producto = new Panel();
            label_cantidad_elementos = new Label();
            ((System.ComponentModel.ISupportInitialize)datagrid_productos).BeginInit();
            panel_opciones.SuspendLayout();
            SuspendLayout();
            // 
            // label_gestion_productos
            // 
            label_gestion_productos.BackColor = Color.FromArgb(255, 224, 183);
            label_gestion_productos.Font = new Font("Lucida Sans", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_gestion_productos.ForeColor = Color.FromArgb(250, 146, 31);
            label_gestion_productos.Location = new Point(21, 13);
            label_gestion_productos.Name = "label_gestion_productos";
            label_gestion_productos.Size = new Size(1168, 39);
            label_gestion_productos.TabIndex = 1;
            label_gestion_productos.Text = "Gestión de Productos";
            label_gestion_productos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // datagrid_productos
            // 
            datagrid_productos.AllowUserToAddRows = false;
            datagrid_productos.AllowUserToDeleteRows = false;
            datagrid_productos.AllowUserToResizeColumns = false;
            datagrid_productos.AllowUserToResizeRows = false;
            datagrid_productos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagrid_productos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datagrid_productos.BackgroundColor = Color.FromArgb(255, 224, 183);
            datagrid_productos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            datagrid_productos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 224, 183);
            dataGridViewCellStyle1.Font = new Font("Lucida Sans", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 224, 183);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            datagrid_productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            datagrid_productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagrid_productos.Columns.AddRange(new DataGridViewColumn[] { Imagen, Código, Descripción, Categoría, Subcategoría, Precio_Venta, Cantidad_Existencia, Detalles, Eliminar });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 224, 183);
            dataGridViewCellStyle2.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 224, 183);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            datagrid_productos.DefaultCellStyle = dataGridViewCellStyle2;
            datagrid_productos.EnableHeadersVisualStyles = false;
            datagrid_productos.GridColor = Color.FromArgb(250, 146, 31);
            datagrid_productos.Location = new Point(21, 189);
            datagrid_productos.MultiSelect = false;
            datagrid_productos.Name = "datagrid_productos";
            datagrid_productos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            datagrid_productos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            datagrid_productos.RowHeadersVisible = false;
            datagrid_productos.RowHeadersWidth = 51;
            datagrid_productos.RowTemplate.Height = 100;
            datagrid_productos.ScrollBars = ScrollBars.Vertical;
            datagrid_productos.Size = new Size(1168, 515);
            datagrid_productos.TabIndex = 3;
            datagrid_productos.CellContentClick += datagrid_productos_CellContentClick;
            datagrid_productos.CellMouseEnter += datagrid_productos_CellMouseEnter;
            datagrid_productos.CellMouseLeave += datagrid_productos_CellMouseLeave;
            datagrid_productos.ColumnHeaderMouseClick += datagrid_productos_ColumnHeaderMouseClick;
            // 
            // Imagen
            // 
            Imagen.FillWeight = 83.18756F;
            Imagen.HeaderText = "Imagen";
            Imagen.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Imagen.MinimumWidth = 6;
            Imagen.Name = "Imagen";
            Imagen.ReadOnly = true;
            Imagen.Resizable = DataGridViewTriState.True;
            // 
            // Código
            // 
            Código.FillWeight = 83.18756F;
            Código.HeaderText = "Código";
            Código.MinimumWidth = 6;
            Código.Name = "Código";
            Código.ReadOnly = true;
            Código.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Descripción
            // 
            Descripción.FillWeight = 83.18756F;
            Descripción.HeaderText = "Descripción";
            Descripción.MinimumWidth = 6;
            Descripción.Name = "Descripción";
            Descripción.ReadOnly = true;
            Descripción.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // Categoría
            // 
            Categoría.FillWeight = 83.18756F;
            Categoría.HeaderText = "Categoría";
            Categoría.MinimumWidth = 6;
            Categoría.Name = "Categoría";
            Categoría.ReadOnly = true;
            Categoría.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Subcategoría
            // 
            Subcategoría.FillWeight = 83.18756F;
            Subcategoría.HeaderText = "Subcategoría";
            Subcategoría.MinimumWidth = 6;
            Subcategoría.Name = "Subcategoría";
            Subcategoría.ReadOnly = true;
            Subcategoría.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Precio_Venta
            // 
            Precio_Venta.FillWeight = 83.18756F;
            Precio_Venta.HeaderText = "Precio Final";
            Precio_Venta.MinimumWidth = 6;
            Precio_Venta.Name = "Precio_Venta";
            Precio_Venta.ReadOnly = true;
            Precio_Venta.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // Cantidad_Existencia
            // 
            Cantidad_Existencia.FillWeight = 83.18756F;
            Cantidad_Existencia.HeaderText = "Cantidad en Existencia";
            Cantidad_Existencia.MinimumWidth = 6;
            Cantidad_Existencia.Name = "Cantidad_Existencia";
            Cantidad_Existencia.ReadOnly = true;
            Cantidad_Existencia.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // Detalles
            // 
            Detalles.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Detalles.HeaderText = "";
            Detalles.Image = Properties.Resources.boton_editar;
            Detalles.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Detalles.MinimumWidth = 6;
            Detalles.Name = "Detalles";
            Detalles.ReadOnly = true;
            Detalles.Resizable = DataGridViewTriState.True;
            Detalles.Width = 40;
            // 
            // Eliminar
            // 
            Eliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Eliminar.HeaderText = "";
            Eliminar.Image = Properties.Resources.eliminar_producto;
            Eliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Eliminar.MinimumWidth = 6;
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            Eliminar.Resizable = DataGridViewTriState.True;
            Eliminar.Width = 40;
            // 
            // btn_agregar_producto
            // 
            btn_agregar_producto.BackColor = Color.FromArgb(250, 146, 31);
            btn_agregar_producto.Enabled = false;
            btn_agregar_producto.FlatAppearance.BorderColor = Color.Black;
            btn_agregar_producto.FlatAppearance.MouseDownBackColor = Color.FromArgb(211, 113, 3);
            btn_agregar_producto.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 119, 4);
            btn_agregar_producto.FlatStyle = FlatStyle.Flat;
            btn_agregar_producto.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_agregar_producto.Image = Properties.Resources.agregar__1_;
            btn_agregar_producto.ImageAlign = ContentAlignment.TopLeft;
            btn_agregar_producto.Location = new Point(112, 7);
            btn_agregar_producto.Name = "btn_agregar_producto";
            btn_agregar_producto.Size = new Size(191, 39);
            btn_agregar_producto.TabIndex = 5;
            btn_agregar_producto.Text = "Agregar producto";
            btn_agregar_producto.TextAlign = ContentAlignment.MiddleRight;
            btn_agregar_producto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_agregar_producto.UseVisualStyleBackColor = false;
            btn_agregar_producto.Click += btn_agregar_producto_Click;
            // 
            // panel_opciones
            // 
            panel_opciones.BorderStyle = BorderStyle.FixedSingle;
            panel_opciones.Controls.Add(label_cantidad_productos_agotados);
            panel_opciones.Controls.Add(label_cantidad_productos_bajos);
            panel_opciones.Controls.Add(btn_exportar_productos);
            panel_opciones.Controls.Add(btn_productos_agotados);
            panel_opciones.Controls.Add(btn_productos_bajos_inventario);
            panel_opciones.Controls.Add(btn_agregar_producto);
            panel_opciones.Location = new Point(21, 65);
            panel_opciones.Name = "panel_opciones";
            panel_opciones.Size = new Size(1168, 55);
            panel_opciones.TabIndex = 2;
            // 
            // label_cantidad_productos_agotados
            // 
            label_cantidad_productos_agotados.AutoEllipsis = true;
            label_cantidad_productos_agotados.BackColor = Color.FromArgb(255, 224, 183);
            label_cantidad_productos_agotados.BorderStyle = BorderStyle.FixedSingle;
            label_cantidad_productos_agotados.Font = new Font("Lucida Sans", 9F);
            label_cantidad_productos_agotados.ForeColor = SystemColors.GrayText;
            label_cantidad_productos_agotados.Location = new Point(819, 1);
            label_cantidad_productos_agotados.Name = "label_cantidad_productos_agotados";
            label_cantidad_productos_agotados.Size = new Size(28, 21);
            label_cantidad_productos_agotados.TabIndex = 85;
            label_cantidad_productos_agotados.TextAlign = ContentAlignment.MiddleCenter;
            label_cantidad_productos_agotados.Visible = false;
            // 
            // label_cantidad_productos_bajos
            // 
            label_cantidad_productos_bajos.AutoEllipsis = true;
            label_cantidad_productos_bajos.BackColor = Color.FromArgb(255, 224, 183);
            label_cantidad_productos_bajos.BorderStyle = BorderStyle.FixedSingle;
            label_cantidad_productos_bajos.Font = new Font("Lucida Sans", 9F);
            label_cantidad_productos_bajos.ForeColor = SystemColors.GrayText;
            label_cantidad_productos_bajos.Location = new Point(592, 1);
            label_cantidad_productos_bajos.Name = "label_cantidad_productos_bajos";
            label_cantidad_productos_bajos.Size = new Size(28, 21);
            label_cantidad_productos_bajos.TabIndex = 84;
            label_cantidad_productos_bajos.TextAlign = ContentAlignment.MiddleCenter;
            label_cantidad_productos_bajos.Visible = false;
            // 
            // btn_exportar_productos
            // 
            btn_exportar_productos.BackColor = Color.FromArgb(250, 146, 31);
            btn_exportar_productos.Enabled = false;
            btn_exportar_productos.FlatAppearance.BorderColor = Color.Black;
            btn_exportar_productos.FlatAppearance.MouseDownBackColor = Color.FromArgb(211, 113, 3);
            btn_exportar_productos.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 119, 4);
            btn_exportar_productos.FlatStyle = FlatStyle.Flat;
            btn_exportar_productos.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_exportar_productos.Image = Properties.Resources.sobresalir__1_;
            btn_exportar_productos.ImageAlign = ContentAlignment.TopLeft;
            btn_exportar_productos.Location = new Point(850, 7);
            btn_exportar_productos.Name = "btn_exportar_productos";
            btn_exportar_productos.Size = new Size(205, 39);
            btn_exportar_productos.TabIndex = 8;
            btn_exportar_productos.Text = "Exportar productos";
            btn_exportar_productos.TextAlign = ContentAlignment.MiddleRight;
            btn_exportar_productos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_exportar_productos.UseVisualStyleBackColor = false;
            btn_exportar_productos.Click += btn_exportar_productos_Click;
            // 
            // btn_productos_agotados
            // 
            btn_productos_agotados.BackColor = Color.FromArgb(250, 146, 31);
            btn_productos_agotados.Enabled = false;
            btn_productos_agotados.FlatAppearance.BorderColor = Color.Black;
            btn_productos_agotados.FlatAppearance.MouseDownBackColor = Color.FromArgb(211, 113, 3);
            btn_productos_agotados.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 119, 4);
            btn_productos_agotados.FlatStyle = FlatStyle.Flat;
            btn_productos_agotados.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_productos_agotados.Image = Properties.Resources.obsoleto__3_;
            btn_productos_agotados.ImageAlign = ContentAlignment.TopLeft;
            btn_productos_agotados.Location = new Point(623, 7);
            btn_productos_agotados.Name = "btn_productos_agotados";
            btn_productos_agotados.Size = new Size(214, 39);
            btn_productos_agotados.TabIndex = 7;
            btn_productos_agotados.Text = "Productos agotados";
            btn_productos_agotados.TextAlign = ContentAlignment.MiddleRight;
            btn_productos_agotados.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_productos_agotados.UseVisualStyleBackColor = false;
            btn_productos_agotados.Click += btn_productos_agotados_Click;
            // 
            // btn_productos_bajos_inventario
            // 
            btn_productos_bajos_inventario.BackColor = Color.FromArgb(250, 146, 31);
            btn_productos_bajos_inventario.Enabled = false;
            btn_productos_bajos_inventario.FlatAppearance.BorderColor = Color.Black;
            btn_productos_bajos_inventario.FlatAppearance.MouseDownBackColor = Color.FromArgb(211, 113, 3);
            btn_productos_bajos_inventario.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 119, 4);
            btn_productos_bajos_inventario.FlatStyle = FlatStyle.Flat;
            btn_productos_bajos_inventario.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_productos_bajos_inventario.Image = Properties.Resources.bajas_ventas;
            btn_productos_bajos_inventario.ImageAlign = ContentAlignment.TopLeft;
            btn_productos_bajos_inventario.Location = new Point(315, 7);
            btn_productos_bajos_inventario.Name = "btn_productos_bajos_inventario";
            btn_productos_bajos_inventario.Size = new Size(294, 39);
            btn_productos_bajos_inventario.TabIndex = 6;
            btn_productos_bajos_inventario.Text = "Productos bajos en inventario";
            btn_productos_bajos_inventario.TextAlign = ContentAlignment.MiddleRight;
            btn_productos_bajos_inventario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_productos_bajos_inventario.UseVisualStyleBackColor = false;
            btn_productos_bajos_inventario.Click += btn_productos_bajos_inventario_Click;
            // 
            // panel_mensaje_aviso
            // 
            panel_mensaje_aviso.BackColor = Color.Transparent;
            panel_mensaje_aviso.Location = new Point(21, 656);
            panel_mensaje_aviso.Name = "panel_mensaje_aviso";
            panel_mensaje_aviso.Size = new Size(314, 48);
            panel_mensaje_aviso.TabIndex = 14;
            panel_mensaje_aviso.Visible = false;
            panel_mensaje_aviso.Paint += panel_mensaje_aviso_Paint;
            // 
            // textbox_busqueda_codigo
            // 
            textbox_busqueda_codigo.BackColor = SystemColors.ButtonHighlight;
            textbox_busqueda_codigo.Enabled = false;
            textbox_busqueda_codigo.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_busqueda_codigo.ForeColor = SystemColors.GrayText;
            textbox_busqueda_codigo.Location = new Point(21, 143);
            textbox_busqueda_codigo.MaxLength = 14;
            textbox_busqueda_codigo.Name = "textbox_busqueda_codigo";
            textbox_busqueda_codigo.Size = new Size(233, 28);
            textbox_busqueda_codigo.TabIndex = 70;
            textbox_busqueda_codigo.TextChanged += textbox_busqueda_codigo_TextChanged;
            textbox_busqueda_codigo.KeyPress += textbox_busqueda_codigo_KeyPress;
            // 
            // btn_borrar_busqueda
            // 
            btn_borrar_busqueda.BackColor = Color.Transparent;
            btn_borrar_busqueda.FlatAppearance.BorderSize = 0;
            btn_borrar_busqueda.FlatAppearance.MouseDownBackColor = SystemColors.ScrollBar;
            btn_borrar_busqueda.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            btn_borrar_busqueda.FlatStyle = FlatStyle.Flat;
            btn_borrar_busqueda.Image = Properties.Resources.equis__3___2_;
            btn_borrar_busqueda.Location = new Point(255, 143);
            btn_borrar_busqueda.Name = "btn_borrar_busqueda";
            btn_borrar_busqueda.Size = new Size(26, 28);
            btn_borrar_busqueda.TabIndex = 72;
            btn_borrar_busqueda.UseVisualStyleBackColor = false;
            btn_borrar_busqueda.Visible = false;
            btn_borrar_busqueda.Click += btn_borrar_busqueda_Click;
            // 
            // combobox_filtro_sucursal
            // 
            combobox_filtro_sucursal.BackColor = Color.FromArgb(250, 146, 31);
            combobox_filtro_sucursal.DropDownStyle = ComboBoxStyle.DropDownList;
            combobox_filtro_sucursal.Enabled = false;
            combobox_filtro_sucursal.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            combobox_filtro_sucursal.ForeColor = Color.Black;
            combobox_filtro_sucursal.FormattingEnabled = true;
            combobox_filtro_sucursal.Location = new Point(315, 147);
            combobox_filtro_sucursal.Name = "combobox_filtro_sucursal";
            combobox_filtro_sucursal.Size = new Size(249, 25);
            combobox_filtro_sucursal.TabIndex = 73;
            combobox_filtro_sucursal.SelectedIndexChanged += combobox_filtro_sucursal_SelectedIndexChanged;
            // 
            // label_buscar_codigo
            // 
            label_buscar_codigo.AutoSize = true;
            label_buscar_codigo.BackColor = Color.Transparent;
            label_buscar_codigo.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_buscar_codigo.ForeColor = SystemColors.GrayText;
            label_buscar_codigo.Location = new Point(21, 147);
            label_buscar_codigo.Name = "label_buscar_codigo";
            label_buscar_codigo.Size = new Size(177, 19);
            label_buscar_codigo.TabIndex = 71;
            label_buscar_codigo.Text = "Buscar por código...";
            label_buscar_codigo.TextAlign = ContentAlignment.MiddleLeft;
            label_buscar_codigo.Click += label_buscar_codigo_Click;
            // 
            // combobox_filtro_categoria
            // 
            combobox_filtro_categoria.BackColor = Color.FromArgb(250, 146, 31);
            combobox_filtro_categoria.DropDownStyle = ComboBoxStyle.DropDownList;
            combobox_filtro_categoria.Enabled = false;
            combobox_filtro_categoria.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            combobox_filtro_categoria.ForeColor = Color.Black;
            combobox_filtro_categoria.FormattingEnabled = true;
            combobox_filtro_categoria.Location = new Point(613, 147);
            combobox_filtro_categoria.Name = "combobox_filtro_categoria";
            combobox_filtro_categoria.Size = new Size(249, 25);
            combobox_filtro_categoria.TabIndex = 74;
            combobox_filtro_categoria.SelectedIndexChanged += combobox_filtro_categoria_SelectedIndexChanged;
            // 
            // combobox_filtro_subcategoria
            // 
            combobox_filtro_subcategoria.BackColor = Color.FromArgb(250, 146, 31);
            combobox_filtro_subcategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            combobox_filtro_subcategoria.Enabled = false;
            combobox_filtro_subcategoria.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            combobox_filtro_subcategoria.ForeColor = Color.Black;
            combobox_filtro_subcategoria.FormattingEnabled = true;
            combobox_filtro_subcategoria.Location = new Point(911, 147);
            combobox_filtro_subcategoria.Name = "combobox_filtro_subcategoria";
            combobox_filtro_subcategoria.Size = new Size(249, 25);
            combobox_filtro_subcategoria.TabIndex = 75;
            combobox_filtro_subcategoria.SelectedIndexChanged += combobox_filtro_subcategoria_SelectedIndexChanged;
            // 
            // btn_cancelar_filtro_sucursal
            // 
            btn_cancelar_filtro_sucursal.BackColor = Color.Transparent;
            btn_cancelar_filtro_sucursal.FlatAppearance.BorderSize = 0;
            btn_cancelar_filtro_sucursal.FlatAppearance.MouseDownBackColor = SystemColors.ScrollBar;
            btn_cancelar_filtro_sucursal.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            btn_cancelar_filtro_sucursal.FlatStyle = FlatStyle.Flat;
            btn_cancelar_filtro_sucursal.Image = Properties.Resources.equis__3___2_;
            btn_cancelar_filtro_sucursal.Location = new Point(567, 145);
            btn_cancelar_filtro_sucursal.Name = "btn_cancelar_filtro_sucursal";
            btn_cancelar_filtro_sucursal.Size = new Size(26, 28);
            btn_cancelar_filtro_sucursal.TabIndex = 76;
            btn_cancelar_filtro_sucursal.UseVisualStyleBackColor = false;
            btn_cancelar_filtro_sucursal.Visible = false;
            btn_cancelar_filtro_sucursal.Click += btn_cancelar_filtro_sucursal_Click;
            // 
            // btn_cancelar_filtro_categoria
            // 
            btn_cancelar_filtro_categoria.BackColor = Color.Transparent;
            btn_cancelar_filtro_categoria.FlatAppearance.BorderSize = 0;
            btn_cancelar_filtro_categoria.FlatAppearance.MouseDownBackColor = SystemColors.ScrollBar;
            btn_cancelar_filtro_categoria.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            btn_cancelar_filtro_categoria.FlatStyle = FlatStyle.Flat;
            btn_cancelar_filtro_categoria.Image = Properties.Resources.equis__3___2_;
            btn_cancelar_filtro_categoria.Location = new Point(864, 145);
            btn_cancelar_filtro_categoria.Name = "btn_cancelar_filtro_categoria";
            btn_cancelar_filtro_categoria.Size = new Size(26, 28);
            btn_cancelar_filtro_categoria.TabIndex = 77;
            btn_cancelar_filtro_categoria.UseVisualStyleBackColor = false;
            btn_cancelar_filtro_categoria.Visible = false;
            btn_cancelar_filtro_categoria.Click += btn_cancelar_filtro_categoria_Click;
            // 
            // btn_cancelar_filtro_subcategoria
            // 
            btn_cancelar_filtro_subcategoria.BackColor = Color.Transparent;
            btn_cancelar_filtro_subcategoria.FlatAppearance.BorderSize = 0;
            btn_cancelar_filtro_subcategoria.FlatAppearance.MouseDownBackColor = SystemColors.ScrollBar;
            btn_cancelar_filtro_subcategoria.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            btn_cancelar_filtro_subcategoria.FlatStyle = FlatStyle.Flat;
            btn_cancelar_filtro_subcategoria.Image = Properties.Resources.equis__3___2_;
            btn_cancelar_filtro_subcategoria.Location = new Point(1162, 145);
            btn_cancelar_filtro_subcategoria.Name = "btn_cancelar_filtro_subcategoria";
            btn_cancelar_filtro_subcategoria.Size = new Size(26, 28);
            btn_cancelar_filtro_subcategoria.TabIndex = 78;
            btn_cancelar_filtro_subcategoria.UseVisualStyleBackColor = false;
            btn_cancelar_filtro_subcategoria.Visible = false;
            btn_cancelar_filtro_subcategoria.Click += btn_cancelar_filtro_subcategoria_Click;
            // 
            // label_filtro_sucursal
            // 
            label_filtro_sucursal.AutoSize = true;
            label_filtro_sucursal.BackColor = Color.Transparent;
            label_filtro_sucursal.Font = new Font("Lucida Sans", 9F);
            label_filtro_sucursal.ForeColor = SystemColors.GrayText;
            label_filtro_sucursal.Location = new Point(315, 127);
            label_filtro_sucursal.Name = "label_filtro_sucursal";
            label_filtro_sucursal.Size = new Size(68, 17);
            label_filtro_sucursal.TabIndex = 79;
            label_filtro_sucursal.Text = "Sucursal";
            label_filtro_sucursal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_filtro_categoria
            // 
            label_filtro_categoria.AutoSize = true;
            label_filtro_categoria.BackColor = Color.Transparent;
            label_filtro_categoria.Font = new Font("Lucida Sans", 9F);
            label_filtro_categoria.ForeColor = SystemColors.GrayText;
            label_filtro_categoria.Location = new Point(613, 127);
            label_filtro_categoria.Name = "label_filtro_categoria";
            label_filtro_categoria.Size = new Size(77, 17);
            label_filtro_categoria.TabIndex = 80;
            label_filtro_categoria.Text = "Categoría";
            label_filtro_categoria.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_filtro_subcategoria
            // 
            label_filtro_subcategoria.AutoSize = true;
            label_filtro_subcategoria.BackColor = Color.Transparent;
            label_filtro_subcategoria.Font = new Font("Lucida Sans", 9F);
            label_filtro_subcategoria.ForeColor = SystemColors.GrayText;
            label_filtro_subcategoria.Location = new Point(911, 127);
            label_filtro_subcategoria.Name = "label_filtro_subcategoria";
            label_filtro_subcategoria.Size = new Size(102, 17);
            label_filtro_subcategoria.TabIndex = 81;
            label_filtro_subcategoria.Text = "Subcategoría";
            label_filtro_subcategoria.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_aviso_productos
            // 
            label_aviso_productos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_aviso_productos.BackColor = Color.FromArgb(255, 224, 183);
            label_aviso_productos.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_aviso_productos.ForeColor = Color.Black;
            label_aviso_productos.Location = new Point(417, 411);
            label_aviso_productos.Name = "label_aviso_productos";
            label_aviso_productos.Size = new Size(379, 59);
            label_aviso_productos.TabIndex = 82;
            label_aviso_productos.TextAlign = ContentAlignment.MiddleCenter;
            label_aviso_productos.Visible = false;
            label_aviso_productos.Click += label_aviso_productos_Click;
            // 
            // panel_mensaje_agregar_eliminar_producto
            // 
            panel_mensaje_agregar_eliminar_producto.BackColor = Color.Transparent;
            panel_mensaje_agregar_eliminar_producto.Location = new Point(874, 656);
            panel_mensaje_agregar_eliminar_producto.Name = "panel_mensaje_agregar_eliminar_producto";
            panel_mensaje_agregar_eliminar_producto.Size = new Size(314, 48);
            panel_mensaje_agregar_eliminar_producto.TabIndex = 15;
            panel_mensaje_agregar_eliminar_producto.Visible = false;
            panel_mensaje_agregar_eliminar_producto.Paint += panel_mensaje_agregar_eliminar_producto_Paint;
            // 
            // label_cantidad_elementos
            // 
            label_cantidad_elementos.BackColor = Color.Transparent;
            label_cantidad_elementos.Font = new Font("Lucida Sans", 9F);
            label_cantidad_elementos.ForeColor = SystemColors.ControlText;
            label_cantidad_elementos.Location = new Point(754, 708);
            label_cantidad_elementos.Name = "label_cantidad_elementos";
            label_cantidad_elementos.Size = new Size(439, 17);
            label_cantidad_elementos.TabIndex = 83;
            label_cantidad_elementos.TextAlign = ContentAlignment.MiddleRight;
            label_cantidad_elementos.Click += label_cantidad_elementos_Click;
            // 
            // seccion_productos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1209, 729);
            Controls.Add(label_cantidad_elementos);
            Controls.Add(panel_mensaje_agregar_eliminar_producto);
            Controls.Add(label_aviso_productos);
            Controls.Add(label_filtro_subcategoria);
            Controls.Add(label_filtro_categoria);
            Controls.Add(label_filtro_sucursal);
            Controls.Add(btn_cancelar_filtro_subcategoria);
            Controls.Add(btn_cancelar_filtro_categoria);
            Controls.Add(btn_cancelar_filtro_sucursal);
            Controls.Add(combobox_filtro_subcategoria);
            Controls.Add(combobox_filtro_categoria);
            Controls.Add(combobox_filtro_sucursal);
            Controls.Add(btn_borrar_busqueda);
            Controls.Add(label_buscar_codigo);
            Controls.Add(textbox_busqueda_codigo);
            Controls.Add(panel_mensaje_aviso);
            Controls.Add(datagrid_productos);
            Controls.Add(panel_opciones);
            Controls.Add(label_gestion_productos);
            MaximizeBox = false;
            Name = "seccion_productos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "seccion_productos";
            FormClosing += seccion_productos_FormClosing;
            Load += seccion_productos_Load;
            ((System.ComponentModel.ISupportInitialize)datagrid_productos).EndInit();
            panel_opciones.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_gestion_productos;
        private DataGridView datagrid_productos;
        private Button btn_agregar_producto;
        private Panel panel_opciones;
        private Panel panel_mensaje_aviso;
        private TextBox textbox_busqueda_codigo;
        private Button btn_borrar_busqueda;
        private ComboBox combobox_filtro_sucursal;
        private Label label_buscar_codigo;
        private ComboBox combobox_filtro_categoria;
        private ComboBox combobox_filtro_subcategoria;
        private Button btn_cancelar_filtro_sucursal;
        private Button btn_cancelar_filtro_categoria;
        private Button btn_cancelar_filtro_subcategoria;
        private Label label_filtro_sucursal;
        private Label label_filtro_categoria;
        private Label label_filtro_subcategoria;
        private Label label_aviso_productos;
        private Panel panel_mensaje_agregar_eliminar_producto;
        private Button btn_productos_bajos_inventario;
        private Button btn_productos_agotados;
        private DataGridViewImageColumn Imagen;
        private DataGridViewTextBoxColumn Código;
        private DataGridViewTextBoxColumn Descripción;
        private DataGridViewTextBoxColumn Categoría;
        private DataGridViewTextBoxColumn Subcategoría;
        private DataGridViewTextBoxColumn Precio_Venta;
        private DataGridViewTextBoxColumn Cantidad_Existencia;
        private DataGridViewImageColumn Detalles;
        private DataGridViewImageColumn Eliminar;
        private Button btn_exportar_productos;
        private Label label_cantidad_elementos;
        private Label label_cantidad_productos_bajos;
        private Label label_cantidad_productos_agotados;
    }
}