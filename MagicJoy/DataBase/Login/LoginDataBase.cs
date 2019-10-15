using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicJoy.DataBase
{
    class LoginDataBase
    {
        Entityes.magicjoydbEntities3 db = new Entityes.magicjoydbEntities3();
        public void inserir (Entityes.tb_usuario usuario)
        {
            
            db.tb_usuario.Add(usuario);

            db.SaveChanges();
        }

        public List<Entityes.tb_usuario> ConsultarParaLogar(string nome)
        {

            List<Entityes.tb_usuario> usario = db.tb_usuario.Where(t => t.nm_usuario == nome).ToList();

            return usario;
        }
    }
}
