namespace MarketPal
{
    partial class aviso_seleccion_categoria_subcategoria
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
            label_aviso_detalles_categoria = new Label();
            SuspendLayout();
            // 
            // label_aviso_detalles_categoria
            // 
            label_aviso_detalles_categoria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_aviso_detalles_categoria.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_aviso_detalles_categoria.ForeColor = Color.Black;
            label_aviso_detalles_categoria.Location = new Point(48, 96);
            label_aviso_detalles_categoria.Name = "label_aviso_detalles_categoria";
            label_aviso_detalles_categoria.Size = new Size(380, 59);
            label_aviso_detalles_categoria.TabIndex = 11;
            label_aviso_detalles_categoria.Text = "Seleccione una categoría o subcategoría para ver sus detalles.";
            label_aviso_detalles_categoria.TextAlign = ContentAlignment.MiddleCenter;
            label_aviso_detalles_categoria.Click += label_aviso_detalles_categoria_Click;
            // 
            // aviso_seleccion_categoria_subcategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(476, 264);
            Controls.Add(label_aviso_detalles_categoria);
            Name = "aviso_seleccion_categoria_subcategoria";
            Text = "aviso_seleccion_categoria_subcategoria";
            Load += aviso_seleccion_categoria_subcategoria_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label_aviso_detalles_categoria;
    }
}