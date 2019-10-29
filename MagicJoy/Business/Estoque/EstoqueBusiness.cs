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
            if (estoque.id_estoque == 0)
            {
                throw new ArgumentException("Selecione o ID do produto");
            }

            DataBase.Estoque.EstoqueDataBase db = new DataBase.Estoque.EstoqueDataBase();
            db.InserirEstoque(Estoque);

        }

        public List<Entityes.tb_estoque> ListarTodosProdutos()
        {
            DataBase.Estoque.EstoqueDataBase ddb = new DataBase.Estoque.EstoqueDataBase();
            List<Entityes.tb_estoque> pesquisa = ddb.ListarTodosProdutos();

            return pesquisa;
        }

        public List<Entityes.tb_estoque> PesquisarPorData(int id)
        {
            DataBase.Estoque.EstoqueDataBase ddb = new DataBase.Estoque.EstoqueDataBase();
            List<Entityes.tb_estoque> pesquisa = ddb.PesquisarPorid(id);

            return pesquisa;
        }
        public List<Entityes.tb_estoque> PesquisarPorID(int id)
        {
            DataBase.Estoque.EstoqueDataBase ddb = new DataBase.Estoque.EstoqueDataBase();
            List<Entityes.tb_estoque> pesquisa = ddb.PesquisarPorId(id);

            return pesquisa;
        }
        public void Alterar(Entityes.tb_estoque estoque)
        {
            DataBase.Estoque.EstoqueDataBase db = new DataBase.Estoque.EstoqueDataBase();
            db.Alterarestoque(estoque);

        }
        public void AlterarPorData(Entityes.tb_controle_ponto ponto)
        {
            DataBase.Estoque.EstoqueDataBase db = new DataBase.Estoque.EstoqueDataBase();
            db.AlterarEstoquePorId(Estoque);

        }
        public void Remover(int id)
        {
            DataBase.Estoque.EstoqueDataBase db = new DataBase.Estoque.EstoqueDataBase();
            db.Removerestoque(id);
        }
        public void RemoverPorId(int id)
        {
            DataBase.Estoque.es db = new DataBase.Estoque.EstoqueDataBase();
            db.RemoverEstoque(id);
        }
    }
}
