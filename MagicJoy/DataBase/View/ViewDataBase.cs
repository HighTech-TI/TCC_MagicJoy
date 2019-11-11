using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicJoy.DataBase.View
{
    class ViewDataBase
    {
        Entityes.db_a4f992_magicEntities db = new Entityes.db_a4f992_magicEntities();
        public List<Entityes.vw_fuxo_caixa> ListarTudo()
        {
            List<Entityes.vw_fuxo_caixa> lista = db.vw_fuxo_caixa.ToList();
            return lista;
        }
    }
}
