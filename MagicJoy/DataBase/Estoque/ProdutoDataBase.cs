using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicJoy.DataBase.Estoque
{
    class ProdutoDataBase
    {
        Entityes.db_a4f992_magicEntities bd = new Entityes.db_a4f992_magicEntities();

        public void Inserir(Entityes.tb_produto produto)
        {
            bd.tb_produto.Add(produto);
            bd.SaveChanges();
        }

        public List<Entityes.tb_produto> ListarIdProduto(int id)
        {
            List<Entityes.tb_produto> lista = bd.tb_produto.Where(x => x.id_produto == id).ToList();
            return lista;
        }

        public List<Entityes.tb_produto> Listarpreco(decimal preco)
        {
            List<Entityes.tb_produto> lista = bd.tb_produto.Where(x => x.vl_preco == preco).ToList();
            return lista;
        }

        public List<Entityes.tb_produto> ListarProduto(string produto)
        {
            List<Entityes.tb_produto> lista = bd.tb_produto.Where(x => x.nm_produto.Contains(produto)).ToList();
            return lista;
        }

        public List<Entityes.tb_produto> ListarTodosProdutos()
        {
            List<Entityes.tb_produto> lista = bd.tb_produto.ToList();
            return lista;
        }

        public void AlterarEstoque(Entityes.tb_produto estoque)
        {
            Entityes.tb_produto alterar = bd.tb_produto.First(s => s.id_produto == estoque.id_produto);
            alterar.nm_produto = estoque.nm_produto;
            alterar.vl_preco = estoque.vl_preco;
            alterar.id_estoque = estoque.id_estoque;

            bd.SaveChanges();
        }

        public void RemoverEstoque(Entityes.tb_produto produto)
        {
            Entityes.tb_produto remover = bd.tb_produto.First(x => x.id_produto == produto.id_produto);
            bd.tb_produto.Remove(remover);
            bd.SaveChanges();
        }
    }
}
