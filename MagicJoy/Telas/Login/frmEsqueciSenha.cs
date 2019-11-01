using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace MagicJoy.Telas.Login
{
    public partial class frmEsqueciSenha : Form
    {
        public frmEsqueciSenha()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
             
            Entityes.tb_usuario db = new Entityes.tb_usuario();
            Business.LoginBusiness busineslog = new Business.LoginBusiness();
            Entityes.tb_usuario user = busineslog.Alterar();
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void frmEsqueciSenha_Load(object sender, EventArgs e)
        {
            Business.LoginBusiness logbusiness = new Business.LoginBusiness();

            List<Entityes.tb_usuario> users = logbusiness.ListarTodosUsuarios();

            comboBox1.DisplayMember = nameof(Entityes.tb_usuario.nm_usuario);
            comboBox1.DataSource = users;
        }
    }
}
