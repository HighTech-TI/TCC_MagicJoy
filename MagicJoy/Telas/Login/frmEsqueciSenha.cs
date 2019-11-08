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
           // try
           // {


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

               

                
                 string eemail = txtemail.Text;
               
                

              
                
                    Random randNum = new Random();
                    int Cod = randNum.Next();

                    string re = "RECUPERAÇÃO DE SENHA";
                    string me = "Insira uma senha que você lembre na próxima vez que for usar o sistema." + "\r\n" + "Seu Código de recuperação é: " + Cod;

                

               

                 Objetos.EnviarEmail fun = new Objetos.EnviarEmail();
                  fun.Enviar(eemail, re, me);
                  

                   


                    MessageBox.Show("Email enviado com sucesso!", "Magic joy", MessageBoxButtons.OK, MessageBoxIcon.Warning);                   
                   
                
                
          // }
           // catch (Exception)
          //  {

                //MessageBox.Show("Ocorreu um erro, tente novamente ou contate seu administrador de sistema!",
                                  //     "Magic Joy", MessageBoxButtons.OK,
                                                  //  MessageBoxIcon.Error);
           // }                 

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

        private void txtrecuperacao_TextChanged(object sender, EventArgs e)
        {
            Telas.Login.frmAlterarLogin alterlog = new frmAlterarLogin();
            alterlog.Show();
            this.Hide();
        }
    }
}
