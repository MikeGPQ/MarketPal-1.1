namespace MarketPal
{
    partial class seccion_uso_puntos
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
            label1 = new Label();
            lblClienteEncontrado = new Label();
            txtTelefonoTarjeta = new TextBox();
            btnBuscarCliente = new Button();
            lblPuntosDisponibles = new Label();
            lblPuntosRestantes = new Label();
            lblPuntosAUsar = new Label();
            btnAplicarDescuento = new Button();
            btnCancelar = new Button();
            label_detalles_producto = new Label();
            lbl_ue = new Label();
            lblErrorBusqueda = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 50);
            label1.Name = "label1";
            label1.Size = new Size(335, 35);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el número de teléfono del cliente o acerque su tarjeta al lector.";
            label1.Click += label1_Click;
            // 
            // lblClienteEncontrado
            // 
            lblClienteEncontrado.AutoSize = true;
            lblClienteEncontrado.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClienteEncontrado.Location = new Point(10, 189);
            lblClienteEncontrado.Name = "lblClienteEncontrado";
            lblClienteEncontrado.Size = new Size(70, 17);
            lblClienteEncontrado.TabIndex = 1;
            lblClienteEncontrado.Text = "Nombre:";
            lblClienteEncontrado.Click += lblClienteNombre_Click;
            // 
            // txtTelefonoTarjeta
            // 
            txtTelefonoTarjeta.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefonoTarjeta.ForeColor = SystemColors.GrayText;
            txtTelefonoTarjeta.Location = new Point(13, 95);
            txtTelefonoTarjeta.Margin = new Padding(3, 4, 3, 4);
            txtTelefonoTarjeta.MaxLength = 10;
            txtTelefonoTarjeta.Name = "txtTelefonoTarjeta";
            txtTelefonoTarjeta.Size = new Size(205, 25);
            txtTelefonoTarjeta.TabIndex = 2;
            txtTelefonoTarjeta.TextChanged += txtTelefonoTarjeta_TextChanged;
            txtTelefonoTarjeta.KeyPress += txtTelefonoTarjeta_KeyPress;
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.BackColor = Color.FromArgb(255, 224, 183);
            btnBuscarCliente.Enabled = false;
            btnBuscarCliente.FlatAppearance.BorderColor = Color.Black;
            btnBuscarCliente.FlatAppearance.MouseDownBackColor = Color.FromArgb(211, 113, 3);
            btnBuscarCliente.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 119, 4);
            btnBuscarCliente.FlatStyle = FlatStyle.Flat;
            btnBuscarCliente.Font = new Font("Lucida Sans", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscarCliente.Location = new Point(228, 95);
            btnBuscarCliente.Margin = new Padding(3, 4, 3, 4);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(105, 25);
            btnBuscarCliente.TabIndex = 3;
            btnBuscarCliente.Text = "Buscar cliente";
            btnBuscarCliente.UseVisualStyleBackColor = false;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // lblPuntosDisponibles
            // 
            lblPuntosDisponibles.AutoSize = true;
            lblPuntosDisponibles.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPuntosDisponibles.Location = new Point(10, 223);
            lblPuntosDisponibles.Name = "lblPuntosDisponibles";
            lblPuntosDisponibles.Size = new Size(150, 17);
            lblPuntosDisponibles.TabIndex = 4;
            lblPuntosDisponibles.Text = "Puntos disponibles:";
            lblPuntosDisponibles.Click += lblPuntosDisponibles_Click;
            // 
            // lblPuntosRestantes
            // 
            lblPuntosRestantes.AutoSize = true;
            lblPuntosRestantes.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPuntosRestantes.Location = new Point(10, 291);
            lblPuntosRestantes.Name = "lblPuntosRestantes";
            lblPuntosRestantes.Size = new Size(130, 17);
            lblPuntosRestantes.TabIndex = 5;
            lblPuntosRestantes.Text = "Puntos restantes:";
            lblPuntosRestantes.Click += lblPuntosRestantes_Click;
            // 
            // lblPuntosAUsar
            // 
            lblPuntosAUsar.AutoSize = true;
            lblPuntosAUsar.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPuntosAUsar.Location = new Point(10, 257);
            lblPuntosAUsar.Name = "lblPuntosAUsar";
            lblPuntosAUsar.Size = new Size(108, 17);
            lblPuntosAUsar.TabIndex = 6;
            lblPuntosAUsar.Text = "Puntos a usar:";
            lblPuntosAUsar.Click += lblPuntosUsados_Click;
            // 
            // btnAplicarDescuento
            // 
            btnAplicarDescuento.BackColor = Color.FromArgb(250, 146, 31);
            btnAplicarDescuento.FlatAppearance.BorderColor = Color.Black;
            btnAplicarDescuento.FlatAppearance.MouseDownBackColor = Color.FromArgb(211, 113, 3);
            btnAplicarDescuento.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 119, 4);
            btnAplicarDescuento.FlatStyle = FlatStyle.Flat;
            btnAplicarDescuento.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAplicarDescuento.Location = new Point(13, 328);
            btnAplicarDescuento.Margin = new Padding(3, 4, 3, 4);
            btnAplicarDescuento.Name = "btnAplicarDescuento";
            btnAplicarDescuento.Size = new Size(319, 31);
            btnAplicarDescuento.TabIndex = 7;
            btnAplicarDescuento.Text = "Aplicar descuento";
            btnAplicarDescuento.UseVisualStyleBackColor = false;
            btnAplicarDescuento.Click += btnAplicarDescuento_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(250, 146, 31);
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(250, 146, 31);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseDownBackColor = SystemColors.ScrollBar;
            btnCancelar.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(250, 146, 31);
            btnCancelar.Image = Properties.Resources.equis__3___1_;
            btnCancelar.Location = new Point(320, 1);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(25, 23);
            btnCancelar.TabIndex = 8;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label_detalles_producto
            // 
            label_detalles_producto.BackColor = Color.FromArgb(250, 146, 31);
            label_detalles_producto.BorderStyle = BorderStyle.FixedSingle;
            label_detalles_producto.Font = new Font("Lucida Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_detalles_producto.ForeColor = SystemColors.ControlText;
            label_detalles_producto.Location = new Point(-3, 0);
            label_detalles_producto.Name = "label_detalles_producto";
            label_detalles_producto.Size = new Size(368, 38);
            label_detalles_producto.TabIndex = 54;
            label_detalles_producto.Text = " Uso de puntos";
            label_detalles_producto.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_ue
            // 
            lbl_ue.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ue.Location = new Point(10, 141);
            lbl_ue.Name = "lbl_ue";
            lbl_ue.Size = new Size(335, 35);
            lbl_ue.TabIndex = 55;
            lbl_ue.Text = "Cliente encontrado. A continuación, se muestran sus datos:";
            lbl_ue.Click += lbl_ue_Click;
            // 
            // lblErrorBusqueda
            // 
            lblErrorBusqueda.AutoSize = true;
            lblErrorBusqueda.Font = new Font("Lucida Sans", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblErrorBusqueda.ForeColor = Color.Red;
            lblErrorBusqueda.Location = new Point(13, 124);
            lblErrorBusqueda.Name = "lblErrorBusqueda";
            lblErrorBusqueda.Size = new Size(154, 15);
            lblErrorBusqueda.TabIndex = 56;
            lblErrorBusqueda.Text = "Cliente no encontrado.";
            lblErrorBusqueda.TextAlign = ContentAlignment.MiddleLeft;
            lblErrorBusqueda.Visible = false;
            // 
            // seccion_uso_puntos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(345, 369);
            Controls.Add(btnCancelar);
            Controls.Add(lblErrorBusqueda);
            Controls.Add(lbl_ue);
            Controls.Add(label_detalles_producto);
            Controls.Add(btnAplicarDescuento);
            Controls.Add(lblPuntosAUsar);
            Controls.Add(lblPuntosRestantes);
            Controls.Add(lblPuntosDisponibles);
            Controls.Add(btnBuscarCliente);
            Controls.Add(txtTelefonoTarjeta);
            Controls.Add(lblClienteEncontrado);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "seccion_uso_puntos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MarketPal";
            Load += seccion_uso_puntos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblClienteEncontrado;
        private TextBox txtTelefonoTarjeta;
        private Button btnBuscarCliente;
        private Label lblPuntosDisponibles;
        private Label lblPuntosRestantes;
        private Label lblPuntosAUsar;
        private Button btnAplicarDescuento;
        private Button btnCancelar;
        private Label label_detalles_producto;
        private Label lbl_ue;
        private Label lblErrorBusqueda;
    }
}