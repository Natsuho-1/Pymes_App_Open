using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace Open_Restaurante
{
    class ModelProductos : Conexion
    {    //Atributos de la clase molde de productos con sus propiedades
        private int idProducto;
        public int IdProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }
        private string nombreProducto;
        public string NombreProducto
        {
            get { return nombreProducto; }
            set { nombreProducto = value; }
        }
        private string codigoProducto;
        public string CodigoProducto
        {
            get { return codigoProducto; }
            set { codigoProducto = value; }
        }
        private double precioProducto;
        public double PrecioProducto
        {
            get { return precioProducto; }
            set { precioProducto = value; }
        }
        private string descripcion;
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private MemoryStream archivoMemoria;
        public MemoryStream ARCHIVOMEMORIA
        {
            get { return archivoMemoria; }
            set { archivoMemoria = value; }
        }

        //Metodos
        public ModelProductos()
        {
        }
        public void db_insert_product()
        {
            QUERY = "INSERT INTO Productos(nombreProducto, codigoProducto, precioProducto, Descripcion)" +
                 "VALUES ('" + nombreProducto + "','" + codigoProducto + "'," + precioProducto  + ",'" + descripcion +"');";
            set_query(QUERY);

        }
        public void image()
        {
            try
            {
                COMANDO = new SqlCommand();
                string rpt;

                COMANDO.Connection = CON;
                COMANDO.CommandText = "ingresarImgProduct";
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.Parameters.AddWithValue("@cod", idProducto);
                COMANDO.Parameters.AddWithValue("@image", archivoMemoria.GetBuffer());

                rpt = COMANDO.ExecuteNonQuery() > 0 ? "En hora buena! La imagen se guardo" : "No se guardo la imagen";


            }
            catch (Exception E)
            {
                MessageBox.Show("" + E);
            }
            
        }

        public void all_products(DataGridView dvgproduct)
        {

            QUERY = "SELECT*FROM view_products_in_database";
            get_data_in_dvg(dvgproduct, QUERY);

        }

        public void buscarProducts(DataGridView dgvproduct, string Search)
        {
            QUERY = "SELECT * FROM view_products_in_database WHERE [Nombre de Producto] LIKE @param + '%' OR [Codigo Product] LIKE @param + '%'";
            get_busqueda(dgvproduct, QUERY, Search);
        }
        public void view_fotos_productos(string codproduct, PictureBox pb)
        {
            QUERY = "SELECT imgProducto FROM Productos WHERE codigoProducto =  ('" + codproduct + "') ";
            get_fotos(QUERY, pb);

        }
        public void EliminarProducto(string codiProducto)
        {
            try
            {
                QUERY = "DELETE FROM Productos WHERE codigoProducto='" + codiProducto + "'";
                set_query(QUERY);
                MessageBox.Show("El producto se elimino con exito", "Realizada");
            }
            catch 
            {
                MessageBox.Show("Ah ocurrido un error intentalo de nuevo", "Atencion");
            }
        }

    
    }
}
