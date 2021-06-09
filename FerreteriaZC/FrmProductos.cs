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
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
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

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            //Cierra la aplicacion
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Electrico");
            comboBox1.Items.Add("Mecanico");
            comboBox1.Items.Add("Construccion");
            comboBox1.Items.Add("Plomeria");
            comboBox1.Items.Add("pintura");
            comboBox1.Items.Add("medicion");
            comboBox1.Items.Add("otro");
            


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
                
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        
        }

        private void txtPrecioCompra_TextChanged(object sender, EventArgs e)
        {

        
        }

        private void btnCalcularGanancia_Click(object sender, EventArgs e)
        {
             int PreCom = 0;
            PreCom = int.Parse(txtPrecioCompra.Text);
            int PreVen = 0;
            PreVen = int.Parse(txtPrecioVenta.Text);
            int Ganancia = 0;
            Ganancia = PreVen - PreCom;
            MessageBox.Show("Tu Ganancia es de"+Ganancia);

            if(Ganancia <0)
            {
                MessageBox.Show("Tu Ganancia es negativa, y es de:" + Ganancia+" dolares");
                txtPrecioCompra.Clear();
                txtPrecioVenta.Clear();
            }

            else if(Ganancia >0)
            {
                MessageBox.Show("Tu Ganancia total es de: " + Ganancia + " dolares");
                txtPrecioCompra.Clear();
                txtPrecioVenta.Clear();
            }

            
        }

        private void txtPrecioVenta_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
             

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
