namespace MarketPal
{
    partial class boton_subcategoria
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
            btn_eliminar_subcategoria = new Button();
            SuspendLayout();
            // 
            // btn_eliminar_subcategoria
            // 
            btn_eliminar_subcategoria.FlatAppearance.BorderSize = 0;
            btn_eliminar_subcategoria.FlatAppearance.MouseDownBackColor = SystemColors.ScrollBar;
            btn_eliminar_subcategoria.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            btn_eliminar_subcategoria.FlatStyle = FlatStyle.Flat;
            btn_eliminar_subcategoria.Image = Properties.Resources.borrar_cat;
            btn_eliminar_subcategoria.Location = new Point(5, 1);
            btn_eliminar_subcategoria.Name = "btn_eliminar_subcategoria";
            btn_eliminar_subcategoria.Size = new Size(32, 28);
            btn_eliminar_subcategoria.TabIndex = 2;
            btn_eliminar_subcategoria.UseVisualStyleBackColor = true;
            btn_eliminar_subcategoria.Click += btn_eliminar_subcategoria_Click;
            btn_eliminar_subcategoria.MouseEnter += btn_eliminar_subcategoria_MouseEnter;
            btn_eliminar_subcategoria.MouseLeave += btn_eliminar_subcategoria_MouseLeave;
            // 
            // boton_subcategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(88, 32);
            Controls.Add(btn_eliminar_subcategoria);
            FormBorderStyle = FormBorderStyle.None;
            Name = "boton_subcategoria";
            StartPosition = FormStartPosition.Manual;
            Text = "boton_subcategoria";
            TransparencyKey = Color.White;
            Load += boton_subcategoria_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_eliminar_subcategoria;
    }
}