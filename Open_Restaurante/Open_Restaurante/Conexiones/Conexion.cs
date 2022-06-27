using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Open_Restaurante
{
    class Conexion
    {
        private string db_host = "localhost";
        private string db_user = "sa";
        private string db_pass = "123456";
        private string db_name = "Restaurantes_OpenLicense";
        public string cadena;
        private string sCn;

        private SqlConnection con;
        public SqlConnection CON
        {
            get { return con; }
            set { con = value; }
        }
        private SqlCommand comando;
        public SqlCommand COMANDO
        {
            get { return comando; }
            set { comando = value; }
        }
        private SqlDataAdapter dataadapter;
        public SqlDataAdapter DATAADAPTER
        {
            get { return dataadapter; }
            set { dataadapter = value; }
        }
        private DataTable datatable;
        public DataTable DATATABLE
        {
            get { return datatable; }
            set { datatable = value; }
        }
        private SqlDataReader datareader;
        public SqlDataReader DATAREADER
        {
            get { return datareader; }
            set { datareader = value; }
        }

        public void Open()
        {
            db_open();
            sCn = cadena;
            con = new SqlConnection(sCn);
            con.Open();
        }
        public void db_open()
        {
            cadena = "server=" + db_host + ";uid=" + db_user + ";pwd=" + db_pass + ";database=" + db_name;
        }
    }
}
