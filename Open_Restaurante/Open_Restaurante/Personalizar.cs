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
    public partial class Personalizar : Form
    {
        LoginModel mlogin = new LoginModel();
        STYLE s = new STYLE();
        public Personalizar()
        {
            InitializeComponent();
        }

        private void txtproducto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lbtitulo.Text = txttitulo.Text;
                lbtitu.Text = txttitulo.Text;
            }
            catch
            {
                lbtitulo.Text = String.Empty;
                lbtitu.Text = String.Empty;
            }
        }

        private void Personalizar_Load(object sender, EventArgs e)
        {
            mlogin.db_style();
            lbtitulo.Text = mlogin.TITULO;
            lbtitu.Text = mlogin.TITULO;
            txtcorreo.Text = mlogin.CORREO;
            txttelefono.Text = mlogin.TELEFONO;
            txttitulo.Select();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            s.TITULO = txttitulo.Text;
            s.TELEFONO = txttelefono.Text;
            s.CORREO = txtcorreo.Text;
            if (MessageBox.Show("¿Desea cambiar el nombre del establecimiento?", "Cambiar Nombre", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                s.Update_dbStyle();
                MessageBox.Show("Nombre modificado exitosamente!! Para ver los cambios es necesario cerrar sesion!!");
            }
        }

        private void txttitulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtcorreo.Focus();
            }
        }

        private void txtcorreo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txttelefono.Focus();
            }
        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;//elimina el sonido
                btnguardar_Click(sender, e);//llama al evento click del boton
            }
        }
    }
}
