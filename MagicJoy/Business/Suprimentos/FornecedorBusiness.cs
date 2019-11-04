using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicJoy.Business.Suprimentos
{
    class FornecedorBusiness
    {
        public void InserirFornecedor(Entityes.tb_fornecedor fornecedor)
        {


            DataBase.Suprimentos.FornecedorDataBase db = new DataBase.Suprimentos.FornecedorDataBase();
            db.InserirForncedor(fornecedor);

        }
        public void Salvar(Entityes.tb_fornecedor fornecedor)
        {
            if (fornecedor.id_fornecedor == 0)
            {
                this.InserirFornecedor(fornecedor);
            }
            else
            {
                this.Alterar(fornecedor);
            }
        }


        public List<Entityes.tb_fornecedor> ListarTodos()
        {
            DataBase.Suprimentos.FornecedorDataBase ddb = new DataBase.Suprimentos.FornecedorDataBase();
            List<Entityes.tb_fornecedor> pesquisa = ddb.ListarTodas();

            return pesquisa;
        }

        public List<Entityes.tb_fornecedor> PesquisarPorNome(string nomefornce)
        {
            DataBase.Suprimentos.FornecedorDataBase ddb = new DataBase.Suprimentos.FornecedorDataBase();
            List<Entityes.tb_fornecedor> pesquisa = ddb.PesquisarPorNomeFornecedor(nomefornce);

            return pesquisa;
        }
        public List<Entityes.tb_fornecedor> PesquisarPorNomedeProduto(string nomefornce)
        {
            DataBase.Suprimentos.FornecedorDataBase ddb = new DataBase.Suprimentos.FornecedorDataBase();
            List<Entityes.tb_fornecedor> pesquisa = ddb.PesquisarPorProduto(nomefornce);

            return pesquisa;
        }
        public List<Entityes.tb_fornecedor> PesquisarPorID(int id)
        {
            DataBase.Suprimentos.FornecedorDataBase ddb = new DataBase.Suprimentos.FornecedorDataBase();
            List<Entityes.tb_fornecedor> pesquisa = ddb.PesquisarPorIdForncedor(id);

            return pesquisa;
        }
        public void Alterar(Entityes.tb_fornecedor fornecedor)
        {
            DataBase.Suprimentos.FornecedorDataBase db = new DataBase.Suprimentos.FornecedorDataBase();
            db.AlterarFornecedor(fornecedor);

        }
       
       public void Remover(Entityes.tb_fornecedor fornecedor)
        {
            DataBase.Suprimentos.FornecedorDataBase db = new DataBase.Suprimentos.FornecedorDataBase();
            db.RemoverFornecedor(fornecedor);
        }
       
    }
}
