using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Open_Restaurante
{
    class ModelProductos : Conexion //heredamos los comandos sql de la clase conexion 
    {

       

        //Atributos de la clase molde de productos con sus propiedades
        private int idProducto;
        public int IdProducto
        {
            get { return IdProducto; }
            set { IdProducto = value; }
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

        //Metodos

        public ModelProductos()
        {
            Open();
        }

        public void CerrarConexion()
        {
            Cerrar();
        }
       
     
    }
}
