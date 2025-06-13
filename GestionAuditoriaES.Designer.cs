namespace MarketPal
{
    partial class GestionAuditoriaES
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
            dataGridView1 = new DataGridView();
            ColumnID = new DataGridViewTextBoxColumn();
            ColumnUsuarioVendedor = new DataGridViewTextBoxColumn();
            ColumnCambioVenta = new DataGridViewTextBoxColumn();
            HoraColumn = new DataGridViewTextBoxColumn();
            label_reportes_de_ventas = new Label();
            label1 = new Label();
            comboBoxFecha = new ComboBox();
            label2 = new Label();
            comboBoxUsuarios = new ComboBox();
            label3 = new Label();
            comboBoxType = new ComboBox();
            buttonClearDate = new Button();
            buttonClearUser = new Button();
            buttonClearType = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnID, ColumnUsuarioVendedor, ColumnCambioVenta, HoraColumn });
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
            dataGridView1.Location = new Point(19, 122);
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
            dataGridView1.Size = new Size(1168, 593);
            dataGridView1.TabIndex = 3;
            // 
            // ColumnID
            // 
            ColumnID.HeaderText = "Type";
            ColumnID.MinimumWidth = 6;
            ColumnID.Name = "ColumnID";
            ColumnID.ReadOnly = true;
            // 
            // ColumnUsuarioVendedor
            // 
            ColumnUsuarioVendedor.HeaderText = "Usuario";
            ColumnUsuarioVendedor.MinimumWidth = 6;
            ColumnUsuarioVendedor.Name = "ColumnUsuarioVendedor";
            ColumnUsuarioVendedor.ReadOnly = true;
            // 
            // ColumnCambioVenta
            // 
            ColumnCambioVenta.HeaderText = "Fecha";
            ColumnCambioVenta.MinimumWidth = 6;
            ColumnCambioVenta.Name = "ColumnCambioVenta";
            ColumnCambioVenta.ReadOnly = true;
            // 
            // HoraColumn
            // 
            HoraColumn.HeaderText = "Hora";
            HoraColumn.MinimumWidth = 6;
            HoraColumn.Name = "HoraColumn";
            HoraColumn.ReadOnly = true;
            // 
            // label_reportes_de_ventas
            // 
            label_reportes_de_ventas.BackColor = Color.FromArgb(255, 224, 183);
            label_reportes_de_ventas.Font = new Font("Lucida Sans", 16.2F, FontStyle.Bold);
            label_reportes_de_ventas.ForeColor = Color.FromArgb(250, 146, 31);
            label_reportes_de_ventas.Location = new Point(19, 14);
            label_reportes_de_ventas.Margin = new Padding(5, 0, 5, 0);
            label_reportes_de_ventas.Name = "label_reportes_de_ventas";
            label_reportes_de_ventas.Size = new Size(1168, 49);
            label_reportes_de_ventas.TabIndex = 2;
            label_reportes_de_ventas.Text = "Entradas y Salidas";
            label_reportes_de_ventas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 9F);
            label1.Location = new Point(741, 94);
            label1.Name = "label1";
            label1.Size = new Size(132, 17);
            label1.TabIndex = 11;
            label1.Text = "Filtrar por fecha: ";
            // 
            // comboBoxFecha
            // 
            comboBoxFecha.BackColor = Color.FromArgb(250, 146, 31);
            comboBoxFecha.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFecha.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxFecha.FormattingEnabled = true;
            comboBoxFecha.Items.AddRange(new object[] { "" });
            comboBoxFecha.Location = new Point(879, 90);
            comboBoxFecha.Margin = new Padding(3, 4, 3, 4);
            comboBoxFecha.Name = "comboBoxFecha";
            comboBoxFecha.Size = new Size(138, 25);
            comboBoxFecha.TabIndex = 10;
            comboBoxFecha.SelectedIndexChanged += comboBoxFecha_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans", 9F);
            label2.Location = new Point(339, 93);
            label2.Name = "label2";
            label2.Size = new Size(146, 17);
            label2.TabIndex = 13;
            label2.Text = "Filtrar por usuario: ";
            // 
            // comboBoxUsuarios
            // 
            comboBoxUsuarios.BackColor = Color.FromArgb(250, 146, 31);
            comboBoxUsuarios.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUsuarios.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxUsuarios.FormattingEnabled = true;
            comboBoxUsuarios.Items.AddRange(new object[] { "" });
            comboBoxUsuarios.Location = new Point(488, 90);
            comboBoxUsuarios.Margin = new Padding(3, 4, 3, 4);
            comboBoxUsuarios.Name = "comboBoxUsuarios";
            comboBoxUsuarios.Size = new Size(180, 25);
            comboBoxUsuarios.TabIndex = 12;
            comboBoxUsuarios.SelectedIndexChanged += comboBoxUsuarios_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans", 9F);
            label3.Location = new Point(32, 92);
            label3.Name = "label3";
            label3.Size = new Size(122, 17);
            label3.TabIndex = 15;
            label3.Text = "Filtrar por tipo: ";
            // 
            // comboBoxType
            // 
            comboBoxType.BackColor = Color.FromArgb(250, 146, 31);
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Entrada", "Salida" });
            comboBoxType.Location = new Point(157, 89);
            comboBoxType.Margin = new Padding(3, 4, 3, 4);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(138, 25);
            comboBoxType.TabIndex = 14;
            comboBoxType.SelectedIndexChanged += comboBoxType_SelectedIndexChanged;
            // 
            // buttonClearDate
            // 
            buttonClearDate.BackColor = Color.Transparent;
            buttonClearDate.FlatAppearance.BorderSize = 0;
            buttonClearDate.FlatAppearance.MouseDownBackColor = SystemColors.ScrollBar;
            buttonClearDate.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            buttonClearDate.FlatStyle = FlatStyle.Flat;
            buttonClearDate.Image = Properties.Resources.equis__3___4_;
            buttonClearDate.Location = new Point(1025, 89);
            buttonClearDate.Margin = new Padding(5);
            buttonClearDate.Name = "buttonClearDate";
            buttonClearDate.Size = new Size(18, 25);
            buttonClearDate.TabIndex = 31;
            buttonClearDate.UseVisualStyleBackColor = false;
            buttonClearDate.Visible = false;
            buttonClearDate.Click += buttonClearDate_Click;
            // 
            // buttonClearUser
            // 
            buttonClearUser.BackColor = Color.Transparent;
            buttonClearUser.FlatAppearance.BorderSize = 0;
            buttonClearUser.FlatAppearance.MouseDownBackColor = SystemColors.ScrollBar;
            buttonClearUser.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            buttonClearUser.FlatStyle = FlatStyle.Flat;
            buttonClearUser.Image = Properties.Resources.equis__3___4_;
            buttonClearUser.Location = new Point(676, 90);
            buttonClearUser.Margin = new Padding(5);
            buttonClearUser.Name = "buttonClearUser";
            buttonClearUser.Size = new Size(18, 25);
            buttonClearUser.TabIndex = 32;
            buttonClearUser.UseVisualStyleBackColor = false;
            buttonClearUser.Visible = false;
            buttonClearUser.Click += buttonClearUser_Click;
            // 
            // buttonClearType
            // 
            buttonClearType.BackColor = Color.Transparent;
            buttonClearType.FlatAppearance.BorderSize = 0;
            buttonClearType.FlatAppearance.MouseDownBackColor = SystemColors.ScrollBar;
            buttonClearType.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            buttonClearType.FlatStyle = FlatStyle.Flat;
            buttonClearType.Image = Properties.Resources.equis__3___4_;
            buttonClearType.Location = new Point(303, 88);
            buttonClearType.Margin = new Padding(5);
            buttonClearType.Name = "buttonClearType";
            buttonClearType.Size = new Size(18, 25);
            buttonClearType.TabIndex = 33;
            buttonClearType.UseVisualStyleBackColor = false;
            buttonClearType.Visible = false;
            buttonClearType.Click += buttonClearType_Click;
            // 
            // GestionAuditoriaES
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1207, 729);
            Controls.Add(buttonClearType);
            Controls.Add(buttonClearUser);
            Controls.Add(buttonClearDate);
            Controls.Add(label3);
            Controls.Add(comboBoxType);
            Controls.Add(label2);
            Controls.Add(comboBoxUsuarios);
            Controls.Add(label1);
            Controls.Add(comboBoxFecha);
            Controls.Add(dataGridView1);
            Controls.Add(label_reportes_de_ventas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GestionAuditoriaES";
            Text = "GestionAuditoriaES";
            Load += GestionAuditoriaES_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label_reportes_de_ventas;
        private Label label1;
        private ComboBox comboBoxFecha;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnUsuarioVendedor;
        private DataGridViewTextBoxColumn ColumnCambioVenta;
        private DataGridViewTextBoxColumn HoraColumn;
        private Label label2;
        private ComboBox comboBoxUsuarios;
        private Label label3;
        private ComboBox comboBoxType;
        private Button buttonClearDate;
        private Button buttonClearUser;
        private Button buttonClearType;
    }
}