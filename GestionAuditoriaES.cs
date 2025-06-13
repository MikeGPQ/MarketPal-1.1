using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            comboBoxUsuarios.Items.Clear();
            comboBoxFecha.Items.Clear();
            client = new FireSharp.FirebaseClient(config);
            actualizarGrid();
        }

        private async void actualizarGrid()
        {
            dataGridView1.Rows.Clear();

            FirebaseResponse auditorias = await client.GetAsync("AuditoriasES/");
            dict_adutoriasES = auditorias.ResultAs<Dictionary<string, Auditoria>>();


            if (dict_adutoriasES != null)
            {
                dict_adutoriasES = sorting(dict_adutoriasES);
                llenarFiltro(dict_adutoriasES);
                dict_adutoriasES = primerFiltro(dict_adutoriasES);
                segundoFiltro(dict_adutoriasES);
                foreach (var auditoria in dict_adutoriasES)
                {
                    dataGridView1.Rows.Add(auditoria.Value.Tipo, auditoria.Value.Usuario, auditoria.Value.Fecha, auditoria.Value.Hora);
                }
            }
        }

        private Dictionary<string, Auditoria> sorting(Dictionary<string, Auditoria> dict_adutoriasES)
        {
            // Función para parsear la hora con el formato correcto
            DateTime ParseHora(string hora)
            {
                // Convertir "02:05:37 p. m." a "02:05:37 PM" que es el formato estándar
                hora = hora.Replace("a. m.", "AM").Replace("p. m.", "PM");
                return DateTime.ParseExact(hora, "hh:mm:ss tt", CultureInfo.InvariantCulture);
            }

            return dict_adutoriasES
                .OrderBy(a => DateTime.ParseExact(a.Value.Fecha, "dd-MM-yyyy", CultureInfo.InvariantCulture))
                .ThenBy(a => ParseHora(a.Value.Hora))
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
        }

        private void llenarFiltro(Dictionary<string, Auditoria> dict_adutoriasES)
        {
            foreach (var auditoria in dict_adutoriasES)
            {
                if (!comboBoxFecha.Items.Contains(auditoria.Value.Fecha))
                {
                    comboBoxFecha.Items.Add(auditoria.Value.Fecha);
                }

                if (!comboBoxUsuarios.Items.Contains(auditoria.Value.Usuario))
                {
                    comboBoxUsuarios.Items.Add(auditoria.Value.Usuario);
                }
            }
        }

        private Dictionary<string, Auditoria> primerFiltro(Dictionary<string, Auditoria> dict_adutoriasES)
        {
            foreach (KeyValuePair<string, Auditoria> auditoria in dict_adutoriasES)
            {
                switch (comboBoxType.Text)
                {
                    case "Entrada":
                        if (auditoria.Value.Tipo != "Entrada")
                        {
                            dict_adutoriasES.Remove(auditoria.Key);

                        }
                        break;
                    case "Salida":
                        if (auditoria.Value.Tipo != "Salida")
                        {
                            dict_adutoriasES.Remove(auditoria.Key);

                        }
                        break;
                    default:
                        break;
                }
            }
            return dict_adutoriasES;
        }


        private Dictionary<string, Auditoria> segundoFiltro(Dictionary<string, Auditoria> dict_adutoriasES)
        {
            if (comboBoxFecha.Text != "")
            {
                foreach (var auditoria in dict_adutoriasES)
                {
                    if (comboBoxFecha.Text != auditoria.Value.Fecha)
                    {
                        dict_adutoriasES.Remove(auditoria.Key);
                    }
                }
            }

            if (comboBoxUsuarios.Text != "")
            {
                foreach (var auditoria in dict_adutoriasES)
                {
                    if (comboBoxUsuarios.Text != auditoria.Value.Usuario)
                    {
                        dict_adutoriasES.Remove(auditoria.Key);
                    }
                }
            }

            return dict_adutoriasES;
        }

        private void comboBoxFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonClearDate.Visible = true;
            actualizarGrid();
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonClearType.Visible = true;
            actualizarGrid();
        }

        private void comboBoxUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonClearUser.Visible = true;
            actualizarGrid();
        }

        private void buttonClearType_Click(object sender, EventArgs e)
        {
            comboBoxType.SelectedItem = null;
            buttonClearType.Visible = false;
            
        }

        private void buttonClearUser_Click(object sender, EventArgs e)
        {
            comboBoxUsuarios.SelectedItem = null;
            buttonClearUser.Visible = false;
            
        }

        private void buttonClearDate_Click(object sender, EventArgs e)
        {
            comboBoxFecha.SelectedItem = null;
            buttonClearDate.Visible = false;
            
        }
    }
}
