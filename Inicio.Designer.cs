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
            textBox_Correo = new TextBox();
            textBox_Password = new TextBox();
            textBox_iniciarSesion = new Button();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox_Correo
            // 
            textBox_Correo.Font = new Font("Lucida Sans", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Correo.Location = new Point(504, 464);
            textBox_Correo.Margin = new Padding(4, 5, 4, 5);
            textBox_Correo.Name = "textBox_Correo";
            textBox_Correo.Size = new Size(337, 24);
            textBox_Correo.TabIndex = 0;
            textBox_Correo.TextChanged += textBox_Correo_TextChanged;
            // 
            // textBox_Password
            // 
            textBox_Password.Font = new Font("Lucida Sans", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Password.Location = new Point(504, 540);
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
            textBox_iniciarSesion.Location = new Point(576, 592);
            textBox_iniciarSesion.Margin = new Padding(4, 5, 4, 5);
            textBox_iniciarSesion.Name = "textBox_iniciarSesion";
            textBox_iniciarSesion.Size = new Size(192, 51);
            textBox_iniciarSesion.TabIndex = 2;
            textBox_iniciarSesion.Text = "Iniciar sesión";
            textBox_iniciarSesion.UseVisualStyleBackColor = true;
            textBox_iniciarSesion.Click += textBox_iniciarSesion_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(255, 224, 183);
            label5.Font = new Font("Lucida Sans", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(250, 146, 31);
            label5.Location = new Point(-3, 0);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(1349, 66);
            label5.TabIndex = 16;
            label5.Text = "MarketPal";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(504, 437);
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
            label2.Location = new Point(504, 513);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(121, 22);
            label2.TabIndex = 18;
            label2.Text = "Contraseña ";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ICON_ORANGE;
            pictureBox1.Location = new Point(502, 80);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(337, 332);
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
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1345, 749);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(textBox_iniciarSesion);
            Controls.Add(textBox_Password);
            Controls.Add(textBox_Correo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MarketPal";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Correo;
		private System.Windows.Forms.TextBox textBox_Password;
		private System.Windows.Forms.Button textBox_iniciarSesion;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label3;
	}
}