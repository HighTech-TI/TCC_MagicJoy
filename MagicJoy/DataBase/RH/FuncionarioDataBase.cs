using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicJoy.DataBase.RH
{
    class FuncionarioDataBase
    {
        Entityes.magicjoydbEntities11 db = new Entityes.magicjoydbEntities11();
        public void InserirFuncionario(Entityes.tb_funcionario funcionario)
        {

            db.tb_funcionario.Add(funcionario);

            db.SaveChanges();
        }
        public List<Entityes.tb_funcionario> ListarTodos()
        {
            List<Entityes.tb_funcionario> tabela = db.tb_funcionario.ToList();
            return tabela;

        }
        public List<Entityes.tb_funcionario> PesquisarPorNome(string nome)
        {
            List<Entityes.tb_funcionario> compras = db.tb_funcionario.Where
                                                      (s => s.nm_nome.Contains(nome)).ToList();
            return compras;

        }
        public List<Entityes.tb_funcionario> PesquisarPorRg(string rg)
        {
            List<Entityes.tb_funcionario> compras = db.tb_funcionario.Where
                                                      (s => s.ds_rg == rg).ToList();
            return compras;

        }
        public List<Entityes.tb_funcionario> PesquisarPorIdFuncionarios(int id)
        {
            List<Entityes.tb_funcionario> funcionario = db.tb_funcionario.Where
                                                      (s => s.id_funcionario == id).ToList();
            return funcionario;
        }
        public void AlterarFuncionario(Entityes.tb_funcionario funcionario)
        {

            Entityes.tb_funcionario altera = db.tb_funcionario.First(a => a.id_funcionario == funcionario.id_funcionario);
            altera.ds_endereco = funcionario.ds_endereco;
            altera.nm_nome = funcionario.nm_nome;         
            altera.ds_cpf = funcionario.ds_cpf;
            altera.ds_rg = funcionario.ds_rg;
            altera.dt_nascimento = funcionario.dt_nascimento;
            altera.dt_admissao = funcionario.dt_admissao;
            altera.dt_demissao = funcionario.dt_demissao;
            altera.ds_celular = funcionario.ds_celular;
            altera.ds_telefone = funcionario.ds_telefone;
            altera.id_beneficios = funcionario.id_beneficios;
            altera.id_folha_pagamento = funcionario.id_folha_pagamento;
            altera.nm_cargo = funcionario.nm_cargo;
            
            
            db.SaveChanges();
        }  
        public void RemoverFuncionario(Entityes.tb_funcionario funcionario)
        {

            Entityes.tb_funcionario remover = db.tb_funcionario.First(r => r.id_funcionario == funcionario.id_funcionario);
            db.tb_funcionario.Remove(remover);

            db.SaveChanges();
        }
    }
}
