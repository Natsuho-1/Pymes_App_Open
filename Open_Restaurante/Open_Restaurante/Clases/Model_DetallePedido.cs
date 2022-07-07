using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Open_Restaurante
{
    class Model_DetallePedido:Conexion
    {

        private int idDetalle;
        public int IDDetalle
        {
            get { return idDetalle; }
            set { idDetalle = value; }

        }
        private int idProducto;
        public int IDProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }
        private int cantidadProducto;
        public int CantidadProducto 
        {
            get { return cantidadProducto; }
            set { cantidadProducto = value; }
        }
        private float precioDetalle;
        public float PrecioDetalle
        {
            get { return precioDetalle; }
            set { precioDetalle = value; }
        }
        private int idPedido;
        public int IDpedido 
        {
            get { return idPedido; }
            set { idPedido = value; }

        }
        public Model_DetallePedido()
        {
            Open();

        }
        public void cerrarConexion()
        {
            Cerrar();
        }
      

        //Método que extrae los detalles de un pedido desde la DB

    }
}
