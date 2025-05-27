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
    public partial class seccion_gestion_usuarios_clientes : Form
    {
        private Form formularioActivo = null;
        private string nombreUsuario;

        public seccion_gestion_usuarios_clientes(string nombre)
        {
            InitializeComponent();
            nombreUsuario = nombre;
        }

        public void MostrarFormularioEnPanel(Form formulario, Button boton)
        {
            if (formularioActivo != null && formularioActivo.GetType() == formulario.GetType())
            {
                formularioActivo.Close();
            }

            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panel_gestion_inventario.Controls.Clear();
            panel_gestion_inventario.Controls.Add(formulario);
            panel_gestion_inventario.Tag = formulario;
            formulario.Show();

            ResaltarBotonSeleccionado(boton);
        }

        private void ResaltarBotonSeleccionado(Button botonSeleccionado)
        {
            foreach (Control control in panel_navegacion.Controls)
            {
                if (control is Button boton)
                {
                    boton.BackColor = Color.FromArgb(255, 224, 183);
                }
            }

            botonSeleccionado.BackColor = Color.FromArgb(250, 146, 31);
        }


        private void panel_gestion_inventario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_navegacion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_productos_Click_1(object sender, EventArgs e)
        {
            MostrarFormularioEnPanel(new GestionUsuarios(nombreUsuario), btn_productos);
        }

        private void seccion_gestion_usuarios_clientes_Load(object sender, EventArgs e)
        {
            MostrarFormularioEnPanel(new GestionUsuarios(nombreUsuario), btn_productos);
        }

        private void btn_categorias_Click_1(object sender, EventArgs e)
        {
            MostrarFormularioEnPanel(new GestionClientes(), btn_categorias);
        }

        private void panel_gestion_inventario_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel_navegacion_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
