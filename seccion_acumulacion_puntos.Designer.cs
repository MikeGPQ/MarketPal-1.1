namespace MarketPal
{
    partial class seccion_acumulacion_puntos
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
            lblClienteNombre = new Label();
            lblPuntosActuales = new Label();
            btnGuardarPuntos = new Button();
            btnCancelar = new Button();
            btnBuscarCliente = new Button();
            txtTelefono = new TextBox();
            lblPuntosObtenidos = new Label();
            lblPuntosTotales = new Label();
            lblErrorBusqueda = new Label();
            lbl_ue = new Label();
            label_detalles_producto = new Label();
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
            // lblClienteNombre
            // 
            lblClienteNombre.AutoSize = true;
            lblClienteNombre.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClienteNombre.Location = new Point(10, 189);
            lblClienteNombre.Name = "lblClienteNombre";
            lblClienteNombre.Size = new Size(70, 17);
            lblClienteNombre.TabIndex = 1;
            lblClienteNombre.Text = "Nombre:";
            lblClienteNombre.Click += lblClienteNombre_Click;
            // 
            // lblPuntosActuales
            // 
            lblPuntosActuales.AutoSize = true;
            lblPuntosActuales.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPuntosActuales.Location = new Point(10, 223);
            lblPuntosActuales.Name = "lblPuntosActuales";
            lblPuntosActuales.Size = new Size(125, 17);
            lblPuntosActuales.TabIndex = 2;
            lblPuntosActuales.Text = "Puntos actuales:";
            lblPuntosActuales.Click += lblPuntosActuales_Click;
            // 
            // btnGuardarPuntos
            // 
            btnGuardarPuntos.BackColor = Color.FromArgb(250, 146, 31);
            btnGuardarPuntos.FlatAppearance.BorderColor = Color.Black;
            btnGuardarPuntos.FlatAppearance.MouseDownBackColor = Color.FromArgb(211, 113, 3);
            btnGuardarPuntos.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 119, 4);
            btnGuardarPuntos.FlatStyle = FlatStyle.Flat;
            btnGuardarPuntos.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardarPuntos.Location = new Point(13, 328);
            btnGuardarPuntos.Margin = new Padding(3, 4, 3, 4);
            btnGuardarPuntos.Name = "btnGuardarPuntos";
            btnGuardarPuntos.Size = new Size(319, 31);
            btnGuardarPuntos.TabIndex = 4;
            btnGuardarPuntos.Text = "Guardar puntos";
            btnGuardarPuntos.UseVisualStyleBackColor = false;
            btnGuardarPuntos.Click += btnGuardarPuntos_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(250, 146, 31);
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
            btnCancelar.TabIndex = 5;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
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
            btnBuscarCliente.TabIndex = 6;
            btnBuscarCliente.Text = "Buscar cliente";
            btnBuscarCliente.UseVisualStyleBackColor = false;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.ForeColor = SystemColors.GrayText;
            txtTelefono.Location = new Point(13, 95);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.MaxLength = 10;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(205, 25);
            txtTelefono.TabIndex = 7;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // lblPuntosObtenidos
            // 
            lblPuntosObtenidos.AutoSize = true;
            lblPuntosObtenidos.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPuntosObtenidos.Location = new Point(10, 257);
            lblPuntosObtenidos.Name = "lblPuntosObtenidos";
            lblPuntosObtenidos.Size = new Size(135, 17);
            lblPuntosObtenidos.TabIndex = 8;
            lblPuntosObtenidos.Text = "Puntos a obtener:";
            lblPuntosObtenidos.Click += lblPuntosObtenidos_Click;
            // 
            // lblPuntosTotales
            // 
            lblPuntosTotales.AutoSize = true;
            lblPuntosTotales.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPuntosTotales.Location = new Point(10, 291);
            lblPuntosTotales.Name = "lblPuntosTotales";
            lblPuntosTotales.Size = new Size(115, 17);
            lblPuntosTotales.TabIndex = 9;
            lblPuntosTotales.Text = "Puntos totales:";
            // 
            // lblErrorBusqueda
            // 
            lblErrorBusqueda.AutoSize = true;
            lblErrorBusqueda.Font = new Font("Lucida Sans", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblErrorBusqueda.ForeColor = Color.Red;
            lblErrorBusqueda.Location = new Point(13, 124);
            lblErrorBusqueda.Name = "lblErrorBusqueda";
            lblErrorBusqueda.Size = new Size(154, 15);
            lblErrorBusqueda.TabIndex = 57;
            lblErrorBusqueda.Text = "Cliente no encontrado.";
            lblErrorBusqueda.TextAlign = ContentAlignment.MiddleLeft;
            lblErrorBusqueda.Visible = false;
            lblErrorBusqueda.Click += lblErrorBusqueda_Click;
            // 
            // lbl_ue
            // 
            lbl_ue.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ue.Location = new Point(10, 141);
            lbl_ue.Name = "lbl_ue";
            lbl_ue.Size = new Size(335, 35);
            lbl_ue.TabIndex = 58;
            lbl_ue.Text = "Cliente encontrado. A continuación, se muestran sus datos:";
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
            label_detalles_producto.TabIndex = 59;
            label_detalles_producto.Text = " Acumulación de puntos";
            label_detalles_producto.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // form_puntos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(345, 369);
            Controls.Add(btnCancelar);
            Controls.Add(lbl_ue);
            Controls.Add(lblErrorBusqueda);
            Controls.Add(lblPuntosTotales);
            Controls.Add(lblPuntosObtenidos);
            Controls.Add(txtTelefono);
            Controls.Add(btnBuscarCliente);
            Controls.Add(btnGuardarPuntos);
            Controls.Add(lblPuntosActuales);
            Controls.Add(lblClienteNombre);
            Controls.Add(label1);
            Controls.Add(label_detalles_producto);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "form_puntos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MarketPal";
            Load += seccion_acumulacion_puntos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblClienteNombre;
        private Label lblPuntosActuales;
        private Button btnGuardarPuntos;
        private Button btnCancelar;
        private Button btnBuscarCliente;
        private TextBox txtTelefono;
        private Label lblPuntosObtenidos;
        private Label lblPuntosTotales;
        private Label lblErrorBusqueda;
        private Label lbl_ue;
        private Label label_detalles_producto;
    }
}