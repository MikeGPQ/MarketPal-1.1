namespace MarketPal
{
    partial class botones_venta_productos
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
            btn_eliminar_producto = new Button();
            btn_agregar_producto = new Button();
            SuspendLayout();
            // 
            // btn_eliminar_producto
            // 
            btn_eliminar_producto.BackColor = Color.Transparent;
            btn_eliminar_producto.Enabled = false;
            btn_eliminar_producto.FlatAppearance.BorderSize = 0;
            btn_eliminar_producto.FlatAppearance.MouseDownBackColor = SystemColors.ScrollBar;
            btn_eliminar_producto.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            btn_eliminar_producto.FlatStyle = FlatStyle.Flat;
            btn_eliminar_producto.Image = Properties.Resources.menos1;
            btn_eliminar_producto.Location = new Point(64, -4);
            btn_eliminar_producto.Margin = new Padding(3, 2, 3, 2);
            btn_eliminar_producto.Name = "btn_eliminar_producto";
            btn_eliminar_producto.Size = new Size(16, 22);
            btn_eliminar_producto.TabIndex = 1;
            btn_eliminar_producto.UseVisualStyleBackColor = false;
            btn_eliminar_producto.Click += btn_eliminar_producto_Click;
            btn_eliminar_producto.MouseLeave += btn_eliminar_producto_MouseLeave;
            btn_eliminar_producto.MouseHover += btn_eliminar_producto_MouseHover;
            // 
            // btn_agregar_producto
            // 
            btn_agregar_producto.BackColor = Color.Transparent;
            btn_agregar_producto.FlatAppearance.BorderSize = 0;
            btn_agregar_producto.FlatAppearance.MouseDownBackColor = SystemColors.ScrollBar;
            btn_agregar_producto.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            btn_agregar_producto.FlatStyle = FlatStyle.Flat;
            btn_agregar_producto.Image = Properties.Resources.mas__1_1;
            btn_agregar_producto.Location = new Point(87, -4);
            btn_agregar_producto.Margin = new Padding(3, 2, 3, 2);
            btn_agregar_producto.Name = "btn_agregar_producto";
            btn_agregar_producto.Size = new Size(16, 22);
            btn_agregar_producto.TabIndex = 0;
            btn_agregar_producto.UseVisualStyleBackColor = false;
            btn_agregar_producto.Click += btn_agregar_producto_Click;
            btn_agregar_producto.MouseLeave += btn_agregar_producto_MouseLeave;
            btn_agregar_producto.MouseHover += btn_agregar_producto_MouseHover;
            // 
            // botones_venta_productos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(105, 49);
            Controls.Add(btn_eliminar_producto);
            Controls.Add(btn_agregar_producto);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "botones_venta_productos";
            StartPosition = FormStartPosition.Manual;
            Text = "MarketPal";
            TransparencyKey = Color.White;
            Load += botones_venta_productos_Load;
            ResumeLayout(false);
        }

        #endregion

        public System.Windows.Forms.Button btn_agregar_producto;
        public System.Windows.Forms.Button btn_eliminar_producto;
    }
}