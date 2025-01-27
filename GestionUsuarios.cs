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
			AuthSecret= "lvGHgu8Z3EYxWpBbAI8n8rCBWVncprXedJlfzfht",
			BasePath= "https://prueba-575f7-default-rtdb.firebaseio.com/"
		};

		IFirebaseClient client; 
		private Dictionary<string, Data> dict_usuarios;
        private string nombreUsuario;

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

		}

		private void textbox_Correo_TextChanged(object sender, EventArgs e)
		{

		}

		private void textbox_id_TextChanged(object sender, EventArgs e)
		{

		}

		//BOTON PARA SUBIR ARCHIVOS
		private async void button_Upload_Click(object sender, EventArgs e)
		{
			///SUBIR EL USUARIO
			if (todoCorrecto()){
				if (textbox_id.ReadOnly == true)
				{
					SetResponse response = await client.SetAsync("Usuarios/" + ("ID:" + textbox_id.Text), genUser(dict_usuarios, false));
					hideButtons();
					clearTextBox();
					actualizarLista();
				}
				else
				{
					//VER QUE NO NO HAYA CORREO O ID REPETIDA
					if (noRepetingData(dict_usuarios))
					{
						SetResponse response = await client.SetAsync("Usuarios/" + ("ID:" + textbox_id.Text), genUser(dict_usuarios, true));
						hideButtons();
						clearTextBox();
						actualizarLista();
					}
				}
			}	
		}

		//GENERAR USUARIO
		private Data genUser(Dictionary<string, Data> dict_usuarios, bool creacion)
		{
			var data = new Data
			{
				Nombre = textbox_Nombre.Text,
				Correo = textbox_Correo.Text,
				Rol = combobox_Rol.Text,
				Password = creacion ? passwordGen(dict_usuarios) : dict_usuarios[$"ID:{textbox_id.Text}"].Password
			};

			return data; 
		}

		//CHECAR QUE TODOS LOS CAMPOS ESTEN COMPLETOS
		private bool todoCorrecto()
		{
			bool respuesta = false;
			//CHECAR QUE LOS CAMPOS NO ESTEN VACIOS
			if (textbox_Nombre.Text == "" || textbox_Correo.Text == "" || textbox_id.Text == "" || combobox_Rol.Text == "")
			{
				MessageBox.Show("ERROR: HAY CAMPOS VACIOS");
			}
			else
			{
				respuesta = true;
			}

			//CHECAR EL CORREO TENGA @
			if (textbox_Correo.Text.Contains('@') == false)
			{
				respuesta = false;
				MessageBox.Show("ERROR: EL FORMATO DE CORREO NO ES VALIDO");
			}

			//CHECAR QUE LA ID SOLO CONTENGA NUMEROS
			if (int.TryParse(textbox_id.Text, out int id) == false)
			{
				respuesta = false;
				MessageBox.Show("ERROR: EL FORMATO DEL ID NO ES VALIDO");
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
				if (usuario.Value.Correo == textbox_Correo.Text)
				{
					MessageBox.Show("ERROR: EL CORREO YA ESTA EN USO");
					return false;
				}

				if (usuario.Key == ("ID:" + textbox_id.Text))
				{
					MessageBox.Show("ERROR: EL ID YA ESTA EN USO");
					return false;
				}
			}
			return true;
		}

		//BOTON PARA BORRAR UN REGISTRO, SOLO ESTA HABILITADO SI TIENES UN USARIO SELECIONADO
		private async void button_Delete_Click(object sender, EventArgs e)
		{
			FirebaseResponse delete = client.Delete("Usuarios/" + ("ID:" + textbox_id.Text));
			hideButtons();
			clearTextBox();
			actualizarLista();
		}

		//SE TRIGEREA CUANDO SE SELECIONA UN ITEM DE LA LISTA
		private void listView_Usuarios_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			if (listView_Usuarios.SelectedItems.Contains(listView_Usuarios.Items[listView_Usuarios.Items.Count-1]))
			{
                textbox_id.Enabled = true;
				textbox_id.ReadOnly = false;
                textbox_Nombre.Enabled = true;
                textbox_Correo.Enabled = true;
                combobox_Rol.Enabled = true;
                button_Delete.Enabled = true;
                button_Upload.Enabled = true;
                textbox_Nombre.Clear();
                textbox_Correo.Clear();
                textbox_id.Clear();
                combobox_Rol.SelectedIndex = -1;
                button_Upload.Text = "???";
                showButtons();
				button_Delete.Visible = false;
				button_Upload.Text = "Subir";
				button_Upload.Location = new System.Drawing.Point(956, 544);
			}
			else
			{
				if (listView_Usuarios.SelectedItems.Count > 0)
				{
					showButtons();
					button_Upload.Text = "Guardar";
                    button_Upload.Location = new System.Drawing.Point(906, 544);
                    ListViewItem selectedItem = listView_Usuarios.SelectedItems[0];
					fillTextBoxes(selectedItem.SubItems[1].Text);

                    textbox_id.Enabled = false;
                    textbox_id.ReadOnly = true;

                    if (selectedItem.SubItems[0].Text.Split("\n")[0] == nombreUsuario)
					{
						textbox_Nombre.Enabled = false;
						textbox_Correo.Enabled = false;
						combobox_Rol.Enabled = false;
						button_Delete.Enabled = false;
						button_Upload.Enabled = false;
					} else
					{
                        textbox_Nombre.Enabled = true;
                        textbox_Correo.Enabled = true;
                        combobox_Rol.Enabled = true;
                        button_Delete.Enabled = true;
                        button_Upload.Enabled = true;
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
				ListViewItem item = new ListViewItem(usuario.Value.Nombre + "\n" + usuario.Key, 0);
				item.SubItems.Add(usuario.Key);
				listView_Usuarios.Items.Add(item);
			}
			listView_Usuarios.Items.Add("Agregar", 1);
		}

		//LLENA LAS TEXT BOXES DE DATOS DEL USUARIO
		private async void fillTextBoxes(string ID)
		{
			foreach (KeyValuePair<string, Data> usuario in dict_usuarios)
			{
				if(usuario.Key == ID)
				{
					textbox_Nombre.Text = usuario.Value.Nombre;
					textbox_Correo.Text = usuario.Value.Correo;
					textbox_id.Text = usuario.Key.Substring(3);
					combobox_Rol.Text = usuario.Value.Rol;

					textbox_id.ReadOnly =true;
				}
			}
		}

		//LIMPIA LAS TEXT BOXES
		private void clearTextBox()
		{
			textBox_Search.TextChanged -= textBox_Search_TextChanged;
			textBox_Search.Clear();
			textBox_Search.TextChanged += textBox_Search_TextChanged;
			textbox_id.ReadOnly = false;
			textbox_Nombre.Clear();
			textbox_Correo.Clear();
			textbox_id.Clear();
			combobox_Rol.SelectedIndex = -1;
			button_Upload.Text = "???";
		}

		//ESCONDER BOTONES
		private void hideButtons()
		{
			label6.Visible = false;
			textbox_Nombre.Visible = false;
			textbox_Correo.Visible = false;
			textbox_id.Visible = false;
			combobox_Rol.Visible = false;
			button_Delete.Visible = false;
			button_Upload.Visible = false;
			label1.Visible = false;
			label2.Visible = false;
			label3.Visible = false;
			label4.Visible = false;
		}

		//MOSTRAR BOTONES
		private void showButtons()
		{
			label6.Visible = true;
			textbox_Nombre.Visible = true;
			textbox_Correo.Visible = true;
			textbox_id.Visible = true;
			combobox_Rol.Visible = true;
			button_Delete.Visible = true;
			button_Upload.Visible = true;
			label1.Visible = true;
			label2.Visible = true;
			label3.Visible = true;
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
	}
}
