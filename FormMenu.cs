using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using MarketPal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMenu : Form
    {
        private Form formularioActivo = null;
        private string sucursalActual;
        public string rolUsuario;
        private string nombreUsuario;
        private Dictionary<string, Auditoria> dict_adutoriasES;

        IFirebaseClient client;
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "lvGHgu8Z3EYxWpBbAI8n8rCBWVncprXedJlfzfht",
            BasePath = "https://prueba-575f7-default-rtdb.firebaseio.com/"
        };

        public FormMenu(string rol, string sucursal, string nombre)
        {
            InitializeComponent();
            sucursalActual = sucursal;
            rolUsuario = rol;
            nombreUsuario = nombre;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            if (rolUsuario == "Usuario")
            {
                button3.Visible = false;
                btnTarjeta.Visible = false;
            }

            client = new FireSharp.FirebaseClient(config);
            label_nombre_usuario.Text = nombreUsuario;
            label_rol_usuario.Text = rolUsuario;

            actualizarLibreria();
            MostrarFormularioEnPanel(new seccion_gestion_ventas(sucursalActual, nombreUsuario, rolUsuario), btn_ventas);
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
            panel1.Controls.Clear();
            panel1.Controls.Add(formulario);
            panel1.Tag = formulario;
            formulario.Show();

            ResaltarBotonSeleccionado(boton);
        }

        private void ResaltarBotonSeleccionado(Button botonSeleccionado)
        {
            foreach (Control control in panel2.Controls)
            {
                if (control is Button boton)
                {
                    boton.BackColor = Color.FromArgb(255, 200, 130);
                }
            }

            botonSeleccionado.BackColor = Color.FromArgb(250, 146, 31);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MostrarFormularioEnPanel(new seccion_gestion_usuarios_clientes(nombreUsuario), button3);
        }

        private void btn_inventario_Click(object sender, EventArgs e)
        {
            MostrarFormularioEnPanel(new seccion_gestion_inventario(rolUsuario, sucursalActual), btn_inventario);
        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            MostrarFormularioEnPanel(new seccion_gestion_ventas(sucursalActual, nombreUsuario, rolUsuario), btn_ventas);
        }

        private async void pictureBox_CerrarSesion_Click(object sender, EventArgs e)
        {
            SetResponse response = await client.SetAsync("AuditoriasES/" + ("ID:" + (checkMax(dict_adutoriasES) + 1)), GenAuditoriaES());
            this.Hide();
            var form = new Inicio();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private object GenAuditoriaES()
        {
            var auditoriaEs = new
            {
                Fecha = DateTime.Now.ToString("dd-MM-yyyy"),
                Hora = DateTime.Now.ToString("hh:mm:ss tt"),
                Usuario = nombreUsuario,
                Tipo = "Salida"
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
            if (dict_adutoriasES != null)
            {
                return dict_adutoriasES.Keys.ToList().Select(id => int.Parse(id.Split("ID:")[1])).ToList().Max();
            }
            return 0;
        }


        private void pictureBox_CerrarSesion_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_CerrarSesion.Cursor = Cursors.Default;
        }

        private void pictureBox_CerrarSesion_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_CerrarSesion.Cursor = Cursors.Hand;
        }

        private void btnTarjeta_Click(object sender, EventArgs e)
        {
            MostrarFormularioEnPanel(new seccion_tarjetas(), btnTarjeta);
        }
    }
}
