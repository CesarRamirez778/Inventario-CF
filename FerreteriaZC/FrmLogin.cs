using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerreteriaZC
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (pbCorrecto.Visible == true && txtClave.Text == "123")
            {

                MessageBox.Show("Bienvenido " + txtUsuario.Text , "Usuario Autenticado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmMain ver = new FrmMain();
                ver.Visible = true;
                this.Hide();

            }
            else if (txtClave.Text == "" || txtUsuario.Text == "")
            {
                MessageBox.Show("Hay campos vacios","Advertencia",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtClave.Clear();
                txtUsuario.Clear();
            }
            else if(pbCorrecto.Visible == true && txtClave.Text != "123")
            {
                MessageBox.Show("Contraseña incorrecta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtClave.Clear();
                txtUsuario.Clear();
            }
            else
            {
                MessageBox.Show("Hay datos incorrectos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtClave.Clear();
                txtUsuario.Clear();
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "cesar")
            {
                pbCorrecto.Visible = true;
                pbIncorrecto.Visible = false;
            }
            else
            {
                pbCorrecto.Visible = false;
                pbIncorrecto.Visible = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Cierra la aplicacion
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
