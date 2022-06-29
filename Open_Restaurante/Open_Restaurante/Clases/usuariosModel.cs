using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
        public void db_insert_user()
        {
            QUERY = "INSERT INTO Usuarios(nombre, apellido, fechaNacimiento, usuario, contraseña, email, telefono, idTipoUsuario)" +
                "VALUES ('" + nombre + "','" + apellido + "','" + fechaNacimiento + "','" + USER + "','" + pass2 + "','" + CORREO + "','" + TELEFONO + "','" + ROL + "');";
            set_query(QUERY);
        }
    }
}
