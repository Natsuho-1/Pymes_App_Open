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
    class LoginModel : Conexion
    {
        public LoginModel()
        {
            Open();
        }

        private string user;
        public string USER
        {
            get { return user; }
            set { user = value; }
        }

        private string pass;
        public string PASS
        {
            get { return pass; }
            set { pass = value; }
        }
        private int rol;
        public int ROL
        {
            get { return rol; }
            set { rol = value; }
        }
        private string tipo;
        public string TIPO
        {
            get { return tipo; }
            set { tipo = value; }
        }
        private string titulo;
        public string TITULO
        {
            get { return titulo; }
            set { titulo = value; }
        }
        private string telefono;
        public string TELEFONO
        {
            get { return telefono; }
            set { telefono = value; }
        }
        private string correo;
        public string CORREO
        {
            get { return correo; }
            set { correo = value; }
        }
        public void db_style()
        {
            COMANDO = new SqlCommand("SELECT titulo, telefono, correo FROM db_style WHERE id = " + 1 + "", CON);
            DATAREADER = COMANDO.ExecuteReader();
            DATAREADER.Read();
            titulo = DATAREADER["titulo"].ToString().Trim();
            telefono = DATAREADER["telefono"].ToString().Trim();
            correo = DATAREADER["correo"].ToString().Trim();
            DATAREADER.Close();
        }

        public void Logear()
        {
            COMANDO = new SqlCommand("Select usuario, contrasena, idTipoUsuario from Usuarios where usuario=@usu and contrasena=@pass", CON);
            COMANDO.Parameters.AddWithValue("usu", user);
            COMANDO.Parameters.AddWithValue("pass", pass);
            DATAADAPTER = new SqlDataAdapter(COMANDO);
            DATATABLE = new DataTable();
            DATAADAPTER.Fill(DATATABLE);
            if (DATATABLE.Rows.Count == 1)
            {
                if (DATATABLE.Rows[0][2].ToString() == "1")
                {
                    rol = 1;
                }
                else if (DATATABLE.Rows[0][2].ToString() == "2")
                {
                    rol = 2;
                }
            }
            else
            {
                ////mensaje aviso
            }
        }
        public void usernew()
        {
            if (tipo == "Administrador")
            {
                rol = 1;
            }
            else if (tipo == "Empleado")
            {
                rol = 2;
            }
        }

    }
}
