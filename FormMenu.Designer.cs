namespace WindowsFormsApp1
{
	partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            panel2 = new Panel();
            btnTarjeta = new Button();
            pictureBox_CerrarSesion = new PictureBox();
            pictureBox1 = new PictureBox();
            label_rol_usuario = new Label();
            label_nombre_usuario = new Label();
            btn_inventario = new Button();
            btn_ventas = new Button();
            button3 = new Button();
            panel1 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_CerrarSesion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 200, 130);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnTarjeta);
            panel2.Controls.Add(pictureBox_CerrarSesion);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label_rol_usuario);
            panel2.Controls.Add(label_nombre_usuario);
            panel2.Controls.Add(btn_inventario);
            panel2.Controls.Add(btn_ventas);
            panel2.Controls.Add(button3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(241, 780);
            panel2.TabIndex = 1;
            // 
            // btnTarjeta
            // 
            btnTarjeta.BackColor = Color.FromArgb(255, 200, 130);
            btnTarjeta.FlatAppearance.BorderSize = 0;
            btnTarjeta.FlatAppearance.MouseDownBackColor = Color.FromArgb(250, 146, 31);
            btnTarjeta.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 186, 94);
            btnTarjeta.FlatStyle = FlatStyle.Flat;
            btnTarjeta.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTarjeta.Location = new Point(-2, 194);
            btnTarjeta.Name = "btnTarjeta";
            btnTarjeta.Size = new Size(242, 65);
            btnTarjeta.TabIndex = 13;
            btnTarjeta.Text = "Tarjetas";
            btnTarjeta.UseVisualStyleBackColor = false;
            btnTarjeta.Click += btnTarjeta_Click;
            // 
            // pictureBox_CerrarSesion
            // 
            pictureBox_CerrarSesion.Image = MarketPal.Properties.Resources.cerrar_sesion_de_usuario__2___2_;
            pictureBox_CerrarSesion.Location = new Point(2, 740);
            pictureBox_CerrarSesion.Name = "pictureBox_CerrarSesion";
            pictureBox_CerrarSesion.Size = new Size(38, 37);
            pictureBox_CerrarSesion.TabIndex = 12;
            pictureBox_CerrarSesion.TabStop = false;
            pictureBox_CerrarSesion.Click += pictureBox_CerrarSesion_Click;
            pictureBox_CerrarSesion.MouseEnter += pictureBox_CerrarSesion_MouseEnter;
            pictureBox_CerrarSesion.MouseLeave += pictureBox_CerrarSesion_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = MarketPal.Properties.Resources.ICON_ORANGE1;
            pictureBox1.Location = new Point(1, 662);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label_rol_usuario
            // 
            label_rol_usuario.AutoEllipsis = true;
            label_rol_usuario.Font = new Font("Lucida Sans", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_rol_usuario.Location = new Point(59, 702);
            label_rol_usuario.Name = "label_rol_usuario";
            label_rol_usuario.Size = new Size(106, 19);
            label_rol_usuario.TabIndex = 10;
            label_rol_usuario.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_nombre_usuario
            // 
            label_nombre_usuario.AutoEllipsis = true;
            label_nombre_usuario.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_nombre_usuario.Location = new Point(59, 664);
            label_nombre_usuario.Name = "label_nombre_usuario";
            label_nombre_usuario.Size = new Size(178, 38);
            label_nombre_usuario.TabIndex = 9;
            label_nombre_usuario.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn_inventario
            // 
            btn_inventario.BackColor = Color.FromArgb(255, 200, 130);
            btn_inventario.FlatAppearance.BorderSize = 0;
            btn_inventario.FlatAppearance.MouseDownBackColor = Color.FromArgb(250, 146, 31);
            btn_inventario.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 186, 94);
            btn_inventario.FlatStyle = FlatStyle.Flat;
            btn_inventario.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_inventario.Location = new Point(-1, 64);
            btn_inventario.Name = "btn_inventario";
            btn_inventario.Size = new Size(242, 65);
            btn_inventario.TabIndex = 8;
            btn_inventario.Text = "Inventario";
            btn_inventario.UseVisualStyleBackColor = false;
            btn_inventario.Click += btn_inventario_Click;
            // 
            // btn_ventas
            // 
            btn_ventas.BackColor = Color.FromArgb(255, 200, 130);
            btn_ventas.FlatAppearance.BorderSize = 0;
            btn_ventas.FlatAppearance.MouseDownBackColor = Color.FromArgb(250, 146, 31);
            btn_ventas.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 186, 94);
            btn_ventas.FlatStyle = FlatStyle.Flat;
            btn_ventas.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_ventas.Location = new Point(-1, -1);
            btn_ventas.Name = "btn_ventas";
            btn_ventas.Size = new Size(242, 65);
            btn_ventas.TabIndex = 7;
            btn_ventas.Text = "Ventas";
            btn_ventas.UseVisualStyleBackColor = false;
            btn_ventas.Click += btn_ventas_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 200, 130);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(250, 146, 31);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 186, 94);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(-1, 129);
            button3.Name = "button3";
            button3.Size = new Size(242, 65);
            button3.TabIndex = 4;
            button3.Text = "Usuarios y Clientes";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(241, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1207, 780);
            panel1.TabIndex = 2;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1448, 780);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MarketPal v2.0";
            FormClosing += FormMenu_FormClosing;
            Load += FormMenu_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_CerrarSesion).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panel2;
		public System.Windows.Forms.Button button3;
		public System.Windows.Forms.Button btn_inventario;
		public System.Windows.Forms.Button btn_ventas;
		private System.Windows.Forms.Panel panel1;
        private Label label_rol_usuario;
        private Label label_nombre_usuario;
        private PictureBox pictureBox1;
        private PictureBox pictureBox_CerrarSesion;
        public Button btnTarjeta;
    }
}