using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicJoy.Business.Estoque
{
    class EstoqueBusiness
    {
        public void InserirEstoque(Entityes.tb_estoque estoque)
        {
            if (estoque.nm_produto == string.Empty)
            {
                throw new ArgumentException("Nome do produto é obrigatório");
            }
            if(estoque.ds_qtd == 0)
            {
                throw new ArgumentException("Quantidade do produto é obrigatório");
            }
            if(estoque.vl_custo == 0)
            {
                throw new ArgumentException("Valor de custo é obrigatório");
            }
            if(estoque.tb_Fornecedor_id_fornecedor == 0)
            {
                throw new ArgumentException("Id do fornecedor é obrigatório");
            }

            DataBase.Estoque.EstoqueDataBase db = new DataBase.Estoque.EstoqueDataBase();
            db.InserirEstoque(estoque);

        }

        public List<Entityes.tb_estoque> ListarTodosProdutos()
        {
            DataBase.Estoque.EstoqueDataBase ddb = new DataBase.Estoque.EstoqueDataBase();
            List<Entityes.tb_estoque> pesquisa = ddb.ListarTodosProdutos();

            return pesquisa;
        }

        public List<Entityes.tb_estoque> PesquisarPorID(int id)
        {
            DataBase.Estoque.EstoqueDataBase ddb = new DataBase.Estoque.EstoqueDataBase();
            List<Entityes.tb_estoque> pesquisa = ddb.ListarIdEstoque(id);

            return pesquisa;
        }
        public void Alterar(Entityes.tb_estoque estoque)
        {
            DataBase.Estoque.EstoqueDataBase db = new DataBase.Estoque.EstoqueDataBase();
            db.AlterarEstoque(estoque);

        }
        public void AlterarPorData(Entityes.tb_controle_ponto ponto)
        {
            DataBase.Estoque.EstoqueDataBase db = new DataBase.Estoque.EstoqueDataBase();
            //db.AlterarEstoquePorId(Estoque);

        }
        public void Remover(Entityes.tb_estoque estoque)
        {
            DataBase.Estoque.EstoqueDataBase db = new DataBase.Estoque.EstoqueDataBase();
            db.RemoverEstoque(estoque);
        }
    }
}
