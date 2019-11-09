using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicJoy.DataBase.RH
{
    class ControleDePontoDataBase
    {
        Entityes.db_a4f992_magicEntities db = new Entityes.db_a4f992_magicEntities();
        public void InserirControleDePonto(Entityes.tb_controle_ponto ponto)
        {

            db.tb_controle_ponto.Add(ponto);

            db.SaveChanges();
        }
        public List<Entityes.tb_controle_ponto> ListarTodosControlePontos()
        {
            List<Entityes.tb_controle_ponto> tabela = db.tb_controle_ponto.ToList();
            return tabela;

        }
        public List<Entityes.tb_controle_ponto> PesquisarPorData(DateTime data)
        {
            List<Entityes.tb_controle_ponto> despesas = db.tb_controle_ponto.Where
                                                      (s => s.dt_dia == data).ToList();
            return despesas;

        }
        public List<Entityes.tb_controle_ponto> PesquisarPorIdControleDePonto(int id)
        {
            List<Entityes.tb_controle_ponto> ponto = db.tb_controle_ponto.Where
                                                      (s => s.id_controle_ponto == id).ToList();
            return ponto;
        }
        public List<Entityes.tb_controle_ponto> PesquisaPorNomeFuncio (string nome)
        {
            List<Entityes.tb_controle_ponto> ponto = db.tb_controle_ponto.Where
                                                      (s => s.tb_funcionario.nm_nome.Contains(nome)).ToList();
            return ponto;
        }
        public void AlterarControleDePonto(Entityes.tb_controle_ponto ponto)
        {

            Entityes.tb_controle_ponto altera = db.tb_controle_ponto.First(a => a.id_controle_ponto == ponto.id_controle_ponto);
            altera.hr_entrada = ponto.hr_entrada;
            altera.hr_intervalo = ponto.hr_intervalo;
            altera.dt_dia = ponto.dt_dia;
            altera.hr_saida = ponto.hr_saida;

            db.SaveChanges();
        }    
        public void RemoverControleDePOnto(Entityes.tb_controle_ponto ponto)
        {

            Entityes.tb_controle_ponto remover = db.tb_controle_ponto.First(r => r.id_controle_ponto == ponto.id_controle_ponto);
            db.tb_controle_ponto.Remove(remover);

            db.SaveChanges();
        }       
    }
}
