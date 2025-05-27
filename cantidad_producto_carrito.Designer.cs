namespace MarketPal
{
    partial class cantidad_producto_carrito
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
            label_indicacion = new Label();
            textbox_cantidad = new TextBox();
            label_ingresar_cantidad = new Label();
            label_mensaje_error = new Label();
            btn_guardar_cantidad = new Button();
            btn_cancelar = new Button();
            SuspendLayout();
            // 
            // label_indicacion
            // 
            label_indicacion.BackColor = Color.FromArgb(250, 146, 31);
            label_indicacion.BorderStyle = BorderStyle.FixedSingle;
            label_indicacion.Font = new Font("Lucida Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_indicacion.ForeColor = SystemColors.ControlText;
            label_indicacion.Location = new Point(-4, -1);
            label_indicacion.Margin = new Padding(4, 0, 4, 0);
            label_indicacion.Name = "label_indicacion";
            label_indicacion.Size = new Size(407, 40);
            label_indicacion.TabIndex = 24;
            label_indicacion.TextAlign = ContentAlignment.MiddleLeft;
            label_indicacion.Click += label_indicacion_Click;
            // 
            // textbox_cantidad
            // 
            textbox_cantidad.BackColor = SystemColors.ButtonHighlight;
            textbox_cantidad.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_cantidad.ForeColor = SystemColors.GrayText;
            textbox_cantidad.Location = new Point(35, 73);
            textbox_cantidad.Margin = new Padding(4, 5, 4, 5);
            textbox_cantidad.Name = "textbox_cantidad";
            textbox_cantidad.Size = new Size(323, 25);
            textbox_cantidad.TabIndex = 27;
            textbox_cantidad.TextChanged += textbox_cantidad_TextChanged;
            textbox_cantidad.KeyPress += textbox_cantidad_KeyPress;
            // 
            // label_ingresar_cantidad
            // 
            label_ingresar_cantidad.AutoEllipsis = true;
            label_ingresar_cantidad.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_ingresar_cantidad.ForeColor = SystemColors.ControlText;
            label_ingresar_cantidad.Location = new Point(35, 49);
            label_ingresar_cantidad.Margin = new Padding(4, 0, 4, 0);
            label_ingresar_cantidad.Name = "label_ingresar_cantidad";
            label_ingresar_cantidad.Size = new Size(76, 19);
            label_ingresar_cantidad.TabIndex = 26;
            label_ingresar_cantidad.Text = "Cantidad";
            // 
            // label_mensaje_error
            // 
            label_mensaje_error.AutoEllipsis = true;
            label_mensaje_error.Font = new Font("Lucida Sans", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_mensaje_error.ForeColor = Color.Red;
            label_mensaje_error.Location = new Point(35, 103);
            label_mensaje_error.Margin = new Padding(4, 0, 4, 0);
            label_mensaje_error.Name = "label_mensaje_error";
            label_mensaje_error.Size = new Size(323, 30);
            label_mensaje_error.TabIndex = 28;
            label_mensaje_error.Visible = false;
            label_mensaje_error.Click += label_mensaje_error_Click;
            // 
            // btn_guardar_cantidad
            // 
            btn_guardar_cantidad.BackColor = Color.FromArgb(250, 146, 31);
            btn_guardar_cantidad.Enabled = false;
            btn_guardar_cantidad.FlatAppearance.BorderColor = Color.Black;
            btn_guardar_cantidad.FlatAppearance.MouseDownBackColor = Color.FromArgb(211, 113, 3);
            btn_guardar_cantidad.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 119, 4);
            btn_guardar_cantidad.FlatStyle = FlatStyle.Flat;
            btn_guardar_cantidad.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_guardar_cantidad.Location = new Point(205, 137);
            btn_guardar_cantidad.Margin = new Padding(4, 5, 4, 5);
            btn_guardar_cantidad.Name = "btn_guardar_cantidad";
            btn_guardar_cantidad.Size = new Size(87, 27);
            btn_guardar_cantidad.TabIndex = 29;
            btn_guardar_cantidad.Text = "Guardar";
            btn_guardar_cantidad.UseVisualStyleBackColor = false;
            btn_guardar_cantidad.Click += btn_guardar_cantidad_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.Transparent;
            btn_cancelar.FlatAppearance.BorderColor = Color.FromArgb(250, 146, 31);
            btn_cancelar.FlatAppearance.MouseDownBackColor = SystemColors.ScrollBar;
            btn_cancelar.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            btn_cancelar.FlatStyle = FlatStyle.Flat;
            btn_cancelar.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cancelar.ForeColor = Color.FromArgb(250, 146, 31);
            btn_cancelar.Location = new Point(300, 137);
            btn_cancelar.Margin = new Padding(4, 5, 4, 5);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(87, 27);
            btn_cancelar.TabIndex = 30;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // cantidad_producto_carrito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(394, 171);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_guardar_cantidad);
            Controls.Add(label_mensaje_error);
            Controls.Add(textbox_cantidad);
            Controls.Add(label_ingresar_cantidad);
            Controls.Add(label_indicacion);
            FormBorderStyle = FormBorderStyle.None;
            Name = "cantidad_producto_carrito";
            StartPosition = FormStartPosition.Manual;
            Text = "cantidad_producto_carrito";
            Load += cantidad_producto_carrito_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_indicacion;
        private TextBox textbox_cantidad;
        private Label label_ingresar_cantidad;
        private Label label_mensaje_error;
        private Button btn_guardar_cantidad;
        private Button btn_cancelar;
    }
}