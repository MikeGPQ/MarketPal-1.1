using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp;
using WindowsFormsApp1;

namespace MarketPal
{
    public partial class Inicio : Form
    {
        string sucursalId = "Sucursal1";
        string rolUsuario;
        string nombreUsuario;

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "lvGHgu8Z3EYxWpBbAI8n8rCBWVncprXedJlfzfht",
            BasePath = "https://prueba-575f7-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        int intentos = 3;

        public Inicio()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }

        private async void textBox_iniciarSesion_Click(object sender, EventArgs e)
        {
            //SI FALLAS 3 VECES SE CIERRA LA APP
            if (intentos == 0)
            {
                this.Close();
            }
            else
            {
                bool todoCorrecto = false;

                //CHECAR EL CORREO TENGA @
                if (textBox_Correo.Text.Contains('@') == false)
                {
                    todoCorrecto = false;
                    label3.Visible = true;
                    label3.Text = "El correo ingresado no es válido.";
                }
                else
                {
                    todoCorrecto = true;
                }

                //FORMATO CORRECTO, AHORA A VALIDAR DATOS
                if (todoCorrecto)
                {
                    FirebaseResponse usuarios = await client.GetAsync("Usuarios/");
                    var dict_usuarios = usuarios.ResultAs<Dictionary<string, Data>>();
                    //REVISAR QUE EL CORREO EXISTA EN LA BASE DE DATOS
                    if (correoExiste(dict_usuarios))
                    {
                        intentos--;
                        //REVISAR QUE LA CONTRASENA SEA CORRECTA
                        if (revisarPassword(dict_usuarios))
                        {
                            this.Hide();
                            var form = new FormMenu(rolUsuario, sucursalId, nombreUsuario);
                            form.Closed += (s, args) => this.Close();
                            form.Show();
                        }
                        else
                        {
                            label3.Visible = true;
                            label3.Text = "La contraseña es incorrecta.";
                        }
                    }
                }
            }
        }

        private bool correoExiste(Dictionary<string, Data> dict_usuarios)
        {
            foreach (KeyValuePair<string, Data> usuario in dict_usuarios)
            {
                if(usuario.Value.Habilitado != false)
                {
                    if (usuario.Value.Correo == textBox_Correo.Text)
                    {
                        rolUsuario = usuario.Value.Rol;
                        nombreUsuario = usuario.Value.Nombre;
                        return true;
                    }
                }
            }
            label3.Visible = true;
            label3.Text = "No existe una cuenta asociada al correo electrónico ingresado.";
            return false;
        }

        private bool revisarPassword(Dictionary<string, Data> dict_usuarios)
        {
            foreach (KeyValuePair<string, Data> usuario in dict_usuarios)
            {
                if (usuario.Value.Correo == textBox_Correo.Text)
                {
                    if (usuario.Value.Password == textBox_Password.Text)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {
            label3.Visible = false;
            textBox_iniciarSesion.Enabled = !string.IsNullOrEmpty(textBox_Correo.Text.Trim()) && !string.IsNullOrEmpty(textBox_Password.Text.Trim());
        }

        private void textBox_Correo_TextChanged(object sender, EventArgs e)
        {
            label3.Visible = false;
            textBox_iniciarSesion.Enabled = !string.IsNullOrEmpty(textBox_Correo.Text.Trim()) && !string.IsNullOrEmpty(textBox_Password.Text.Trim());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
