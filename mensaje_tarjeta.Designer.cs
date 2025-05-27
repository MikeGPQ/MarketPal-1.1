namespace MarketPal
{
    partial class mensaje_tarjeta
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
            label_mensaje_tarjeta = new Label();
            textBox_id_tarjeta = new TextBox();
            btn_Cancelar = new Button();
            SuspendLayout();
            // 
            // label_mensaje_tarjeta
            // 
            label_mensaje_tarjeta.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_mensaje_tarjeta.Location = new Point(13, 14);
            label_mensaje_tarjeta.Margin = new Padding(4, 0, 4, 0);
            label_mensaje_tarjeta.Name = "label_mensaje_tarjeta";
            label_mensaje_tarjeta.Size = new Size(213, 27);
            label_mensaje_tarjeta.TabIndex = 7;
            label_mensaje_tarjeta.Text = "Acerque la tarjeta al lector...";
            label_mensaje_tarjeta.TextAlign = ContentAlignment.MiddleLeft;
            label_mensaje_tarjeta.Click += label_mensaje_tarjeta_Click;
            // 
            // textBox_id_tarjeta
            // 
            textBox_id_tarjeta.Font = new Font("Lucida Sans", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_id_tarjeta.ForeColor = SystemColors.GrayText;
            textBox_id_tarjeta.Location = new Point(13, 15);
            textBox_id_tarjeta.MaxLength = 10;
            textBox_id_tarjeta.Name = "textBox_id_tarjeta";
            textBox_id_tarjeta.Size = new Size(165, 23);
            textBox_id_tarjeta.TabIndex = 9;
            textBox_id_tarjeta.KeyPress += textBox_id_tarjeta_KeyPress;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = Color.FromArgb(250, 146, 31);
            btn_Cancelar.FlatAppearance.BorderColor = Color.Black;
            btn_Cancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(211, 113, 3);
            btn_Cancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 119, 4);
            btn_Cancelar.FlatStyle = FlatStyle.Flat;
            btn_Cancelar.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Cancelar.Location = new Point(132, 48);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(94, 29);
            btn_Cancelar.TabIndex = 10;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // mensaje_tarjeta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 253, 253);
            ClientSize = new Size(239, 88);
            Controls.Add(btn_Cancelar);
            Controls.Add(label_mensaje_tarjeta);
            Controls.Add(textBox_id_tarjeta);
            FormBorderStyle = FormBorderStyle.None;
            Name = "mensaje_tarjeta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mensaje_tarjeta";
            TopMost = true;
            Load += mensaje_tarjeta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_mensaje_tarjeta;
        private TextBox textBox_id_tarjeta;
        private Button btn_Cancelar;
    }
}