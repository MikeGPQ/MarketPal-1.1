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
using System.Security.Cryptography;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Net.Mail;

namespace MarketPal
{
    public partial class Inicio : Form
    {
        string sucursalId = "Sucursal1";
        string rolUsuario;
        string nombreUsuario;
        DateTime fechaExpiracionCodigo;
        string codigoVerificacion;


        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "lvGHgu8Z3EYxWpBbAI8n8rCBWVncprXedJlfzfht",
            BasePath = "https://prueba-575f7-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        int intentos = 3;
        private Dictionary<string, Auditoria> dict_adutoriasES;

        public Inicio()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            actualizarLibreria();
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
                            codigoVerificacion = GenerarCodigoVerificacion();
                            fechaExpiracionCodigo = DateTime.Now.AddMinutes(5);
                            MessageBox.Show(codigoVerificacion);
                            //await EnviarCodigoPorCorreo(textBox_Correo.Text, codigoVerificacion);

                            var tempCodigoForm = new codigoVerificacion();
                            tempCodigoForm.ShowDialog();
                            if(tempCodigoForm.CodigoIngresado != null)
                            {
                                if (ValidarCodigoVerificacion(tempCodigoForm.CodigoIngresado))
                                {
                                    SetResponse response = await client.SetAsync("AuditoriasES/" + ("ID:" + (checkMax(dict_adutoriasES) + 1)), GenAuditoriaES());
                                    this.Hide();
                                    var form = new FormMenu(rolUsuario, sucursalId, nombreUsuario);
                                    form.Closed += (s, args) => this.Close();
                                    form.Show();
                                }
                            }
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

        private string GenerarCodigoVerificacion()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString(); 
        }

        private async Task EnviarCodigoPorCorreo(string email, string codigo)
        {
            var apiKey = "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";
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("miguelgarciaparra@hotmail.com", "MarketPal");
            var to = new EmailAddress(email);
            var subject = "Tu código de verificación para MarketPal";
            var plainTextContent = $"Tu código de verificación es: {codigo}";
            var htmlContent = $"<strong>Tu código de verificación es: {codigo}</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }

        private bool ValidarCodigoVerificacion(string codigoIngresado)
        {
            return codigoIngresado == codigoVerificacion && DateTime.Now <= fechaExpiracionCodigo;
        }


        private object GenAuditoriaES()
        {
            var auditoriaEs = new
            {
                Fecha = DateTime.Now.ToString("dd-MM-yyyy"),
                Hora = DateTime.Now.ToString("hh:mm:ss tt"),
                Usuario = nombreUsuario,
                Tipo = "Entrada"
            };
            return auditoriaEs;
        }

        private async void actualizarLibreria()
        {
            FirebaseResponse auditorias = await client.GetAsync("AuditoriasES/");
            dict_adutoriasES = auditorias.ResultAs<Dictionary<string, Auditoria>>();
        } 

        private int checkMax(Dictionary<string, Auditoria> dict_adutoriasES)
        {
            if(dict_adutoriasES != null)
            {
                
                return dict_adutoriasES.Keys.ToList().Select(id => int.Parse(id.Split("ID:")[1])).ToList().Max();
            }
            return 0;
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
                    if (usuario.Value.Password == HashCode(textBox_Password.Text))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        //CIFRADO
        private string HashCode(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                
                byte[] bytes = Encoding.UTF8.GetBytes(password);
               
                byte[] hashBytes = sha256.ComputeHash(bytes);

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2")); 
                }
                
                return builder.ToString();
            }
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
