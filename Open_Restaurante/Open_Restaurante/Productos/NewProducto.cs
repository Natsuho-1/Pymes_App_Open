using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace Open_Restaurante
{
    public partial class NewProducto : Form
    {
        ModelProductos produ = new ModelProductos();
        public NewProducto()
        {
            InitializeComponent();
            Conexion cn = new Conexion();
            cn.Open();
        }

        private void NewProducto_Load(object sender, EventArgs e)
        {
            txtproducto.Select();
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

        private void btnagregar_Click(object sender, EventArgs e)
        {

        }

        
    }
}
