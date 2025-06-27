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
    public partial class codigoVerificacion : Form
    {
        public string CodigoIngresado;

        public codigoVerificacion()
        {
            InitializeComponent();
        }

        private void codigoVerificacion_Load(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            CodigoIngresado = null;
            this.Close();
        }

        private void textBox_Ok_Click(object sender, EventArgs e)
        {
            CodigoIngresado = textBox_CodigoVerificacion.Text;
            this.Close();
        }
    }
}
