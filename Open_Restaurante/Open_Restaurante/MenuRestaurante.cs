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
    public partial class MenuRestaurante : Form
    {
        LoginModel mlogin = new LoginModel();
        public MenuRestaurante()
        {
            InitializeComponent();
            this.ttMsg.SetToolTip(this.btninicio, "Volver a Inicio");
            this.ttMsg.SetToolTip(this.btnagregar, "Agregar Producto");
            this.ttMsg.SetToolTip(this.btnadministrar, "Administrar Productos");
            this.ttMsg.SetToolTip(this.btnLogout, "Administrar Usuarios, Cerrar Sesión, Nuevo Usuario");
            this.ttMsg.SetToolTip(this.btnConfiguracion, "Personaliza la Aplicacion");
            this.ttMsg.SetToolTip(this.btnreports, "Finanzas y Reportes");


            Conexion cn = new Conexion();
            cn.Open();
        }

        private void MenuRestaurante_Load(object sender, EventArgs e)
        {
            mlogin.db_style();
            lbtitulo.Text = mlogin.TITULO;
        }

        // metodos para ocultar y mostrar menus
        private void hideSubMenu()
        {
        }
        private void showSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private Form activeForm = null;

        //metodo para peneles hijos todavia no implementado

        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMedio.Controls.Add(childForm);
            panelMedio.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (lbvec.Text == "retra")
            {
                int newWidth = 120;
                panelconfig.Size = new Size(newWidth, panelconfig.Height);
                panelDER.Size = new Size(newWidth, panelconfig.Height);
                lbvec.Text = "Exp";
            }
            else if (lbvec.Text == "Exp")
            {
                int newWidth = 8;
                panelconfig.Size = new Size(newWidth, panelconfig.Height);
                panelDER.Size = new Size(newWidth, panelconfig.Height);
                lbvec.Text = "retra";
            }
            showSubMenu(panelSubLogout);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
        }

        private void btncerrarsesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesion? cualquier información que no se haya guardado se perdera.", "Cerrar Sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                FmLogin l = new FmLogin();
                this.Hide();
                l.Show();
            }
        }
    }
}
