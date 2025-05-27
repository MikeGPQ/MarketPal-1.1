namespace MarketPal
{
	partial class GestionUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionUsuarios));
            textbox_Nombre = new TextBox();
            textbox_Correo = new TextBox();
            combobox_Rol = new ComboBox();
            button_Upload = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            listView_Usuarios = new ListView();
            fotoPerfil = new ImageList(components);
            button_Delete = new Button();
            textBox_Search = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label_ErrorNombre = new Label();
            label_ErrorCorreo = new Label();
            label_ErrorRol = new Label();
            SuspendLayout();
            // 
            // textbox_Nombre
            // 
            textbox_Nombre.Font = new Font("Lucida Sans", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_Nombre.ForeColor = SystemColors.GrayText;
            textbox_Nombre.Location = new Point(907, 325);
            textbox_Nombre.Margin = new Padding(5);
            textbox_Nombre.Name = "textbox_Nombre";
            textbox_Nombre.Size = new Size(273, 24);
            textbox_Nombre.TabIndex = 1;
            textbox_Nombre.TextChanged += textbox_Nombre_TextChanged;
            // 
            // textbox_Correo
            // 
            textbox_Correo.Font = new Font("Lucida Sans", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_Correo.ForeColor = SystemColors.GrayText;
            textbox_Correo.Location = new Point(907, 392);
            textbox_Correo.Margin = new Padding(5);
            textbox_Correo.Name = "textbox_Correo";
            textbox_Correo.Size = new Size(273, 24);
            textbox_Correo.TabIndex = 2;
            textbox_Correo.TextChanged += textbox_Correo_TextChanged;
            // 
            // combobox_Rol
            // 
            combobox_Rol.Font = new Font("Lucida Sans", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            combobox_Rol.ForeColor = Color.Black;
            combobox_Rol.FormattingEnabled = true;
            combobox_Rol.Items.AddRange(new object[] { "Administrador", "Usuario" });
            combobox_Rol.Location = new Point(907, 465);
            combobox_Rol.Margin = new Padding(5);
            combobox_Rol.Name = "combobox_Rol";
            combobox_Rol.Size = new Size(273, 24);
            combobox_Rol.TabIndex = 5;
            combobox_Rol.SelectedIndexChanged += combobox_Rol_SelectedIndexChanged;
            // 
            // button_Upload
            // 
            button_Upload.BackColor = Color.FromArgb(250, 146, 31);
            button_Upload.FlatAppearance.BorderColor = Color.Black;
            button_Upload.FlatAppearance.MouseDownBackColor = Color.FromArgb(211, 113, 3);
            button_Upload.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 119, 4);
            button_Upload.FlatStyle = FlatStyle.Flat;
            button_Upload.Font = new Font("Lucida Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Upload.Location = new Point(914, 563);
            button_Upload.Margin = new Padding(5);
            button_Upload.Name = "button_Upload";
            button_Upload.Size = new Size(101, 35);
            button_Upload.TabIndex = 6;
            button_Upload.Text = "???";
            button_Upload.UseVisualStyleBackColor = false;
            button_Upload.Click += button_Upload_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(841, 331);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 16);
            label1.TabIndex = 8;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(841, 395);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 16);
            label2.TabIndex = 9;
            label2.Text = "Correo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(841, 469);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(28, 16);
            label4.TabIndex = 11;
            label4.Text = "Rol";
            // 
            // listView_Usuarios
            // 
            listView_Usuarios.BackColor = Color.FromArgb(255, 224, 183);
            listView_Usuarios.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView_Usuarios.LargeImageList = fotoPerfil;
            listView_Usuarios.Location = new Point(16, 125);
            listView_Usuarios.Margin = new Padding(5);
            listView_Usuarios.Name = "listView_Usuarios";
            listView_Usuarios.Size = new Size(803, 591);
            listView_Usuarios.TabIndex = 12;
            listView_Usuarios.UseCompatibleStateImageBehavior = false;
            listView_Usuarios.ItemSelectionChanged += listView_Usuarios_ItemSelectionChanged;
            // 
            // fotoPerfil
            // 
            fotoPerfil.ColorDepth = ColorDepth.Depth8Bit;
            fotoPerfil.ImageStream = (ImageListStreamer)resources.GetObject("fotoPerfil.ImageStream");
            fotoPerfil.TransparentColor = Color.Transparent;
            fotoPerfil.Images.SetKeyName(0, "ICON_ORANGE.png");
            fotoPerfil.Images.SetKeyName(1, "PLUS_ORANGE.png");
            fotoPerfil.Images.SetKeyName(2, "ADMIN_ICON_ORANGE.png");
            fotoPerfil.Images.SetKeyName(3, "ICON_BLACK.png");
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
            button_Delete.Location = new Point(1022, 544);
            button_Delete.Margin = new Padding(5);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(101, 35);
            button_Delete.TabIndex = 13;
            button_Delete.Text = "Deshabilitar";
            button_Delete.UseVisualStyleBackColor = false;
            button_Delete.Click += button_Delete_Click;
            // 
            // textBox_Search
            // 
            textBox_Search.BackColor = SystemColors.Window;
            textBox_Search.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Search.ForeColor = SystemColors.GrayText;
            textBox_Search.Location = new Point(16, 91);
            textBox_Search.Margin = new Padding(5);
            textBox_Search.Name = "textBox_Search";
            textBox_Search.Size = new Size(803, 25);
            textBox_Search.TabIndex = 14;
            textBox_Search.TextChanged += textBox_Search_TextChanged;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(255, 224, 183);
            label5.Font = new Font("Lucida Sans", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(250, 146, 31);
            label5.Location = new Point(16, 13);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(1178, 67);
            label5.TabIndex = 15;
            label5.Text = "Gestión de Usuarios";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(895, 247);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(246, 26);
            label6.TabIndex = 18;
            label6.Text = "Detalles del Usuario";
            // 
            // label_ErrorNombre
            // 
            label_ErrorNombre.AutoSize = true;
            label_ErrorNombre.ForeColor = Color.FromArgb(250, 146, 31);
            label_ErrorNombre.Location = new Point(841, 357);
            label_ErrorNombre.Name = "label_ErrorNombre";
            label_ErrorNombre.Size = new Size(50, 20);
            label_ErrorNombre.TabIndex = 19;
            label_ErrorNombre.Text = "label3";
            label_ErrorNombre.Visible = false;
            // 
            // label_ErrorCorreo
            // 
            label_ErrorCorreo.AutoSize = true;
            label_ErrorCorreo.ForeColor = Color.FromArgb(250, 146, 31);
            label_ErrorCorreo.Location = new Point(841, 423);
            label_ErrorCorreo.Name = "label_ErrorCorreo";
            label_ErrorCorreo.Size = new Size(50, 20);
            label_ErrorCorreo.TabIndex = 20;
            label_ErrorCorreo.Text = "label3";
            label_ErrorCorreo.Visible = false;
            // 
            // label_ErrorRol
            // 
            label_ErrorRol.AutoSize = true;
            label_ErrorRol.ForeColor = Color.FromArgb(250, 146, 31);
            label_ErrorRol.Location = new Point(841, 496);
            label_ErrorRol.Name = "label_ErrorRol";
            label_ErrorRol.Size = new Size(50, 20);
            label_ErrorRol.TabIndex = 21;
            label_ErrorRol.Text = "label3";
            label_ErrorRol.Visible = false;
            // 
            // GestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1209, 729);
            Controls.Add(label_ErrorRol);
            Controls.Add(label_ErrorCorreo);
            Controls.Add(label_ErrorNombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox_Search);
            Controls.Add(button_Delete);
            Controls.Add(listView_Usuarios);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_Upload);
            Controls.Add(combobox_Rol);
            Controls.Add(textbox_Correo);
            Controls.Add(textbox_Nombre);
            Margin = new Padding(5);
            Name = "GestionUsuarios";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox textbox_Nombre;
		private System.Windows.Forms.TextBox textbox_Correo;
		private System.Windows.Forms.ComboBox combobox_Rol;
		private System.Windows.Forms.Button button_Upload;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ListView listView_Usuarios;
		private System.Windows.Forms.ImageList fotoPerfil;
		private System.Windows.Forms.Button button_Delete;
		private System.Windows.Forms.TextBox textBox_Search;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
        private Label label_ErrorNombre;
        private Label label_ErrorCorreo;
        private Label label_ErrorRol;
    }
}

