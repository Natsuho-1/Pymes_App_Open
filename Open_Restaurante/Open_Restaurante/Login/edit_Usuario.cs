using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace Open_Restaurante
{
    public partial class edit_Usuario : Form
    {
        usuariosModel usu = new usuariosModel();
        public edit_Usuario()
        {
            InitializeComponent();
            Conexion cn = new Conexion();
            cn.Open();
        }

        private void NewUsuario_Load(object sender, EventArgs e)
        {
            usu.DATATABLE = new DataTable();
            usu.all_users(dvgusers);
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                usu.buscarusers(dvgusers, txtbuscar.Text);
            }
            catch (Exception E)
            {
                MessageBox.Show("El usuario no existe." + E, "Atencion");
            }
        }

        private void dvgusers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int pocicion;
            try
            {
                pocicion = dvgusers.CurrentRow.Index;
                lbnombre.Text = dvgusers[1, pocicion].Value.ToString();
                lbemail.Text = dvgusers[3, pocicion].Value.ToString();
                lbtelefono.Text = dvgusers[4, pocicion].Value.ToString();
                lbfecha.Text = dvgusers[2, pocicion].Value.ToString();
                lbuser.Text = dvgusers[0, pocicion].Value.ToString();

                usu.view_fotos_users(lbuser.Text, pbimagen);

            }
            catch
            {
                MessageBox.Show("No ah seleccionado ningun registro", "Atencion");
            }
        }

        private void btnseleccionarimg_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|**.png|GIF (*.gif)|*.gif";
            if (getImage.ShowDialog() == DialogResult.OK)
            {
                pbimagen.Image = Image.FromFile(getImage.FileName);
            }
            else
            {
                MessageBox.Show("No se selecciono imagen", "sin eleccion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (lbuser.Text == "")
            {
                MessageBox.Show("Selecciona primero un usuario","Advertencia");
            }
            else
            {
                usu.ARCHIVOMEMORIA = new MemoryStream();
                pbimagen.Image.Save(usu.ARCHIVOMEMORIA, ImageFormat.Bmp);
                usu.USER = lbuser.Text;
                usu.imagen();
                MessageBox.Show("Se ah actualizado con exito", "Atencion");
            }

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Eliminar este Usuario?", "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                if (lbuser.Text == "Admin")
                {
                    MessageBox.Show("No puedes eliminar el usuario principal", "Atencion");
                }
                else
                {
                    usu.EliminarUsuario(lbuser.Text);
                    usu.DATATABLE = new DataTable();
                    usu.all_users(dvgusers);
                }
            }
        }
    }
}
