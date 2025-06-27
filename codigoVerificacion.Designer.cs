namespace MarketPal
{
    partial class codigoVerificacion
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
            btn_Cancel = new Button();
            label_mensaje = new Label();
            textBox_CodigoVerificacion = new TextBox();
            textBox_Ok = new Button();
            SuspendLayout();
            // 
            // btn_Cancel
            // 
            btn_Cancel.BackColor = Color.FromArgb(250, 146, 31);
            btn_Cancel.FlatAppearance.BorderColor = Color.Black;
            btn_Cancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(211, 113, 3);
            btn_Cancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 119, 4);
            btn_Cancel.FlatStyle = FlatStyle.Flat;
            btn_Cancel.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Cancel.Location = new Point(192, 72);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(94, 29);
            btn_Cancel.TabIndex = 13;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = false;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // label_mensaje
            // 
            label_mensaje.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_mensaje.Location = new Point(64, 19);
            label_mensaje.Margin = new Padding(4, 0, 4, 0);
            label_mensaje.Name = "label_mensaje";
            label_mensaje.Size = new Size(270, 27);
            label_mensaje.TabIndex = 11;
            label_mensaje.Text = "Coloque el codigo de verificacion";
            label_mensaje.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox_CodigoVerificacion
            // 
            textBox_CodigoVerificacion.Font = new Font("Lucida Sans", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_CodigoVerificacion.ForeColor = SystemColors.GrayText;
            textBox_CodigoVerificacion.Location = new Point(12, 75);
            textBox_CodigoVerificacion.MaxLength = 10;
            textBox_CodigoVerificacion.Name = "textBox_CodigoVerificacion";
            textBox_CodigoVerificacion.Size = new Size(165, 23);
            textBox_CodigoVerificacion.TabIndex = 12;
            // 
            // textBox_Ok
            // 
            textBox_Ok.BackColor = Color.White;
            textBox_Ok.Enabled = false;
            textBox_Ok.FlatAppearance.BorderColor = Color.FromArgb(250, 146, 31);
            textBox_Ok.FlatAppearance.MouseDownBackColor = SystemColors.ScrollBar;
            textBox_Ok.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            textBox_Ok.FlatStyle = FlatStyle.Flat;
            textBox_Ok.Font = new Font("Lucida Sans", 9F);
            textBox_Ok.ForeColor = Color.FromArgb(250, 146, 31);
            textBox_Ok.Location = new Point(293, 72);
            textBox_Ok.Margin = new Padding(4, 5, 4, 5);
            textBox_Ok.Name = "textBox_Ok";
            textBox_Ok.Size = new Size(94, 29);
            textBox_Ok.TabIndex = 14;
            textBox_Ok.Text = "Ok";
            textBox_Ok.UseVisualStyleBackColor = false;
            textBox_Ok.Click += textBox_Ok_Click;
            // 
            // codigoVerificacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 110);
            Controls.Add(textBox_Ok);
            Controls.Add(btn_Cancel);
            Controls.Add(label_mensaje);
            Controls.Add(textBox_CodigoVerificacion);
            FormBorderStyle = FormBorderStyle.None;
            Name = "codigoVerificacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "codigoVerificacion";
            TopMost = true;
            Load += codigoVerificacion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Cancel;
        private Label label_mensaje;
        private TextBox textBox_CodigoVerificacion;
        private Button textBox_Ok;
    }
}