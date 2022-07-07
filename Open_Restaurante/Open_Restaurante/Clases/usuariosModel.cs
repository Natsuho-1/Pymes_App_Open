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
    class usuariosModel : LoginModel
    {
        public usuariosModel()
        {

        }
        private string nombre;
        public string NOMBRE
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string apellido;
        public string APELLIDO
        {
            get { return apellido; }
            set { apellido = value; }
        }
        private DateTime fechaNacimiento;
        public DateTime FECHANACIMIENTO
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        private string pass2;
        public string PASS2
        {
            get { return pass2; }
            set { pass2 = value; }
        }
        private MemoryStream archivoMemoria;
        public MemoryStream ARCHIVOMEMORIA
        {
            get { return archivoMemoria; }
            set { archivoMemoria = value; }
        }
        public void db_insert_user()
        {
            QUERY = "INSERT INTO Usuarios(nombre, apellido, fechaNacimiento, usuario, contrasena, email, telefono, idTipoUsuario)" +
                "VALUES ('" + nombre + "','" + apellido + "','" + fechaNacimiento + "','" + USER + "',CONVERT(varbinary,'" + pass2 + "'),'" + CORREO + "','" + TELEFONO + "','" + ROL + "');";
            set_query(QUERY);
        }
        public void imagen()
        {
            try
            {
                COMANDO = new SqlCommand();
                string rpt;

                COMANDO.Connection = CON;
                COMANDO.CommandText = "ingresarimg";
                COMANDO.CommandType = CommandType.StoredProcedure;
                COMANDO.Parameters.AddWithValue("@cod", USER);
                COMANDO.Parameters.AddWithValue("@imagen", archivoMemoria.GetBuffer());

                rpt = COMANDO.ExecuteNonQuery() > 0 ? "ok se guardo la imagen" : "No se guardo";
            }
            catch (Exception E)
            {
                MessageBox.Show("" + E);
            }

        }
        public void all_users(DataGridView dvg)
        {
            QUERY = "SELECT*FROM view_users_in_database";
            get_data_in_dvg(dvg, QUERY);
        }
        public void buscarusers(DataGridView dvg, string Search)
        {
            QUERY = "SELECT * FROM view_users_in_database WHERE [Nombre de Usuario] LIKE @param + '%' or [Nombre Completo] LIKE @param + '%' or [Tipo de Usuario] LIKE @param + '%'";
            get_busqueda(dvg, QUERY, Search);
        }
        public void view_fotos_users(string usuario, PictureBox pb)
        {
            QUERY = "SELECT foto FROM Usuarios WHERE usuario=('" + usuario + "')";
            get_fotos(QUERY, pb);
        }
        public void EliminarUsuario(string usuario)
        {
            try
            {
                QUERY = "DELETE FROM Usuarios WHERE usuario='" + usuario + "'";
                set_query(QUERY);
                MessageBox.Show("El usuario se elimino con exito", "Realizado");
            }
            catch
            {
                MessageBox.Show("Ah ocurrido un error intentalo de nuevo", "Atencion");
            }
        }
    }
}
