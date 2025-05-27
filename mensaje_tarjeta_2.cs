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

namespace MarketPal
{
    public partial class mensaje_tarjeta_2 : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "lvGHgu8Z3EYxWpBbAI8n8rCBWVncprXedJlfzfht",
            BasePath = "https://prueba-575f7-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        private Dictionary<string, string> dict_tarjetas;

        public mensaje_tarjeta_2()
        {
            InitializeComponent();
        }

        private void mensaje_tarjeta_2_Load(object sender, EventArgs e)
        {
            textBox_id_tarjeta.Focus();
            client = new FireSharp.FirebaseClient(config);
            loadTarjetas();
        }

        private async void loadTarjetas()
        {
            FirebaseResponse tarjetas = await client.GetAsync("Tarjetas/");
            dict_tarjetas = tarjetas.ResultAs<Dictionary<string, string>>();
        }

        private async void textBox_id_tarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (seRepite(textBox_id_tarjeta.Text))
                {
                    SetResponse response = await client.SetAsync("Tarjetas/" + ("ID:" + textBox_id_tarjeta.Text), "");
                }
                else
                {
                    MessageBox.Show("ERROR: LA TARJETA YA ESTA REGISTRADA");
                }
                this.Close();
            }
        }

        private bool seRepite(string id)
        {
            if(dict_tarjetas != null)
            {
                foreach (KeyValuePair<string, string> tarjeta in dict_tarjetas)
                {
                    if (tarjeta.Key.Split("ID:")[1] == id)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
