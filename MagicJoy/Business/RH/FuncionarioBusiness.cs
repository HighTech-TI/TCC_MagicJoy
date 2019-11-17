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
           
            if(ponto.nm_nome == string.Empty)
            {
                throw new Exception("Nome obrigatório");
            }
            if(ponto.nm_cargo == string.Empty)
            {
                throw new Exception("Cargo obrigatório");
            }
            if(ponto.ds_celular == string.Empty)
            {
                throw new Exception("Celular obrigatório");
            }
            if(ponto.ds_cpf == string.Empty)
            {
                throw new Exception("CPF obrigatório");
            }
            if(ponto.ds_endereco == string.Empty)
            {
                throw new Exception("Endereço obrigatório");
            }
            if(ponto.ds_rg == string.Empty)
            {
                throw new Exception("RG obrigatório");
            }
            if(ponto.ds_telefone == string.Empty)
            {
                throw new Exception("Telefone obrigatório");
            }
            
                   
            DataBase.RH.FuncionarioDataBase db = new DataBase.RH.FuncionarioDataBase();
            db.InserirFuncionario(ponto);

        }

        public void Salvar(Entityes.tb_funcionario funcionario)
        {
            if (funcionario.id_funcionario == 0)
            {
                this.InserirFuncionario(funcionario);
            }
            else
            {
                this.Alterar(funcionario);
            }
        }
        public List<Entityes.tb_funcionario> ListarTodos()
        {
            DataBase.RH.FuncionarioDataBase ddb = new DataBase.RH.FuncionarioDataBase();
            List<Entityes.tb_funcionario> pesquisa = ddb.ListarTodos();

            return pesquisa;
        }

        public List<Entityes.tb_funcionario> PesquisarPorNome(string data)
        {
            DataBase.RH.FuncionarioDataBase ddb = new DataBase.RH.FuncionarioDataBase();
            List<Entityes.tb_funcionario> pesquisa = ddb.PesquisarPorNome(data);

            return pesquisa;
        }
        public List<Entityes.tb_funcionario> PesquisarPorID(int id)
        {
            DataBase.RH.FuncionarioDataBase ddb = new DataBase.RH.FuncionarioDataBase();
            List<Entityes.tb_funcionario> pesquisa = ddb.PesquisarPorIdFuncionarios(id);

            return pesquisa;
        }
        public List<Entityes.tb_funcionario> PesquisarPorRg(string id)
        {
            DataBase.RH.FuncionarioDataBase ddb = new DataBase.RH.FuncionarioDataBase();
            List<Entityes.tb_funcionario> pesquisa = ddb.PesquisarPorRg(id);

            return pesquisa;
        }
        public void Alterar(Entityes.tb_funcionario ponto)
        {
            DataBase.RH.FuncionarioDataBase db = new DataBase.RH.FuncionarioDataBase();
            db.AlterarFuncionario(ponto);

        }       
        public void Remover(Entityes.tb_funcionario funcionario)
        {
            DataBase.RH.FuncionarioDataBase db = new DataBase.RH.FuncionarioDataBase();
            db.RemoverFuncionario(funcionario);
        }
      
    }
}
