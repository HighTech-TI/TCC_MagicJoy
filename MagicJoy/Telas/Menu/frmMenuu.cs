using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicJoy.Telas.Menu
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();

            lblLogado.Text = "Seja Bem-Vindo " + Objetos.UsuarioLogado.Nome;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMenuu_Load(object sender, EventArgs e)
        {
            label4.Text = DateTime.Today.ToShortDateString();

            Thread t = new Thread(new ThreadStart(ChangeLabelColor));
            t.Start();

        }
        private void ChangeLabelColor()
        {
            while (true)
            {
                Thread.Sleep(1000);
                label3.ForeColor = Color.Maroon;
                label6.ForeColor = Color.Maroon;
                Thread.Sleep(1000);
                label3.ForeColor = Color.Pink;
                label6.ForeColor = Color.Pink;
                Thread.Sleep(1000);
                label3.ForeColor = Color.Purple;
                label6.ForeColor = Color.Purple;
                Thread.Sleep(1000);
                label3.ForeColor = Color.BlueViolet;
                label6.ForeColor = Color.BlueViolet;
                Thread.Sleep(1000);
                label3.ForeColor = Color.Yellow;
                label6.ForeColor = Color.Yellow;
                Thread.Sleep(1000);
                label3.ForeColor = Color.Green;
                label6.ForeColor = Color.Green;
                Thread.Sleep(1000);
                label3.ForeColor = Color.OrangeRed;
                label6.ForeColor = Color.OrangeRed;
                Thread.Sleep(1000);
                label3.ForeColor = Color.Blue;
                label6.ForeColor = Color.Blue;
                Thread.Sleep(1000);
                label3.ForeColor = Color.Red;
                label6.ForeColor = Color.Red;
            }

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {



        }

        private void timer3_Tick(object sender, EventArgs e)
        {






        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void opçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            picfluxo.Visible = true;
            menuFC.Visible = true;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            picCompra.Visible = true;
            menuStrip1.Visible = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void menuFC_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lblLogado_Click(object sender, EventArgs e)
        {

        }
    }
}
