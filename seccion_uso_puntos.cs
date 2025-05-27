using FireSharp.Interfaces;
using FireSharp.Response;

namespace MarketPal
{
    public partial class seccion_uso_puntos : Form
    {
        private seccion_venta_productos formVentas;
        private IFirebaseClient firebaseClient;
        private Dictionary<string, Data_Client> clientesCargados = new Dictionary<string, Data_Client>();
        private string clienteID;
        private decimal totalCompra;
        private decimal puntosAUsar;

        public seccion_uso_puntos(seccion_venta_productos ventasForm, IFirebaseClient client)
        {
            InitializeComponent();
            formVentas = ventasForm;
            firebaseClient = client;
        }

        private void seccion_uso_puntos_Load(object sender, EventArgs e)
        {
            this.Size = new Size(345, 143);
            this.CenterToScreen();
            btnAplicarDescuento.Enabled = false;
            txtTelefonoTarjeta.Focus();
        }

        private async void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string telefonoTarjeta = txtTelefonoTarjeta.Text.Trim();
            var clienteResponse = await firebaseClient.GetAsync("/Clientes");
            var clientes = clienteResponse.ResultAs<Dictionary<string, Data_Client>>();

            if (clientes == null) { lblErrorBusqueda.Visible = true; return; }

            foreach (var cliente in clientes)
            {
                if (cliente.Value.Telefono == telefonoTarjeta || cliente.Value.Tarjeta == telefonoTarjeta)
                {
                    this.Size = new Size(345, 369);
                    this.CenterToScreen();
                    btnAplicarDescuento.Enabled = true;

                    clienteID = cliente.Key;
                    clientesCargados[clienteID] = cliente.Value;

                    lblClienteEncontrado.Text = $"Nombre: {cliente.Value.Nombre}.";
                    lblPuntosDisponibles.Text = $"Puntos disponibles: {cliente.Value.Puntos:F2}.";

                    totalCompra = decimal.Parse(formVentas.label_total_carrito.Text.Replace("MXN", "").Trim());
                    puntosAUsar = Math.Min(cliente.Value.Puntos, totalCompra);
                    decimal puntosRestantes = cliente.Value.Puntos - puntosAUsar;

                    lblPuntosAUsar.Text = $"Puntos a usar: {puntosAUsar:F2}.";
                    lblPuntosRestantes.Text = $"Puntos restantes: {puntosRestantes:F2}.";

                    btnAplicarDescuento.Enabled = cliente.Value.Puntos != 0;

                    return;
                }
            }

            lblErrorBusqueda.Visible = true;
        }

        private async void btnAplicarDescuento_Click(object sender, EventArgs e)
        {
            Data_Client clienteActual = clientesCargados[clienteID];
            clienteActual.Puntos -= puntosAUsar;
            FirebaseResponse updateResponse = await firebaseClient.UpdateAsync($"/Clientes/{clienteID}", clienteActual);

            if (updateResponse.StatusCode == System.Net.HttpStatusCode.OK)
            {
                formVentas.lblSubtotal.Text = $"Subtotal: MXN {totalCompra:N2}";
                formVentas.lblDescuentoAplicado.Text = $"Descuento por puntos: MXN {puntosAUsar:N2}";
                decimal nuevoTotal = totalCompra - puntosAUsar;
                formVentas.label_total_carrito.Text = $"MXN {nuevoTotal:N2}";
                formVentas.btnPuntos.Visible = false;
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al actualizar los puntos.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTelefonoTarjeta_TextChanged(object sender, EventArgs e)
        {
            if (this.Size == new Size(345, 369)) { this.Size = new Size(345, 143); this.CenterToScreen(); btnAplicarDescuento.Enabled = false; }
            if (lblErrorBusqueda.Visible) { lblErrorBusqueda.Visible = false; }
            btnBuscarCliente.Enabled = !string.IsNullOrEmpty(txtTelefonoTarjeta.Text) && txtTelefonoTarjeta.Text.Length == 10;
        }

        private void txtTelefonoTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                btnBuscarCliente.PerformClick();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblClienteNombre_Click(object sender, EventArgs e)
        {

        }

        private void lblPuntosDisponibles_Click(object sender, EventArgs e)
        {

        }

        private void lblPuntosUsados_Click(object sender, EventArgs e)
        {

        }

        private void lblPuntosRestantes_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ue_Click(object sender, EventArgs e)
        {

        }
    }
}