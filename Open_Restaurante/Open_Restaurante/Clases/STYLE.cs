using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Open_Restaurante
{
    class STYLE : LoginModel
    {
        public STYLE()
        {

        }
        public void Update_dbStyle()
        {
            QUERY = "UPDATE db_style SET titulo='" + TITULO + "', telefono='" + TELEFONO + "', correo='" + CORREO + "' WHERE id=" + 1 + "";
            set_query(QUERY);
        }
    }
}
