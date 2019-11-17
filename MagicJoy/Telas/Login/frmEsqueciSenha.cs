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

        Business.LoginBusiness business = new Business.LoginBusiness();

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            txtemail.Text = string.Empty;
           
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {


            Entityes.tb_codigo db = new Entityes.tb_codigo();

            Random rdn = new Random();
            rdn.Next();
            string codigo = rdn.Next(0, 1000) + Environment.NewLine;
            string email;
            email = txtemail.Text;
            string assunto = "CÓDIGO DE RECUPERAÇÃO";
            db.ds_codigo = Convert.ToInt32(codigo);
            Business.LoginBusiness bs = new Business.LoginBusiness();
            bs.inserircodicd(db);

            Objetos.EnviarEmail obee = new Objetos.EnviarEmail();
            obee.Enviar(email, assunto, codigo);

            MessageBox.Show("Email enviado com sucesso!", "Magic Joy",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);

            Telas.Login.frmRecuperarSenha tela = new frmRecuperarSenha();
            tela.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           


           
            
        }

        private void frmEsqueciSenha_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

       
    }
}
