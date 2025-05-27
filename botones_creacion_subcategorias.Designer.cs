namespace MarketPal
{
    partial class botones_creacion_subcategorias
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
            btn_cancelar_creacion_subcategoria = new Button();
            btn_confirmar_creacion_subcategoria = new Button();
            SuspendLayout();
            // 
            // btn_cancelar_creacion_subcategoria
            // 
            btn_cancelar_creacion_subcategoria.FlatAppearance.BorderSize = 0;
            btn_cancelar_creacion_subcategoria.FlatAppearance.MouseDownBackColor = SystemColors.ScrollBar;
            btn_cancelar_creacion_subcategoria.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            btn_cancelar_creacion_subcategoria.FlatStyle = FlatStyle.Flat;
            btn_cancelar_creacion_subcategoria.Image = Properties.Resources.equis__2_;
            btn_cancelar_creacion_subcategoria.Location = new Point(38, 1);
            btn_cancelar_creacion_subcategoria.Name = "btn_cancelar_creacion_subcategoria";
            btn_cancelar_creacion_subcategoria.Size = new Size(32, 28);
            btn_cancelar_creacion_subcategoria.TabIndex = 3;
            btn_cancelar_creacion_subcategoria.UseVisualStyleBackColor = true;
            btn_cancelar_creacion_subcategoria.Click += btn_cancelar_creacion_subcategoria_Click;
            // 
            // btn_confirmar_creacion_subcategoria
            // 
            btn_confirmar_creacion_subcategoria.Enabled = false;
            btn_confirmar_creacion_subcategoria.FlatAppearance.BorderSize = 0;
            btn_confirmar_creacion_subcategoria.FlatAppearance.MouseDownBackColor = SystemColors.ScrollBar;
            btn_confirmar_creacion_subcategoria.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            btn_confirmar_creacion_subcategoria.FlatStyle = FlatStyle.Flat;
            btn_confirmar_creacion_subcategoria.Image = Properties.Resources.controlar1;
            btn_confirmar_creacion_subcategoria.Location = new Point(5, 1);
            btn_confirmar_creacion_subcategoria.Name = "btn_confirmar_creacion_subcategoria";
            btn_confirmar_creacion_subcategoria.Size = new Size(32, 28);
            btn_confirmar_creacion_subcategoria.TabIndex = 2;
            btn_confirmar_creacion_subcategoria.UseVisualStyleBackColor = true;
            btn_confirmar_creacion_subcategoria.Click += btn_confirmar_creacion_subcategoria_Click;
            // 
            // botones_creacion_subcategorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(88, 32);
            Controls.Add(btn_cancelar_creacion_subcategoria);
            Controls.Add(btn_confirmar_creacion_subcategoria);
            FormBorderStyle = FormBorderStyle.None;
            Name = "botones_creacion_subcategorias";
            StartPosition = FormStartPosition.Manual;
            Text = "botones_creacion_subcategorias";
            TransparencyKey = Color.White;
            Load += botones_creacion_subcategorias_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_cancelar_creacion_subcategoria;
        public Button btn_confirmar_creacion_subcategoria;
    }
}