using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicJoy.Business.RH
{
    class FuncionarioBusiness
    {
        public void InserirFuncionario(Entityes.tb_funcionario ponto)
        {         

            DataBase.RH.FuncionarioDataBase db = new DataBase.RH.FuncionarioDataBase();
            db.InserirFuncionario(ponto);

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
        public void AlterarPorData(Entityes.tb_controle_ponto ponto)
        {
            DataBase.RH.ControleDePontoDataBase db = new DataBase.RH.ControleDePontoDataBase();
            db.AlterarPontoPorData(ponto);

        }
        public void Remover(int id)
        {
            DataBase.RH.ControleDePontoDataBase db = new DataBase.RH.ControleDePontoDataBase();
            db.RemoverControleDePOnto(id);
        }
        public void RemoverPorData(DateTime data)
        {
            DataBase.RH.ControleDePontoDataBase db = new DataBase.RH.ControleDePontoDataBase();
            db.RemoverPontoPorData(data);
        }
    }
}
