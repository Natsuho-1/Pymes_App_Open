using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Open_Restaurante
{
    public partial class FmLogin : Form
    {
        LoginModel mlogin = new LoginModel();

        public FmLogin()
        {
            InitializeComponent();
            this.ttMsg.SetToolTip(this.cbmostrarpass, "Mostrar Contraseña");
            Conexion cn = new Conexion();
            cn.Open();
        }

        private void FmLogin_Load(object sender, EventArgs e)
        {
            mlogin.db_style();
            lbtitulo.Text = mlogin.TITULO;
            lbcorreo.Text = mlogin.CORREO;
            lbtelefono.Text = mlogin.TELEFONO;
            txtuser.Select();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                //boton ingresar
                mlogin.USER = txtuser.Text;
                mlogin.PASS = txtpass.Text;

                mlogin.Logear();

                switch (mlogin.ROL)
                {
                    case 1:
                        MenuRestaurante menu = new MenuRestaurante();
                        this.Hide();
                        menu.Show();
                        break;
                    case 2:
                        MenuPrueba menu2 = new MenuPrueba();
                        this.Hide();
                        menu2.Show();
                        break;
                    default:
                        txtuser.Select();
                        break;
                }
            }
            catch
            {
                MessageBox.Show("No existe el usuario", "Atencion");
            }
        }

        private void txtuser_KeyDown(object sender, KeyEventArgs e)
        {
            //
        }

        private void txtuser_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtpass.Focus();
            }
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;//elimina el sonido
                btnlogin_Click(sender, e);//llama al evento click del boton
            }
        }

        private void cbmostrarpass_CheckedChanged(object sender, EventArgs e)
        {
            txtpass.UseSystemPasswordChar = !cbmostrarpass.Checked;
        }
    }
}
