using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MarketPal
{
    public partial class seccion_tarjetas : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "lvGHgu8Z3EYxWpBbAI8n8rCBWVncprXedJlfzfht",
            BasePath = "https://prueba-575f7-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        private Dictionary<string, string> dict_tarjetas;
        private Dictionary<string, Data_Client> dict_clientes;
        private System.Windows.Forms.Timer debounceTimer;


        public seccion_tarjetas()
        {
            InitializeComponent();

        }

        private void seccion_tarjetas_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                actualizarLista();
                debounceTimer = new System.Windows.Forms.Timer();
                debounceTimer.Interval = 300;
                debounceTimer.Tick += DebounceTimer_Tick;
            }
            catch (Exception ex)
            {

            }
        }

        private void DebounceTimer_Tick(object sender, EventArgs e)
        {
            debounceTimer.Stop();
            actualizarLista();
        }


        private void button_Tarjeta_Click(object sender, EventArgs e)
        {
            var forms_mensaje_tarjeta = new mensaje_tarjeta_2();
            forms_mensaje_tarjeta.ShowDialog();
            actualizarLista();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void actualizarLista()
        {
            try
            {
                dataGridView1.Rows.Clear();
                FirebaseResponse tarjetas = await client.GetAsync("Tarjetas/");
                dict_tarjetas = tarjetas.ResultAs<Dictionary<string, string>>();
                FirebaseResponse clientes = await client.GetAsync("Clientes/");
                dict_clientes = clientes.ResultAs<Dictionary<string, Data_Client>>();

                if (dict_tarjetas != null)
                {
                    dict_tarjetas = primerFiltro(dict_tarjetas);

                    dict_tarjetas = segundoFiltro(dict_tarjetas);

                    foreach (KeyValuePair<string, string> tarjeta in dict_tarjetas)
                    {
                        dataGridView1.Rows.Add(tarjeta.Key.Split("ID:")[1], tienePropietario(tarjeta.Key.Split("ID:")[1]));
                    }

                }
                labelTotal.Text = "Número de tarjetas: " + dataGridView1.RowCount.ToString() + ".";
            }
            catch (Exception ex)
            {

            }
        }

        private Dictionary<string, string> segundoFiltro(Dictionary<string, string> dict_tarjetas)
        {
            foreach (KeyValuePair<string, string> tarjeta in dict_tarjetas)
            {
                if (textBox_SearchID.Text != " " && textBox_SearchID.Text != "")
                {
                    if (!tarjeta.Key.Split("ID:")[1].Contains(textBox_SearchID.Text))
                    {
                        dict_tarjetas.Remove(tarjeta.Key);
                    }
                }

                if (textBox_SearchPropt.Text != " " && textBox_SearchPropt.Text != "")
                {

                    if (!tienePropietario(tarjeta.Key.Split("ID:")[1]).ToLower().Contains(textBox_SearchPropt.Text.ToLower()))
                    {
                        dict_tarjetas.Remove(tarjeta.Key);
                    }
                }
            }
            return dict_tarjetas;
        }

        private Dictionary<string, string> primerFiltro(Dictionary<string, string> dict_tarjetas)
        {
            foreach (KeyValuePair<string, string> tarjeta in dict_tarjetas)
            {
                switch (combobox_Disponibilidad.Text)
                {
                    case "Disponibles":
                        if (tienePropietario(tarjeta.Key.Split("ID:")[1]) != "-")
                        {
                            dict_tarjetas.Remove(tarjeta.Key);

                        }
                        break;
                    case "En uso":
                        if (tienePropietario(tarjeta.Key.Split("ID:")[1]) == "-")
                        {
                            dict_tarjetas.Remove(tarjeta.Key);
                        }
                        break;
                    default:
                        break;
                }
            }
            return dict_tarjetas;
        }

        private string tienePropietario(string tarjeta)
        {
            if(dict_clientes != null)
            {
                foreach (KeyValuePair<string, Data_Client> cliente in dict_clientes)
                {
                    if (cliente.Value.Tarjeta == tarjeta)
                    {
                        return cliente.Value.Nombre;
                    }
                }
            }
            return "-";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns[2].Index)
            {
                FirebaseResponse delete = client.Delete("Tarjetas/" + ("ID:" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()));
                deleteCard(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                actualizarLista();
            }
        }

        private async void deleteCard(string tarjeta)
        {
            foreach (KeyValuePair<string, Data_Client> cliente in dict_clientes)
            {
                if (cliente.Value.Tarjeta == tarjeta)
                {
                    var data = new Data_Client
                    {
                        Nombre = cliente.Value.Nombre,
                        Correo = cliente.Value.Correo,
                        Telefono = cliente.Value.Telefono,
                        Tarjeta = null,
                        Puntos = cliente.Value.Puntos,
                        Fecha = cliente.Value.Fecha,
                    };

                    cliente.Value.Tarjeta = null;
                    SetResponse response = await client.SetAsync("Clientes/" + cliente.Key, data);
                }
            }
        }

        private void textBox_SearchID_TextChanged(object sender, EventArgs e)
        {
            debounceTimer.Stop();
            debounceTimer.Start();
        }

        private void textBox_SearchPropt_TextChanged(object sender, EventArgs e)
        {
            debounceTimer.Stop();
            debounceTimer.Start();
        }

        private void combobox_Disponibilidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            CancelarFiltroCategoria.Visible = true;
            actualizarLista();
        }

        private void CancelarFiltroCategoria_Click(object sender, EventArgs e)
        {
            CancelarFiltroCategoria.Visible = false;
            combobox_Disponibilidad.SelectedItem = null;
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns[2].Index)
            {
                this.Cursor = Cursors.Hand;
            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
