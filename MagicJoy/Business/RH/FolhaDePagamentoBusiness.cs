using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicJoy.Business.RH
{
    class FolhaDePagamentoBusiness
    {
        public void InserirControleDePonto(Entityes.tb_controle_ponto ponto)
        {
            if (ponto.id_funcionario == 0)
            {
                throw new ArgumentException("Selecione o ID do funcionário");
            }
            


            DataBase.RH.ControleDePontoDataBase db = new DataBase.RH.ControleDePontoDataBase();
            db.InserirControleDePonto(ponto);

        }
        public Entityes.tb_folha_pagamento PesquisarParaSalario(int id, decimal salrio)
        {
            DataBase.RH.FolhaDepagamentoDataBase logdatabase = new DataBase.RH.FolhaDepagamentoDataBase();
            Entityes.tb_folha_pagamento folha = logdatabase.PesquisarParaSalario(id, salrio);

            return folha;
        }

        public List<Entityes.tb_controle_ponto> ListarTodosUsuarios()
        {
            DataBase.RH.ControleDePontoDataBase ddb = new DataBase.RH.ControleDePontoDataBase();
            List<Entityes.tb_controle_ponto> pesquisa = ddb.ListarTodosControlePontos();

            return pesquisa;
        }

        public List<Entityes.tb_controle_ponto> PesquisarPorData(DateTime data)
        {
            DataBase.RH.ControleDePontoDataBase ddb = new DataBase.RH.ControleDePontoDataBase();
            List<Entityes.tb_controle_ponto> pesquisa = ddb.PesquisarPorData(data);

            return pesquisa;
        }
        public List<Entityes.tb_controle_ponto> PesquisarPorID(int id)
        {
            DataBase.RH.ControleDePontoDataBase ddb = new DataBase.RH.ControleDePontoDataBase();
            List<Entityes.tb_controle_ponto> pesquisa = ddb.PesquisarPorIdControleDePonto(id);

            return pesquisa;
        }
        public void Alterar(Entityes.tb_controle_ponto ponto)
        {
            DataBase.RH.ControleDePontoDataBase db = new DataBase.RH.ControleDePontoDataBase();
            db.AlterarControleDePonto(ponto);

        }
        
       // public void Remover(int id)
      //  {
         //   DataBase.RH.ControleDePontoDataBase db = new DataBase.RH.ControleDePontoDataBase();
           // db.RemoverControleDePOnto(id);
        //}
       
    }
}
