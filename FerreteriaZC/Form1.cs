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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void pbMenu_Click(object sender, EventArgs e)
        {
            if (Menu.Width == 240)
            {
                Menu.Width = 100;
            }
            else
            {
                Menu.Width = 240;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Cierra la aplicacion
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            //Cierra la aplicacion
            DialogResult result = MessageBox.Show("¿Está seguro que desea cerrar sesión?", "Cerrar Sesion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                FrmLogin ver = new FrmLogin();
                ver.Visible = true;
                this.Hide();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            FrmMain ver = new FrmMain();
            ver.Visible = true;
            this.Hide();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            FrmCategoría ver = new FrmCategoría();
            ver.Visible = true;
            this.Hide();
        }

        private void TopBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmProductos ver = new FrmProductos();
            ver.Visible = true;
            this.Hide();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios ver = new FrmUsuarios();
            ver.Visible = true;
            this.Hide();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            FrmImprimir ver = new FrmImprimir();
            ver.Visible = true;
            this.Hide();
        }
    }
}
