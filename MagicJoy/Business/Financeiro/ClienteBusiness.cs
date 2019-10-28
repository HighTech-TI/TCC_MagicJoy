using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicJoy.Business.Financeiro
{
    class ClienteBusiness
    {
        public void InserirCliente(Entityes.tb_cliente cliente)
        {
            if(cliente.nm_nome == string.Empty)
            {
                throw new ArgumentException("Nome obrigatório");
            }

            if(cliente.ds_cpf == string.Empty)
            {
                throw new ArgumentException("Cpf obrigatório");
               
            }
            if(cliente.ds_endereço == string.Empty)
            {
                throw new ArgumentException("Endereço obrigatório");
            }
            if(cliente.ds_telefone == string.Empty)
            {
                throw new ArgumentException("Telefone obrigatório");
            }
            
            DataBase.Financeiro.ClienteDataBase db = new DataBase.Financeiro.ClienteDataBase();
            db.InserirClientes(cliente);

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
