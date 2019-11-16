using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicJoy.Business.Financeiro
{
    class DespesaBusiness
    {
        public void InserirCliente(Entityes.tb_despesa despesa)
        {
            if(despesa.ds_descricao == string.Empty)
            {
                throw new Exception("Descrição obrigatório");
            }
            if(despesa.vl_despesa == 0)
            {
                throw new Exception("Valor obrigatório");
            }

            DataBase.Financeiro.DespesasDataBase db = new DataBase.Financeiro.DespesasDataBase();
            db.InserirDespesas(despesa);

        }
        public void Salvar(Entityes.tb_despesa despesa)
        {
            if (despesa.id_despesa == 0)
            {
                this.InserirCliente(despesa);
            }
            else
            {
                this.Alterar(despesa);
            }
        }

        public List<Entityes.tb_despesa> ListarTudo()
        {
            DataBase.Financeiro.DespesasDataBase ddb = new DataBase.Financeiro.DespesasDataBase();
            List<Entityes.tb_despesa> pesquisa = ddb.ListarTodos();

            return pesquisa;
        }

        public List<Entityes.tb_despesa> PesquisarPorID(int id)
        {
            DataBase.Financeiro.DespesasDataBase dbb = new DataBase.Financeiro.DespesasDataBase();
            List<Entityes.tb_despesa> pesquisa = dbb.PesquisarPorI(id);

            return pesquisa;
        }
        public List<Entityes.tb_despesa> PesquisarPorNome(string nome)
        {
            DataBase.Financeiro.DespesasDataBase dbb = new DataBase.Financeiro.DespesasDataBase();
            List<Entityes.tb_despesa> pesquisa = dbb.PesquisarPorNome(nome);

            return pesquisa;
        }
        public List<Entityes.tb_despesa> PesquisarPorData(DateTime data)
        {
            DataBase.Financeiro.DespesasDataBase dbb = new DataBase.Financeiro.DespesasDataBase();
            List<Entityes.tb_despesa> pesquisa = dbb.PesquisarPorData(data);

            return pesquisa;
        }
        public void Alterar(Entityes.tb_despesa despesa)
        {
            DataBase.Financeiro.DespesasDataBase db = new DataBase.Financeiro.DespesasDataBase();
            db.AlterarDespesas(despesa);
            
        }
        public void Remover(Entityes.tb_despesa despesa)
        {
            DataBase.Financeiro.DespesasDataBase clientee = new DataBase.Financeiro.DespesasDataBase();
            clientee.AlterarDespesas(despesa);
        }
    }
}
