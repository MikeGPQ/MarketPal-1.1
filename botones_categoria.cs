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
    public partial class botones_categoria : Form
    {
        public botones_categoria()
        {
            InitializeComponent();
        }

        private void botones_categoria_Load(object sender, EventArgs e)
        {

        }

        private void btn_agregar_categoria_Click(object sender, EventArgs e)
        {
            ((seccion_categorias)Owner)?.agregar_categoria();
        }

        private void btn_eliminar_categoria_Click(object sender, EventArgs e)
        {
            ((seccion_categorias)Owner)?.eliminar_categoria();
        }

        private void btn_agregar_categoria_MouseEnter(object sender, EventArgs e)
        {
            if (Owner is seccion_categorias categoriasForm)
            {
                categoriasForm.DetenerTimerOcultarBotones();
            }
        }

        private void btn_agregar_categoria_MouseLeave(object sender, EventArgs e)
        {
            if (Owner is seccion_categorias categoriasForm)
            {
                categoriasForm.IniciarTimerOcultarBotones();
            }
        }

        private void btn_eliminar_categoria_MouseEnter(object sender, EventArgs e)
        {
            if (Owner is seccion_categorias categoriasForm)
            {
                categoriasForm.DetenerTimerOcultarBotones();
            }
        }

        private void btn_eliminar_categoria_MouseLeave(object sender, EventArgs e)
        {
            if (Owner is seccion_categorias categoriasForm)
            {
                categoriasForm.IniciarTimerOcultarBotones();
            }
        }
    }
}
