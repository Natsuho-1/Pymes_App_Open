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
     class ModelPedido: Conexion
    {
        private int idPedido;
        public int IdPedido
        {
            get { return idPedido; }
            set { idPedido = value; }
        }
        private int idUsuario;
        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }
        private DateTime fechaPedido;
        public DateTime FechaPedido
        {
            get { return fechaPedido; }
            set { fechaPedido = value; }
        }

        private int estadoPedido;
        public int EstadoPedido 
        {
            get { return estadoPedido; }
            set { estadoPedido = value; }
        }
        private float totalPedido;
        public float TotalPedido
        {
            get { return totalPedido; }
            set { totalPedido = value; }
        }

        //Metodos

        public ModelPedido()
        {
            Open();
        }

        public void CerrarConexion()
        {
            Cerrar();
        }
    }
}
