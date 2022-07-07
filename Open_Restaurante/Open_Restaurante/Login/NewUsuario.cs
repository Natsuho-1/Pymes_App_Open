using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Open_Restaurante
{
    public partial class NewUsuario : Form
    {
        usuariosModel usu = new usuariosModel();
        public NewUsuario()
        {
            InitializeComponent();
            Conexion cn = new Conexion();
            cn.Open();
        }

        private void NewUsuario_Load(object sender, EventArgs e)
        {
            txtnombre.Select();
        }
        public void limpiar()
        {
            txtnombre.Text = txtapellidos.Text = txttelefono.Text = txtemail.Text = txtpass1.Text = txtpass2.Text = lbusuario.Text = String.Empty;
            txtnombre.Select();
            lbcon.Visible = false;
        }
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void cbmostrar_CheckedChanged(object sender, EventArgs e)
        {
            txtpass1.UseSystemPasswordChar = txtpass2.UseSystemPasswordChar = !cbmostrar.Checked;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                usu.NOMBRE = txtnombre.Text;
                usu.APELLIDO = txtapellidos.Text;
                usu.FECHANACIMIENTO = Convert.ToDateTime(this.dtfechanacimiento.Value.ToString("yyyy-MM-dd"));
                usu.USER = lbusuario.Text;
                usu.PASS = txtpass1.Text;
                usu.PASS2 = txtpass2.Text;
                usu.CORREO = txtemail.Text;
                usu.TELEFONO = txttelefono.Text;
                if (rbadmin.Checked == true)
                {
                    usu.ROL = 1;
                }
                else if (rbempleado.Checked == true)
                {
                    usu.ROL = 2;
                }
                if (txtpass1.Text == txtpass2.Text)
                {
                    usu.db_insert_user();
                    MessageBox.Show("Registro ingresado exitosamente", "Atencion");
                    limpiar();
                }
                else
                {
                    lbcon.Visible = true;
                }

            }
            catch
            {
                MessageBox.Show("No se pudo ingresar el usuario o el nombre de\nusuario ya esta ocupado", "Atencion");
            }

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lbusuario.Text = txtnombre.Text.Substring(0, 1);
            }
            catch
            {
                lbusuario.Text = String.Empty;
            }
        }

        private void txtapellidos_TextChanged(object sender, EventArgs e)
        {
            string c1 = txtnombre.Text.Substring(0, 1);
            try
            {
                lbusuario.Text = "" + c1 + "" + txtapellidos.Text;
            }
            catch
            {
                lbusuario.Text = c1;
            }
        }
    }
}
