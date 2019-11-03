using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicJoy.Business.Estoque
{
    class ProdutoBusiness
    {
        public void InserirProduto(Entityes.tb_produto produto)
        {
            if (produto.nm_produto == string.Empty)
            {
                throw new ArgumentException("Nome do produto é obrigatório");
            }
            if (produto.vl_preco == 0)
            {
                throw new ArgumentException("Preço do produto é obrigatótio");
            }

            if (produto.id_estoque == 0)
            {
                throw new ArgumentException("Id do estoque é obrigatório");
            }

            DataBase.Estoque.ProdutoDataBase produtoo = new DataBase.Estoque.ProdutoDataBase();
            produtoo.Inserir(produto);
        }
        public void Salvar(Entityes.tb_produto produto)
        {
            if (produto.id_produto == 0)
            {
                this.InserirProduto(produto);
            }
            else
            {
                this.Alterar(produto);
            }
        }


        public List<Entityes.tb_produto> ListarTodosProdutos()
        {
            DataBase.Estoque.ProdutoDataBase ddb = new DataBase.Estoque.ProdutoDataBase();
            List<Entityes.tb_produto> pesquisa = ddb.ListarTodosProdutos();

            return pesquisa;
        }

        public List<Entityes.tb_produto> PesquisarPorID(int id)
        {
            DataBase.Estoque.ProdutoDataBase ddb = new DataBase.Estoque.ProdutoDataBase();
            List<Entityes.tb_produto> pesquisa = ddb.ListarIdProduto(id);

            return pesquisa;
        }
        public List<Entityes.tb_produto> PesquisarPorPreco(decimal preco)
        {
            DataBase.Estoque.ProdutoDataBase ddb = new DataBase.Estoque.ProdutoDataBase();
            List<Entityes.tb_produto> pesquisa = ddb.Listarpreco(preco);

            return pesquisa;
        }
        public List<Entityes.tb_produto> PesquisarPorPodruto(string produto)
        {
            DataBase.Estoque.ProdutoDataBase ddb = new DataBase.Estoque.ProdutoDataBase();
            List<Entityes.tb_produto> pesquisa = ddb.ListarProduto(produto);

            return pesquisa;
        }
        public void Alterar(Entityes.tb_produto produto)
        {
            DataBase.Estoque.ProdutoDataBase db = new DataBase.Estoque.ProdutoDataBase();
            db.AlterarEstoque(produto);


        }
        public void Remover(Entityes.tb_produto produto)
        {
            DataBase.Estoque.ProdutoDataBase db = new DataBase.Estoque.ProdutoDataBase();
            db.RemoverEstoque(produto);

        }
    }
}
