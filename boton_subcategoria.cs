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
    public partial class boton_subcategoria : Form
    {
        public boton_subcategoria()
        {
            InitializeComponent();
        }

        private void boton_subcategoria_Load(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_subcategoria_Click(object sender, EventArgs e)
        {
            ((seccion_categorias)Owner)?.eliminar_subcategoria();
        }

        private void btn_eliminar_subcategoria_MouseEnter(object sender, EventArgs e)
        {
            if (Owner is seccion_categorias categoriasForm)
            {
                categoriasForm.DetenerTimerOcultarBotones();
            }
        }

        private void btn_eliminar_subcategoria_MouseLeave(object sender, EventArgs e)
        {
            if (Owner is seccion_categorias categoriasForm)
            {
                categoriasForm.IniciarTimerOcultarBotones();
            }
        }
    }
}
