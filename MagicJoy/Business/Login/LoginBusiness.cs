using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicJoy.Business
{
    class LoginBusiness
    {
        public void inserir(Entityes.tb_usuario usuario)
        {
            if(usuario.nm_usuario == string.Empty)
            {
                throw new ArgumentException("Usuário obrigatório!");
            }
         
            if(usuario.nm_senha == string.Empty)
            {
                throw new ArgumentException("Senha é obrigatório");
            }

            if(usuario.ds_email == string.Empty)
            {
                throw new ArgumentException("Email obrigatório!");
            }

            
            
            if(usuario.ds_cargo == string.Empty)
            {
                throw new ArgumentException("Cargo obrigatório!");
            }

            DataBase.LoginDataBase db = new DataBase.LoginDataBase();
            db.inserir(usuario);

        }

        public List<Entityes.tb_usuario> ListarTodosUsuarios()
        {
            DataBase.LoginDataBase logdata = new DataBase.LoginDataBase();
            List<Entityes.tb_usuario> pesquisa = logdata.ListarTodosUsuarios();

            return pesquisa;
        }
        
        public Entityes.tb_usuario PesquisarParaLogar(string nome, string senha)
        {
            DataBase.LoginDataBase logdatabase = new DataBase.LoginDataBase();
            Entityes.tb_usuario usuario = logdatabase.PesquisarParaLogar(nome, senha);

            return usuario;
        }

        public Entityes.tb_usuario PesquisarusuariosIguasi(string nome)
        {
            DataBase.LoginDataBase logdatabase = new DataBase.LoginDataBase();
            Entityes.tb_usuario usuario = logdatabase.PesquisarusuariosIguasi(nome);

            return usuario;


        }



    }
}
