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

namespace MarketPal
{
    public partial class mensaje_tarjeta : Form
    {
        private GestionClientes formsGestionClientes;
        private bool esEdicion;

        public mensaje_tarjeta(GestionClientes formsGestionClientes, bool esEdicion)
        {
            this.formsGestionClientes = formsGestionClientes;
            this.esEdicion = esEdicion;
            InitializeComponent();
        }

        private void mensaje_tarjeta_Load(object sender, EventArgs e)
        {
            textBox_id_tarjeta.Focus();
        }

        private void textBox_id_tarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (!esEdicion)
                {
                    formsGestionClientes.button_Tarjeta.Visible = false;
                    formsGestionClientes.label7.Visible = true;
                    formsGestionClientes.textBox_Tarjeta.Visible = true;
                    formsGestionClientes.btnModificarTarjeta.Visible = true;
                }
                formsGestionClientes.textBox_Tarjeta.Text = textBox_id_tarjeta.Text;
                this.Close();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (!esEdicion)
            {
                formsGestionClientes.button_Tarjeta.Visible = true;
                formsGestionClientes.label7.Visible = false;
                formsGestionClientes.textBox_Tarjeta.Visible = false;
                formsGestionClientes.btnModificarTarjeta.Visible = false;
            }
            this.Close();
        }

        private void label_mensaje_tarjeta_Click(object sender, EventArgs e)
        {

        }
    }
}
