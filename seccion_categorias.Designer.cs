namespace MarketPal
{
    partial class seccion_categorias
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(seccion_categorias));
            label_gestion_categorias = new Label();
            panel_creacion_categorias = new Panel();
            label_mensaje_error_nombre_categoria = new Label();
            label_contador_caracteres_nombre_categoria = new Label();
            label_unidad_medida_categoria = new Label();
            label_nombre_categoria = new Label();
            combobox_unidad_medida = new ComboBox();
            btn_crear_categoria = new Button();
            textbox_nombre_categoria = new TextBox();
            label_indicacion_crear_categoria = new Label();
            label_crear_categoria = new Label();
            panel_arbol_categorias = new Panel();
            label_aviso_categorias = new Label();
            panel_mensaje_aviso = new Panel();
            panel_detalles_categoria = new Panel();
            treeview_arbol_categorias = new TreeView();
            imagelist_treeview = new ImageList(components);
            label_arbol_categorias = new Label();
            timer_ocultar_botones = new System.Windows.Forms.Timer(components);
            panel_creacion_categorias.SuspendLayout();
            panel_arbol_categorias.SuspendLayout();
            SuspendLayout();
            // 
            // label_gestion_categorias
            // 
            label_gestion_categorias.BackColor = Color.FromArgb(255, 224, 183);
            label_gestion_categorias.Font = new Font("Lucida Sans", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_gestion_categorias.ForeColor = Color.FromArgb(250, 146, 31);
            label_gestion_categorias.Location = new Point(21, 13);
            label_gestion_categorias.Name = "label_gestion_categorias";
            label_gestion_categorias.Size = new Size(1168, 39);
            label_gestion_categorias.TabIndex = 0;
            label_gestion_categorias.Text = "Gestión de Categorías";
            label_gestion_categorias.TextAlign = ContentAlignment.MiddleCenter;
            label_gestion_categorias.Click += label_gestion_categorias_Click;
            // 
            // panel_creacion_categorias
            // 
            panel_creacion_categorias.BorderStyle = BorderStyle.FixedSingle;
            panel_creacion_categorias.Controls.Add(label_mensaje_error_nombre_categoria);
            panel_creacion_categorias.Controls.Add(label_contador_caracteres_nombre_categoria);
            panel_creacion_categorias.Controls.Add(label_unidad_medida_categoria);
            panel_creacion_categorias.Controls.Add(label_nombre_categoria);
            panel_creacion_categorias.Controls.Add(combobox_unidad_medida);
            panel_creacion_categorias.Controls.Add(btn_crear_categoria);
            panel_creacion_categorias.Controls.Add(textbox_nombre_categoria);
            panel_creacion_categorias.Controls.Add(label_indicacion_crear_categoria);
            panel_creacion_categorias.Controls.Add(label_crear_categoria);
            panel_creacion_categorias.Location = new Point(21, 65);
            panel_creacion_categorias.Name = "panel_creacion_categorias";
            panel_creacion_categorias.Size = new Size(1168, 215);
            panel_creacion_categorias.TabIndex = 1;
            panel_creacion_categorias.Paint += panel_creacion_categorias_Paint;
            // 
            // label_mensaje_error_nombre_categoria
            // 
            label_mensaje_error_nombre_categoria.AutoSize = true;
            label_mensaje_error_nombre_categoria.Font = new Font("Lucida Sans", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_mensaje_error_nombre_categoria.ForeColor = Color.Red;
            label_mensaje_error_nombre_categoria.Location = new Point(21, 183);
            label_mensaje_error_nombre_categoria.Name = "label_mensaje_error_nombre_categoria";
            label_mensaje_error_nombre_categoria.Size = new Size(238, 15);
            label_mensaje_error_nombre_categoria.TabIndex = 9;
            label_mensaje_error_nombre_categoria.Text = "El nombre ingresado ya está en uso.";
            label_mensaje_error_nombre_categoria.TextAlign = ContentAlignment.MiddleLeft;
            label_mensaje_error_nombre_categoria.Visible = false;
            label_mensaje_error_nombre_categoria.Click += label_mensaje_error_nombre_categoria_Click;
            // 
            // label_contador_caracteres_nombre_categoria
            // 
            label_contador_caracteres_nombre_categoria.AutoSize = true;
            label_contador_caracteres_nombre_categoria.Font = new Font("Lucida Sans", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_contador_caracteres_nombre_categoria.ForeColor = SystemColors.GrayText;
            label_contador_caracteres_nombre_categoria.Location = new Point(362, 131);
            label_contador_caracteres_nombre_categoria.Name = "label_contador_caracteres_nombre_categoria";
            label_contador_caracteres_nombre_categoria.Size = new Size(0, 15);
            label_contador_caracteres_nombre_categoria.TabIndex = 8;
            label_contador_caracteres_nombre_categoria.TextAlign = ContentAlignment.MiddleLeft;
            label_contador_caracteres_nombre_categoria.Click += label_contador_caracteres_nombre_categoria_Click;
            // 
            // label_unidad_medida_categoria
            // 
            label_unidad_medida_categoria.AutoSize = true;
            label_unidad_medida_categoria.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_unidad_medida_categoria.ForeColor = SystemColors.ControlText;
            label_unidad_medida_categoria.Location = new Point(521, 127);
            label_unidad_medida_categoria.Name = "label_unidad_medida_categoria";
            label_unidad_medida_categoria.Size = new Size(162, 19);
            label_unidad_medida_categoria.TabIndex = 7;
            label_unidad_medida_categoria.Text = "Unidad de medida";
            label_unidad_medida_categoria.TextAlign = ContentAlignment.MiddleLeft;
            label_unidad_medida_categoria.Click += label_unidad_medida_categoria_Click;
            // 
            // label_nombre_categoria
            // 
            label_nombre_categoria.AutoSize = true;
            label_nombre_categoria.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_nombre_categoria.ForeColor = SystemColors.ControlText;
            label_nombre_categoria.Location = new Point(21, 127);
            label_nombre_categoria.Name = "label_nombre_categoria";
            label_nombre_categoria.Size = new Size(76, 19);
            label_nombre_categoria.TabIndex = 6;
            label_nombre_categoria.Text = "Nombre";
            label_nombre_categoria.TextAlign = ContentAlignment.MiddleLeft;
            label_nombre_categoria.Click += label_nombre_categoria_Click;
            // 
            // combobox_unidad_medida
            // 
            combobox_unidad_medida.BackColor = SystemColors.ButtonHighlight;
            combobox_unidad_medida.DropDownStyle = ComboBoxStyle.DropDownList;
            combobox_unidad_medida.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            combobox_unidad_medida.ForeColor = Color.Black;
            combobox_unidad_medida.FormattingEnabled = true;
            combobox_unidad_medida.Location = new Point(521, 152);
            combobox_unidad_medida.Name = "combobox_unidad_medida";
            combobox_unidad_medida.Size = new Size(457, 27);
            combobox_unidad_medida.TabIndex = 5;
            combobox_unidad_medida.SelectedIndexChanged += combobox_unidad_medida_SelectedIndexChanged;
            // 
            // btn_crear_categoria
            // 
            btn_crear_categoria.BackColor = Color.FromArgb(250, 146, 31);
            btn_crear_categoria.Enabled = false;
            btn_crear_categoria.FlatAppearance.BorderColor = Color.Black;
            btn_crear_categoria.FlatAppearance.MouseDownBackColor = Color.FromArgb(211, 113, 3);
            btn_crear_categoria.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 119, 4);
            btn_crear_categoria.FlatStyle = FlatStyle.Flat;
            btn_crear_categoria.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_crear_categoria.Location = new Point(1019, 149);
            btn_crear_categoria.Name = "btn_crear_categoria";
            btn_crear_categoria.Size = new Size(107, 29);
            btn_crear_categoria.TabIndex = 4;
            btn_crear_categoria.Text = "Crear";
            btn_crear_categoria.UseVisualStyleBackColor = false;
            btn_crear_categoria.Click += btn_crear_categoria_Click;
            // 
            // textbox_nombre_categoria
            // 
            textbox_nombre_categoria.BackColor = SystemColors.ButtonHighlight;
            textbox_nombre_categoria.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_nombre_categoria.ForeColor = SystemColors.GrayText;
            textbox_nombre_categoria.Location = new Point(21, 152);
            textbox_nombre_categoria.MaxLength = 50;
            textbox_nombre_categoria.Name = "textbox_nombre_categoria";
            textbox_nombre_categoria.Size = new Size(457, 28);
            textbox_nombre_categoria.TabIndex = 3;
            textbox_nombre_categoria.TextChanged += textbox_nombre_categoria_TextChanged;
            textbox_nombre_categoria.KeyPress += textbox_nombre_categoria_KeyPress;
            // 
            // label_indicacion_crear_categoria
            // 
            label_indicacion_crear_categoria.Font = new Font("Lucida Sans", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_indicacion_crear_categoria.ForeColor = Color.FromArgb(250, 146, 31);
            label_indicacion_crear_categoria.Location = new Point(11, 60);
            label_indicacion_crear_categoria.Name = "label_indicacion_crear_categoria";
            label_indicacion_crear_categoria.Size = new Size(1147, 53);
            label_indicacion_crear_categoria.TabIndex = 2;
            label_indicacion_crear_categoria.Text = "Para crear una categoría, ingrese su nombre y seleccione la unidad de medida que se aplicará a la cantidad en existencia y mínima de los productos que pertenezcan a esta categoría.";
            label_indicacion_crear_categoria.TextAlign = ContentAlignment.MiddleLeft;
            label_indicacion_crear_categoria.Click += label_indicacion_crear_categoria_Click;
            // 
            // label_crear_categoria
            // 
            label_crear_categoria.BackColor = Color.FromArgb(250, 146, 31);
            label_crear_categoria.BorderStyle = BorderStyle.FixedSingle;
            label_crear_categoria.Font = new Font("Lucida Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_crear_categoria.ForeColor = SystemColors.ControlText;
            label_crear_categoria.Location = new Point(13, 19);
            label_crear_categoria.Name = "label_crear_categoria";
            label_crear_categoria.Size = new Size(1139, 30);
            label_crear_categoria.TabIndex = 2;
            label_crear_categoria.Text = "Crear una categoría";
            label_crear_categoria.TextAlign = ContentAlignment.MiddleLeft;
            label_crear_categoria.Click += label_crear_categoria_Click;
            // 
            // panel_arbol_categorias
            // 
            panel_arbol_categorias.BorderStyle = BorderStyle.FixedSingle;
            panel_arbol_categorias.Controls.Add(label_aviso_categorias);
            panel_arbol_categorias.Controls.Add(panel_mensaje_aviso);
            panel_arbol_categorias.Controls.Add(panel_detalles_categoria);
            panel_arbol_categorias.Controls.Add(treeview_arbol_categorias);
            panel_arbol_categorias.Controls.Add(label_arbol_categorias);
            panel_arbol_categorias.Location = new Point(21, 307);
            panel_arbol_categorias.Name = "panel_arbol_categorias";
            panel_arbol_categorias.Size = new Size(1168, 397);
            panel_arbol_categorias.TabIndex = 2;
            panel_arbol_categorias.Paint += panel_arbol_categorias_Paint;
            // 
            // label_aviso_categorias
            // 
            label_aviso_categorias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_aviso_categorias.BackColor = Color.Transparent;
            label_aviso_categorias.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_aviso_categorias.ForeColor = Color.Black;
            label_aviso_categorias.Location = new Point(136, 188);
            label_aviso_categorias.Name = "label_aviso_categorias";
            label_aviso_categorias.Size = new Size(379, 59);
            label_aviso_categorias.TabIndex = 83;
            label_aviso_categorias.Text = "Seleccione una categoría o subcategoría para ver sus detalles.";
            label_aviso_categorias.TextAlign = ContentAlignment.MiddleCenter;
            label_aviso_categorias.Visible = false;
            label_aviso_categorias.Click += label_aviso_categorias_Click;
            // 
            // panel_mensaje_aviso
            // 
            panel_mensaje_aviso.BackColor = Color.Transparent;
            panel_mensaje_aviso.Location = new Point(-1, 347);
            panel_mensaje_aviso.Name = "panel_mensaje_aviso";
            panel_mensaje_aviso.Size = new Size(314, 48);
            panel_mensaje_aviso.TabIndex = 13;
            panel_mensaje_aviso.Visible = false;
            panel_mensaje_aviso.Paint += panel_mensaje_aviso_Paint;
            // 
            // panel_detalles_categoria
            // 
            panel_detalles_categoria.BorderStyle = BorderStyle.FixedSingle;
            panel_detalles_categoria.Location = new Point(657, 67);
            panel_detalles_categoria.Name = "panel_detalles_categoria";
            panel_detalles_categoria.Size = new Size(493, 311);
            panel_detalles_categoria.TabIndex = 12;
            panel_detalles_categoria.Paint += panel_detalles_categoria_Paint;
            // 
            // treeview_arbol_categorias
            // 
            treeview_arbol_categorias.Font = new Font("Lucida Sans", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            treeview_arbol_categorias.ForeColor = SystemColors.ControlText;
            treeview_arbol_categorias.ImageIndex = 0;
            treeview_arbol_categorias.ImageList = imagelist_treeview;
            treeview_arbol_categorias.Location = new Point(13, 67);
            treeview_arbol_categorias.Name = "treeview_arbol_categorias";
            treeview_arbol_categorias.SelectedImageIndex = 0;
            treeview_arbol_categorias.Size = new Size(626, 311);
            treeview_arbol_categorias.TabIndex = 11;
            treeview_arbol_categorias.BeforeCollapse += treeview_arbol_categorias_BeforeCollapse;
            treeview_arbol_categorias.BeforeExpand += treeview_arbol_categorias_BeforeExpand;
            treeview_arbol_categorias.AfterSelect += treeview_arbol_categorias_AfterSelect;
            treeview_arbol_categorias.MouseLeave += treeview_arbol_categorias_MouseLeave;
            treeview_arbol_categorias.MouseMove += treeview_arbol_categorias_MouseMove;
            // 
            // imagelist_treeview
            // 
            imagelist_treeview.ColorDepth = ColorDepth.Depth32Bit;
            imagelist_treeview.ImageStream = (ImageListStreamer)resources.GetObject("imagelist_treeview.ImageStream");
            imagelist_treeview.TransparentColor = Color.Transparent;
            imagelist_treeview.Images.SetKeyName(0, "categoria.png");
            imagelist_treeview.Images.SetKeyName(1, "subcategoria.png");
            // 
            // label_arbol_categorias
            // 
            label_arbol_categorias.BackColor = Color.FromArgb(250, 146, 31);
            label_arbol_categorias.BorderStyle = BorderStyle.FixedSingle;
            label_arbol_categorias.Font = new Font("Lucida Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_arbol_categorias.ForeColor = SystemColors.ControlText;
            label_arbol_categorias.Location = new Point(11, 19);
            label_arbol_categorias.Name = "label_arbol_categorias";
            label_arbol_categorias.Size = new Size(1139, 30);
            label_arbol_categorias.TabIndex = 10;
            label_arbol_categorias.Text = "Árbol de categorías";
            label_arbol_categorias.TextAlign = ContentAlignment.MiddleLeft;
            label_arbol_categorias.Click += label_arbol_categorias_Click;
            // 
            // timer_ocultar_botones
            // 
            timer_ocultar_botones.Interval = 450;
            timer_ocultar_botones.Tick += timer_ocultar_botones_Tick;
            // 
            // seccion_categorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1209, 729);
            Controls.Add(panel_arbol_categorias);
            Controls.Add(panel_creacion_categorias);
            Controls.Add(label_gestion_categorias);
            MaximizeBox = false;
            Name = "seccion_categorias";
            Text = "seccion_categorias";
            Load += seccion_categorias_Load;
            panel_creacion_categorias.ResumeLayout(false);
            panel_creacion_categorias.PerformLayout();
            panel_arbol_categorias.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label_gestion_categorias;
        private Panel panel_creacion_categorias;
        private Label label_crear_categoria;
        private Label label_indicacion_crear_categoria;
        private TextBox textbox_nombre_categoria;
        private Button btn_crear_categoria;
        private ComboBox combobox_unidad_medida;
        private Label label_nombre_categoria;
        private Label label_unidad_medida_categoria;
        private Label label_contador_caracteres_nombre_categoria;
        private Label label_mensaje_error_nombre_categoria;
        private Panel panel_arbol_categorias;
        private Label label_arbol_categorias;
        private ImageList imagelist_treeview;
        private Panel panel_detalles_categoria;
        private System.Windows.Forms.Timer timer_ocultar_botones;
        public TreeView treeview_arbol_categorias;
        private Panel panel_mensaje_aviso;
        private Label label_aviso_categorias;
    }
}