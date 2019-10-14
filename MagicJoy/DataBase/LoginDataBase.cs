using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicJoy.DataBase
{
    class LoginDataBase
    {
        public void inserir (Entityes.tb_usuario usuario)
        {
            Entityes.magicjoydbEntities2 db = new Entityes.magicjoydbEntities2();
            db.tb_usuario.Add(usuario);
        }         
    }
}
