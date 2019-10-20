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
        public List<Entityes.tb_funcionario> ListarTodasCompras()
        {
            List<Entityes.tb_funcionario> tabela = db.tb_funcionario.ToList();
            return tabela;

        }
        public List<Entityes.tb_funcionario> PesquisarPorNome(string nome)
        {
            List<Entityes.tb_funcionario> compras = db.tb_funcionario.Where
                                                      (s => s.nm_nome == nome).ToList();
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
            altera.tb_folha_pagamento_id_folha_pagamento = funcionario.tb_folha_pagamento_id_folha_pagamento;
            altera.ds_cpf = funcionario.ds_cpf;
            altera.ds_rg = funcionario.ds_rg;
            altera.dt_nascimento = funcionario.dt_nascimento;
            altera.dt_admissao = funcionario.dt_admissao;
            altera.dt_demissao = funcionario.dt_demissao;
            
            db.SaveChanges();
        }
        public void AlterarCompraPorData(Entityes.tb_funcionario funcionario)
        {

            Entityes.tb_funcionario altera = db.tb_funcionario.First(a => a.nm_nome == funcionario.nm_nome);
            altera.ds_endereco = funcionario.ds_endereco;
            altera.nm_nome = funcionario.nm_nome;
            altera.tb_folha_pagamento_id_folha_pagamento = funcionario.tb_folha_pagamento_id_folha_pagamento;
            altera.ds_cpf = funcionario.ds_cpf;
            altera.ds_rg = funcionario.ds_rg;
            altera.dt_nascimento = funcionario.dt_nascimento;
            altera.dt_admissao = funcionario.dt_admissao;
            altera.dt_demissao = funcionario.dt_demissao;

            db.SaveChanges();
        }
        public void RemoverFuncionario(int id)
        {

            Entityes.tb_funcionario remover = db.tb_funcionario.First(r => r.id_funcionario == id);
            db.tb_funcionario.Remove(remover);

            db.SaveChanges();
        }
        public void RemoverFuncionarioPorNome(string nome)
        {

            Entityes.tb_funcionario remover = db.tb_funcionario.First(r => r.nm_nome == nome);
            db.tb_funcionario.Remove(remover);

            db.SaveChanges();
        }
    }
}
