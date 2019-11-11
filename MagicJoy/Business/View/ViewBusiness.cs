using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicJoy.Business.View
{
    class ViewBusiness
    {
        public List<Entityes.vw_fuxo_caixa> ListarTudo()
        {
            DataBase.View.ViewDataBase ddb = new DataBase.View.ViewDataBase();
            List<Entityes.vw_fuxo_caixa> pesquisa = ddb.ListarTudo();

            return pesquisa;
        }

    }
}
