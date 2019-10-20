using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicJoy.DataBase
{
    class LoginDataBase
    {
        Entityes.magicjoydbEntities11 db = new Entityes.magicjoydbEntities11();
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

        public Entityes.tb_usuario PesquisarusuariosIguasi(string nome)
        {
            Entityes.tb_usuario usuario = db.tb_usuario.FirstOrDefault(t => t.nm_usuario == nome);
                                                                         
            return usuario;
        }

    }
}
