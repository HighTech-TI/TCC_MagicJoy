using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicJoy.DataBase.RH
{
    class FolhaDepagamentoDataBase
    {
        Entityes.db_a4f992_magicEntities db = new Entityes.db_a4f992_magicEntities();
        public void inserir(Entityes.tb_folha_pagamento rh)
        {

            db.tb_folha_pagamento.Add(rh);

            db.SaveChanges();
        }
        public Entityes.tb_folha_pagamento PesquisarParaSalario(int id, decimal salario)
        {
            Entityes.tb_folha_pagamento folha = db.tb_folha_pagamento.FirstOrDefault(t => t.id_funcionario == id
                                                                         && t.vl_bruto == salario);

            return folha;
        }
        public List<Entityes.tb_folha_pagamento> ListarTodasFolha()
        {
            List<Entityes.tb_folha_pagamento> tabela = db.tb_folha_pagamento.ToList();
            return tabela;

        }
        public List<Entityes.tb_folha_pagamento> PesquisarFolhaPorIdFolha(int id)
        {
            List<Entityes.tb_folha_pagamento> folha = db.tb_folha_pagamento.Where
                                                      (s => s.id_folha_pagamento == id).ToList();
            return folha;

        }
        public List<Entityes.tb_folha_pagamento> PesquisarFolhaPorIdFunc(int id)
        {
            List<Entityes.tb_folha_pagamento> folha = db.tb_folha_pagamento.Where
                                                      (s => s.id_funcionario == id).ToList();
            return folha;
        }
        public void AlterarFolha(Entityes.tb_folha_pagamento folha)
        {

            Entityes.tb_folha_pagamento alterar = db.tb_folha_pagamento.First(a => a.id_folha_pagamento == folha.id_folha_pagamento);
            

            db.SaveChanges();
        }
        public void RemoverFolha(int id)
        {

            Entityes.tb_folha_pagamento remover = db.tb_folha_pagamento.First(r => r.id_folha_pagamento == id);
            db.tb_folha_pagamento.Remove(remover);

            db.SaveChanges();
        }
    }
}
