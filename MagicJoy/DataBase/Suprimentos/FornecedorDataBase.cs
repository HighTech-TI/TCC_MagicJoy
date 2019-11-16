using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicJoy.DataBase.Suprimentos
{
    class FornecedorDataBase
    {
        Entityes.magicjoydbEntities2 db = new Entityes.magicjoydbEntities2();
       
        public void InserirForncedor(Entityes.tb_fornecedor fornecedor)
        {

            db.tb_fornecedor.Add(fornecedor);

            db.SaveChanges();
        }
        public List<Entityes.tb_fornecedor> ListarTodas()
        {
            List<Entityes.tb_fornecedor> tabela = db.tb_fornecedor.ToList();
            return tabela;

        }

        public List<Entityes.tb_fornecedor> ListarTodosforncedores()
        {
            List<Entityes.tb_fornecedor> tabela = db.tb_fornecedor.ToList();
            return tabela;
        }
        public List<Entityes.tb_fornecedor> PesquisarPorNomeFornecedor(string nome)
        {
            List<Entityes.tb_fornecedor> fornecedor = db.tb_fornecedor.Where
                                                      (s => s.nm_fornecedor == nome).ToList();
            return fornecedor;

        }
        public List<Entityes.tb_fornecedor> PesquisarPorIdForncedor(int id)
        {
            List<Entityes.tb_fornecedor> fornecedor = db.tb_fornecedor.Where
                                                      (s => s.id_fornecedor == id).ToList();
            return fornecedor;
        }
        public List<Entityes.tb_fornecedor> PesquisarPorProduto(string nome)
        {
            List<Entityes.tb_fornecedor> fornecedor = db.tb_fornecedor.Where
                                                      (s => s.nm_produto.Contains(nome)).ToList();
            return fornecedor;
        }
        public void AlterarFornecedor(Entityes.tb_fornecedor fornecedor)
        {

            Entityes.tb_fornecedor fornece = db.tb_fornecedor.First(a => a.id_fornecedor == fornecedor.id_fornecedor);
            fornece.ds_endereço = fornecedor.ds_endereço;
            fornece.ds_telefone = fornecedor.ds_telefone;
            fornece.ds_email = fornecedor.ds_email;
            fornece.nm_produto = fornecedor.nm_produto;
            fornece.ds_celular = fornecedor.ds_celular;
            fornece.nm_fornecedor = fornecedor.nm_fornecedor;
            fornece.ds_cnpj = fornecedor.ds_cnpj;
            fornece.ds_cpf = fornecedor.ds_cpf;
                                           

            db.SaveChanges();
        }
        public void RemoverFornecedor(Entityes.tb_fornecedor fornecedor)
        {

            Entityes.tb_fornecedor remover = db.tb_fornecedor.First(r => r.id_fornecedor == fornecedor.id_fornecedor);
            db.tb_fornecedor.Remove(remover);

            db.SaveChanges();
        }
    }
}
