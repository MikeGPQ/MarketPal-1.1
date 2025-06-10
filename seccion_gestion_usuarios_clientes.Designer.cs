using System.Drawing;
using System.Windows.Forms;

namespace MarketPal
{
    partial class seccion_gestion_usuarios_clientes
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
            btn_categorias = new Button();
            panel_gestion_inventario = new Panel();
            btn_productos = new Button();
            panel_navegacion = new Panel();
            btn_entradasSalidas = new Button();
            panel_navegacion.SuspendLayout();
            SuspendLayout();
            // 
            // btn_categorias
            // 
            btn_categorias.BackColor = Color.FromArgb(255, 224, 183);
            btn_categorias.FlatAppearance.BorderSize = 0;
            btn_categorias.FlatAppearance.MouseDownBackColor = Color.FromArgb(248, 140, 30);
            btn_categorias.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 186, 94);
            btn_categorias.FlatStyle = FlatStyle.Flat;
            btn_categorias.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_categorias.Location = new Point(165, 0);
            btn_categorias.Name = "btn_categorias";
            btn_categorias.Size = new Size(165, 51);
            btn_categorias.TabIndex = 1;
            btn_categorias.Text = "Clientes";
            btn_categorias.UseVisualStyleBackColor = false;
            btn_categorias.Click += btn_categorias_Click_1;
            // 
            // panel_gestion_inventario
            // 
            panel_gestion_inventario.BackColor = Color.Transparent;
            panel_gestion_inventario.Location = new Point(0, 51);
            panel_gestion_inventario.Name = "panel_gestion_inventario";
            panel_gestion_inventario.Size = new Size(1207, 729);
            panel_gestion_inventario.TabIndex = 2;
            panel_gestion_inventario.Paint += panel_gestion_inventario_Paint_1;
            // 
            // btn_productos
            // 
            btn_productos.BackColor = Color.FromArgb(255, 224, 183);
            btn_productos.FlatAppearance.BorderSize = 0;
            btn_productos.FlatAppearance.MouseDownBackColor = Color.FromArgb(248, 140, 30);
            btn_productos.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 186, 94);
            btn_productos.FlatStyle = FlatStyle.Flat;
            btn_productos.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_productos.Location = new Point(0, 0);
            btn_productos.Name = "btn_productos";
            btn_productos.Size = new Size(165, 51);
            btn_productos.TabIndex = 3;
            btn_productos.Text = "Usuarios";
            btn_productos.UseVisualStyleBackColor = false;
            btn_productos.Click += btn_productos_Click_1;
            // 
            // panel_navegacion
            // 
            panel_navegacion.BackColor = Color.FromArgb(255, 224, 183);
            panel_navegacion.Controls.Add(btn_entradasSalidas);
            panel_navegacion.Controls.Add(btn_categorias);
            panel_navegacion.Controls.Add(btn_productos);
            panel_navegacion.Dock = DockStyle.Top;
            panel_navegacion.Location = new Point(0, 0);
            panel_navegacion.Name = "panel_navegacion";
            panel_navegacion.Size = new Size(1207, 51);
            panel_navegacion.TabIndex = 4;
            panel_navegacion.Paint += panel_navegacion_Paint_1;
            // 
            // btn_entradasSalidas
            // 
            btn_entradasSalidas.BackColor = Color.FromArgb(255, 224, 183);
            btn_entradasSalidas.FlatAppearance.BorderSize = 0;
            btn_entradasSalidas.FlatAppearance.MouseDownBackColor = Color.FromArgb(248, 140, 30);
            btn_entradasSalidas.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 186, 94);
            btn_entradasSalidas.FlatStyle = FlatStyle.Flat;
            btn_entradasSalidas.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_entradasSalidas.Location = new Point(331, 0);
            btn_entradasSalidas.Name = "btn_entradasSalidas";
            btn_entradasSalidas.Size = new Size(165, 51);
            btn_entradasSalidas.TabIndex = 2;
            btn_entradasSalidas.Text = "Auditorias";
            btn_entradasSalidas.UseVisualStyleBackColor = false;
            btn_entradasSalidas.Click += btn_entradasSalidas_Click;
            // 
            // seccion_gestion_usuarios_clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1207, 780);
            Controls.Add(panel_navegacion);
            Controls.Add(panel_gestion_inventario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "seccion_gestion_usuarios_clientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MarketPal";
            Load += seccion_gestion_usuarios_clientes_Load;
            panel_navegacion.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView datagrid_lista_productos;
        private Panel panel_gestion_inventario;
        private Panel panel_navegacion;
        public Button btn_categorias;
        public Button btn_productos;
        public Button btn_entradasSalidas;
    }
}
