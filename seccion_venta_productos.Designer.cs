namespace MarketPal
{
    partial class seccion_venta_productos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            listViewProductos = new ListView();
            imageListProductos = new ImageList(components);
            dataGridViewCarrito = new DataGridView();
            colImagen = new DataGridViewImageColumn();
            colProducto = new DataGridViewTextBoxColumn();
            colEliminar = new DataGridViewImageColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colAgregar = new DataGridViewImageColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colDescuento = new DataGridViewTextBoxColumn();
            colPrecioFinal = new DataGridViewTextBoxColumn();
            BorrarProducto = new DataGridViewImageColumn();
            txtBuscarCodigo = new TextBox();
            comboBoxSubCategoria = new ComboBox();
            comboBoxCategoria = new ComboBox();
            lblCategoria = new Label();
            lblSubCategoria = new Label();
            btnCobrar = new Button();
            label_ventas = new Label();
            label_total_carrito = new Label();
            lblBuscarCodigo = new Label();
            dataGridViewImageColumn1 = new DataGridViewImageColumn();
            dataGridViewImageColumn2 = new DataGridViewImageColumn();
            dataGridViewImageColumn3 = new DataGridViewImageColumn();
            borrrartxtbox = new Button();
            CancelarFiltroSubcategoria = new Button();
            CancelarFiltroCategoria = new Button();
            panel_total_carrito = new Panel();
            lblIdVenta = new Label();
            btnPuntos = new Button();
            lblSubtotal = new Label();
            lblDescuentoAplicado = new Label();
            label_tc = new Label();
            label_ingresar_monto = new Label();
            panel_monto = new Panel();
            label_cambio = new Label();
            textbox_monto_recibido = new TextBox();
            label_monto_recibido = new Label();
            btn_siguiente_venta = new Button();
            btnPausarVenta = new Button();
            cmbVentasPausadas = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarrito).BeginInit();
            panel_total_carrito.SuspendLayout();
            panel_monto.SuspendLayout();
            SuspendLayout();
            // 
            // listViewProductos
            // 
            listViewProductos.BorderStyle = BorderStyle.FixedSingle;
            listViewProductos.Font = new Font("Lucida Sans", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listViewProductos.ForeColor = SystemColors.ControlText;
            listViewProductos.LargeImageList = imageListProductos;
            listViewProductos.Location = new Point(709, 140);
            listViewProductos.Margin = new Padding(5, 5, 5, 5);
            listViewProductos.Name = "listViewProductos";
            listViewProductos.Size = new Size(479, 575);
            listViewProductos.TabIndex = 7;
            listViewProductos.UseCompatibleStateImageBehavior = false;
            listViewProductos.MouseLeave += listViewProductos_MouseLeave;
            listViewProductos.MouseMove += listViewProductos_MouseMove;
            // 
            // imageListProductos
            // 
            imageListProductos.ColorDepth = ColorDepth.Depth32Bit;
            imageListProductos.ImageSize = new Size(95, 95);
            imageListProductos.TransparentColor = Color.Transparent;
            // 
            // dataGridViewCarrito
            // 
            dataGridViewCarrito.AllowUserToAddRows = false;
            dataGridViewCarrito.AllowUserToDeleteRows = false;
            dataGridViewCarrito.AllowUserToResizeColumns = false;
            dataGridViewCarrito.AllowUserToResizeRows = false;
            dataGridViewCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCarrito.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCarrito.BackgroundColor = Color.FromArgb(255, 224, 183);
            dataGridViewCarrito.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCarrito.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 224, 183);
            dataGridViewCellStyle1.Font = new Font("Lucida Sans", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 224, 183);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewCarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCarrito.Columns.AddRange(new DataGridViewColumn[] { colImagen, colProducto, colEliminar, colCantidad, colAgregar, colPrecio, colDescuento, colPrecioFinal, BorrarProducto });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 224, 183);
            dataGridViewCellStyle3.Font = new Font("Lucida Sans", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 224, 183);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewCarrito.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCarrito.EnableHeadersVisualStyles = false;
            dataGridViewCarrito.GridColor = Color.FromArgb(250, 146, 31);
            dataGridViewCarrito.Location = new Point(21, 80);
            dataGridViewCarrito.Margin = new Padding(5, 5, 5, 5);
            dataGridViewCarrito.MultiSelect = false;
            dataGridViewCarrito.Name = "dataGridViewCarrito";
            dataGridViewCarrito.RowHeadersVisible = false;
            dataGridViewCarrito.RowHeadersWidth = 51;
            dataGridViewCarrito.ScrollBars = ScrollBars.Vertical;
            dataGridViewCarrito.Size = new Size(679, 444);
            dataGridViewCarrito.TabIndex = 8;
            dataGridViewCarrito.CellContentClick += dataGridViewCarrito_CellContentClick;
            dataGridViewCarrito.CellContentDoubleClick += dataGridViewCarrito_CellContentDoubleClick;
            dataGridViewCarrito.CellMouseEnter += dataGridViewCarrito_CellMouseEnter;
            dataGridViewCarrito.CellMouseLeave += dataGridViewCarrito_CellMouseLeave;
            dataGridViewCarrito.RowsAdded += dataGridViewCarrito_RowsAdded;
            dataGridViewCarrito.RowsRemoved += dataGridViewCarrito_RowsRemoved;
            // 
            // colImagen
            // 
            colImagen.HeaderText = "Imagen";
            colImagen.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colImagen.MinimumWidth = 6;
            colImagen.Name = "colImagen";
            // 
            // colProducto
            // 
            colProducto.HeaderText = "Prod.";
            colProducto.MinimumWidth = 6;
            colProducto.Name = "colProducto";
            // 
            // colEliminar
            // 
            colEliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colEliminar.HeaderText = "";
            colEliminar.Image = Properties.Resources.menos;
            colEliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colEliminar.MinimumWidth = 6;
            colEliminar.Name = "colEliminar";
            colEliminar.Resizable = DataGridViewTriState.True;
            colEliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            colEliminar.Width = 25;
            // 
            // colCantidad
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colCantidad.DefaultCellStyle = dataGridViewCellStyle2;
            colCantidad.HeaderText = "Cantidad";
            colCantidad.MinimumWidth = 6;
            colCantidad.Name = "colCantidad";
            colCantidad.Resizable = DataGridViewTriState.True;
            colCantidad.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colAgregar
            // 
            colAgregar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colAgregar.HeaderText = "";
            colAgregar.Image = Properties.Resources.mas__1_;
            colAgregar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colAgregar.MinimumWidth = 6;
            colAgregar.Name = "colAgregar";
            colAgregar.Resizable = DataGridViewTriState.False;
            colAgregar.Width = 25;
            // 
            // colPrecio
            // 
            colPrecio.HeaderText = "Precio Unitario";
            colPrecio.MinimumWidth = 6;
            colPrecio.Name = "colPrecio";
            // 
            // colDescuento
            // 
            colDescuento.HeaderText = "Dto.";
            colDescuento.MinimumWidth = 6;
            colDescuento.Name = "colDescuento";
            // 
            // colPrecioFinal
            // 
            colPrecioFinal.HeaderText = "Precio Final";
            colPrecioFinal.MinimumWidth = 6;
            colPrecioFinal.Name = "colPrecioFinal";
            // 
            // BorrarProducto
            // 
            BorrarProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            BorrarProducto.HeaderText = "";
            BorrarProducto.Image = Properties.Resources.borrar__1_;
            BorrarProducto.ImageLayout = DataGridViewImageCellLayout.Zoom;
            BorrarProducto.MinimumWidth = 6;
            BorrarProducto.Name = "BorrarProducto";
            BorrarProducto.Width = 25;
            // 
            // txtBuscarCodigo
            // 
            txtBuscarCodigo.BackColor = SystemColors.ButtonHighlight;
            txtBuscarCodigo.Font = new Font("Lucida Sans", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarCodigo.ForeColor = SystemColors.GrayText;
            txtBuscarCodigo.Location = new Point(709, 101);
            txtBuscarCodigo.Margin = new Padding(5, 5, 5, 5);
            txtBuscarCodigo.MaxLength = 14;
            txtBuscarCodigo.Name = "txtBuscarCodigo";
            txtBuscarCodigo.Size = new Size(143, 23);
            txtBuscarCodigo.TabIndex = 9;
            txtBuscarCodigo.TextChanged += txtBuscarCodigo_TextChanged;
            txtBuscarCodigo.KeyPress += txtBuscarCodigo_KeyPress;
            // 
            // comboBoxSubCategoria
            // 
            comboBoxSubCategoria.BackColor = Color.FromArgb(250, 146, 31);
            comboBoxSubCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSubCategoria.Enabled = false;
            comboBoxSubCategoria.Font = new Font("Lucida Sans", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxSubCategoria.ForeColor = Color.Black;
            comboBoxSubCategoria.FormattingEnabled = true;
            comboBoxSubCategoria.Location = new Point(1038, 101);
            comboBoxSubCategoria.Margin = new Padding(5, 5, 5, 5);
            comboBoxSubCategoria.Name = "comboBoxSubCategoria";
            comboBoxSubCategoria.Size = new Size(130, 23);
            comboBoxSubCategoria.TabIndex = 11;
            comboBoxSubCategoria.SelectedIndexChanged += comboBoxSubCategoria_SelectedIndexChanged;
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.BackColor = Color.FromArgb(250, 146, 31);
            comboBoxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategoria.Font = new Font("Lucida Sans", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxCategoria.ForeColor = Color.Black;
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Location = new Point(880, 101);
            comboBoxCategoria.Margin = new Padding(5, 5, 5, 5);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(130, 23);
            comboBoxCategoria.TabIndex = 12;
            comboBoxCategoria.SelectedIndexChanged += comboBoxCategoria_SelectedIndexChanged;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Lucida Sans", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategoria.ForeColor = SystemColors.GrayText;
            lblCategoria.Location = new Point(877, 77);
            lblCategoria.Margin = new Padding(5, 0, 5, 0);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(68, 15);
            lblCategoria.TabIndex = 13;
            lblCategoria.Text = "Categoría";
            lblCategoria.Click += lblCategoria_Click;
            // 
            // lblSubCategoria
            // 
            lblSubCategoria.AutoSize = true;
            lblSubCategoria.Font = new Font("Lucida Sans", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubCategoria.ForeColor = SystemColors.GrayText;
            lblSubCategoria.Location = new Point(1035, 77);
            lblSubCategoria.Margin = new Padding(5, 0, 5, 0);
            lblSubCategoria.Name = "lblSubCategoria";
            lblSubCategoria.Size = new Size(90, 15);
            lblSubCategoria.TabIndex = 14;
            lblSubCategoria.Text = "Subcategoría";
            // 
            // btnCobrar
            // 
            btnCobrar.BackColor = Color.FromArgb(250, 146, 31);
            btnCobrar.Enabled = false;
            btnCobrar.FlatAppearance.BorderColor = Color.Black;
            btnCobrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(211, 113, 3);
            btnCobrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 119, 4);
            btnCobrar.FlatStyle = FlatStyle.Flat;
            btnCobrar.Font = new Font("Lucida Sans", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCobrar.Location = new Point(223, 83);
            btnCobrar.Margin = new Padding(5, 5, 5, 5);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(71, 32);
            btnCobrar.TabIndex = 18;
            btnCobrar.Text = "Cobrar";
            btnCobrar.UseVisualStyleBackColor = false;
            btnCobrar.Click += btnCobrar_Click;
            // 
            // label_ventas
            // 
            label_ventas.BackColor = Color.FromArgb(255, 224, 183);
            label_ventas.Font = new Font("Lucida Sans", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_ventas.ForeColor = Color.FromArgb(250, 146, 31);
            label_ventas.Location = new Point(21, 16);
            label_ventas.Margin = new Padding(5, 0, 5, 0);
            label_ventas.Name = "label_ventas";
            label_ventas.Size = new Size(1168, 49);
            label_ventas.TabIndex = 19;
            label_ventas.Text = "Ventas";
            label_ventas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_total_carrito
            // 
            label_total_carrito.AutoEllipsis = true;
            label_total_carrito.Font = new Font("Lucida Sans", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_total_carrito.ForeColor = SystemColors.ControlText;
            label_total_carrito.Location = new Point(3, 68);
            label_total_carrito.Margin = new Padding(5, 0, 5, 0);
            label_total_carrito.Name = "label_total_carrito";
            label_total_carrito.Size = new Size(357, 51);
            label_total_carrito.TabIndex = 20;
            label_total_carrito.Text = "MXN 0.00";
            label_total_carrito.Click += label_total_carrito_Click;
            // 
            // lblBuscarCodigo
            // 
            lblBuscarCodigo.AutoSize = true;
            lblBuscarCodigo.Font = new Font("Lucida Sans", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBuscarCodigo.ForeColor = SystemColors.GrayText;
            lblBuscarCodigo.Location = new Point(709, 105);
            lblBuscarCodigo.Margin = new Padding(5, 0, 5, 0);
            lblBuscarCodigo.Name = "lblBuscarCodigo";
            lblBuscarCodigo.Size = new Size(135, 15);
            lblBuscarCodigo.TabIndex = 10;
            lblBuscarCodigo.Text = "Buscar por código...";
            lblBuscarCodigo.Click += lblBuscarCodigo_Click;
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewImageColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewImageColumn1.HeaderText = "E";
            dataGridViewImageColumn1.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewImageColumn1.MinimumWidth = 6;
            dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            dataGridViewImageColumn1.Resizable = DataGridViewTriState.True;
            dataGridViewImageColumn1.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewImageColumn1.Width = 25;
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewImageColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewImageColumn2.HeaderText = "A";
            dataGridViewImageColumn2.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewImageColumn2.MinimumWidth = 6;
            dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            dataGridViewImageColumn2.Resizable = DataGridViewTriState.False;
            dataGridViewImageColumn2.Width = 25;
            // 
            // dataGridViewImageColumn3
            // 
            dataGridViewImageColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewImageColumn3.HeaderText = "BorrarProducto";
            dataGridViewImageColumn3.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewImageColumn3.MinimumWidth = 6;
            dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            dataGridViewImageColumn3.Width = 25;
            // 
            // borrrartxtbox
            // 
            borrrartxtbox.BackColor = Color.Transparent;
            borrrartxtbox.FlatAppearance.BorderSize = 0;
            borrrartxtbox.FlatAppearance.MouseDownBackColor = SystemColors.ScrollBar;
            borrrartxtbox.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            borrrartxtbox.FlatStyle = FlatStyle.Flat;
            borrrartxtbox.Image = Properties.Resources.equis__3___4_;
            borrrartxtbox.Location = new Point(854, 101);
            borrrartxtbox.Margin = new Padding(5, 5, 5, 5);
            borrrartxtbox.Name = "borrrartxtbox";
            borrrartxtbox.Size = new Size(18, 25);
            borrrartxtbox.TabIndex = 17;
            borrrartxtbox.UseVisualStyleBackColor = false;
            borrrartxtbox.Visible = false;
            borrrartxtbox.Click += borrrartxtbox_Click;
            // 
            // CancelarFiltroSubcategoria
            // 
            CancelarFiltroSubcategoria.BackColor = Color.Transparent;
            CancelarFiltroSubcategoria.FlatAppearance.BorderSize = 0;
            CancelarFiltroSubcategoria.FlatAppearance.MouseDownBackColor = SystemColors.ScrollBar;
            CancelarFiltroSubcategoria.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            CancelarFiltroSubcategoria.FlatStyle = FlatStyle.Flat;
            CancelarFiltroSubcategoria.Image = Properties.Resources.equis__3___4_;
            CancelarFiltroSubcategoria.Location = new Point(1170, 101);
            CancelarFiltroSubcategoria.Margin = new Padding(5, 5, 5, 5);
            CancelarFiltroSubcategoria.Name = "CancelarFiltroSubcategoria";
            CancelarFiltroSubcategoria.Size = new Size(18, 25);
            CancelarFiltroSubcategoria.TabIndex = 16;
            CancelarFiltroSubcategoria.UseVisualStyleBackColor = false;
            CancelarFiltroSubcategoria.Visible = false;
            CancelarFiltroSubcategoria.Click += CancelarFiltroSubcategoria_Click;
            // 
            // CancelarFiltroCategoria
            // 
            CancelarFiltroCategoria.BackColor = Color.Transparent;
            CancelarFiltroCategoria.FlatAppearance.BorderSize = 0;
            CancelarFiltroCategoria.FlatAppearance.MouseDownBackColor = SystemColors.ScrollBar;
            CancelarFiltroCategoria.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            CancelarFiltroCategoria.FlatStyle = FlatStyle.Flat;
            CancelarFiltroCategoria.Image = Properties.Resources.equis__3___4_;
            CancelarFiltroCategoria.Location = new Point(1013, 101);
            CancelarFiltroCategoria.Margin = new Padding(5, 5, 5, 5);
            CancelarFiltroCategoria.Name = "CancelarFiltroCategoria";
            CancelarFiltroCategoria.Size = new Size(18, 25);
            CancelarFiltroCategoria.TabIndex = 15;
            CancelarFiltroCategoria.UseVisualStyleBackColor = false;
            CancelarFiltroCategoria.Visible = false;
            CancelarFiltroCategoria.Click += CancelarFiltroCategoria_Click;
            // 
            // panel_total_carrito
            // 
            panel_total_carrito.BorderStyle = BorderStyle.FixedSingle;
            panel_total_carrito.Controls.Add(lblIdVenta);
            panel_total_carrito.Controls.Add(btnPuntos);
            panel_total_carrito.Controls.Add(lblSubtotal);
            panel_total_carrito.Controls.Add(lblDescuentoAplicado);
            panel_total_carrito.Controls.Add(label_total_carrito);
            panel_total_carrito.Location = new Point(21, 591);
            panel_total_carrito.Margin = new Padding(3, 4, 3, 4);
            panel_total_carrito.Name = "panel_total_carrito";
            panel_total_carrito.Size = new Size(367, 125);
            panel_total_carrito.TabIndex = 21;
            panel_total_carrito.Paint += panel_total_carrito_Paint;
            // 
            // lblIdVenta
            // 
            lblIdVenta.AutoEllipsis = true;
            lblIdVenta.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIdVenta.ForeColor = SystemColors.ControlText;
            lblIdVenta.Location = new Point(216, 3);
            lblIdVenta.Margin = new Padding(5, 0, 5, 0);
            lblIdVenta.Name = "lblIdVenta";
            lblIdVenta.Size = new Size(147, 23);
            lblIdVenta.TabIndex = 28;
            lblIdVenta.Text = "ID:";
            lblIdVenta.TextAlign = ContentAlignment.TopRight;
            lblIdVenta.Click += lblIdVenta_Click;
            // 
            // btnPuntos
            // 
            btnPuntos.BackColor = Color.FromArgb(250, 146, 31);
            btnPuntos.FlatAppearance.BorderColor = Color.Black;
            btnPuntos.FlatAppearance.MouseDownBackColor = Color.FromArgb(211, 113, 3);
            btnPuntos.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 119, 4);
            btnPuntos.FlatStyle = FlatStyle.Flat;
            btnPuntos.Font = new Font("Lucida Sans", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPuntos.Location = new Point(262, 83);
            btnPuntos.Margin = new Padding(3, 4, 3, 4);
            btnPuntos.Name = "btnPuntos";
            btnPuntos.Size = new Size(96, 31);
            btnPuntos.TabIndex = 23;
            btnPuntos.Text = "Usar puntos";
            btnPuntos.UseVisualStyleBackColor = false;
            btnPuntos.Click += btnPuntos_Click;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtotal.Location = new Point(8, 19);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(84, 19);
            lblSubtotal.TabIndex = 22;
            lblSubtotal.Text = "Subtotal:";
            lblSubtotal.Click += lblSubtotal_Click;
            // 
            // lblDescuentoAplicado
            // 
            lblDescuentoAplicado.AutoSize = true;
            lblDescuentoAplicado.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescuentoAplicado.Location = new Point(8, 43);
            lblDescuentoAplicado.Name = "lblDescuentoAplicado";
            lblDescuentoAplicado.Size = new Size(201, 19);
            lblDescuentoAplicado.TabIndex = 21;
            lblDescuentoAplicado.Text = "Descuento por puntos:";
            lblDescuentoAplicado.Click += lblDescuentoAplicado_Click;
            // 
            // label_tc
            // 
            label_tc.BackColor = Color.FromArgb(250, 146, 31);
            label_tc.BorderStyle = BorderStyle.FixedSingle;
            label_tc.Font = new Font("Lucida Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_tc.ForeColor = SystemColors.ControlText;
            label_tc.Location = new Point(21, 533);
            label_tc.Margin = new Padding(5, 0, 5, 0);
            label_tc.Name = "label_tc";
            label_tc.Size = new Size(367, 47);
            label_tc.TabIndex = 22;
            label_tc.Text = "Total a pagar";
            label_tc.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_ingresar_monto
            // 
            label_ingresar_monto.BackColor = Color.FromArgb(250, 146, 31);
            label_ingresar_monto.BorderStyle = BorderStyle.FixedSingle;
            label_ingresar_monto.Font = new Font("Lucida Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_ingresar_monto.ForeColor = SystemColors.ControlText;
            label_ingresar_monto.Location = new Point(397, 533);
            label_ingresar_monto.Margin = new Padding(5, 0, 5, 0);
            label_ingresar_monto.Name = "label_ingresar_monto";
            label_ingresar_monto.Size = new Size(303, 47);
            label_ingresar_monto.TabIndex = 23;
            label_ingresar_monto.Text = "Ingresar monto recibido";
            label_ingresar_monto.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel_monto
            // 
            panel_monto.BorderStyle = BorderStyle.FixedSingle;
            panel_monto.Controls.Add(label_cambio);
            panel_monto.Controls.Add(textbox_monto_recibido);
            panel_monto.Controls.Add(label_monto_recibido);
            panel_monto.Controls.Add(btnCobrar);
            panel_monto.Controls.Add(btn_siguiente_venta);
            panel_monto.Location = new Point(397, 591);
            panel_monto.Margin = new Padding(3, 4, 3, 4);
            panel_monto.Name = "panel_monto";
            panel_monto.Size = new Size(303, 125);
            panel_monto.TabIndex = 22;
            // 
            // label_cambio
            // 
            label_cambio.AutoEllipsis = true;
            label_cambio.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_cambio.ForeColor = SystemColors.ControlText;
            label_cambio.Location = new Point(10, 56);
            label_cambio.Margin = new Padding(5, 0, 5, 0);
            label_cambio.Name = "label_cambio";
            label_cambio.Size = new Size(275, 21);
            label_cambio.TabIndex = 26;
            label_cambio.Text = "Cambio:";
            label_cambio.Visible = false;
            label_cambio.Click += label_cambio_Click;
            // 
            // textbox_monto_recibido
            // 
            textbox_monto_recibido.BackColor = SystemColors.ButtonHighlight;
            textbox_monto_recibido.Enabled = false;
            textbox_monto_recibido.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_monto_recibido.ForeColor = SystemColors.GrayText;
            textbox_monto_recibido.Location = new Point(142, 15);
            textbox_monto_recibido.Margin = new Padding(5, 5, 5, 5);
            textbox_monto_recibido.Name = "textbox_monto_recibido";
            textbox_monto_recibido.Size = new Size(143, 25);
            textbox_monto_recibido.TabIndex = 25;
            textbox_monto_recibido.TextChanged += textbox_monto_recibido_TextChanged;
            textbox_monto_recibido.KeyPress += textbox_monto_recibido_KeyPress;
            // 
            // label_monto_recibido
            // 
            label_monto_recibido.AutoEllipsis = true;
            label_monto_recibido.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_monto_recibido.ForeColor = SystemColors.ControlText;
            label_monto_recibido.Location = new Point(10, 19);
            label_monto_recibido.Margin = new Padding(5, 0, 5, 0);
            label_monto_recibido.Name = "label_monto_recibido";
            label_monto_recibido.Size = new Size(275, 19);
            label_monto_recibido.TabIndex = 24;
            label_monto_recibido.Text = "Monto recibido:";
            label_monto_recibido.Click += label_monto_recibido_Click;
            // 
            // btn_siguiente_venta
            // 
            btn_siguiente_venta.BackColor = Color.FromArgb(250, 146, 31);
            btn_siguiente_venta.FlatAppearance.BorderColor = Color.Black;
            btn_siguiente_venta.FlatAppearance.MouseDownBackColor = Color.FromArgb(211, 113, 3);
            btn_siguiente_venta.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 119, 4);
            btn_siguiente_venta.FlatStyle = FlatStyle.Flat;
            btn_siguiente_venta.Font = new Font("Lucida Sans", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_siguiente_venta.Location = new Point(193, 83);
            btn_siguiente_venta.Margin = new Padding(5, 5, 5, 5);
            btn_siguiente_venta.Name = "btn_siguiente_venta";
            btn_siguiente_venta.Size = new Size(101, 32);
            btn_siguiente_venta.TabIndex = 27;
            btn_siguiente_venta.Text = "Nueva venta";
            btn_siguiente_venta.UseVisualStyleBackColor = false;
            btn_siguiente_venta.Visible = false;
            btn_siguiente_venta.Click += btn_siguiente_venta_Click;
            // 
            // btnPausarVenta
            // 
            btnPausarVenta.BackColor = Color.FromArgb(255, 128, 0);
            btnPausarVenta.FlatStyle = FlatStyle.Flat;
            btnPausarVenta.Font = new Font("Lucida Sans", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPausarVenta.Location = new Point(33, 28);
            btnPausarVenta.Margin = new Padding(3, 4, 3, 4);
            btnPausarVenta.Name = "btnPausarVenta";
            btnPausarVenta.Size = new Size(86, 27);
            btnPausarVenta.TabIndex = 24;
            btnPausarVenta.Text = "Pausar Venta";
            btnPausarVenta.UseVisualStyleBackColor = false;
            btnPausarVenta.Click += btnPausarVenta_Click;
            // 
            // cmbVentasPausadas
            // 
            cmbVentasPausadas.BackColor = Color.White;
            cmbVentasPausadas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVentasPausadas.Font = new Font("Lucida Sans", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbVentasPausadas.ForeColor = Color.Black;
            cmbVentasPausadas.FormattingEnabled = true;
            cmbVentasPausadas.Location = new Point(136, 29);
            cmbVentasPausadas.Margin = new Padding(3, 4, 3, 4);
            cmbVentasPausadas.Name = "cmbVentasPausadas";
            cmbVentasPausadas.Size = new Size(138, 23);
            cmbVentasPausadas.TabIndex = 25;
            cmbVentasPausadas.Visible = false;
            cmbVentasPausadas.SelectedIndexChanged += cmbVentasPausadas_SelectedIndexChanged;
            // 
            // seccion_venta_productos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1209, 729);
            Controls.Add(btnPausarVenta);
            Controls.Add(cmbVentasPausadas);
            Controls.Add(panel_monto);
            Controls.Add(label_ingresar_monto);
            Controls.Add(label_tc);
            Controls.Add(panel_total_carrito);
            Controls.Add(label_ventas);
            Controls.Add(borrrartxtbox);
            Controls.Add(CancelarFiltroSubcategoria);
            Controls.Add(CancelarFiltroCategoria);
            Controls.Add(lblSubCategoria);
            Controls.Add(lblCategoria);
            Controls.Add(comboBoxCategoria);
            Controls.Add(comboBoxSubCategoria);
            Controls.Add(lblBuscarCodigo);
            Controls.Add(txtBuscarCodigo);
            Controls.Add(dataGridViewCarrito);
            Controls.Add(listViewProductos);
            Margin = new Padding(5, 5, 5, 5);
            MaximizeBox = false;
            Name = "seccion_venta_productos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MarketPal";
            Load += seccion_venta_productos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarrito).EndInit();
            panel_total_carrito.ResumeLayout(false);
            panel_total_carrito.PerformLayout();
            panel_monto.ResumeLayout(false);
            panel_monto.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ListView listViewProductos;
        private System.Windows.Forms.ImageList imageListProductos;
        private System.Windows.Forms.TextBox txtBuscarCodigo;
        private System.Windows.Forms.ComboBox comboBoxSubCategoria;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblSubCategoria;
        private System.Windows.Forms.Button CancelarFiltroCategoria;
        private System.Windows.Forms.Button CancelarFiltroSubcategoria;
        private System.Windows.Forms.Button borrrartxtbox;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Label label_ventas;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Label lblBuscarCodigo;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.Panel panel_total_carrito;
        private System.Windows.Forms.Label label_tc;
        private System.Windows.Forms.Label label_ingresar_monto;
        private System.Windows.Forms.Panel panel_monto;
        private System.Windows.Forms.TextBox textbox_monto_recibido;
        private System.Windows.Forms.Label label_monto_recibido;
        private System.Windows.Forms.Label label_cambio;
        public System.Windows.Forms.DataGridView dataGridViewCarrito;
        private DataGridViewImageColumn colImagen;
        private DataGridViewTextBoxColumn colProducto;
        private DataGridViewImageColumn colEliminar;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewImageColumn colAgregar;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colDescuento;
        private DataGridViewTextBoxColumn colPrecioFinal;
        private DataGridViewImageColumn BorrarProducto;
        private Button btn_siguiente_venta;
        public Label label_total_carrito;
        public Label lblSubtotal;
        public Label lblDescuentoAplicado;
        public Button btnPuntos;
        private Label lblIdVenta;
        private Button btnPausarVenta;
        private ComboBox cmbVentasPausadas;
    }
}

