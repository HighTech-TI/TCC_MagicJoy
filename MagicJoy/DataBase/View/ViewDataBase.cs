using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicJoy.DataBase.View
{
    class ViewDataBase
    {
        Entityes.magicjoydbEntities2 db = new Entityes.magicjoydbEntities2();
        public List<Entityes.vw_fuxo_caixa> ListarTudo()
        {
            List<Entityes.vw_fuxo_caixa> lista = db.vw_fuxo_caixa.ToList();
            return lista;
        }
    }
}
