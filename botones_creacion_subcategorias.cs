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
    public partial class botones_creacion_subcategorias : Form
    {
        public botones_creacion_subcategorias()
        {
            InitializeComponent();
        }

        private void botones_creacion_subcategorias_Load(object sender, EventArgs e)
        {

        }

        private void btn_confirmar_creacion_subcategoria_Click(object sender, EventArgs e)
        {
            ((seccion_categorias)Owner)?.ConfirmarCreacionSubcategoria();
        }

        private void btn_cancelar_creacion_subcategoria_Click(object sender, EventArgs e)
        {
            ((seccion_categorias)Owner)?.CancelarCreacionSubcategoria();
            ((seccion_categorias)Owner)?.ActivarScroll();
            ((seccion_categorias)Owner)?.treeview_arbol_categorias.ExpandAll();
        }
    }
}
