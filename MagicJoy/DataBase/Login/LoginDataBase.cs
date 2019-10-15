using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicJoy.DataBase
{
    class LoginDataBase
    {
        Entityes.magicjoydbEntities4 db = new Entityes.magicjoydbEntities4();
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
    }
}
