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
    public partial class FrmImprimir : Form
    {
        public FrmImprimir()
        {
            InitializeComponent();
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

        private void btnInventario_Click(object sender, EventArgs e)
        {
            FrmMain ver = new FrmMain();
            ver.Visible = true;
            this.Hide();
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmProductos ver = new FrmProductos();
            ver.Visible = true;
            this.Hide();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            FrmCategoría ver = new FrmCategoría();
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

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
