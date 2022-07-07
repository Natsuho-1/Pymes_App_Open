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
            produ.numeroOrden();
            lbcodigo.Text = "PR" + produ.ORDEN;
            txtproducto.Select();

        }

        public void limpiar()
        {
            txtproducto.Text = txtprecio.Text = txtdescripcion.Text = String.Empty;
            txtproducto.Select();
            pbimagen.Image = Open_Restaurante.Properties.Resources.productimg;
            
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {

            try
            {          
                //Para la imagen del producto
                produ.ARCHIVOMEMORIA = new MemoryStream();
                pbimagen.Image.Save(produ.ARCHIVOMEMORIA, ImageFormat.Bmp);

                //Atributes fill up

                produ.NombreProducto = txtproducto.Text;
                produ.PrecioProducto = double.Parse(txtprecio.Text);
                produ.Descripcion = txtdescripcion.Text;
                produ.CodigoProducto = lbcodigo.Text;

                produ.db_insert_product();
                produ.image();

                MessageBox.Show("Producto ingresado exitosamente", "En hora buena!");
                limpiar();
            }
            catch (Exception Error)
            {
                MessageBox.Show("No se pudo ingresar el producto, o se ha ingresado el mismo tipo más de una vez" + Error, "Alerta"); 
                
            }

        }

        private void btnseleccionarimg_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|**.png|GIF (*.gif)|*.gif";
            if (getImage.ShowDialog() == DialogResult.OK)
            {
                pbimagen.Image = Image.FromFile(getImage.FileName);
            }
            else
            {
                MessageBox.Show("No se selecciono imagen", "Sin eleccion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
