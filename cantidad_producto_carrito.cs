using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketPal
{
    public partial class cantidad_producto_carrito : Form
    {
        public decimal CantidadExistente { get; set; }
        public decimal CantidadInicial { get; set; } = 0;
        public string UnidadMedida { get; set; }
        public decimal CantidadSeleccionada { get; private set; }

        public cantidad_producto_carrito()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
        }

        private void cantidad_producto_carrito_Load(object sender, EventArgs e)
        {
            if (Owner != null)
            {
                var parentBounds = Owner.ClientRectangle;
                var parentLocation = Owner.PointToScreen(Point.Empty);

                int x = parentLocation.X + (parentBounds.Width - this.Width) / 2;
                int y = parentLocation.Y + (parentBounds.Height - this.Height) / 2;

                x = Math.Max(x, 0);
                y = Math.Max(y, 0);

                this.Location = new Point(x, y);
            }

            label_indicacion.Text = CantidadInicial > 0 ? " Modificar cantidad" : " Ingresar cantidad";
            textbox_cantidad.Text = CantidadInicial > 0 ? CantidadInicial.ToString("0.##") : string.Empty;
        }

        private void textbox_cantidad_TextChanged(object sender, EventArgs e)
        {
            string texto = textbox_cantidad.Text.Trim();
            bool esDecimalValido = UnidadMedida == "kg" || !texto.Contains(".");

            decimal cantidad = texto == "." ? 0 : decimal.TryParse(texto, out decimal valor) ? valor : 0;

            if (cantidad > 0 && esDecimalValido)
            {
                btn_guardar_cantidad.Enabled = cantidad != CantidadInicial;
            }
            else
            {
                btn_guardar_cantidad.Enabled = false;
            }

            label_mensaje_error.Visible = false;
        }

        private void textbox_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (textbox_cantidad.Text.Contains(".") || UnidadMedida == "uds."))
            {
                e.Handled = true;
            }
        }

        private void btn_guardar_cantidad_Click(object sender, EventArgs e)
        {
            string texto = textbox_cantidad.Text.Trim();

            if (decimal.TryParse(texto, out decimal cantidad))
            {
                if (cantidad > CantidadExistente)
                {
                    label_mensaje_error.Text = "La cantidad ingresada excede la cantidad en inventario.";
                    label_mensaje_error.Visible = true;
                }
                else
                {
                    CantidadSeleccionada = cantidad;
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void label_mensaje_error_Click(object sender, EventArgs e)
        {

        }

        private void label_indicacion_Click(object sender, EventArgs e)
        {

        }
    }
}
