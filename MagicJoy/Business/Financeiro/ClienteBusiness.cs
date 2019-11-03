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
        public void Salvar(Entityes.tb_cliente cliente)
        {
            if (cliente.id_cliente == 0)
            {
                this.InserirCliente(cliente);
            }
            else
            {
                this.Alterar(cliente);
            }
        }

        public List<Entityes.tb_cliente> ListarTudo()
        {
            DataBase.Financeiro.ClienteDataBase ddb = new DataBase.Financeiro.ClienteDataBase();
            List<Entityes.tb_cliente> pesquisa = ddb.ListarTodosClientes();

            return pesquisa;
        }

        public List<Entityes.tb_cliente> PesquisarPorID(int id)
        {
            DataBase.Financeiro.ClienteDataBase dbb = new DataBase.Financeiro.ClienteDataBase();
            List<Entityes.tb_cliente> pesquisa = dbb.PesquisarPorIdCliente(id);

            return pesquisa;
        }
        public List<Entityes.tb_cliente> PesquisarPorCpf(string cpf)
        {
            DataBase.Financeiro.ClienteDataBase dbb = new DataBase.Financeiro.ClienteDataBase();
            List<Entityes.tb_cliente> pesquisa = dbb.PesquisarPorCpf(cpf);

            return pesquisa;
        }
        public List<Entityes.tb_cliente> PesquisarPorNome(string nome)
        {
            DataBase.Financeiro.ClienteDataBase dbb = new DataBase.Financeiro.ClienteDataBase();
            List<Entityes.tb_cliente> pesquisa = dbb.PesquisarPorNome(nome);

            return pesquisa;
        }
        public void Alterar(Entityes.tb_cliente cliente)
        {
            DataBase.Financeiro.ClienteDataBase db = new DataBase.Financeiro.ClienteDataBase();
            db.AlterarCliente(cliente);

        }       
        public void Remover(Entityes.tb_cliente cliente)
        {
            DataBase.Financeiro.ClienteDataBase clientee = new DataBase.Financeiro.ClienteDataBase();
            clientee.RemoverCliente(cliente);
        }
      
    }
}
