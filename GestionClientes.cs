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
			///SUBIR EL USUARIO
			if (todoCorrecto())
			{
				if (button_Uppload.Text == "Guardar")
				{
					ListViewItem selectedItem = listView_Clientes.SelectedItems[0];
					if (selectedItem.SubItems[0].Text != textbox_Nombre.Text)
					{
						FirebaseResponse delete = client.Delete("Clientes/" + selectedItem.SubItems[0].Text);
					}
					SetResponse response = await client.SetAsync("Clientes/" + textbox_Nombre.Text, genUser(dict_clientes));
					hideButtons();
					clearTextBox();
					actualizarLista();
				}
				else
				{
					if (noRepetingData(dict_clientes))
					{
						SetResponse response = await client.SetAsync("Clientes/" + textbox_Nombre.Text, genUser(dict_clientes));
						hideButtons();
						clearTextBox();
						actualizarLista();
					}
				}
			}
		}

		//GENERAR CLIENTE
		private Data_Client genUser(Dictionary<string, Data_Client> dict_clientes)
		{
			var data = new Data_Client
			{
				Nombre = textbox_Nombre.Text,
				Correo = textbox_Correo.Text,
				Telefono = textbox_Telefono.Text,
			};

			return data;
		}

		//CHECAR QUE TODOS LOS APARTADOS ESTEN COMPLETOS
		private bool todoCorrecto()
		{
			bool respuesta = false;

			//CHECAR QUE LOS CAMPOS NO ESTEN VACIOS
			if (textbox_Nombre.Text == "" || textbox_Correo.Text == "" || textbox_Telefono.Text == "")
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

			//CHECAR QUE LA TELEFONO SOLO CONTENGA NUMEROS Y QUE SEA UN TELEFONO COMPLETO
			if (long.TryParse(textbox_Telefono.Text, out long telefono) == false || textbox_Telefono.Text.Length == 11)
			{
				respuesta = false;
				MessageBox.Show("ERROR: EL FORMATO DEL TELEFONO NO ES VALIDO");
			}

			return respuesta;
		}

		//CHECAR QUE NO SE REPITA TELEFONO Y CORREO
		private bool noRepetingData(Dictionary<string, Data_Client> dict_clientes)
		{
			foreach (KeyValuePair<string, Data_Client> cliente in dict_clientes)
			{
				if (cliente.Value.Correo == textbox_Correo.Text)
				{
					MessageBox.Show("ERROR: EL CORREO YA ESTA EN USO");
					return false;
				}

				if (cliente.Value.Telefono == textbox_Telefono.Text)
				{
					MessageBox.Show("ERROR: EL NUMERO DE TELEFONO YA ESTA EN USO");
					return false;
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

			foreach (KeyValuePair<string, Data_Client> cliente in dict_clientes)
			{
				ListViewItem item = new ListViewItem(cliente.Key, 0);
				listView_Clientes.Items.Add(item);
			}
			listView_Clientes.Items.Add("Agregar", 1);
		}

		//BOTON DE BORRAR CLIENTE
		private void button_Delete_Click(object sender, EventArgs e)
		{
			FirebaseResponse delete = client.Delete("Clientes/" + textbox_Nombre.Text);
			clearTextBox();
			hideButtons();
			actualizarLista();
		}

		//CUANDO SELECIONAS EN EL LISTVIEW
		private void listView_Clientes_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			if (listView_Clientes.SelectedItems.Contains(listView_Clientes.Items[listView_Clientes.Items.Count - 1]))
			{
                textbox_Nombre.Clear();
                textbox_Correo.Clear();
                textbox_Telefono.Clear();
                button_Uppload.Text = "???";
                showButtons();
				button_Delete.Visible = false;
				button_Uppload.Text = "Subir";
                button_Uppload.Location = new System.Drawing.Point(956, 544);
            }
			else
			{
				if (listView_Clientes.SelectedItems.Count > 0)
				{
					showButtons();
					button_Uppload.Text = "Guardar";
                    button_Uppload.Location = new System.Drawing.Point(906, 544);
                    ListViewItem selectedItem = listView_Clientes.SelectedItems[0];
					fillTextBoxes(selectedItem.SubItems[0].Text);
				}
				else
				{
					hideButtons();
				}
			}
		}

		//RELLENAR LAS TEXBOCES
		private async void fillTextBoxes(string nombre)
		{
			foreach (KeyValuePair<string, Data_Client> cliente in dict_clientes)
			{
				if (cliente.Key == nombre)
				{
					textbox_Nombre.Text = cliente.Key;
					textbox_Correo.Text = cliente.Value.Correo;
					textbox_Telefono.Text = cliente.Value.Telefono;
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

			if(textBox_Search.Text != " ")
			{
				foreach (KeyValuePair<string, Data_Client> cliente in dict_clientes)
				{
					if (cliente.Key.ToLower().Contains(textBox_Search.Text.ToLower()))
					{
						ListViewItem item = new ListViewItem(cliente.Key, 0);
						listView_Clientes.Items.Add(item);
					}
				}
				listView_Clientes.Items.Add("Agregar", 1);
			}
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}
	}
}
