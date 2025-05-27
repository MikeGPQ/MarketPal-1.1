using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MarketPal
{
    public partial class GestionClientes : Form
    {
        //INICIO
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "lvGHgu8Z3EYxWpBbAI8n8rCBWVncprXedJlfzfht",
            BasePath = "https://prueba-575f7-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        private Dictionary<string, Data_Client> dict_clientes;
        private string selectedUser;


        public GestionClientes()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            hideButtons();
            actualizarLista();
        }

        //BOTON PARA SUBIR DATOS
        private async void button_Uppload_Click(object sender, EventArgs e)
        {
            if (textBox_Tarjeta.Text != "")
            {
                SetResponse response = await client.SetAsync("Tarjetas/" + ("ID:" + textBox_Tarjeta.Text),"");
            }

            ///SUBIR EL USUARIO
            if (todoCorrecto() && noRepetingData(dict_clientes))
            {
                if (button_Uppload.Text == "Guardar")
                {
                    revisarTarjeta();
                    SetResponse response = await client.SetAsync("Clientes/" + ("ID:" + selectedUser), genUser(dict_clientes, false));
                    hideButtons();
                    clearTextBox();
                    actualizarLista();
                }
                else
                {
                    SetResponse response = await client.SetAsync("Clientes/" + ("ID:" + (checkMax(dict_clientes) + 1)), genUser(dict_clientes, true));
                    hideButtons();
                    clearTextBox();
                    actualizarLista();
                }

                
            }
        }

        private void revisarTarjeta()
        {
            if (textBox_Tarjeta.Text != dict_clientes["ID:" + selectedUser].Tarjeta && dict_clientes["ID:" + selectedUser].Tarjeta != null)
            {
                FirebaseResponse delete = client.Delete("Tarjetas/" + ("ID:" + dict_clientes["ID:" + selectedUser].Tarjeta));
            }
        }

        private int checkMax(Dictionary<string, Data_Client> dict_clientes)
        {
            if (dict_clientes != null)
            {
                return dict_clientes.Keys.ToList().Select(id => int.Parse(id.Split("ID:")[1])).ToList().Max();
            }
            return 0;
        }


        //GENERAR CLIENTE
        private Data_Client genUser(Dictionary<string, Data_Client> dict_clientes, bool newCliente)
        {
            var data = new Data_Client
            {
                Nombre = textbox_Nombre.Text,
                Correo = textbox_Correo.Text,
                Telefono = textbox_Telefono.Text,
                Tarjeta = textBox_Tarjeta.Text != "" ? textBox_Tarjeta.Text : null,
                Puntos = newCliente ? 0 : decimal.Parse(textBox_Puntos.Text),
                Fecha = newCliente ? DateTime.Now.ToString("d/M/yyyy") : dict_clientes[$"ID:{selectedUser}"].Fecha,
            };

            return data;
        }


        //CHECAR QUE TODOS LOS APARTADOS ESTEN COMPLETOS
        private bool todoCorrecto()
        {
            bool respuesta = false;

            //CHECAR QUE LOS CAMPOS NO ESTEN VACIOS
            if (textbox_Nombre.Text == "")
            {
                label_ErrorNombre.Visible = true;
                label_ErrorNombre.Text = "ERROR: HAY CAMPOS VACIOS";
            }
            else
            {
                respuesta = true;
            }

            //CHECAR QUE LOS CAMPOS NO ESTEN VACIOS
            if (textbox_Correo.Text == "")
            {
                label_ErrorCorreo.Visible = true;
                label_ErrorCorreo.Text = "ERROR: HAY CAMPOS VACIOS";
            }
            else
            {
                respuesta = true;
            }

            //CHECAR QUE LOS CAMPOS NO ESTEN VACIOS
            if (textbox_Telefono.Text == "")
            {
                label_ErrorCelular.Visible = true;
                label_ErrorCelular.Text = "ERROR: HAY CAMPOS VACIOS";
            }
            else
            {
                respuesta = true;
            }

            //CHECAR EL CORREO TENGA @
            if (textbox_Correo.Text.Contains('@') == false)
            {
                respuesta = false;
                label_ErrorCorreo.Visible = true;
                label_ErrorCorreo.Text = "ERROR: EL FORMATO DE CORREO NO ES VALIDO";
            }

            //CHECAR QUE SEA UN TELEFONO COMPLETO
            if (textbox_Telefono.Text.Length != 10)
            {
                respuesta = false;
                label_ErrorCelular.Visible = true;
                label_ErrorCelular.Text = "ERROR: AL TELEFONO LE FALTAN NUMEROS";
            }

            return respuesta;
        }

        //CHECAR QUE NO SE REPITA TELEFONO Y CORREO
        private bool noRepetingData(Dictionary<string, Data_Client> dict_clientes)
        {
            if(dict_clientes != null)
            {
                foreach (KeyValuePair<string, Data_Client> cliente in dict_clientes)
                {
                    if (cliente.Key != ("ID:" + selectedUser))
                    {
                        if (cliente.Value.Correo == textbox_Correo.Text)
                        {
                            label_ErrorCorreo.Visible = true;
                            label_ErrorCorreo.Text = "ERROR: EL CORREO YA ESTA EN USO";
                            return false;
                        }

                        if (cliente.Value.Telefono == textbox_Telefono.Text)
                        {
                            label_ErrorCelular.Visible = true;
                            label_ErrorCelular.Text = "ERROR: EL NUMERO DE TELEFONO YA ESTA EN USO";
                            return false;
                        }

                        if (cliente.Value.Tarjeta == textBox_Tarjeta.Text && cliente.Value.Tarjeta != null)
                        {
                            label_ErrorTarjeta.Visible = true;
                            label_ErrorTarjeta.Text = "ERROR: EL NUMERO DE TARJETA YA ESTA EN USO";
                            return false;
                        }
                    }

                }
            }
            
            return true;
        }

        //ACTUALIZAR LIST VIEW
        private async void actualizarLista()
        {
            listView_Clientes.Clear();
            FirebaseResponse clientes = await client.GetAsync("Clientes/");
            dict_clientes = clientes.ResultAs<Dictionary<string, Data_Client>>();
            if(dict_clientes != null)
            {
                foreach (KeyValuePair<string, Data_Client> cliente in dict_clientes)
                {
                    ListViewItem item = new ListViewItem(cliente.Value.Nombre + "\n" + cliente.Key, 0);
                    item.SubItems.Add(cliente.Key);
                    listView_Clientes.Items.Add(item);
                }
            }
            
            listView_Clientes.Items.Add("Agregar", 1);
        }

        //BOTON DE BORRAR CLIENTE
        private void button_Delete_Click(object sender, EventArgs e)
        {
            FirebaseResponse delete = client.Delete("Clientes/" + ("ID:" + selectedUser));
            FirebaseResponse deleteTarjeta = client.Delete("Tarjetas/" + ("ID:" + dict_clientes["ID:" + selectedUser].Tarjeta));
            clearTextBox();
            hideButtons();
            actualizarLista();
        }

        private void hideErrors()
        {
            label_ErrorCorreo.Visible = false;
            label_ErrorNombre.Visible = false;
            label_ErrorCelular.Visible = false;
            label_ErrorTarjeta.Visible = false;
        }

        //CUANDO SELECIONAS EN EL LISTVIEW
        private void listView_Clientes_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            hideErrors();
            if (listView_Clientes.SelectedItems.Contains(listView_Clientes.Items[listView_Clientes.Items.Count - 1]))
            {
                textbox_Nombre.Clear();
                textbox_Correo.Clear();
                textbox_Telefono.Clear();
                button_Uppload.Text = "???";
                button_Uppload.Location = new Point(968, 638);
                showButtons();
                button_Delete.Visible = false;
                button_Uppload.Text = "Subir";
                textBox_Puntos.Enabled = false;
                textBox_Puntos.Text = "0";
                textBox_Tarjeta.Clear();
                label7.Visible = false;
                textBox_Tarjeta.Visible = false;
                textBox_Tarjeta.Enabled = false;
                btnModificarTarjeta.Visible = false;
                button_Tarjeta.Visible = true;
                selectedUser = "";
            }
            else
            {
                if (listView_Clientes.SelectedItems.Count > 0)
                {
                    label7.Visible = false;
                    textBox_Tarjeta.Visible = false;
                    textBox_Tarjeta.Enabled = false;
                    textBox_Tarjeta.Clear();
                    button_Uppload.Location = new Point(910, 638);
                    button_Uppload.Text = "Guardar";
                    ListViewItem selectedItem = listView_Clientes.SelectedItems[0];
                    textBox_Puntos.Enabled = true;
                    selectedUser = selectedItem.SubItems[1].Text.Split("ID:")[1];
                    fillTextBoxes(selectedItem.SubItems[1].Text);
                    showButtons();
                }
                else
                {
                    hideButtons();
                }
            }
        }

        //RELLENAR LAS TEXBOCES
        private async void fillTextBoxes(string ID)
        {
            foreach (KeyValuePair<string, Data_Client> cliente in dict_clientes)
            {
                if (cliente.Key == ID)
                {
                    textbox_Nombre.Text = cliente.Value.Nombre;
                    textbox_Correo.Text = cliente.Value.Correo;
                    textbox_Telefono.Text = cliente.Value.Telefono;
                    textBox_Puntos.Text = "" + cliente.Value.Puntos;
                    if (cliente.Value.Tarjeta != null)
                    {
                        label7.Visible = true;
                        textBox_Tarjeta.Visible = true;
                        btnModificarTarjeta.Visible = true;
                        textBox_Tarjeta.Text = cliente.Value.Tarjeta;
                    }
                    else
                    {
                        button_Tarjeta.Visible = true;
                    }
                }
            }
        }

        //ESCONDER BOTONES
        private void hideButtons()
        {
            textbox_Nombre.Visible = false;
            textbox_Correo.Visible = false;
            textbox_Telefono.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            button_Uppload.Visible = false;
            button_Delete.Visible = false;
            textBox_Puntos.Visible = false;
            label6.Visible = false;
            textBox_Tarjeta.Visible = false;
            label7.Visible = false;
            button_Tarjeta.Visible = false;
            btnModificarTarjeta.Visible = false;
        }

        //MOSTRAR BOTONES
        private void showButtons()
        {
            label4.Visible = true;
            textbox_Nombre.Visible = true;
            textbox_Correo.Visible = true;
            textbox_Telefono.Visible = true;
            button_Delete.Visible = true;
            button_Uppload.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            textBox_Puntos.Visible = true;
            label6.Visible = true;
        }

        //LIMPIA LAS TEXT BOXES
        private void clearTextBox()
        {
            textBox_Search.TextChanged -= textBox_Search_TextChanged;
            textBox_Search.Clear();
            textBox_Search.TextChanged += textBox_Search_TextChanged;
            textbox_Nombre.Clear();
            textbox_Correo.Clear();
            textbox_Telefono.Clear();
            button_Uppload.Text = "???";
            textBox_Puntos.Clear();
            textBox_Tarjeta.Clear();
        }

        //BUSCADOR
        private async void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            hideButtons();
            if (listView_Clientes.SelectedIndices.Count > 0)
                for (int i = 0; i < listView_Clientes.SelectedIndices.Count; i++)
                {
                    listView_Clientes.Items[listView_Clientes.SelectedIndices[i]].Selected = false;
                }
            listView_Clientes.Clear();

            if (textBox_Search.Text != " ")
            {
                foreach (KeyValuePair<string, Data_Client> cliente in dict_clientes)
                {
                    if (cliente.Value.Nombre.ToLower().Contains(textBox_Search.Text.ToLower()))
                    {
                        ListViewItem item = new ListViewItem(cliente.Value.Nombre + "\n" + cliente.Key, 0);
                        item.SubItems.Add(cliente.Key);
                        listView_Clientes.Items.Add(item);
                    }
                }
                listView_Clientes.Items.Add("Agregar", 1);
            }
        }

        private void textbox_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void textBox_Puntos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_Tarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private void button_Tarjeta_Click(object sender, EventArgs e)
        {
            var forms_mensaje_tarjeta = new mensaje_tarjeta(this, false);
            forms_mensaje_tarjeta.ShowDialog();
        }

        private void btnModificarTarjeta_Click(object sender, EventArgs e)
        {
            var forms_mensaje_tarjeta = new mensaje_tarjeta(this, true);
            forms_mensaje_tarjeta.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textbox_Nombre_TextChanged(object sender, EventArgs e)
        {
            label_ErrorNombre.Visible = false;
            if (button_Uppload.Text == "Guardar")
            {
                foreach (KeyValuePair<string, Data_Client> cliente in dict_clientes)
                {
                    if (cliente.Key == ("ID:" + selectedUser))
                    {

                        if (cliente.Value.Nombre == textbox_Nombre.Text)
                        {

                            button_Uppload.Enabled = false;
                        }
                        else
                        {
                            button_Uppload.Enabled = true;
                        }
                    }
                }
            }
        }

        private void textbox_Correo_TextChanged(object sender, EventArgs e)
        {
            label_ErrorCorreo.Visible = false;
            if (button_Uppload.Text == "Guardar")
            {
                foreach (KeyValuePair<string, Data_Client> cliente in dict_clientes)
                {
                    if (cliente.Key == ("ID:" + selectedUser))
                    {

                        if (cliente.Value.Correo == textbox_Correo.Text)
                        {

                            button_Uppload.Enabled = false;
                        }
                        else
                        {
                            button_Uppload.Enabled = true;
                        }
                    }
                }
            }
        }

        private void textbox_Telefono_TextChanged(object sender, EventArgs e)
        {
            label_ErrorCelular.Visible = false;
            if (button_Uppload.Text == "Guardar")
            {
                foreach (KeyValuePair<string, Data_Client> cliente in dict_clientes)
                {
                    if (cliente.Key == ("ID:" + selectedUser))
                    {

                        if (cliente.Value.Telefono == textbox_Telefono.Text)
                        {

                            button_Uppload.Enabled = false;
                        }
                        else
                        {
                            button_Uppload.Enabled = true;
                        }
                    }
                }
            }
        }

        private void textBox_Puntos_TextChanged(object sender, EventArgs e)
        {
            if (button_Uppload.Text == "Guardar")
            {
                foreach (KeyValuePair<string, Data_Client> cliente in dict_clientes)
                {
                    if (cliente.Key == ("ID:" + selectedUser))
                    {

                        if (cliente.Value.Puntos.ToString() == textBox_Puntos.Text)
                        {

                            button_Uppload.Enabled = false;
                        }
                        else
                        {
                            button_Uppload.Enabled = true;
                        }
                    }
                }
            }
        }

        private void textBox_Tarjeta_TextChanged(object sender, EventArgs e)
        {
            label_ErrorTarjeta.Visible = false;
            if (button_Uppload.Text == "Guardar")
            {
                foreach (KeyValuePair<string, Data_Client> cliente in dict_clientes)
                {
                    if (cliente.Key == ("ID:" + selectedUser))
                    {

                        if (cliente.Value.Tarjeta == textBox_Tarjeta.Text)
                        {

                            button_Uppload.Enabled = false;
                        }
                        else
                        {
                            button_Uppload.Enabled = true;
                        }
                    }
                }
            }
        }
    }
}
