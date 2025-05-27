namespace MarketPal
{
    partial class vista_previa_ticket
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
            btnCancelar = new Button();
            textBoxVistaPrevia = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(250, 146, 31);
            label1.Font = new Font("Lucida Sans", 13.8F, FontStyle.Bold);
            label1.Location = new Point(-2, -2);
            label1.Name = "label1";
            label1.Size = new Size(338, 28);
            label1.TabIndex = 0;
            label1.Text = "Ticket de compra";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
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
            btnCancelar.Location = new Point(301, 0);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(35, 28);
            btnCancelar.TabIndex = 9;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // textBoxVistaPrevia
            // 
            textBoxVistaPrevia.BackColor = Color.White;
            textBoxVistaPrevia.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxVistaPrevia.Location = new Point(-2, 26);
            textBoxVistaPrevia.Multiline = true;
            textBoxVistaPrevia.Name = "textBoxVistaPrevia";
            textBoxVistaPrevia.ReadOnly = true;
            textBoxVistaPrevia.ScrollBars = ScrollBars.Vertical;
            textBoxVistaPrevia.Size = new Size(338, 326);
            textBoxVistaPrevia.TabIndex = 0;
            textBoxVistaPrevia.TextAlign = HorizontalAlignment.Center;
            textBoxVistaPrevia.TextChanged += textBoxVistaPrevia_TextChanged;
            // 
            // vista_previa_ticket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(335, 350);
            Controls.Add(textBoxVistaPrevia);
            Controls.Add(btnCancelar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "vista_previa_ticket";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "vista_previa_ticket";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCancelar;
        private TextBox textBoxVistaPrevia;
    }
}