using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Open_Restaurante
{
    public partial class NewProducto : Form
    {
        public NewProducto()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtproducto.Text = txtprecio.Text = txtdescripcion.Text = String.Empty;
            txtproducto.Select();
        }
    }
}
