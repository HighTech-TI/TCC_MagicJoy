using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicJoy.DataBase.Financeiro
{
    class DespesasDataBase
    {
        Entityes.db_a4f992_magicEntities db = new Entityes.db_a4f992_magicEntities();
        public void InserirDespesas(Entityes.tb_despesa despesas)
        {

            db.tb_despesa.Add(despesas);

            db.SaveChanges();
        }
        public List<Entityes.tb_despesa> ListarTodos()
        {
            List<Entityes.tb_despesa> tabela = db.tb_despesa.ToList();
            return tabela;

        }
        public List<Entityes.tb_despesa> PesquisarPorNome(string descricao)
        {
            List<Entityes.tb_despesa> despesas = db.tb_despesa.Where
                                                      (s => s.ds_descricao.Contains(descricao)).ToList();
            return despesas;

        }
        public List<Entityes.tb_despesa> PesquisarPorI(int id)
        {
            List<Entityes.tb_despesa> despesas = db.tb_despesa.Where
                                                      (s => s.id_despesa == id).ToList();
            return despesas;
        }
        public List<Entityes.tb_despesa> PesquisarPorData(DateTime data)
        {
            List<Entityes.tb_despesa> despesas = db.tb_despesa.Where
                                                      (s => s.dt_datadevencimento == data).ToList();
            return despesas;
        }
        public void AlterarDespesas(Entityes.tb_despesa despesa)
        {

            Entityes.tb_despesa altera = db.tb_despesa.First(a => a.id_despesa == despesa.id_despesa);
            altera.ds_descricao = despesa.ds_descricao;
            altera.vl_valor = despesa.vl_valor;
            altera.dt_datadevencimento = despesa.dt_datadevencimento;


            db.SaveChanges();
        }    
        public void RemoverDespesa(Entityes.tb_despesa despesa)
        {

            Entityes.tb_despesa remover = db.tb_despesa.First(r => r.id_despesa == despesa.id_despesa);
            db.tb_despesa.Remove(remover);

            db.SaveChanges();
        }
       
    }
}
