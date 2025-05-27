namespace MarketPal
{
    partial class botones_categoria
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
            btn_agregar_categoria = new Button();
            btn_eliminar_categoria = new Button();
            SuspendLayout();
            // 
            // btn_agregar_categoria
            // 
            btn_agregar_categoria.FlatAppearance.BorderSize = 0;
            btn_agregar_categoria.FlatAppearance.MouseDownBackColor = SystemColors.ScrollBar;
            btn_agregar_categoria.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            btn_agregar_categoria.FlatStyle = FlatStyle.Flat;
            btn_agregar_categoria.Image = Properties.Resources.agregar_cat3;
            btn_agregar_categoria.Location = new Point(5, 1);
            btn_agregar_categoria.Name = "btn_agregar_categoria";
            btn_agregar_categoria.Size = new Size(32, 28);
            btn_agregar_categoria.TabIndex = 0;
            btn_agregar_categoria.UseVisualStyleBackColor = true;
            btn_agregar_categoria.Click += btn_agregar_categoria_Click;
            btn_agregar_categoria.MouseEnter += btn_agregar_categoria_MouseEnter;
            btn_agregar_categoria.MouseLeave += btn_agregar_categoria_MouseLeave;
            // 
            // btn_eliminar_categoria
            // 
            btn_eliminar_categoria.FlatAppearance.BorderSize = 0;
            btn_eliminar_categoria.FlatAppearance.MouseDownBackColor = SystemColors.ScrollBar;
            btn_eliminar_categoria.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            btn_eliminar_categoria.FlatStyle = FlatStyle.Flat;
            btn_eliminar_categoria.Image = Properties.Resources.borrar_cat;
            btn_eliminar_categoria.Location = new Point(38, 1);
            btn_eliminar_categoria.Name = "btn_eliminar_categoria";
            btn_eliminar_categoria.Size = new Size(32, 28);
            btn_eliminar_categoria.TabIndex = 1;
            btn_eliminar_categoria.UseVisualStyleBackColor = true;
            btn_eliminar_categoria.Click += btn_eliminar_categoria_Click;
            btn_eliminar_categoria.MouseEnter += btn_eliminar_categoria_MouseEnter;
            btn_eliminar_categoria.MouseLeave += btn_eliminar_categoria_MouseLeave;
            // 
            // botones_categoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(88, 32);
            Controls.Add(btn_eliminar_categoria);
            Controls.Add(btn_agregar_categoria);
            FormBorderStyle = FormBorderStyle.None;
            Name = "botones_categoria";
            StartPosition = FormStartPosition.Manual;
            Text = "botones_categoria";
            TopMost = true;
            TransparencyKey = Color.White;
            Load += botones_categoria_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_agregar_categoria;
        private Button btn_eliminar_categoria;
    }
}