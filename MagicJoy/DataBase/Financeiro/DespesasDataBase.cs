using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicJoy.DataBase.Financeiro
{
    class DespesasDataBase
    {
        Entityes.magicjoydbEntities14 db = new Entityes.magicjoydbEntities14();
        public void InserirDespesas(Entityes.tb_despesa despesas)
        {

            db.tb_despesa.Add(despesas);

            db.SaveChanges();
        }
        public List<Entityes.tb_despesa> ListarTodosClientes()
        {
            List<Entityes.tb_despesa> tabela = db.tb_despesa.ToList();
            return tabela;

        }
        public List<Entityes.tb_despesa> PesquisarPorNome(string descricao)
        {
            List<Entityes.tb_despesa> despesas = db.tb_despesa.Where
                                                      (s => s.ds_descricao == descricao).ToList();
            return despesas;

        }
        public List<Entityes.tb_despesa> PesquisarPorIdFuncionarios(int id)
        {
            List<Entityes.tb_despesa> despesas = db.tb_despesa.Where
                                                      (s => s.id_despesa == id).ToList();
            return despesas;
        }
        public void AlterarDespesas(Entityes.tb_despesa despesa)
        {

            Entityes.tb_despesa altera = db.tb_despesa.First(a => a.id_despesa == despesa.id_despesa);
            altera.ds_descricao = despesa.ds_descricao;
            altera.vl_valor = despesa.vl_valor;
            altera.dt_vencimento = despesa.dt_vencimento;


            db.SaveChanges();
        }
        public void AlterarDespesaPorDescricao (Entityes.tb_despesa despesa)
        {

            Entityes.tb_despesa altera = db.tb_despesa.First(a => a.ds_descricao == despesa.ds_descricao);
            altera.ds_descricao = despesa.ds_descricao;
            altera.vl_valor = despesa.vl_valor;
            altera.dt_vencimento = despesa.dt_vencimento;

            db.SaveChanges();
        }
        public void RemoverDespesa(int id)
        {

            Entityes.tb_despesa remover = db.tb_despesa.First(r => r.id_despesa == id);
            db.tb_despesa.Remove(remover);

            db.SaveChanges();
        }
        public void RemoverDesccricaoPorDescricao(string nome)
        {

            Entityes.tb_despesa remover = db.tb_despesa.First(r => r.ds_descricao == nome);
            db.tb_despesa.Remove(remover);

            db.SaveChanges();
        }
    }
}
