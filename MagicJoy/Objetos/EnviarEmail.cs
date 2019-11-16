using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicJoy.Objetos
{
    class EnviarEmail
    {
        Entityes.magicjoydbEntities2 db = new Entityes.magicjoydbEntities2();
        public bool login(string login, string senha, string email)
        {


            var usuario = db.tb_usuario.FirstOrDefault(x => (x.nm_usuario == login || x.ds_email == email) && x.nm_senha == senha);
            if (usuario != null)
            {
                return true;
            }
            return false;
        }
        public bool esqueceusenha(string email)
        {

            var usuario = db.tb_usuario.FirstOrDefault(x => x.ds_email == email);
            if (usuario != null)
            {
                return true;
            }
            return false;
        }
        public bool codigo(int codigo)
        {
            var tabela = db.tb_codigo.FirstOrDefault(x => x.ds_codigo == codigo);

            if (tabela != null)
            {
                return true;
            }
            return false;

        }
        public bool usuario(string usuario)
        {
            var tabela = db.tb_usuario.FirstOrDefault(x => x.nm_usuario == usuario);

            if (tabela != null)
            {
                return true;
            }
            return false;

        }
        
        public void Enviar(string emailPara, string assunto, string mensagem)
        {
            Task.Factory.StartNew(() =>
            {
                System.Net.Mail.MailMessage email = new System.Net.Mail.MailMessage();

                string remetente = "hightech.tecnology@gmail.com";
                string senha = "fcdsgrd0217";

                // Configura Remetente, Destinatário
                email.From = new System.Net.Mail.MailAddress(remetente);
                email.To.Add(emailPara);

                // Configura Assunto, Corpo e se o Corpo está em Html
                email.Subject = assunto;
                email.Body = mensagem;
                email.IsBodyHtml = true;

                // Configura os parâmetros do objeto SMTP
                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;

                // Atribui credenciais
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential(remetente, senha);

                // Envia a mensagem
                smtp.Send(email);
            });
        }
    }
}
