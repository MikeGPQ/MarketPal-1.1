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
            ColumnID.HeaderText = "ID";
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
            // GestionAuditoriaES
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1207, 729);
            Controls.Add(dataGridView1);
            Controls.Add(label_reportes_de_ventas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GestionAuditoriaES";
            Text = "GestionAuditoriaES";
            Load += GestionAuditoriaES_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label_reportes_de_ventas;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnUsuarioVendedor;
        private DataGridViewTextBoxColumn ColumnCambioVenta;
        private DataGridViewTextBoxColumn HoraColumn;
    }
}