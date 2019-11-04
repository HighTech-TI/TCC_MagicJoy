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
            comboBox1.Text = string.Empty;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            try
            {


                Entityes.tb_usuario db = new Entityes.tb_usuario();
                Entityes.tb_usuario email = business.PesquisarParaRecuparearparaemail(txtemail.Text);

                if (txtemail.Text != email.ds_email)
                {
                    try
                    {
                        txtemail.BackColor = System.Drawing.Color.Red;

                        throw new Exception();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Email incorreta do email cadastrado",
                                        "Magic Joy", MessageBoxButtons.OK,
                                                     MessageBoxIcon.Error);
                    }
                }

                Entityes.tb_usuario user = business.PesquisarParaEnviarEmail(comboBox1.Text, txtemail.Text);

                string combnome = comboBox1.Text;
                string eemail = txtemail.Text;

                if(combnome == user.nm_usuario && eemail == email.ds_email)
                {
                    string re = "zika";
                    string me = "suave";
                    Objetos.EnviarEmail fun = new Objetos.EnviarEmail();
                    fun.Enviar(eemail, re, me);
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Ocorreu um erro, tente novamente ou contate seu administrador de sistema!",
                                       "Magic Joy", MessageBoxButtons.OK,
                                                    MessageBoxIcon.Error);
            }                 

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Business.LoginBusiness businesslog = new Business.LoginBusiness();
            Entityes.tb_usuario email = businesslog.PesquisarParaEmail(txtemail.Text);

            if (email == null)
            {
                txtemail.BackColor = System.Drawing.Color.White;
                txtemail.Visible = false;
                return;
            }


            if (txtemail.Text == email.ds_email)
            {
                try
                {

                    txtemail.BackColor = System.Drawing.Color.White;

                }

                catch (Exception)

                {

                    MessageBox.Show("Nome de usuário já está em uso!",
                                    "Cadastro de usuário", MessageBoxButtons.OK);
                }               

            }
            else
            {               
                txtemail.BackColor = System.Drawing.Color.Red;
            }
        }

        private void frmEsqueciSenha_Load(object sender, EventArgs e)
        {
            Business.LoginBusiness logbusiness = new Business.LoginBusiness();

            List<Entityes.tb_usuario> users = logbusiness.ListarTodosUsuarios();

            comboBox1.DisplayMember = nameof(Entityes.tb_usuario.nm_usuario);
            comboBox1.DataSource = users;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
