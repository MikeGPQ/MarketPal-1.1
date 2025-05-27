using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.IO.RecyclableMemoryStreamManager;


namespace MarketPal
{
    public partial class seccion_reporte_ventas : Form
    {
        string Sucursalid;
        public Dictionary<string, Venta> ventasCargados;
        private IFirebaseClient firebaseClient;
        string ruta;
        private string rolUsuario;
        private void ConfigurarFirebase()
        {
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "lvGHgu8Z3EYxWpBbAI8n8rCBWVncprXedJlfzfht",
                BasePath = "https://prueba-575f7-default-rtdb.firebaseio.com/"
            };

            firebaseClient = new FireSharp.FirebaseClient(config);

            if (firebaseClient == null)
            {
                MessageBox.Show("No se pudo conectar a Firebase.");
            }
        }

        public seccion_reporte_ventas(string Sucursalid, string rol)
        {
            InitializeComponent();
            this.Sucursalid = Sucursalid;
            rolUsuario = rol;
        }



        private void seccion_reporte_ventas_Load(object sender, EventArgs e)
        {
            if (rolUsuario == "Usuario")
            {
                panel1.Visible = false;
                dataGridView1.Size = new Size(1167, 593);
            }

            ConfigurarFirebase();
            cargar_base_de_datos(Sucursalid);
            CargarVentasDesdeBaseDatos(Sucursalid);
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private async Task cargar_base_de_datos(string sucursalId)
        {

            FirebaseResponse responseTickets = await firebaseClient.GetAsync($"/Sucursales/{Sucursalid}");
            var ticketsCargados = responseTickets.ResultAs<Ticket>();
            textBox_nombre_empresa.Text = ticketsCargados.Nombre;
            textBox_direccion_empresa.Text = ticketsCargados.Direccion;
            textBox_mensaje_despedida.Text = ticketsCargados.Mensaje;
            textBox_telefono_empresa.Text = ticketsCargados.Telefono;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket();
            ticket.Nombre = textBox_nombre_empresa.Text;
            ticket.Direccion = textBox_direccion_empresa.Text;
            ticket.Mensaje = textBox_mensaje_despedida.Text;
            ticket.Telefono = textBox_telefono_empresa.Text;
            await firebaseClient.UpdateAsync($"/Sucursales/{Sucursalid}", ticket);
            cargar_base_de_datos(Sucursalid);

        }


        private async Task CargarVentasDesdeBaseDatos(string sucursalId)
        {
            try
            {
                var responseVentas = await firebaseClient.GetAsync($"/Ventas/{Sucursalid}");
                ventasCargados = responseVentas.ResultAs<Dictionary<string, Venta>>();

                if (ventasCargados != null)
                {
                    foreach (var venta in ventasCargados)
                    {
                        dataGridView1.Rows.Add(venta.Key, venta.Value.UsuarioVendedor, venta.Value.FechaHora, venta.Value.SubtotalVenta, venta.Value.DescuentoAplicadoVenta, venta.Value.TotalVenta, venta.Value.MontoRecibidoVenta, venta.Value.CambioVenta);
                    }


                    comboBoxFecha.Items.Clear();
                    comboBoxFecha.Items.AddRange(ventasCargados.Values
                        .Select(v =>
                        {
                            DateTime fechaVenta;
                            if (DateTime.TryParse(v.FechaHora, out fechaVenta))
                                return fechaVenta.Date;
                            else
                                return DateTime.MinValue;
                        })
                        .Where(f => f != DateTime.MinValue)
                        .Distinct()
                        .OrderBy(f => f)
                        .Select(f => f.ToString("dd/MM/yyyy"))
                        .ToArray());


                    comboBoxVendedor.Items.Clear();
                    comboBoxVendedor.Items.AddRange(ventasCargados.Values
                        .Select(v => v.UsuarioVendedor)
                        .Distinct()
                        .OrderBy(v => v)
                        .ToArray());
                }
            }
            catch (OperationCanceledException)
            {

            }
            catch (Exception ex)
            {

            }
        }


        private void textBox_nombre_empresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarVentas();
        }

        private void comboBoxVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarVentas();
        }

        private void label_reportes_de_ventas_Click(object sender, EventArgs e)
        {

        }

        private async void button_vista_previa_Click(object sender, EventArgs e)
        {

            try
            {
                string idVenta = "VNT1";

                GenerarTicketFisico ticketFisico = new GenerarTicketFisico();
                ruta = await ticketFisico.generarTicketTXT(Sucursalid, idVenta);

                // MessageBox.Show($"Ticket generado en: {ruta}");

                // Abrir el archivo automáticamente
                // System.Diagnostics.Process.Start("notepad.exe", ruta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            vista_previa_ticket f2 = new("VNT1", ruta);
            f2.Show();
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Columns[e.ColumnIndex].Name == "ColumnVerTicket")
            {

                string idVenta = dataGridView1.Rows[e.RowIndex].Cells["ColumnID"].Value.ToString();


                try
                {

                    GenerarTicketFisico ticketFisico = new GenerarTicketFisico();
                    ruta = await ticketFisico.generarTicketTXT(Sucursalid, idVenta);

                    //MessageBox.Show($"Ticket generado en: {ruta}");

                    // Abrir el archivo automáticamente
                    //System.Diagnostics.Process.Start("notepad.exe", ruta);
                }
                catch (Exception ex)
                {

                }

                vista_previa_ticket f2 = new(idVenta, ruta);
                f2.Show();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarVentas();
        }

        private void FiltrarVentas()
        {
            var fechaSeleccionada = comboBoxFecha.SelectedItem?.ToString();
            var vendedorSeleccionado = comboBoxVendedor.SelectedItem?.ToString();

            DateTime? fechaSeleccionadaDate = null;
            if (!string.IsNullOrEmpty(fechaSeleccionada))
                fechaSeleccionadaDate = DateTime.Parse(fechaSeleccionada);

            var ventasFiltradas = ventasCargados.Where(v =>
            {
                bool coincideFecha = true;
                if (fechaSeleccionadaDate.HasValue)
                {
                    DateTime fechaVenta;
                    if (DateTime.TryParse(v.Value.FechaHora, out fechaVenta))
                        coincideFecha = fechaVenta.Date == fechaSeleccionadaDate.Value.Date;
                }

                bool coincideVendedor = string.IsNullOrEmpty(vendedorSeleccionado) || v.Value.UsuarioVendedor == vendedorSeleccionado;

                return coincideFecha && coincideVendedor;
            }).ToList();

            dataGridView1.Rows.Clear();

            foreach (var venta in ventasFiltradas)
            {
                dataGridView1.Rows.Add(
                    venta.Key,
                    venta.Value.UsuarioVendedor,
                    venta.Value.FechaHora,
                    venta.Value.SubtotalVenta,
                    venta.Value.DescuentoAplicadoVenta,
                    venta.Value.TotalVenta,
                    venta.Value.MontoRecibidoVenta,
                    venta.Value.CambioVenta
                );
            }
        }

        private void button_limpiar_filtros_Click(object sender, EventArgs e)
        {
            comboBoxFecha.SelectedIndex = -1;
            comboBoxVendedor.SelectedIndex = -1;

            // Volver a mostrar todas las ventas
            dataGridView1.Rows.Clear();

            foreach (var venta in ventasCargados)
            {
                dataGridView1.Rows.Add(
                    venta.Key,
                    venta.Value.UsuarioVendedor,
                    venta.Value.FechaHora,
                    venta.Value.SubtotalVenta,
                    venta.Value.DescuentoAplicadoVenta,
                    venta.Value.TotalVenta,
                    venta.Value.MontoRecibidoVenta,
                    venta.Value.CambioVenta
                );
            }
        }
    }
}
