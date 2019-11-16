using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicJoy.DataBase
{
    class LoginDataBase
    {
        Entityes.magicjoydbEntities2 db = new Entityes.magicjoydbEntities2();
        public void inserir (Entityes.tb_usuario usuario)
        {
            
            db.tb_usuario.Add(usuario);

                    db.SaveChanges();
        }

       public List<Entityes.tb_usuario> ListarTodosUsuarios()
       {
            List<Entityes.tb_usuario> tabela = db.tb_usuario.ToList();
            return tabela;
                         
       }

       public Entityes.tb_usuario PesquisarParaLogar(string nome, string senha)
       {
            Entityes.tb_usuario usuario = db.tb_usuario.FirstOrDefault(t => t.nm_usuario == nome
                                                                         && t.nm_senha == senha);

            return usuario;
       }
        public Entityes.tb_usuario PesquisarParaEnviarEmail(string usuario, string email)
        {
            Entityes.tb_usuario usuarioo = db.tb_usuario.FirstOrDefault(t => t.nm_usuario == usuario
                                                                         && t.ds_email == email );
            return usuarioo;
        }
        public Entityes.tb_usuario PesquisarParaRecuperacaoNoEmail(string email)
        {
            Entityes.tb_usuario usuario = db.tb_usuario.FirstOrDefault(t => t.ds_email == email);
                                                                         
            return usuario;
        }


        public Entityes.tb_usuario PesquisarusuariosIguasi(string nome)
        {
            Entityes.tb_usuario usuario = db.tb_usuario.FirstOrDefault(t => t.nm_usuario == nome);
                                                                         
            return usuario;
        }
        public void remover(Entityes.tb_codigo codigo)
        {
            var deleteCommand = db.Database.Connection.CreateCommand();
            deleteCommand.CommandText = "DELETE FROM tb_codigo";
            db.Database.Connection.Open();

            deleteCommand.ExecuteNonQuery();

            db.Database.Connection.Close();

        }
        public void inserirrcd(Entityes.tb_codigo tabela)
        {
            db.tb_codigo.Add(tabela);
            db.SaveChanges();
        }
        public void AlterarDadosUsuario(Entityes.tb_usuario usuario)
        {
            Entityes.tb_usuario altera = db.tb_usuario.First(a => a.nm_usuario == usuario.nm_usuario);    
            altera.nm_senha = usuario.nm_senha;
            db.SaveChanges();
            
        }
        public void EnviarCod(Entityes.tb_usuario tb)
        {
            //Gerar Numero aletorios
            //
            Random randNum = new Random();

            //Configura o email
            //
            string Email = tb.ds_email;
            string Assunto = "Codigo de recuperação";
            int Cod = randNum.Next();
            string Messagem = ("Insira uma senha que você lembre na próxima vez que for usar o sistema." + "\r\n" + "O Codigo de Verefição é: " + Cod);



            //Objeto responsavel
            //
            Objetos.EnviarEmail enviarEmail = new Objetos.EnviarEmail();
            enviarEmail.Enviar(Email, Assunto, Messagem);

            //Salvando o codigo no banco
            //
          // Entityes.tb_usuario alterar = db.tb_usuario.First(t => t.id_usuario == tb.id_usuario);
           //alterar.ds_recuperacao = Cod;
          // db.SaveChanges();

        }
       // public void Alterar(Entityes.tb_usuario usuario)
     //   {
          //  Random randNum = new Random();

           // Entityes.tb_usuario alterar = db.tb_usuario.First(t => t.ds_recuperacao == usuario.ds_recuperacao);
           // int Cod = randNum.Next();
           // alterar.ds_recuperacao = Cod;
           
           // db.SaveChanges();
       // }
        public Entityes.tb_usuario PesquisarParaRecuperar(string email)
        {
            Entityes.tb_usuario usuario = db.tb_usuario.FirstOrDefault(t => t.ds_email == email);                                                                      

            return usuario;
        }
    }
}
