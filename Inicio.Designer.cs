namespace MarketPal
{
	partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            textBox_Correo = new TextBox();
            textBox_Password = new TextBox();
            textBox_iniciarSesion = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label_gestion_categorias = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox_Correo
            // 
            textBox_Correo.Font = new Font("Lucida Sans", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Correo.Location = new Point(504, 480);
            textBox_Correo.Margin = new Padding(4, 5, 4, 5);
            textBox_Correo.Name = "textBox_Correo";
            textBox_Correo.Size = new Size(337, 24);
            textBox_Correo.TabIndex = 0;
            textBox_Correo.TextChanged += textBox_Correo_TextChanged;
            // 
            // textBox_Password
            // 
            textBox_Password.Font = new Font("Lucida Sans", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Password.Location = new Point(504, 556);
            textBox_Password.Margin = new Padding(4, 5, 4, 5);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.PasswordChar = '*';
            textBox_Password.Size = new Size(337, 24);
            textBox_Password.TabIndex = 1;
            textBox_Password.UseSystemPasswordChar = true;
            textBox_Password.TextChanged += textBox_Password_TextChanged;
            // 
            // textBox_iniciarSesion
            // 
            textBox_iniciarSesion.Enabled = false;
            textBox_iniciarSesion.FlatAppearance.BorderColor = Color.FromArgb(250, 146, 31);
            textBox_iniciarSesion.FlatAppearance.MouseDownBackColor = SystemColors.ScrollBar;
            textBox_iniciarSesion.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            textBox_iniciarSesion.FlatStyle = FlatStyle.Flat;
            textBox_iniciarSesion.Font = new Font("Lucida Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_iniciarSesion.ForeColor = Color.FromArgb(250, 146, 31);
            textBox_iniciarSesion.Location = new Point(576, 608);
            textBox_iniciarSesion.Margin = new Padding(4, 5, 4, 5);
            textBox_iniciarSesion.Name = "textBox_iniciarSesion";
            textBox_iniciarSesion.Size = new Size(192, 51);
            textBox_iniciarSesion.TabIndex = 2;
            textBox_iniciarSesion.Text = "Iniciar sesión";
            textBox_iniciarSesion.UseVisualStyleBackColor = true;
            textBox_iniciarSesion.Click += textBox_iniciarSesion_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(504, 453);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(189, 22);
            label1.TabIndex = 17;
            label1.Text = "Correo electrónico ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(504, 529);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(121, 22);
            label2.TabIndex = 18;
            label2.Text = "Contraseña ";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(485, 106);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(391, 330);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(250, 146, 31);
            label3.Location = new Point(397, 656);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(549, 52);
            label3.TabIndex = 20;
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Visible = false;
            label3.Click += label3_Click;
            // 
            // label_gestion_categorias
            // 
            label_gestion_categorias.BackColor = Color.FromArgb(255, 224, 183);
            label_gestion_categorias.Font = new Font("Lucida Sans", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_gestion_categorias.ForeColor = Color.FromArgb(250, 146, 31);
            label_gestion_categorias.Location = new Point(0, -3);
            label_gestion_categorias.Name = "label_gestion_categorias";
            label_gestion_categorias.Size = new Size(1351, 63);
            label_gestion_categorias.TabIndex = 21;
            label_gestion_categorias.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(250, 146, 31);
            label4.Location = new Point(13, 718);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(51, 22);
            label4.TabIndex = 22;
            label4.Text = "v2.0";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1345, 749);
            Controls.Add(label4);
            Controls.Add(label_gestion_categorias);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_iniciarSesion);
            Controls.Add(textBox_Password);
            Controls.Add(textBox_Correo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MarketPal v2.0";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Correo;
		private System.Windows.Forms.TextBox textBox_Password;
		private System.Windows.Forms.Button textBox_iniciarSesion;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label3;
        private Label label_gestion_categorias;
        private Label label4;
    }
}