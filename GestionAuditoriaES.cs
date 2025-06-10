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
    public partial class GestionAuditoriaES : Form
    {

        IFirebaseClient client;
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "lvGHgu8Z3EYxWpBbAI8n8rCBWVncprXedJlfzfht",
            BasePath = "https://prueba-575f7-default-rtdb.firebaseio.com/"
        };

        private Dictionary<string, Auditoria> dict_adutoriasES;


        public GestionAuditoriaES()
        {
            InitializeComponent();
        }

        private void GestionAuditoriaES_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            actualizarGrid();
        }

        

        private async void actualizarGrid()
        {
            FirebaseResponse auditorias = await client.GetAsync("AuditoriasES/");
            dict_adutoriasES = auditorias.ResultAs<Dictionary<string, Auditoria>>();
            
            if (auditorias.Body != "null")
            {
                foreach (var auditoria in dict_adutoriasES)
                {
                    dataGridView1.Rows.Add(auditoria.Key, auditoria.Value.Usuario,auditoria.Value.Fecha,auditoria.Value.Hora);
                }
            }
                

            
        }
    }
}
