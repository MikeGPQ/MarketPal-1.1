namespace MarketPal
{
    partial class seccion_reporte_ventas
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(seccion_reporte_ventas));
            label_reportes_de_ventas = new Label();
            dataGridView1 = new DataGridView();
            ColumnID = new DataGridViewTextBoxColumn();
            ColumnUsuarioVendedor = new DataGridViewTextBoxColumn();
            ColumnFechaHora = new DataGridViewTextBoxColumn();
            ColumnSubtotalVenta = new DataGridViewTextBoxColumn();
            ColumnDescuentoAplicadoVenta = new DataGridViewTextBoxColumn();
            ColumnTotalVenta = new DataGridViewTextBoxColumn();
            ColumnMontoRecibidoVenta = new DataGridViewTextBoxColumn();
            ColumnCambioVenta = new DataGridViewTextBoxColumn();
            ColumnVerTicket = new DataGridViewImageColumn();
            label_personalizar = new Label();
            label_nombre_empresa = new Label();
            label_direccion_empresa = new Label();
            label_mensaje_despedida = new Label();
            panel1 = new Panel();
            textBox_telefono_empresa = new TextBox();
            label_telefono_empresa = new Label();
            button_vista_previa = new Button();
            button_guardar_ticket = new Button();
            textBox_mensaje_despedida = new TextBox();
            textBox_direccion_empresa = new TextBox();
            textBox_nombre_empresa = new TextBox();
            comboBoxFecha = new ComboBox();
            comboBoxVendedor = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            button_limpiar_filtros = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label_reportes_de_ventas
            // 
            label_reportes_de_ventas.BackColor = Color.FromArgb(255, 224, 183);
            label_reportes_de_ventas.Font = new Font("Lucida Sans", 16.2F, FontStyle.Bold);
            label_reportes_de_ventas.ForeColor = Color.FromArgb(250, 146, 31);
            label_reportes_de_ventas.Location = new Point(21, 16);
            label_reportes_de_ventas.Margin = new Padding(5, 0, 5, 0);
            label_reportes_de_ventas.Name = "label_reportes_de_ventas";
            label_reportes_de_ventas.Size = new Size(1168, 49);
            label_reportes_de_ventas.TabIndex = 0;
            label_reportes_de_ventas.Text = "Reporte de Ventas";
            label_reportes_de_ventas.TextAlign = ContentAlignment.MiddleCenter;
            label_reportes_de_ventas.Click += label_reportes_de_ventas_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(255, 224, 183);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 224, 183);
            dataGridViewCellStyle1.Font = new Font("Lucida Sans", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 224, 183);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnID, ColumnUsuarioVendedor, ColumnFechaHora, ColumnSubtotalVenta, ColumnDescuentoAplicadoVenta, ColumnTotalVenta, ColumnMontoRecibidoVenta, ColumnCambioVenta, ColumnVerTicket });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 224, 183);
            dataGridViewCellStyle2.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(250, 146, 31);
            dataGridView1.Location = new Point(21, 124);
            dataGridView1.Margin = new Padding(5);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RightToLeft = RightToLeft.No;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 224, 183);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(827, 593);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ColumnID
            // 
            ColumnID.HeaderText = "ID";
            ColumnID.MinimumWidth = 6;
            ColumnID.Name = "ColumnID";
            ColumnID.ReadOnly = true;
            // 
            // ColumnUsuarioVendedor
            // 
            ColumnUsuarioVendedor.HeaderText = "Usuario Vendedor";
            ColumnUsuarioVendedor.MinimumWidth = 6;
            ColumnUsuarioVendedor.Name = "ColumnUsuarioVendedor";
            ColumnUsuarioVendedor.ReadOnly = true;
            // 
            // ColumnFechaHora
            // 
            ColumnFechaHora.HeaderText = "Fecha y Hora";
            ColumnFechaHora.MinimumWidth = 6;
            ColumnFechaHora.Name = "ColumnFechaHora";
            ColumnFechaHora.ReadOnly = true;
            // 
            // ColumnSubtotalVenta
            // 
            ColumnSubtotalVenta.HeaderText = "Subtotal";
            ColumnSubtotalVenta.MinimumWidth = 6;
            ColumnSubtotalVenta.Name = "ColumnSubtotalVenta";
            ColumnSubtotalVenta.ReadOnly = true;
            // 
            // ColumnDescuentoAplicadoVenta
            // 
            ColumnDescuentoAplicadoVenta.HeaderText = "Descuento por Puntos";
            ColumnDescuentoAplicadoVenta.MinimumWidth = 6;
            ColumnDescuentoAplicadoVenta.Name = "ColumnDescuentoAplicadoVenta";
            ColumnDescuentoAplicadoVenta.ReadOnly = true;
            // 
            // ColumnTotalVenta
            // 
            ColumnTotalVenta.HeaderText = "Total";
            ColumnTotalVenta.MinimumWidth = 6;
            ColumnTotalVenta.Name = "ColumnTotalVenta";
            ColumnTotalVenta.ReadOnly = true;
            // 
            // ColumnMontoRecibidoVenta
            // 
            ColumnMontoRecibidoVenta.HeaderText = "Monto Recibido";
            ColumnMontoRecibidoVenta.MinimumWidth = 6;
            ColumnMontoRecibidoVenta.Name = "ColumnMontoRecibidoVenta";
            ColumnMontoRecibidoVenta.ReadOnly = true;
            // 
            // ColumnCambioVenta
            // 
            ColumnCambioVenta.HeaderText = "Cambio";
            ColumnCambioVenta.MinimumWidth = 6;
            ColumnCambioVenta.Name = "ColumnCambioVenta";
            ColumnCambioVenta.ReadOnly = true;
            // 
            // ColumnVerTicket
            // 
            ColumnVerTicket.HeaderText = "Ver Ticket";
            ColumnVerTicket.Image = (Image)resources.GetObject("ColumnVerTicket.Image");
            ColumnVerTicket.ImageLayout = DataGridViewImageCellLayout.Zoom;
            ColumnVerTicket.MinimumWidth = 6;
            ColumnVerTicket.Name = "ColumnVerTicket";
            ColumnVerTicket.ReadOnly = true;
            ColumnVerTicket.Resizable = DataGridViewTriState.True;
            // 
            // label_personalizar
            // 
            label_personalizar.BackColor = Color.FromArgb(250, 146, 31);
            label_personalizar.BorderStyle = BorderStyle.FixedSingle;
            label_personalizar.Font = new Font("Lucida Sans", 13.8F, FontStyle.Bold);
            label_personalizar.Location = new Point(6, 7);
            label_personalizar.Name = "label_personalizar";
            label_personalizar.Size = new Size(319, 65);
            label_personalizar.TabIndex = 2;
            label_personalizar.Text = "Personalización de Tickets";
            label_personalizar.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_nombre_empresa
            // 
            label_nombre_empresa.AutoSize = true;
            label_nombre_empresa.Font = new Font("Lucida Sans", 9F);
            label_nombre_empresa.Location = new Point(15, 85);
            label_nombre_empresa.Name = "label_nombre_empresa";
            label_nombre_empresa.Size = new Size(176, 17);
            label_nombre_empresa.TabIndex = 3;
            label_nombre_empresa.Text = "Nombre de la empresa:";
            // 
            // label_direccion_empresa
            // 
            label_direccion_empresa.AutoSize = true;
            label_direccion_empresa.Font = new Font("Lucida Sans", 9F);
            label_direccion_empresa.Location = new Point(15, 199);
            label_direccion_empresa.Name = "label_direccion_empresa";
            label_direccion_empresa.Size = new Size(82, 17);
            label_direccion_empresa.TabIndex = 4;
            label_direccion_empresa.Text = "Dirección:";
            // 
            // label_mensaje_despedida
            // 
            label_mensaje_despedida.AutoSize = true;
            label_mensaje_despedida.Font = new Font("Lucida Sans", 9F);
            label_mensaje_despedida.Location = new Point(15, 309);
            label_mensaje_despedida.Name = "label_mensaje_despedida";
            label_mensaje_despedida.Size = new Size(174, 17);
            label_mensaje_despedida.TabIndex = 5;
            label_mensaje_despedida.Text = "Mensaje de despedida:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBox_telefono_empresa);
            panel1.Controls.Add(label_telefono_empresa);
            panel1.Controls.Add(label_nombre_empresa);
            panel1.Controls.Add(button_vista_previa);
            panel1.Controls.Add(button_guardar_ticket);
            panel1.Controls.Add(textBox_mensaje_despedida);
            panel1.Controls.Add(textBox_direccion_empresa);
            panel1.Controls.Add(textBox_nombre_empresa);
            panel1.Controls.Add(label_direccion_empresa);
            panel1.Controls.Add(label_mensaje_despedida);
            panel1.Controls.Add(label_personalizar);
            panel1.Location = new Point(856, 83);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(332, 634);
            panel1.TabIndex = 6;
            // 
            // textBox_telefono_empresa
            // 
            textBox_telefono_empresa.Font = new Font("Lucida Sans", 9F);
            textBox_telefono_empresa.Location = new Point(15, 165);
            textBox_telefono_empresa.Margin = new Padding(3, 4, 3, 4);
            textBox_telefono_empresa.Name = "textBox_telefono_empresa";
            textBox_telefono_empresa.Size = new Size(297, 25);
            textBox_telefono_empresa.TabIndex = 12;
            // 
            // label_telefono_empresa
            // 
            label_telefono_empresa.AutoSize = true;
            label_telefono_empresa.Font = new Font("Lucida Sans", 9F);
            label_telefono_empresa.Location = new Point(15, 141);
            label_telefono_empresa.Name = "label_telefono_empresa";
            label_telefono_empresa.Size = new Size(78, 17);
            label_telefono_empresa.TabIndex = 11;
            label_telefono_empresa.Text = "Teléfono:";
            // 
            // button_vista_previa
            // 
            button_vista_previa.BackColor = Color.FromArgb(250, 146, 31);
            button_vista_previa.FlatStyle = FlatStyle.Flat;
            button_vista_previa.Font = new Font("Lucida Sans", 7.8F);
            button_vista_previa.Location = new Point(89, 483);
            button_vista_previa.Margin = new Padding(3, 4, 3, 4);
            button_vista_previa.Name = "button_vista_previa";
            button_vista_previa.Size = new Size(101, 32);
            button_vista_previa.TabIndex = 10;
            button_vista_previa.Text = "Vista previa";
            button_vista_previa.UseVisualStyleBackColor = false;
            button_vista_previa.Click += button_vista_previa_Click;
            // 
            // button_guardar_ticket
            // 
            button_guardar_ticket.BackColor = Color.FromArgb(250, 146, 31);
            button_guardar_ticket.FlatStyle = FlatStyle.Flat;
            button_guardar_ticket.Font = new Font("Lucida Sans", 7.8F);
            button_guardar_ticket.Location = new Point(211, 483);
            button_guardar_ticket.Margin = new Padding(5);
            button_guardar_ticket.Name = "button_guardar_ticket";
            button_guardar_ticket.Size = new Size(101, 32);
            button_guardar_ticket.TabIndex = 9;
            button_guardar_ticket.Text = "Guardar";
            button_guardar_ticket.UseVisualStyleBackColor = false;
            button_guardar_ticket.Click += button1_Click;
            // 
            // textBox_mensaje_despedida
            // 
            textBox_mensaje_despedida.Font = new Font("Lucida Sans", 9F);
            textBox_mensaje_despedida.Location = new Point(15, 333);
            textBox_mensaje_despedida.Margin = new Padding(3, 4, 3, 4);
            textBox_mensaje_despedida.Multiline = true;
            textBox_mensaje_despedida.Name = "textBox_mensaje_despedida";
            textBox_mensaje_despedida.Size = new Size(297, 120);
            textBox_mensaje_despedida.TabIndex = 8;
            // 
            // textBox_direccion_empresa
            // 
            textBox_direccion_empresa.Font = new Font("Lucida Sans", 9F);
            textBox_direccion_empresa.Location = new Point(15, 221);
            textBox_direccion_empresa.Margin = new Padding(3, 4, 3, 4);
            textBox_direccion_empresa.Multiline = true;
            textBox_direccion_empresa.Name = "textBox_direccion_empresa";
            textBox_direccion_empresa.Size = new Size(297, 83);
            textBox_direccion_empresa.TabIndex = 7;
            // 
            // textBox_nombre_empresa
            // 
            textBox_nombre_empresa.Font = new Font("Lucida Sans", 9F);
            textBox_nombre_empresa.Location = new Point(15, 109);
            textBox_nombre_empresa.Margin = new Padding(3, 4, 3, 4);
            textBox_nombre_empresa.Name = "textBox_nombre_empresa";
            textBox_nombre_empresa.Size = new Size(297, 25);
            textBox_nombre_empresa.TabIndex = 6;
            textBox_nombre_empresa.TextChanged += textBox_nombre_empresa_TextChanged;
            // 
            // comboBoxFecha
            // 
            comboBoxFecha.BackColor = Color.FromArgb(250, 146, 31);
            comboBoxFecha.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFecha.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxFecha.FormattingEnabled = true;
            comboBoxFecha.Location = new Point(159, 82);
            comboBoxFecha.Margin = new Padding(3, 4, 3, 4);
            comboBoxFecha.Name = "comboBoxFecha";
            comboBoxFecha.Size = new Size(138, 25);
            comboBoxFecha.TabIndex = 7;
            comboBoxFecha.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBoxVendedor
            // 
            comboBoxVendedor.BackColor = Color.FromArgb(250, 146, 31);
            comboBoxVendedor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxVendedor.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxVendedor.FormattingEnabled = true;
            comboBoxVendedor.Location = new Point(477, 82);
            comboBoxVendedor.Margin = new Padding(3, 4, 3, 4);
            comboBoxVendedor.Name = "comboBoxVendedor";
            comboBoxVendedor.Size = new Size(138, 25);
            comboBoxVendedor.TabIndex = 8;
            comboBoxVendedor.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 9F);
            label1.Location = new Point(21, 85);
            label1.Name = "label1";
            label1.Size = new Size(132, 17);
            label1.TabIndex = 9;
            label1.Text = "Filtrar por fecha: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans", 9F);
            label2.Location = new Point(314, 85);
            label2.Name = "label2";
            label2.Size = new Size(157, 17);
            label2.TabIndex = 10;
            label2.Text = "Filtrar por vendedor:";
            // 
            // button_limpiar_filtros
            // 
            button_limpiar_filtros.BackColor = Color.FromArgb(250, 146, 31);
            button_limpiar_filtros.FlatStyle = FlatStyle.Flat;
            button_limpiar_filtros.Font = new Font("Lucida Sans", 7.8F);
            button_limpiar_filtros.Location = new Point(653, 78);
            button_limpiar_filtros.Margin = new Padding(3, 4, 3, 4);
            button_limpiar_filtros.Name = "button_limpiar_filtros";
            button_limpiar_filtros.Size = new Size(105, 32);
            button_limpiar_filtros.TabIndex = 13;
            button_limpiar_filtros.Text = "Limpiar filtros";
            button_limpiar_filtros.UseVisualStyleBackColor = false;
            button_limpiar_filtros.Click += button_limpiar_filtros_Click;
            // 
            // seccion_reporte_ventas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1209, 729);
            Controls.Add(button_limpiar_filtros);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxVendedor);
            Controls.Add(comboBoxFecha);
            Controls.Add(dataGridView1);
            Controls.Add(label_reportes_de_ventas);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "seccion_reporte_ventas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MarketPal";
            Load += seccion_reporte_ventas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_reportes_de_ventas;
        private DataGridView dataGridView1;
        private Label label_personalizar;
        private Label label_nombre_empresa;
        private Label label_direccion_empresa;
        private Label label_mensaje_despedida;
        private Panel panel1;
        private TextBox textBox_mensaje_despedida;
        private TextBox textBox_direccion_empresa;
        private TextBox textBox_nombre_empresa;
        private Button button_vista_previa;
        private Button button_guardar_ticket;
        private TextBox textBox_telefono_empresa;
        private Label label_telefono_empresa;
        private ComboBox comboBoxFecha;
        private ComboBox comboBoxVendedor;
        private Label label1;
        private Label label2;
        private Button button_limpiar_filtros;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnUsuarioVendedor;
        private DataGridViewTextBoxColumn ColumnFechaHora;
        private DataGridViewTextBoxColumn ColumnSubtotalVenta;
        private DataGridViewTextBoxColumn ColumnDescuentoAplicadoVenta;
        private DataGridViewTextBoxColumn ColumnTotalVenta;
        private DataGridViewTextBoxColumn ColumnMontoRecibidoVenta;
        private DataGridViewTextBoxColumn ColumnCambioVenta;
        private DataGridViewImageColumn ColumnVerTicket;
    }
}