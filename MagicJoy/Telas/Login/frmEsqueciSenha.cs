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
            //Enviar Email
            SmtpClient cliente = new SmtpClient(); //objeto para enviar email
            NetworkCredential credencial = new NetworkCredential(); //Para entrar dentro do endereço eletrÔnico

            //Configurações do cliente
            cliente.Host = "smtp.gmail.com";
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
            cliente.UseDefaultCredentials = false;

            //credencias de acessos
            credencial.UserName = "gabrielrocha.d320";
            credencial.Password = "felicidade19";

            //definir credenciais
            cliente.Credentials = credencial;

            //estruturar a menssagem
            MailMessage messagem = new MailMessage();
            messagem.From = new MailAddress("gabrielrocha.d320@gmail.com");
            messagem.Subject = "Assunto";
            messagem.Body = "Corpo do email";
            messagem.To.Add("gabrielrocha.d320@gmail.com");

            //envio da menssagem 
            cliente.Send(messagem);

            MessageBox.Show("Enviado com sucesso");
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
