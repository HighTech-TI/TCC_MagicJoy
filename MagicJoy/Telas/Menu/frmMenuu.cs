using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicJoy.Telas.Menu
{
    public partial class frmMenuu : Form
    {
        public frmMenuu()
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
            if(this.WindowState == FormWindowState.Maximized)
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

            timer2.Start();

           


        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
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
            
           
            if(pic1.Visible == true)
            {
                pic2.Visible = true;
                pic4.Visible = false;
                pic5.Visible = false;
                pic6.Visible = false;
                lblDaMagic.Visible = false;
                pic8.Visible = false;
            }
            if (pic4.Visible == true)
            {
                pic2.Visible = false;
                pic4.Visible = false;
                pic5.Visible = false;
                pic6.Visible = false;
                lblDaMagic.Visible = false;
                pic8.Visible = false;
            }
            else if(pic2.Visible == true)
            {
                pic1.Visible = false;
                pic4.Visible = false;
                pic5.Visible = false;
                pic6.Visible = false;
                lblDaMagic.Visible = false;
                pic8.Visible = false;
            }
            else if (pic5.Visible == true)
            {
                pic1.Visible = false;
                pic4.Visible = false;
                pic2.Visible = false;
                pic6.Visible = false;
                lblDaMagic.Visible = false;
                pic8.Visible = false;
            }
            else if (pic6.Visible == true)
            {
                pic1.Visible = false;
                pic4.Visible = false;
                pic2.Visible = false;
                pic5.Visible = false;
                lblDaMagic.Visible = false;
                pic8.Visible = false;
            }
            else if (lblDaMagic.Visible == true)
            {
                pic1.Visible = false;
                pic4.Visible = false;
                pic2.Visible = false;
                pic5.Visible = false;
                pic6.Visible = false;
                pic8.Visible = false;
            }
            else if (pic8.Visible == true)
            {
                pic1.Visible = false;
                pic4.Visible = false;
                pic2.Visible = false;
                pic5.Visible = false;
                pic6.Visible = false;
                lblDaMagic.Visible = false;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {


            bool loop = true;

            while (loop)
            {
                if (label3.ForeColor == Color.White && label4.ForeColor == Color.White)
                {
                    label3.ForeColor = Color.Maroon;
                    label4.ForeColor = Color.Maroon;
                }
                if (label3.ForeColor == Color.Maroon && label4.ForeColor == Color.Maroon)
                {
                    label3.ForeColor = Color.Pink;
                    label4.ForeColor = Color.Pink;
                }
                if (label3.ForeColor == Color.Pink && label4.ForeColor == Color.Pink)
                {
                    label3.ForeColor = Color.Purple;
                    label4.ForeColor = Color.Purple;
                }
                if (label3.ForeColor == Color.Purple && label4.ForeColor == Color.Purple)
                {
                    label3.ForeColor = Color.BlueViolet;
                    label4.ForeColor = Color.BlueViolet;
                }
                if (label3.ForeColor == Color.BlueViolet && label4.ForeColor == Color.BlueViolet)
                {
                    label3.ForeColor = Color.Yellow;
                    label4.ForeColor = Color.Yellow;
                }
                if (label3.ForeColor == Color.Yellow && label4.ForeColor == Color.Yellow)
                {
                    label3.ForeColor = Color.Green;
                    label4.ForeColor = Color.Green;
                }
                if (label3.ForeColor == Color.Yellow && label4.ForeColor == Color.Yellow)
                {
                    label3.ForeColor = Color.OrangeRed;
                    label4.ForeColor = Color.OrangeRed;
                }

            }

        }
    }
}
