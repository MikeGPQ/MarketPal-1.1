using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using RestSharp.Extensions;
using System.Text.Json;
using System.Text.Json.Nodes;
using Newtonsoft.Json.Linq;
using FireSharp.Extensions;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MarketPal
{
    public partial class GestionUsuarios : Form
    {
        //INICIO
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "lvGHgu8Z3EYxWpBbAI8n8rCBWVncprXedJlfzfht",
            BasePath = "https://prueba-575f7-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        private Dictionary<string, Data> dict_usuarios;
        private string nombreUsuario;
        private string selectedUser;

        public GestionUsuarios(string nombre)
        {
            InitializeComponent();
            nombreUsuario = nombre;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            hideButtons();
            actualizarLista();
        }

        private void textbox_Nombre_TextChanged(object sender, EventArgs e)
        {
            label_ErrorNombre.Visible = false;
            if (button_Upload.Text == "Guardar")
            {
                foreach (KeyValuePair<string, Data> usuario in dict_usuarios)
                {
                    if (usuario.Key == ("ID:" + selectedUser))
                    {
                        if (usuario.Value.Nombre == textbox_Nombre.Text)
                        {
                            button_Upload.Enabled = false;
                        }
                        else
                        {
                            button_Upload.Enabled = true;
                        }
                    }
                }
            }
        }

        private void textbox_Correo_TextChanged(object sender, EventArgs e)
        {
            label_ErrorCorreo.Visible = false;
            if (button_Upload.Text == "Guardar")
            {
                foreach (KeyValuePair<string, Data> usuario in dict_usuarios)
                {
                    if (usuario.Key == ("ID:" + selectedUser))
                    {
                        if (usuario.Value.Correo == textbox_Correo.Text)
                        {
                            button_Upload.Enabled = false;
                        }
                        else
                        {
                            button_Upload.Enabled = true;
                        }
                    }
                }
            }
        }

        private void textbox_id_TextChanged(object sender, EventArgs e)
        {

        }

        //BOTON PARA SUBIR ARCHIVOS
        private async void button_Upload_Click(object sender, EventArgs e)
        {
            ///SUBIR EL USUARIO
            if (todoCorrecto() && noRepetingData(dict_usuarios))
            {
                if (button_Upload.Text == "Guardar")
                {
                    SetResponse response = await client.SetAsync("Usuarios/" + ("ID:" + selectedUser), genUser(dict_usuarios, false));
                    hideButtons();
                    clearTextBox();
                    actualizarLista();
                }
                else
                {
                    //VER QUE NO NO HAYA CORREO O ID REPETIDA
                    SetResponse response = await client.SetAsync("Usuarios/" + ("ID:" + (checkMax(dict_usuarios) + 1)), genUser(dict_usuarios, true));
                    hideButtons();
                    clearTextBox();
                    actualizarLista();
                }
            }
        }

        private int checkMax(Dictionary<string, Data> dict_usuarios)
        {
            return dict_usuarios.Keys.ToList().Select(id => int.Parse(id.Split("ID:")[1])).ToList().Max();
        }

        //GENERAR USUARIO
        private Data genUser(Dictionary<string, Data> dict_usuarios, bool creacion)
        {
            var data = new Data
            {
                Nombre = textbox_Nombre.Text,
                Correo = textbox_Correo.Text,
                Rol = combobox_Rol.Text,
                Password = creacion ? passwordGen(dict_usuarios) : dict_usuarios[$"ID:{selectedUser}"].Password
            };

            return data;
        }

        //CHECAR QUE TODOS LOS CAMPOS ESTEN COMPLETOS
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
            if (combobox_Rol.Text == "")
            {
                label_ErrorRol.Visible = true;
                label_ErrorRol.Text = "ERROR: HAY CAMPOS VACIOS";
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

            return respuesta;
        }

        //GENERAR CONTRASENA DE 8 DIGITOS CON NUMEROS AL AZAR, TAMBIEN COMPRUEBA QUE NO SE REPITA
        private string passwordGen(Dictionary<string, Data> dict_usuarios)
        {
            int n = 8;
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();

            while (0 < n--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }

            foreach (KeyValuePair<string, Data> usuario in dict_usuarios)
            {
                if (usuario.Value.Password == res.ToString())
                {
                    passwordGen(dict_usuarios);
                }
            }
            MessageBox.Show($"Contraseña generada: {res.ToString()}.");
            return res.ToString();
        }

        //CHECA QUE NO SE REPITA LA ID Y EL CORREO INTRODUCIDO
        private bool noRepetingData(Dictionary<string, Data> dict_usuarios)
        {
            foreach (KeyValuePair<string, Data> usuario in dict_usuarios)
            {
                if (usuario.Key != ("ID:" + selectedUser))
                {
                    if (usuario.Value.Correo == textbox_Correo.Text)
                    {
                        label_ErrorCorreo.Visible = true;
                        label_ErrorCorreo.Text = "ERROR: EL CORREO YA ESTA EN USO";
                        return false;
                    }
                }
            }
            return true;
        }

        //BOTON PARA BORRAR UN REGISTRO, SOLO ESTA HABILITADO SI TIENES UN USARIO SELECIONADO
        private async void button_Delete_Click(object sender, EventArgs e)
        {
            FirebaseResponse delete = client.Delete("Usuarios/" + ("ID:" + selectedUser));
            hideButtons();
            clearTextBox();
            actualizarLista();
        }

        private void hideErrors()
        {
            label_ErrorCorreo.Visible = false;
            label_ErrorNombre.Visible = false;
            label_ErrorRol.Visible = false;
        }

        //SE TRIGEREA CUANDO SE SELECIONA UN ITEM DE LA LISTA
        private void listView_Usuarios_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            hideErrors();
            if (listView_Usuarios.SelectedItems.Contains(listView_Usuarios.Items[listView_Usuarios.Items.Count - 1]))
            {
                textbox_Nombre.Enabled = true;
                textbox_Correo.Enabled = true;
                combobox_Rol.Enabled = true;
                button_Delete.Enabled = true;
                button_Upload.Enabled = true;
                textbox_Nombre.Clear();
                textbox_Correo.Clear();
                combobox_Rol.SelectedIndex = -1;
                button_Upload.Text = "???";
                showButtons();
                button_Delete.Visible = false;
                button_Upload.Text = "Subir";
                selectedUser = "";

                button_Upload.Location = new System.Drawing.Point(956, 544);
            }
            else
            {
                if (listView_Usuarios.SelectedItems.Count > 0)
                {
                    showButtons();
                    button_Upload.Text = "Guardar";
                    button_Upload.Enabled = false;
                    button_Upload.Location = new System.Drawing.Point(906, 544);
                    ListViewItem selectedItem = listView_Usuarios.SelectedItems[0];
                    selectedUser = selectedItem.SubItems[1].Text.Split("ID:")[1];
                    fillTextBoxes(selectedItem.SubItems[1].Text);

                    if (selectedItem.SubItems[0].Text.Split("\n")[0] == nombreUsuario)
                    {
                        textbox_Nombre.Enabled = false;
                        textbox_Correo.Enabled = false;
                        combobox_Rol.Enabled = false;
                        button_Delete.Enabled = false;
                        button_Upload.Enabled = false;
                    }
                    else
                    {
                        textbox_Nombre.Enabled = true;
                        textbox_Correo.Enabled = true;
                        combobox_Rol.Enabled = true;
                        button_Delete.Enabled = true;
                    }

                }
                else
                {
                    hideButtons();
                }
            }
        }

        //ACTUALIZA Y LLENA EL LIST VIEW
        private async void actualizarLista()
        {
            listView_Usuarios.Clear();
            FirebaseResponse usuarios = await client.GetAsync("Usuarios/");
            dict_usuarios = usuarios.ResultAs<Dictionary<string, Data>>();

            foreach (KeyValuePair<string, Data> usuario in dict_usuarios)
            {
                if (usuario.Value.Rol == "Administrador")
                {
                    ListViewItem item = new ListViewItem(usuario.Value.Nombre + "\n" + usuario.Key, 2);
                    item.SubItems.Add(usuario.Key);
                    listView_Usuarios.Items.Add(item);
                }
                else
                {
                    ListViewItem item = new ListViewItem(usuario.Value.Nombre + "\n" + usuario.Key, 0);
                    item.SubItems.Add(usuario.Key);
                    listView_Usuarios.Items.Add(item);
                }
            }
            listView_Usuarios.Items.Add("Agregar", 1);
        }

        //LLENA LAS TEXT BOXES DE DATOS DEL USUARIO
        private async void fillTextBoxes(string ID)
        {
            foreach (KeyValuePair<string, Data> usuario in dict_usuarios)
            {
                if (usuario.Key == ID)
                {
                    textbox_Nombre.Text = usuario.Value.Nombre;
                    textbox_Correo.Text = usuario.Value.Correo;
                    combobox_Rol.Text = usuario.Value.Rol;
                }
            }
        }

        //LIMPIA LAS TEXT BOXES
        private void clearTextBox()
        {
            textBox_Search.TextChanged -= textBox_Search_TextChanged;
            textBox_Search.Clear();
            textBox_Search.TextChanged += textBox_Search_TextChanged;
            textbox_Nombre.Clear();
            textbox_Correo.Clear();
            combobox_Rol.SelectedIndex = -1;
            button_Upload.Text = "???";
        }

        //ESCONDER BOTONES
        private void hideButtons()
        {
            label6.Visible = false;
            textbox_Nombre.Visible = false;
            textbox_Correo.Visible = false;
            combobox_Rol.Visible = false;
            button_Delete.Visible = false;
            button_Upload.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label4.Visible = false;
        }

        //MOSTRAR BOTONES
        private void showButtons()
        {
            label6.Visible = true;
            textbox_Nombre.Visible = true;
            textbox_Correo.Visible = true;
            combobox_Rol.Visible = true;
            button_Delete.Visible = true;
            button_Upload.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label4.Visible = true;
        }

        //BUSCADOR
        private async void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            hideButtons();
            if (listView_Usuarios.SelectedIndices.Count > 0)
                for (int i = 0; i < listView_Usuarios.SelectedIndices.Count; i++)
                {
                    listView_Usuarios.Items[listView_Usuarios.SelectedIndices[i]].Selected = false;
                }
            listView_Usuarios.Clear();

            if (textBox_Search.Text != " ")
            {
                foreach (KeyValuePair<string, Data> usuario in dict_usuarios)
                {
                    if (usuario.Value.Nombre.ToLower().Contains(textBox_Search.Text.ToLower()))
                    {
                        ListViewItem item = new ListViewItem(usuario.Value.Nombre + "\n" + usuario.Key, 0);
                        item.SubItems.Add(usuario.Key);
                        listView_Usuarios.Items.Add(item);
                    }
                }
                listView_Usuarios.Items.Add("Agregar", 1);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void combobox_Rol_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_ErrorRol.Visible = false;
            if (button_Upload.Text == "Guardar")
            {
                foreach (KeyValuePair<string, Data> usuario in dict_usuarios)
                {
                    if (usuario.Key == ("ID:" + selectedUser))
                    {
                        if (usuario.Value.Rol == combobox_Rol.Text)
                        {
                            button_Upload.Enabled = false;
                        }
                        else
                        {
                            button_Upload.Enabled = true;
                        }
                    }
                }
            }
        }
    }
}
