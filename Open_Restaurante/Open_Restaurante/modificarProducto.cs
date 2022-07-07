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
    public partial class modificarProducto : Form
    {
        ModelProductos produ = new ModelProductos();
        public modificarProducto()
        {
            InitializeComponent();
            Conexion cn = new Conexion();
            cn.Open();
        }

        private void NewProducto_Load(object sender, EventArgs e)
        {
            produ.DATATABLE = new DataTable();
            produ.all_products(dvgproductos);
        }

        public void limpiar()
        {
            txtproducto.Text = txtprecio.Text = txtdescripcion.Text = String.Empty;
            txtproducto.Select();
            pbimagen.Image = Open_Restaurante.Properties.Resources.productimg;
            
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (lbcodigo.Text == "")
            {
                MessageBox.Show("Selecciona primero un usuario", "Advertencia");
            }
            else
            {
                produ.ARCHIVOMEMORIA = new MemoryStream();
                pbimagen.Image.Save(produ.ARCHIVOMEMORIA, ImageFormat.Bmp);
                produ.CodigoProducto = lbcodigo.Text;
                //consulta para modificar datos
                produ.image();
                MessageBox.Show("Se ah actualizado con exito", "Atencion");
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

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                produ.buscarProducts(dvgproductos, txtbuscar.Text);
            }
            catch (Exception E)
            {
                MessageBox.Show("El usuario no existe." + E, "Atencion");
            }
        }

        private void dvgproductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int pocicion;
            try
            {
                pocicion = dvgproductos.CurrentRow.Index;
                lbcodigo.Text = dvgproductos[0, pocicion].Value.ToString();
                txtproducto.Text = dvgproductos[1, pocicion].Value.ToString();
                txtprecio.Text = dvgproductos[2, pocicion].Value.ToString();
                txtdescripcion.Text = dvgproductos[3, pocicion].Value.ToString();

                produ.view_fotos_productos(lbcodigo.Text, pbimagen);
            }
            catch
            {
                MessageBox.Show("No ah seleccionado ningun registro", "Atencion");
            }
        }
    }
}
