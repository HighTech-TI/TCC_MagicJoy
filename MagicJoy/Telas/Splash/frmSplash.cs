﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicJoy.Telas.Splash
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Telas.Login.frmLogin tela = new Login.frmLogin();
            tela.Show();
            this.Hide();
            
            timer1.Stop();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
