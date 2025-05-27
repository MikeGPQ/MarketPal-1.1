using FireSharp.Interfaces;
using FireSharp.Response;

namespace MarketPal
{
    public partial class seccion_acumulacion_puntos : Form
    {
        private seccion_venta_productos formVentas;
        private IFirebaseClient firebaseClient;
        private Dictionary<string, Data_Client> clientesCargados = new Dictionary<string, Data_Client>();
        private string clienteID;
        private decimal puntosTotales;

        public seccion_acumulacion_puntos(seccion_venta_productos ventasForm, IFirebaseClient client)
        {
            InitializeComponent();
            formVentas = ventasForm;
            firebaseClient = client;
        }

        private void seccion_acumulacion_puntos_Load(object sender, EventArgs e)
        {
            this.Size = new Size(345, 143);
            this.CenterToScreen();
            btnGuardarPuntos.Enabled = false;
            txtTelefono.Focus();
        }

        private async void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string telefonoTarjeta = txtTelefono.Text.Trim();
            var clienteResponse = await firebaseClient.GetAsync("/Clientes");
            var clientes = clienteResponse.ResultAs<Dictionary<string, Data_Client>>();

            if (clientes == null) { lblErrorBusqueda.Visible = true; return; }

            foreach (var cliente in clientes)
            {
                if (cliente.Value.Telefono == telefonoTarjeta || cliente.Value.Tarjeta == telefonoTarjeta)
                {
                    this.Size = new Size(345, 369);
                    this.CenterToScreen();
                    btnGuardarPuntos.Enabled = true;

                    clienteID = cliente.Key;
                    clientesCargados[clienteID] = cliente.Value;

                    lblClienteNombre.Text = $"Nombre: {cliente.Value.Nombre}.";
                    lblPuntosActuales.Text = $"Puntos actuales: {cliente.Value.Puntos:N2}.";

                    decimal totalCompra = decimal.Parse(formVentas.label_total_carrito.Text.Replace("MXN", "").Trim());
                    decimal puntosObtenidos = totalCompra * 0.03m;
                    puntosTotales = cliente.Value.Puntos + puntosObtenidos;

                    lblPuntosObtenidos.Text = $"Puntos a obtener: {puntosObtenidos:N2}.";
                    lblPuntosTotales.Text = $"Puntos totales: {puntosTotales:N2}.";

                    return;
                }
            }

            lblErrorBusqueda.Visible = true;
        }

        private async void btnGuardarPuntos_Click(object sender, EventArgs e)
        {
            Data_Client clienteActual = clientesCargados[clienteID];
            clienteActual.Puntos = puntosTotales;
            FirebaseResponse updateResponse = await firebaseClient.UpdateAsync($"/Clientes/{clienteID}", clienteActual);

            if (updateResponse.StatusCode == System.Net.HttpStatusCode.OK)
            {
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

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (this.Size == new Size(345, 369)) { this.Size = new Size(345, 143); this.CenterToScreen(); btnGuardarPuntos.Enabled = false; }
            if (lblErrorBusqueda.Visible) { lblErrorBusqueda.Visible = false; }
            btnBuscarCliente.Enabled = !string.IsNullOrEmpty(txtTelefono.Text) && txtTelefono.Text.Length == 10;
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
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

        private void lblPuntosActuales_Click(object sender, EventArgs e)
        {

        }

        private void lblPuntosObtenidos_Click(object sender, EventArgs e)
        {

        }

        private void lblErrorBusqueda_Click(object sender, EventArgs e)
        {

        }
    }
}