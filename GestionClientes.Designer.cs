namespace MarketPal
{
	partial class GestionClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionClientes));
            button_Uppload = new Button();
            textbox_Nombre = new TextBox();
            textbox_Correo = new TextBox();
            textbox_Telefono = new TextBox();
            listView_Clientes = new ListView();
            imageList1 = new ImageList(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button_Delete = new Button();
            textBox_Search = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            textBox_Puntos = new TextBox();
            label7 = new Label();
            textBox_Tarjeta = new TextBox();
            button_Tarjeta = new Button();
            btnModificarTarjeta = new Button();
            label_ErrorCorreo = new Label();
            label_ErrorCelular = new Label();
            label_ErrorTarjeta = new Label();
            label_ErrorNombre = new Label();
            SuspendLayout();
            // 
            // button_Uppload
            // 
            button_Uppload.BackColor = Color.FromArgb(250, 146, 31);
            button_Uppload.FlatAppearance.BorderColor = Color.Black;
            button_Uppload.FlatAppearance.MouseDownBackColor = Color.FromArgb(211, 113, 3);
            button_Uppload.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 119, 4);
            button_Uppload.FlatStyle = FlatStyle.Flat;
            button_Uppload.Font = new Font("Lucida Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Uppload.Location = new Point(910, 638);
            button_Uppload.Margin = new Padding(4, 5, 4, 5);
            button_Uppload.Name = "button_Uppload";
            button_Uppload.Size = new Size(100, 35);
            button_Uppload.TabIndex = 0;
            button_Uppload.Text = "???";
            button_Uppload.UseVisualStyleBackColor = false;
            button_Uppload.Click += button_Uppload_Click;
            // 
            // textbox_Nombre
            // 
            textbox_Nombre.Font = new Font("Lucida Sans", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_Nombre.ForeColor = SystemColors.GrayText;
            textbox_Nombre.Location = new Point(910, 305);
            textbox_Nombre.Margin = new Padding(4, 5, 4, 5);
            textbox_Nombre.Name = "textbox_Nombre";
            textbox_Nombre.Size = new Size(273, 24);
            textbox_Nombre.TabIndex = 1;
            textbox_Nombre.TextChanged += textbox_Nombre_TextChanged;
            // 
            // textbox_Correo
            // 
            textbox_Correo.Font = new Font("Lucida Sans", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_Correo.ForeColor = SystemColors.GrayText;
            textbox_Correo.Location = new Point(910, 372);
            textbox_Correo.Margin = new Padding(4, 5, 4, 5);
            textbox_Correo.Name = "textbox_Correo";
            textbox_Correo.Size = new Size(273, 24);
            textbox_Correo.TabIndex = 2;
            textbox_Correo.TextChanged += textbox_Correo_TextChanged;
            // 
            // textbox_Telefono
            // 
            textbox_Telefono.Font = new Font("Lucida Sans", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_Telefono.ForeColor = SystemColors.GrayText;
            textbox_Telefono.Location = new Point(910, 438);
            textbox_Telefono.Margin = new Padding(4, 5, 4, 5);
            textbox_Telefono.MaxLength = 10;
            textbox_Telefono.Name = "textbox_Telefono";
            textbox_Telefono.Size = new Size(273, 24);
            textbox_Telefono.TabIndex = 3;
            textbox_Telefono.TextChanged += textbox_Telefono_TextChanged;
            textbox_Telefono.KeyPress += textbox_Telefono_KeyPress;
            // 
            // listView_Clientes
            // 
            listView_Clientes.BackColor = Color.FromArgb(255, 224, 183);
            listView_Clientes.LargeImageList = imageList1;
            listView_Clientes.Location = new Point(16, 125);
            listView_Clientes.Margin = new Padding(4, 5, 4, 5);
            listView_Clientes.Name = "listView_Clientes";
            listView_Clientes.Size = new Size(803, 590);
            listView_Clientes.TabIndex = 4;
            listView_Clientes.UseCompatibleStateImageBehavior = false;
            listView_Clientes.ItemSelectionChanged += listView_Clientes_ItemSelectionChanged;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "ICON_ORANGE.png");
            imageList1.Images.SetKeyName(1, "PLUS_ORANGE.png");
            imageList1.Images.SetKeyName(2, "ICON_BLACK.png");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(843, 310);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 16);
            label1.TabIndex = 5;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(843, 377);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 16);
            label2.TabIndex = 6;
            label2.Text = "Correo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Lucida Sans", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(843, 442);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(52, 16);
            label3.TabIndex = 7;
            label3.Text = "Celular";
            label3.Click += label3_Click;
            // 
            // button_Delete
            // 
            button_Delete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_Delete.BackColor = Color.White;
            button_Delete.FlatAppearance.BorderColor = Color.FromArgb(250, 146, 31);
            button_Delete.FlatAppearance.MouseDownBackColor = SystemColors.ScrollBar;
            button_Delete.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            button_Delete.FlatStyle = FlatStyle.Flat;
            button_Delete.Font = new Font("Lucida Sans", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Delete.ForeColor = Color.FromArgb(250, 146, 31);
            button_Delete.Location = new Point(1024, 638);
            button_Delete.Margin = new Padding(4, 5, 4, 5);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(100, 35);
            button_Delete.TabIndex = 8;
            button_Delete.Text = "Deshabilitar";
            button_Delete.UseVisualStyleBackColor = false;
            button_Delete.Click += button_Delete_Click;
            // 
            // textBox_Search
            // 
            textBox_Search.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Search.ForeColor = SystemColors.GrayText;
            textBox_Search.Location = new Point(16, 90);
            textBox_Search.Margin = new Padding(4, 5, 4, 5);
            textBox_Search.Name = "textBox_Search";
            textBox_Search.Size = new Size(803, 25);
            textBox_Search.TabIndex = 9;
            textBox_Search.TextChanged += textBox_Search_TextChanged;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(255, 224, 183);
            label5.Font = new Font("Lucida Sans", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(250, 146, 31);
            label5.Location = new Point(16, 14);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(1178, 66);
            label5.TabIndex = 16;
            label5.Text = "Gestión de Clientes";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(896, 222);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(235, 26);
            label4.TabIndex = 17;
            label4.Text = "Detalles del Cliente";
            label4.Click += label4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Lucida Sans", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(843, 510);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(51, 16);
            label6.TabIndex = 19;
            label6.Text = "Puntos";
            // 
            // textBox_Puntos
            // 
            textBox_Puntos.Enabled = false;
            textBox_Puntos.Font = new Font("Lucida Sans", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Puntos.ForeColor = SystemColors.GrayText;
            textBox_Puntos.Location = new Point(910, 506);
            textBox_Puntos.Margin = new Padding(4, 5, 4, 5);
            textBox_Puntos.Name = "textBox_Puntos";
            textBox_Puntos.Size = new Size(273, 24);
            textBox_Puntos.TabIndex = 18;
            textBox_Puntos.TextChanged += textBox_Puntos_TextChanged;
            textBox_Puntos.KeyPress += textBox_Puntos_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Lucida Sans", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(843, 579);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(54, 16);
            label7.TabIndex = 21;
            label7.Text = "Tarjeta";
            label7.Visible = false;
            // 
            // textBox_Tarjeta
            // 
            textBox_Tarjeta.Enabled = false;
            textBox_Tarjeta.Font = new Font("Lucida Sans", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Tarjeta.ForeColor = SystemColors.GrayText;
            textBox_Tarjeta.Location = new Point(910, 575);
            textBox_Tarjeta.Margin = new Padding(4, 5, 4, 5);
            textBox_Tarjeta.MaxLength = 10;
            textBox_Tarjeta.Name = "textBox_Tarjeta";
            textBox_Tarjeta.Size = new Size(232, 24);
            textBox_Tarjeta.TabIndex = 20;
            textBox_Tarjeta.Visible = false;
            textBox_Tarjeta.TextChanged += textBox_Tarjeta_TextChanged;
            textBox_Tarjeta.KeyPress += textBox_Tarjeta_KeyPress;
            // 
            // button_Tarjeta
            // 
            button_Tarjeta.BackColor = Color.FromArgb(255, 224, 183);
            button_Tarjeta.FlatAppearance.BorderColor = Color.Black;
            button_Tarjeta.FlatAppearance.MouseDownBackColor = Color.FromArgb(211, 113, 3);
            button_Tarjeta.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 119, 4);
            button_Tarjeta.FlatStyle = FlatStyle.Flat;
            button_Tarjeta.Font = new Font("Lucida Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Tarjeta.Location = new Point(942, 570);
            button_Tarjeta.Margin = new Padding(4, 5, 4, 5);
            button_Tarjeta.Name = "button_Tarjeta";
            button_Tarjeta.Size = new Size(153, 35);
            button_Tarjeta.TabIndex = 22;
            button_Tarjeta.Text = "Asignar tarjeta";
            button_Tarjeta.UseVisualStyleBackColor = false;
            button_Tarjeta.Click += button_Tarjeta_Click;
            // 
            // btnModificarTarjeta
            // 
            btnModificarTarjeta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnModificarTarjeta.BackColor = Color.FromArgb(250, 146, 31);
            btnModificarTarjeta.FlatAppearance.BorderColor = Color.Black;
            btnModificarTarjeta.FlatAppearance.MouseDownBackColor = SystemColors.ScrollBar;
            btnModificarTarjeta.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            btnModificarTarjeta.FlatStyle = FlatStyle.Flat;
            btnModificarTarjeta.Font = new Font("Lucida Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModificarTarjeta.ForeColor = Color.FromArgb(250, 146, 31);
            btnModificarTarjeta.Image = (Image)resources.GetObject("btnModificarTarjeta.Image");
            btnModificarTarjeta.Location = new Point(1150, 575);
            btnModificarTarjeta.Margin = new Padding(4, 5, 4, 5);
            btnModificarTarjeta.Name = "btnModificarTarjeta";
            btnModificarTarjeta.Size = new Size(33, 24);
            btnModificarTarjeta.TabIndex = 23;
            btnModificarTarjeta.UseVisualStyleBackColor = false;
            btnModificarTarjeta.Click += btnModificarTarjeta_Click;
            // 
            // label_ErrorCorreo
            // 
            label_ErrorCorreo.AutoSize = true;
            label_ErrorCorreo.ForeColor = Color.FromArgb(250, 146, 31);
            label_ErrorCorreo.Location = new Point(843, 403);
            label_ErrorCorreo.Name = "label_ErrorCorreo";
            label_ErrorCorreo.Size = new Size(50, 20);
            label_ErrorCorreo.TabIndex = 24;
            label_ErrorCorreo.Text = "label8";
            label_ErrorCorreo.Visible = false;
            // 
            // label_ErrorCelular
            // 
            label_ErrorCelular.AutoSize = true;
            label_ErrorCelular.ForeColor = Color.FromArgb(250, 146, 31);
            label_ErrorCelular.Location = new Point(843, 467);
            label_ErrorCelular.Name = "label_ErrorCelular";
            label_ErrorCelular.Size = new Size(50, 20);
            label_ErrorCelular.TabIndex = 25;
            label_ErrorCelular.Text = "label8";
            label_ErrorCelular.Visible = false;
            // 
            // label_ErrorTarjeta
            // 
            label_ErrorTarjeta.AutoSize = true;
            label_ErrorTarjeta.ForeColor = Color.FromArgb(250, 146, 31);
            label_ErrorTarjeta.Location = new Point(843, 606);
            label_ErrorTarjeta.Name = "label_ErrorTarjeta";
            label_ErrorTarjeta.Size = new Size(50, 20);
            label_ErrorTarjeta.TabIndex = 26;
            label_ErrorTarjeta.Text = "label8";
            label_ErrorTarjeta.Visible = false;
            // 
            // label_ErrorNombre
            // 
            label_ErrorNombre.AutoSize = true;
            label_ErrorNombre.ForeColor = Color.FromArgb(250, 146, 31);
            label_ErrorNombre.Location = new Point(843, 336);
            label_ErrorNombre.Name = "label_ErrorNombre";
            label_ErrorNombre.Size = new Size(50, 20);
            label_ErrorNombre.TabIndex = 27;
            label_ErrorNombre.Text = "label8";
            label_ErrorNombre.Visible = false;
            // 
            // GestionClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1209, 729);
            Controls.Add(label_ErrorNombre);
            Controls.Add(label_ErrorTarjeta);
            Controls.Add(label_ErrorCelular);
            Controls.Add(label_ErrorCorreo);
            Controls.Add(btnModificarTarjeta);
            Controls.Add(button_Tarjeta);
            Controls.Add(label7);
            Controls.Add(textBox_Tarjeta);
            Controls.Add(label6);
            Controls.Add(textBox_Puntos);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(textBox_Search);
            Controls.Add(button_Delete);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listView_Clientes);
            Controls.Add(textbox_Telefono);
            Controls.Add(textbox_Correo);
            Controls.Add(textbox_Nombre);
            Controls.Add(button_Uppload);
            Margin = new Padding(4, 5, 4, 5);
            Name = "GestionClientes";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button_Uppload;
		private System.Windows.Forms.TextBox textbox_Nombre;
		private System.Windows.Forms.TextBox textbox_Correo;
		private System.Windows.Forms.TextBox textbox_Telefono;
		private System.Windows.Forms.ListView listView_Clientes;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Button button_Delete;
		private System.Windows.Forms.TextBox textBox_Search;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
        private Label label6;
        private TextBox textBox_Puntos;
        public TextBox textBox_Tarjeta;
        public Label label7;
        public Button button_Tarjeta;
        public Button btnModificarTarjeta;
        private Label label_ErrorCorreo;
        private Label label_ErrorCelular;
        private Label label_ErrorTarjeta;
        private Label label_ErrorNombre;
    }
}