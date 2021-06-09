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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Cierra la aplicacion
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir?", "Salir",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }

            
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtClave.Text == "")
            {
                MessageBox.Show("No pueden haber campos vacíos","Llenar datos", MessageBoxButtons.OK , MessageBoxIcon.Information);
                txtClave.Clear();
                txtUsuario.Clear();
            }
            else if(CheckValidar.Checked == true && txtClave.Text == "123")
            {
                MessageBox.Show("Bienvenido " + txtUsuario.Text ,"Autentificacion correcta",MessageBoxButtons.OK,MessageBoxIcon.Information);
                FrmMain ver = new FrmMain();
                ver.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hay campos con Datos inválidos","Datos Invalidos",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtClave.Clear();
                txtUsuario.Clear();
            }
            
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "David" || txtUsuario.Text == "Katherine" || txtUsuario.Text == "Ernesto")
            {
                //PbValidar.Image = System.Drawing.Image.FromFile("FerreteriaZC/bin/debug/img/check.png");
                PbError.Visible = false;
                pbCheck.Visible = true;
                CheckValidar.Checked = true;
                //CheckValidar.ForeColor = Color.Green;

                lblUsuario.ForeColor = Color.Yellow;
            }
            else
            {
                PbError.Visible = true;
                pbCheck.Visible = false;
                CheckValidar.Checked = false;
                lblUsuario.ForeColor = Color.White;
            }
        }

        private void btnIngresar_MouseHover(object sender, EventArgs e)
        {
            btnIngresar.ForeColor = Color.Yellow;
        }

        private void btnIngresar_MouseLeave(object sender, EventArgs e)
        {
            btnIngresar.ForeColor = Color.White;
        }

        private void btnIngresar_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CheckValidar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TopMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
