namespace MarketPal
{
    partial class mensaje_aviso
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mensaje_aviso));
            label_aviso = new Label();
            picturebox_imagen_aviso = new PictureBox();
            imagelist_aviso = new ImageList(components);
            btn_cerrar_aviso = new Button();
            ((System.ComponentModel.ISupportInitialize)picturebox_imagen_aviso).BeginInit();
            SuspendLayout();
            // 
            // label_aviso
            // 
            label_aviso.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_aviso.ForeColor = Color.LimeGreen;
            label_aviso.ImageAlign = ContentAlignment.MiddleLeft;
            label_aviso.Location = new Point(58, 6);
            label_aviso.Name = "label_aviso";
            label_aviso.Size = new Size(236, 37);
            label_aviso.TabIndex = 8;
            label_aviso.Text = "La subcategoría se ha eliminado exitosamente.";
            label_aviso.TextAlign = ContentAlignment.MiddleLeft;
            label_aviso.Click += label_aviso_Click;
            // 
            // picturebox_imagen_aviso
            // 
            picturebox_imagen_aviso.InitialImage = null;
            picturebox_imagen_aviso.Location = new Point(8, 5);
            picturebox_imagen_aviso.Name = "picturebox_imagen_aviso";
            picturebox_imagen_aviso.Size = new Size(43, 38);
            picturebox_imagen_aviso.SizeMode = PictureBoxSizeMode.Zoom;
            picturebox_imagen_aviso.TabIndex = 9;
            picturebox_imagen_aviso.TabStop = false;
            picturebox_imagen_aviso.Click += picturebox_imagen_aviso_Click;
            // 
            // imagelist_aviso
            // 
            imagelist_aviso.ColorDepth = ColorDepth.Depth32Bit;
            imagelist_aviso.ImageStream = (ImageListStreamer)resources.GetObject("imagelist_aviso.ImageStream");
            imagelist_aviso.TransparentColor = Color.Transparent;
            imagelist_aviso.Images.SetKeyName(0, "marca-de-verificacion.png");
            imagelist_aviso.Images.SetKeyName(1, "signo-de-exclamacion.png");
            // 
            // btn_cerrar_aviso
            // 
            btn_cerrar_aviso.BackColor = Color.Transparent;
            btn_cerrar_aviso.FlatAppearance.BorderSize = 0;
            btn_cerrar_aviso.FlatAppearance.MouseDownBackColor = SystemColors.ScrollBar;
            btn_cerrar_aviso.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            btn_cerrar_aviso.FlatStyle = FlatStyle.Flat;
            btn_cerrar_aviso.Image = Properties.Resources.equis__3___1_;
            btn_cerrar_aviso.Location = new Point(296, 1);
            btn_cerrar_aviso.Name = "btn_cerrar_aviso";
            btn_cerrar_aviso.Size = new Size(17, 17);
            btn_cerrar_aviso.TabIndex = 10;
            btn_cerrar_aviso.UseVisualStyleBackColor = false;
            btn_cerrar_aviso.Click += btn_cerrar_aviso_Click;
            // 
            // mensaje_aviso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 253, 253);
            ClientSize = new Size(314, 48);
            Controls.Add(btn_cerrar_aviso);
            Controls.Add(picturebox_imagen_aviso);
            Controls.Add(label_aviso);
            FormBorderStyle = FormBorderStyle.None;
            Name = "mensaje_aviso";
            StartPosition = FormStartPosition.Manual;
            Text = "aviso_nombre_subcategoria";
            Load += mensaje_aviso_Load;
            ((System.ComponentModel.ISupportInitialize)picturebox_imagen_aviso).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Label label_aviso;
        public PictureBox picturebox_imagen_aviso;
        public ImageList imagelist_aviso;
        public Button btn_cerrar_aviso;
    }
}