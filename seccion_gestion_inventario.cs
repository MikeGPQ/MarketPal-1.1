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
    public partial class seccion_gestion_inventario : Form
    {
        private Form formularioActivo = null;
        private string sucursalActual;
        public string rolUsuario;

        public seccion_gestion_inventario(string rol, string sucursal)
        {
            InitializeComponent();
            rolUsuario = rol;
            sucursalActual = sucursal;
        }

        private void seccion_gestion_inventario_Load(object sender, EventArgs e)
        {
            MostrarFormularioEnPanel(new seccion_productos(sucursalActual, null, null, rolUsuario), btn_productos);

            if (rolUsuario == "Usuario")
            {
                btn_categorias.Visible = false;
            }
        }

        private void btn_productos_Click(object sender, EventArgs e)
        {
            MostrarFormularioEnPanel(new seccion_productos(sucursalActual, null, null, rolUsuario), btn_productos);
        }

        private void btn_categorias_Click(object sender, EventArgs e)
        {
            MostrarFormularioEnPanel(new seccion_categorias(sucursalActual), btn_categorias);
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
    }
}
