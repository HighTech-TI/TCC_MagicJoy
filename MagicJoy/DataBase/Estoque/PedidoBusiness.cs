using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicJoy.DataBase.Estoque
{
    class PedidoBusiness
    {
        Entityes.magicjoydbEntities13 banco = new Entityes.magicjoydbEntities13();

        public void Inserir(Entityes.tb_estoque estoque)
        {
            banco.tb_estoque.Add(estoque);
            banco.SaveChanges();
        }

        public List<Entityes.tb_estoque> ListarIdEstoque(int id)
        {
            List<Entityes.tb_estoque> lista = banco.tb_estoque.Where(x => x.id_estoque == id).ToList();
            return lista;
        }

        public List<Entityes.tb_estoque> ListarQTd(int qtd)
        {
            List<Entityes.tb_estoque> lista = banco.tb_estoque.Where(x => x.ds_qtd == qtd).ToList();
            return lista;
        }

        public List<Entityes.tb_estoque> ListarProduto(string produto)
        {
            List<Entityes.tb_estoque> lista = banco.tb_estoque.Where(x => x.nm_produto.Contains(produto)).ToList();
            return lista;
        }

        public List<Entityes.tb_estoque> ListarTodosProdutos()
        {
            List<Entityes.tb_estoque> lista = banco.tb_estoque.ToList();
            return lista;
        }

        public void AlterarEstoque(Entityes.tb_estoque estoque)
        {
            Entityes.tb_estoque alterar = banco.tb_estoque.First(s => s.id_estoque == estoque.id_estoque);
            alterar.nm_produto = estoque.nm_produto;
            alterar.ds_qtd = estoque.ds_qtd;
            alterar.vl_custo = estoque.vl_custo;
            banco.SaveChanges();
        }

        public void RemoverEstoque(Entityes.tb_estoque estoque)
        {
            Entityes.tb_estoque remover = banco.tb_estoque.First(x => x.id_estoque == estoque.id_estoque);
            banco.tb_estoque.Remove(remover);
            banco.SaveChanges();
        }
    }
}
