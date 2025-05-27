namespace MarketPal
{
    partial class seccion_gestion_ventas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel_gestion_inventario = new Panel();
            btn_ventas = new Button();
            panel_navegacion = new Panel();
            btnReporteVentas = new Button();
            panel_navegacion.SuspendLayout();
            SuspendLayout();
            // 
            // panel_gestion_inventario
            // 
            panel_gestion_inventario.BackColor = Color.Transparent;
            panel_gestion_inventario.Location = new Point(0, 51);
            panel_gestion_inventario.Name = "panel_gestion_inventario";
            panel_gestion_inventario.Size = new Size(1207, 729);
            panel_gestion_inventario.TabIndex = 2;
            panel_gestion_inventario.Paint += panel_gestion_inventario_Paint;
            // 
            // btn_ventas
            // 
            btn_ventas.BackColor = Color.FromArgb(255, 224, 183);
            btn_ventas.FlatAppearance.BorderSize = 0;
            btn_ventas.FlatAppearance.MouseDownBackColor = Color.FromArgb(250, 146, 31);
            btn_ventas.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 186, 94);
            btn_ventas.FlatStyle = FlatStyle.Flat;
            btn_ventas.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_ventas.Location = new Point(0, 0);
            btn_ventas.Name = "btn_ventas";
            btn_ventas.Size = new Size(165, 51);
            btn_ventas.TabIndex = 3;
            btn_ventas.Text = "Cobro";
            btn_ventas.UseVisualStyleBackColor = false;
            btn_ventas.Click += btn_productos_Click;
            // 
            // panel_navegacion
            // 
            panel_navegacion.BackColor = Color.FromArgb(255, 224, 183);
            panel_navegacion.Controls.Add(btnReporteVentas);
            panel_navegacion.Controls.Add(btn_ventas);
            panel_navegacion.Dock = DockStyle.Top;
            panel_navegacion.Location = new Point(0, 0);
            panel_navegacion.Name = "panel_navegacion";
            panel_navegacion.Size = new Size(1207, 51);
            panel_navegacion.TabIndex = 4;
            panel_navegacion.Paint += panel_navegacion_Paint;
            // 
            // btnReporteVentas
            // 
            btnReporteVentas.BackColor = Color.FromArgb(255, 224, 183);
            btnReporteVentas.FlatAppearance.BorderSize = 0;
            btnReporteVentas.FlatAppearance.MouseDownBackColor = Color.FromArgb(250, 146, 31);
            btnReporteVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 186, 94);
            btnReporteVentas.FlatStyle = FlatStyle.Flat;
            btnReporteVentas.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReporteVentas.Location = new Point(165, 0);
            btnReporteVentas.Name = "btnReporteVentas";
            btnReporteVentas.Size = new Size(208, 51);
            btnReporteVentas.TabIndex = 4;
            btnReporteVentas.Text = "Reporte de Ventas";
            btnReporteVentas.UseVisualStyleBackColor = false;
            btnReporteVentas.Click += btnReporteVentas_Click;
            // 
            // seccion_gestion_ventas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1207, 780);
            Controls.Add(panel_navegacion);
            Controls.Add(panel_gestion_inventario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "seccion_gestion_ventas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MarketPal";
            Load += seccion_gestion_inventario_Load;
            panel_navegacion.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView datagrid_lista_productos;
        private Panel panel_gestion_inventario;
        private Panel panel_navegacion;
        public Button btn_ventas;
        public Button btnReporteVentas;
    }
}
