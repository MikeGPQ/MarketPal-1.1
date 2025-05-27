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
    public partial class mensaje_aviso : Form
    {
        public mensaje_aviso()
        {
            InitializeComponent();
        }

        private void mensaje_aviso_Load(object sender, EventArgs e)
        {

        }

        public void ConfigurarAviso(string mensaje, Color colorTexto, Image imagen)
        {
            label_aviso.Text = mensaje;
            label_aviso.ForeColor = colorTexto;
            picturebox_imagen_aviso.Image = imagen;
        }

        private void btn_cerrar_aviso_Click(object sender, EventArgs e)
        {
            if (this.Parent is Panel parentPanel)
            {
                this.Hide();
                parentPanel.Visible = false;
            }
            else
            {
                this.Close();
            }
        }

        private void label_aviso_Click(object sender, EventArgs e)
        {

        }

        private void picturebox_imagen_aviso_Click(object sender, EventArgs e)
        {

        }
    }
}
