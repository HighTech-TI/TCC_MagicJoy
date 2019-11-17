using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicJoy.Business.Estoque
{
    class PedidoBusiness
    {
        public void InserirProduto(Entityes.tb_pedido pedido)
        {
            if (pedido.nm_pedido == string.Empty)
            {
                throw new Exception("Pedido obrigatório");
            }
            if(pedido.nm_pedinte == string.Empty)
            {
                throw new Exception("Pedinte obrigatório");
            }                   
            DataBase.Estoque.PedidoDataBase produtoo = new DataBase.Estoque.PedidoDataBase();
            produtoo.Inserir(pedido);
        }
        public void Salvar(Entityes.tb_pedido pedido)
        {
            if (pedido.id_pedido == 0)
            {
                this.InserirProduto(pedido);
            }
            else
            {
                this.Alterar(pedido);
            }
        }


        public List<Entityes.tb_pedido> ListarTodosProdutos()
        {
            DataBase.Estoque.PedidoDataBase ddb = new DataBase.Estoque.PedidoDataBase();
            List<Entityes.tb_pedido> pesquisa = ddb.ListarTodosProdutos();

            return pesquisa;
        }
    

        public List<Entityes.tb_pedido> PesquisarPorID(int id)
        {
            DataBase.Estoque.PedidoDataBase ddb = new DataBase.Estoque.PedidoDataBase();
            List<Entityes.tb_pedido> pesquisa = ddb.ListarIdEstoque(id);

            return pesquisa;
        }
       
        public List<Entityes.tb_pedido> PesquisarPedinte(string pedinte)
        {
            DataBase.Estoque.PedidoDataBase ddb = new DataBase.Estoque.PedidoDataBase();
            List<Entityes.tb_pedido> pesquisa = ddb.ListarPedinte(pedinte);

            return pesquisa;
        }
        public void Alterar(Entityes.tb_pedido pedido)
        {
            DataBase.Estoque.PedidoDataBase db = new DataBase.Estoque.PedidoDataBase();
            db.AlterarEstoque(pedido);


        }
        public void Remover(Entityes.tb_pedido produto)
        {
            DataBase.Estoque.PedidoDataBase db = new DataBase.Estoque.PedidoDataBase();
            db.RemoverEstoque(produto);

        }
    }
}
