namespace MarketPal
{
    partial class detalles_categoria
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
            label_detalles_categoria = new Label();
            label_nombre_categoria = new Label();
            textbox_nombre_categoria = new TextBox();
            label_unidad_medida_categoria = new Label();
            combobox_unidad_medida = new ComboBox();
            label_contador_caracteres_nombre_categoria = new Label();
            label_mensaje_error_nombre_categoria = new Label();
            label_numero_subcategorias = new Label();
            btn_editar_detalles_categoria = new Button();
            btn_eliminar_categoria = new Button();
            btn_guardar_detalles_categoria = new Button();
            btn_cancelar_cambios_categoria = new Button();
            SuspendLayout();
            // 
            // label_detalles_categoria
            // 
            label_detalles_categoria.BackColor = Color.FromArgb(255, 224, 183);
            label_detalles_categoria.Font = new Font("Lucida Sans", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_detalles_categoria.ForeColor = Color.FromArgb(250, 146, 31);
            label_detalles_categoria.Location = new Point(-4, 0);
            label_detalles_categoria.Name = "label_detalles_categoria";
            label_detalles_categoria.Size = new Size(597, 42);
            label_detalles_categoria.TabIndex = 1;
            label_detalles_categoria.Text = " Detalles de la categoría";
            label_detalles_categoria.TextAlign = ContentAlignment.MiddleLeft;
            label_detalles_categoria.Click += label_detalles_categoria_Click;
            // 
            // label_nombre_categoria
            // 
            label_nombre_categoria.AutoSize = true;
            label_nombre_categoria.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_nombre_categoria.ForeColor = SystemColors.ControlText;
            label_nombre_categoria.Location = new Point(17, 84);
            label_nombre_categoria.Name = "label_nombre_categoria";
            label_nombre_categoria.Size = new Size(76, 19);
            label_nombre_categoria.TabIndex = 8;
            label_nombre_categoria.Text = "Nombre";
            label_nombre_categoria.TextAlign = ContentAlignment.MiddleLeft;
            label_nombre_categoria.Click += label_nombre_categoria_Click;
            // 
            // textbox_nombre_categoria
            // 
            textbox_nombre_categoria.BackColor = SystemColors.ButtonHighlight;
            textbox_nombre_categoria.Enabled = false;
            textbox_nombre_categoria.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_nombre_categoria.ForeColor = SystemColors.GrayText;
            textbox_nombre_categoria.Location = new Point(17, 110);
            textbox_nombre_categoria.MaxLength = 50;
            textbox_nombre_categoria.Name = "textbox_nombre_categoria";
            textbox_nombre_categoria.Size = new Size(211, 28);
            textbox_nombre_categoria.TabIndex = 7;
            textbox_nombre_categoria.TextChanged += textbox_nombre_categoria_TextChanged;
            textbox_nombre_categoria.KeyPress += textbox_nombre_categoria_KeyPress;
            // 
            // label_unidad_medida_categoria
            // 
            label_unidad_medida_categoria.AutoSize = true;
            label_unidad_medida_categoria.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_unidad_medida_categoria.ForeColor = SystemColors.ControlText;
            label_unidad_medida_categoria.Location = new Point(249, 84);
            label_unidad_medida_categoria.Name = "label_unidad_medida_categoria";
            label_unidad_medida_categoria.Size = new Size(162, 19);
            label_unidad_medida_categoria.TabIndex = 10;
            label_unidad_medida_categoria.Text = "Unidad de medida";
            label_unidad_medida_categoria.TextAlign = ContentAlignment.MiddleLeft;
            label_unidad_medida_categoria.Click += label_unidad_medida_categoria_Click;
            // 
            // combobox_unidad_medida
            // 
            combobox_unidad_medida.BackColor = SystemColors.ButtonHighlight;
            combobox_unidad_medida.DropDownStyle = ComboBoxStyle.DropDownList;
            combobox_unidad_medida.Enabled = false;
            combobox_unidad_medida.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            combobox_unidad_medida.ForeColor = SystemColors.GrayText;
            combobox_unidad_medida.FormattingEnabled = true;
            combobox_unidad_medida.Location = new Point(249, 111);
            combobox_unidad_medida.Name = "combobox_unidad_medida";
            combobox_unidad_medida.Size = new Size(211, 27);
            combobox_unidad_medida.TabIndex = 9;
            combobox_unidad_medida.SelectedIndexChanged += combobox_unidad_medida_SelectedIndexChanged;
            // 
            // label_contador_caracteres_nombre_categoria
            // 
            label_contador_caracteres_nombre_categoria.AutoSize = true;
            label_contador_caracteres_nombre_categoria.Font = new Font("Lucida Sans", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_contador_caracteres_nombre_categoria.ForeColor = SystemColors.GrayText;
            label_contador_caracteres_nombre_categoria.Location = new Point(113, 87);
            label_contador_caracteres_nombre_categoria.Name = "label_contador_caracteres_nombre_categoria";
            label_contador_caracteres_nombre_categoria.Size = new Size(0, 15);
            label_contador_caracteres_nombre_categoria.TabIndex = 11;
            label_contador_caracteres_nombre_categoria.TextAlign = ContentAlignment.MiddleLeft;
            label_contador_caracteres_nombre_categoria.Click += label_contador_caracteres_nombre_categoria_Click;
            // 
            // label_mensaje_error_nombre_categoria
            // 
            label_mensaje_error_nombre_categoria.Font = new Font("Lucida Sans", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_mensaje_error_nombre_categoria.ForeColor = Color.Red;
            label_mensaje_error_nombre_categoria.Location = new Point(17, 141);
            label_mensaje_error_nombre_categoria.Name = "label_mensaje_error_nombre_categoria";
            label_mensaje_error_nombre_categoria.Size = new Size(211, 31);
            label_mensaje_error_nombre_categoria.TabIndex = 12;
            label_mensaje_error_nombre_categoria.Text = "El nombre ingresado ya está en uso.";
            label_mensaje_error_nombre_categoria.TextAlign = ContentAlignment.MiddleLeft;
            label_mensaje_error_nombre_categoria.Visible = false;
            label_mensaje_error_nombre_categoria.Click += label_mensaje_error_nombre_categoria_Click;
            // 
            // label_numero_subcategorias
            // 
            label_numero_subcategorias.AutoSize = true;
            label_numero_subcategorias.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_numero_subcategorias.ForeColor = SystemColors.ControlText;
            label_numero_subcategorias.Location = new Point(17, 186);
            label_numero_subcategorias.Name = "label_numero_subcategorias";
            label_numero_subcategorias.Size = new Size(0, 19);
            label_numero_subcategorias.TabIndex = 13;
            label_numero_subcategorias.TextAlign = ContentAlignment.MiddleLeft;
            label_numero_subcategorias.Click += label_numero_subcategorias_Click;
            // 
            // btn_editar_detalles_categoria
            // 
            btn_editar_detalles_categoria.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_editar_detalles_categoria.BackColor = Color.FromArgb(250, 146, 31);
            btn_editar_detalles_categoria.FlatAppearance.BorderColor = Color.Black;
            btn_editar_detalles_categoria.FlatAppearance.MouseDownBackColor = Color.FromArgb(211, 113, 3);
            btn_editar_detalles_categoria.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 119, 4);
            btn_editar_detalles_categoria.FlatStyle = FlatStyle.Flat;
            btn_editar_detalles_categoria.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_editar_detalles_categoria.Location = new Point(235, 214);
            btn_editar_detalles_categoria.Name = "btn_editar_detalles_categoria";
            btn_editar_detalles_categoria.Size = new Size(105, 29);
            btn_editar_detalles_categoria.TabIndex = 14;
            btn_editar_detalles_categoria.Text = "Editar";
            btn_editar_detalles_categoria.UseVisualStyleBackColor = false;
            btn_editar_detalles_categoria.Visible = false;
            btn_editar_detalles_categoria.Click += btn_editar_detalles_categoria_Click;
            // 
            // btn_eliminar_categoria
            // 
            btn_eliminar_categoria.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_eliminar_categoria.BackColor = Color.Transparent;
            btn_eliminar_categoria.FlatAppearance.BorderColor = Color.FromArgb(250, 146, 31);
            btn_eliminar_categoria.FlatAppearance.MouseDownBackColor = SystemColors.ScrollBar;
            btn_eliminar_categoria.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            btn_eliminar_categoria.FlatStyle = FlatStyle.Flat;
            btn_eliminar_categoria.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_eliminar_categoria.ForeColor = Color.FromArgb(250, 146, 31);
            btn_eliminar_categoria.Location = new Point(355, 214);
            btn_eliminar_categoria.Name = "btn_eliminar_categoria";
            btn_eliminar_categoria.Size = new Size(105, 29);
            btn_eliminar_categoria.TabIndex = 15;
            btn_eliminar_categoria.Text = "Eliminar";
            btn_eliminar_categoria.UseVisualStyleBackColor = false;
            btn_eliminar_categoria.Click += btn_eliminar_categoria_Click;
            // 
            // btn_guardar_detalles_categoria
            // 
            btn_guardar_detalles_categoria.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_guardar_detalles_categoria.BackColor = Color.FromArgb(250, 146, 31);
            btn_guardar_detalles_categoria.Enabled = false;
            btn_guardar_detalles_categoria.FlatAppearance.BorderColor = Color.Black;
            btn_guardar_detalles_categoria.FlatAppearance.MouseDownBackColor = Color.FromArgb(211, 113, 3);
            btn_guardar_detalles_categoria.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 119, 4);
            btn_guardar_detalles_categoria.FlatStyle = FlatStyle.Flat;
            btn_guardar_detalles_categoria.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_guardar_detalles_categoria.Location = new Point(235, 214);
            btn_guardar_detalles_categoria.Name = "btn_guardar_detalles_categoria";
            btn_guardar_detalles_categoria.Size = new Size(105, 29);
            btn_guardar_detalles_categoria.TabIndex = 16;
            btn_guardar_detalles_categoria.Text = "Guardar";
            btn_guardar_detalles_categoria.UseVisualStyleBackColor = false;
            btn_guardar_detalles_categoria.Visible = false;
            btn_guardar_detalles_categoria.Click += btn_guardar_detalles_categoria_Click;
            // 
            // btn_cancelar_cambios_categoria
            // 
            btn_cancelar_cambios_categoria.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cancelar_cambios_categoria.BackColor = Color.Transparent;
            btn_cancelar_cambios_categoria.FlatAppearance.BorderColor = Color.FromArgb(250, 146, 31);
            btn_cancelar_cambios_categoria.FlatAppearance.MouseDownBackColor = SystemColors.ScrollBar;
            btn_cancelar_cambios_categoria.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            btn_cancelar_cambios_categoria.FlatStyle = FlatStyle.Flat;
            btn_cancelar_cambios_categoria.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cancelar_cambios_categoria.ForeColor = Color.FromArgb(250, 146, 31);
            btn_cancelar_cambios_categoria.Location = new Point(355, 214);
            btn_cancelar_cambios_categoria.Name = "btn_cancelar_cambios_categoria";
            btn_cancelar_cambios_categoria.Size = new Size(105, 29);
            btn_cancelar_cambios_categoria.TabIndex = 17;
            btn_cancelar_cambios_categoria.Text = "Cancelar";
            btn_cancelar_cambios_categoria.UseVisualStyleBackColor = false;
            btn_cancelar_cambios_categoria.Visible = false;
            btn_cancelar_cambios_categoria.Click += btn_cancelar_cambios_categoria_Click;
            // 
            // detalles_categoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(476, 264);
            Controls.Add(btn_cancelar_cambios_categoria);
            Controls.Add(btn_guardar_detalles_categoria);
            Controls.Add(btn_eliminar_categoria);
            Controls.Add(btn_editar_detalles_categoria);
            Controls.Add(label_numero_subcategorias);
            Controls.Add(label_mensaje_error_nombre_categoria);
            Controls.Add(label_contador_caracteres_nombre_categoria);
            Controls.Add(label_unidad_medida_categoria);
            Controls.Add(combobox_unidad_medida);
            Controls.Add(label_nombre_categoria);
            Controls.Add(textbox_nombre_categoria);
            Controls.Add(label_detalles_categoria);
            Name = "detalles_categoria";
            Text = "detalles_categoria";
            Load += detalles_categoria_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_detalles_categoria;
        private Label label_nombre_categoria;
        private TextBox textbox_nombre_categoria;
        private Label label_unidad_medida_categoria;
        private ComboBox combobox_unidad_medida;
        private Label label_contador_caracteres_nombre_categoria;
        private Label label_mensaje_error_nombre_categoria;
        private Label label_numero_subcategorias;
        private Button btn_editar_detalles_categoria;
        private Button btn_eliminar_categoria;
        private Button btn_guardar_detalles_categoria;
        private Button btn_cancelar_cambios_categoria;
    }
}