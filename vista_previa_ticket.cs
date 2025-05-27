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
    public partial class vista_previa_ticket : Form
    {
        private string ID;
        private string Ruta;

        public vista_previa_ticket(string ID, string Ruta)
        {
            InitializeComponent();
            this.ID = ID;
            this.Ruta = Ruta;
            MostrarReporteVentas(ID);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxVistaPrevia_TextChanged(object sender, EventArgs e)
        {

        }

        private void MostrarContenidoArchivo(string rutaArchivo)
        {
            try
            {
                // Lee todo el contenido del archivo
                string contenidoArchivo = System.IO.File.ReadAllText(rutaArchivo);

                // Muestra el contenido en el TextBox
                textBoxVistaPrevia.Text = contenidoArchivo;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo: {ex.Message}");
            }
        }

        // Método que se llamaría cuando quieras mostrar el archivo
        private void MostrarReporteVentas(string ID)
        {
            MostrarContenidoArchivo(Ruta);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
