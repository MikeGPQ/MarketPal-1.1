namespace MarketPal
{
    partial class seccion_tarjetas
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
            label_reportes_de_ventas = new Label();
            dataGridView1 = new DataGridView();
            ColumnID = new DataGridViewTextBoxColumn();
            ColumnUsuarioVendedor = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewImageColumn();
            button_Tarjeta = new Button();
            textBox_SearchID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox_SearchPropt = new TextBox();
            combobox_Disponibilidad = new ComboBox();
            label3 = new Label();
            CancelarFiltroCategoria = new Button();
            labelTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label_reportes_de_ventas
            // 
            label_reportes_de_ventas.BackColor = Color.FromArgb(255, 224, 183);
            label_reportes_de_ventas.Font = new Font("Lucida Sans", 16.2F, FontStyle.Bold);
            label_reportes_de_ventas.ForeColor = Color.FromArgb(250, 146, 31);
            label_reportes_de_ventas.Location = new Point(-1, 0);
            label_reportes_de_ventas.Margin = new Padding(5, 0, 5, 0);
            label_reportes_de_ventas.Name = "label_reportes_de_ventas";
            label_reportes_de_ventas.Size = new Size(1211, 61);
            label_reportes_de_ventas.TabIndex = 1;
            label_reportes_de_ventas.Text = "Tarjetas";
            label_reportes_de_ventas.TextAlign = ContentAlignment.MiddleCenter;
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 224, 183);
            dataGridViewCellStyle1.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 224, 183);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnID, ColumnUsuarioVendedor, Delete });
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
            dataGridView1.Location = new Point(14, 140);
            dataGridView1.Margin = new Padding(5, 5, 5, 5);
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
            dataGridView1.Size = new Size(1179, 603);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellMouseEnter += dataGridView1_CellMouseEnter;
            dataGridView1.CellMouseLeave += dataGridView1_CellMouseLeave;
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
            ColumnUsuarioVendedor.HeaderText = "Propietario";
            ColumnUsuarioVendedor.MinimumWidth = 6;
            ColumnUsuarioVendedor.Name = "ColumnUsuarioVendedor";
            ColumnUsuarioVendedor.ReadOnly = true;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Delete.HeaderText = "Eliminar";
            Delete.Image = Properties.Resources.borrar__1_;
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Resizable = DataGridViewTriState.True;
            Delete.Width = 80;
            // 
            // button_Tarjeta
            // 
            button_Tarjeta.BackColor = Color.FromArgb(250, 146, 31);
            button_Tarjeta.FlatAppearance.BorderColor = Color.Black;
            button_Tarjeta.FlatAppearance.MouseDownBackColor = Color.FromArgb(211, 113, 3);
            button_Tarjeta.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 119, 4);
            button_Tarjeta.FlatStyle = FlatStyle.Flat;
            button_Tarjeta.Font = new Font("Lucida Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Tarjeta.Location = new Point(1040, 81);
            button_Tarjeta.Margin = new Padding(5, 5, 5, 5);
            button_Tarjeta.Name = "button_Tarjeta";
            button_Tarjeta.Size = new Size(153, 35);
            button_Tarjeta.TabIndex = 23;
            button_Tarjeta.Text = "Subir tarjeta";
            button_Tarjeta.UseVisualStyleBackColor = false;
            button_Tarjeta.Click += button_Tarjeta_Click;
            // 
            // textBox_SearchID
            // 
            textBox_SearchID.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_SearchID.ForeColor = SystemColors.GrayText;
            textBox_SearchID.Location = new Point(56, 87);
            textBox_SearchID.Margin = new Padding(5, 5, 5, 5);
            textBox_SearchID.MaxLength = 10;
            textBox_SearchID.Name = "textBox_SearchID";
            textBox_SearchID.Size = new Size(217, 25);
            textBox_SearchID.TabIndex = 24;
            textBox_SearchID.TextChanged += textBox_SearchID_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 92);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(20, 16);
            label1.TabIndex = 25;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(290, 91);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 16);
            label2.TabIndex = 27;
            label2.Text = "Propietario";
            // 
            // textBox_SearchPropt
            // 
            textBox_SearchPropt.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_SearchPropt.ForeColor = SystemColors.GrayText;
            textBox_SearchPropt.Location = new Point(376, 87);
            textBox_SearchPropt.Margin = new Padding(5, 5, 5, 5);
            textBox_SearchPropt.Name = "textBox_SearchPropt";
            textBox_SearchPropt.Size = new Size(217, 25);
            textBox_SearchPropt.TabIndex = 26;
            textBox_SearchPropt.TextChanged += textBox_SearchPropt_TextChanged;
            // 
            // combobox_Disponibilidad
            // 
            combobox_Disponibilidad.BackColor = Color.FromArgb(250, 146, 31);
            combobox_Disponibilidad.DropDownStyle = ComboBoxStyle.DropDownList;
            combobox_Disponibilidad.Font = new Font("Lucida Sans", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            combobox_Disponibilidad.ForeColor = Color.Black;
            combobox_Disponibilidad.FormattingEnabled = true;
            combobox_Disponibilidad.Items.AddRange(new object[] { "Disponibles", "En uso" });
            combobox_Disponibilidad.Location = new Point(709, 87);
            combobox_Disponibilidad.Margin = new Padding(5, 5, 5, 5);
            combobox_Disponibilidad.Name = "combobox_Disponibilidad";
            combobox_Disponibilidad.Size = new Size(143, 24);
            combobox_Disponibilidad.TabIndex = 28;
            combobox_Disponibilidad.SelectedIndexChanged += combobox_Disponibilidad_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(601, 92);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 16);
            label3.TabIndex = 29;
            label3.Text = "Disponibilidad";
            // 
            // CancelarFiltroCategoria
            // 
            CancelarFiltroCategoria.BackColor = Color.Transparent;
            CancelarFiltroCategoria.FlatAppearance.BorderSize = 0;
            CancelarFiltroCategoria.FlatAppearance.MouseDownBackColor = SystemColors.ScrollBar;
            CancelarFiltroCategoria.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            CancelarFiltroCategoria.FlatStyle = FlatStyle.Flat;
            CancelarFiltroCategoria.Image = Properties.Resources.equis__3___4_;
            CancelarFiltroCategoria.Location = new Point(861, 87);
            CancelarFiltroCategoria.Margin = new Padding(5, 5, 5, 5);
            CancelarFiltroCategoria.Name = "CancelarFiltroCategoria";
            CancelarFiltroCategoria.Size = new Size(18, 25);
            CancelarFiltroCategoria.TabIndex = 30;
            CancelarFiltroCategoria.UseVisualStyleBackColor = false;
            CancelarFiltroCategoria.Visible = false;
            CancelarFiltroCategoria.Click += CancelarFiltroCategoria_Click;
            // 
            // labelTotal
            // 
            labelTotal.ForeColor = Color.FromArgb(250, 146, 31);
            labelTotal.Location = new Point(893, 747);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(298, 20);
            labelTotal.TabIndex = 31;
            labelTotal.Text = "label4";
            labelTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // seccion_tarjetas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1207, 749);
            Controls.Add(labelTotal);
            Controls.Add(CancelarFiltroCategoria);
            Controls.Add(label3);
            Controls.Add(combobox_Disponibilidad);
            Controls.Add(label2);
            Controls.Add(textBox_SearchPropt);
            Controls.Add(label1);
            Controls.Add(textBox_SearchID);
            Controls.Add(button_Tarjeta);
            Controls.Add(dataGridView1);
            Controls.Add(label_reportes_de_ventas);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "seccion_tarjetas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MarketPal";
            Load += seccion_tarjetas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_reportes_de_ventas;
        private DataGridView dataGridView1;
        public Button button_Tarjeta;
        private TextBox textBox_SearchID;
        private Label label1;
        private Label label2;
        private TextBox textBox_SearchPropt;
        private ComboBox combobox_Disponibilidad;
        private Label label3;
        private Button CancelarFiltroCategoria;
        private Label labelTotal;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnUsuarioVendedor;
        private DataGridViewImageColumn Delete;
    }
}