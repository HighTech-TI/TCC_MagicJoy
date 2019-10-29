using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicJoy.DataBase.Estoque
{
    class EstoqueDataBase
    {
        public List<Database.Entity.tb_estoque> ListarIdEstoque(int id)
        {
            if (id == 0)
            {
                throw new ArgumentException(" numero de id invalido");
            }
            EstoqueDataBase db = new EstoqueDataBase();
            List<EstoqueDataBase.Entity.tb_estoque> est = db.ListarIdEstoque(id);

            return Estoque;
        }
    }
}
