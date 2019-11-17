using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicJoy.Telas.Financeiro
{
    public partial class frmFluxoDeCaixa : Form
    {
        public frmFluxoDeCaixa()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmFluxoDeCaixa_Load(object sender, EventArgs e)
        {
            ListarTudo();
        }
        private void ListarTudo()
        {
            Business.View.ViewBusiness business = new Business.View.ViewBusiness();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = business.ListarTudo();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Telas.Menu.btnforne tela = new Menu.btnforne();
            tela.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Telas.Menu.btnforne tela = new Menu.btnforne();
            tela.Show();
            this.Hide();
        }
    }
}
