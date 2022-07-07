using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace Open_Restaurante
{
    class Conexion
    {
        private string db_host = "DESKTOP-229DHRP\\SQLEXPRESS";
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
        private string query;
        public string QUERY
        {
            get { return query; }
            set { query = value; }
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
        ///crear db_close()
        protected void set_query(string query)
        {
            comando = new SqlCommand(query, con);
            comando.ExecuteNonQuery();
        }
        public void get_data_in_dvg(DataGridView dgv, string query)
        {
            try
            {
                DATAADAPTER = new SqlDataAdapter(query, con);
                DATAADAPTER.Fill(DATATABLE);
                dgv.DataSource = DATATABLE;
                dgv.Refresh();
            }
            catch (Exception E)
            {
                MessageBox.Show("No se pudo llenar la tabla: " + E.ToString());
            }
        }
        public void get_busqueda(DataGridView dvg, string query, string Search)
        {
            try
            {
                COMANDO = new SqlCommand(query, con);
                COMANDO.Parameters.AddWithValue("@param", Search);
                DATAADAPTER = new SqlDataAdapter(COMANDO);
                DataTable dt = new DataTable();
                DATAADAPTER.Fill(dt);
                dvg.DataSource = dt;
            }
            catch (Exception E)
            {
                MessageBox.Show("No se pudo llenar la tabla: " + E.ToString());
            }
        }
        public void get_fotos(string query, PictureBox pb)
        {
            comando = new SqlCommand(query, con);
            datareader = comando.ExecuteReader();
            if (datareader.Read())
            {
                try
                {
                    Byte[] archivo = (byte[])datareader["foto"];
                    Stream imagenn = new MemoryStream(archivo);

                    pb.Image = Image.FromStream(imagenn);
                    datareader.Close();
                }
                catch
                {
                    pb.Image = Open_Restaurante.Properties.Resources.productimg;
                    MessageBox.Show("El usuario no posee fotografia.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    datareader.Close();
                }

            }
            else
            {
                MessageBox.Show("El usuario no posee foto.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Question);
                datareader.Close();
            }
        }
    }
}
