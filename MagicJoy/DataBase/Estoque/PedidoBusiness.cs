using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicJoy.DataBase.Estoque
{
    class PedidoDataBase
    {
        Entityes.db_a4f992_magicEntities banco = new Entityes.db_a4f992_magicEntities();

        public void Inserir(Entityes.tb_pedido pedido)
        {
            banco.tb_pedido.Add(pedido);
            banco.SaveChanges();
        }

        public List<Entityes.tb_pedido> ListarIdEstoque(int id)
        {
            List<Entityes.tb_pedido> lista = banco.tb_pedido.Where(x => x.id_pedido == id).ToList();
            return lista;
        }

        public List<Entityes.tb_pedido> ListarPedinte(string pedinte)
        {
            List<Entityes.tb_pedido> lista = banco.tb_pedido.Where(x => x.nm_pedinte.Contains(pedinte)).ToList();
            return lista;
        }

        public List<Entityes.tb_pedido> ListarTodosProdutos()
        {
            List<Entityes.tb_pedido> lista = banco.tb_pedido.ToList();
            return lista;
        }

        public void AlterarEstoque(Entityes.tb_pedido pedido)
        {
            Entityes.tb_pedido alterar = banco.tb_pedido.First(s => s.id_pedido == pedido.id_pedido);
            alterar.nm_pedido = pedido.nm_pedido;
            alterar.nm_pedinte = pedido.nm_pedinte;
            alterar.dt_pedido = pedido.dt_pedido;
            banco.SaveChanges();
        }

        public void RemoverEstoque(Entityes.tb_pedido pedido)
        {
            Entityes.tb_pedido remover = banco.tb_pedido.First(x => x.id_pedido == pedido.id_pedido);
            banco.tb_pedido.Remove(remover);
            banco.SaveChanges();
        }
    }
}
