using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicJoy.DataBase.Suprimentos
{
    class FornecedorDataBase
    {
        Entityes.magicjoydbEntities20 db = new Entityes.magicjoydbEntities20();
       
        public void InserirForncedor(Entityes.tb_fornecedor fornecedor)
        {

            db.tb_fornecedor.Add(fornecedor);

            db.SaveChanges();
        }
        public List<Entityes.tb_folha_pagamento> ListarTodasFolha()
        {
            List<Entityes.tb_folha_pagamento> tabela = db.tb_folha_pagamento.ToList();
            return tabela;

        }
        public List<Entityes.tb_fornecedor> PesquisarPorNomeFornecedor(string nome)
        {
            List<Entityes.tb_fornecedor> fornecedor = db.tb_fornecedor.Where
                                                      (s => s.nm_fornecedor == nome).ToList();
            return fornecedor;

        }
        public List<Entityes.tb_fornecedor> PesquisarPorIdForncedor(int id)
        {
            List<Entityes.tb_fornecedor> fornecedor = db.tb_fornecedor.Where
                                                      (s => s.id_fornecedor == id).ToList();
            return fornecedor;
        }
        public void AlterarFornecedor(Entityes.tb_fornecedor fornecedor)
        {

            Entityes.tb_fornecedor fornece = db.tb_fornecedor.First(a => a.id_fornecedor == fornecedor.id_fornecedor);
            fornece.ds_endereço = fornecedor.ds_endereço;
            fornece.ds_telefone = fornecedor.ds_telefone;
            fornece.ds_email = fornecedor.ds_email;
            fornece.nm_produto = fornecedor.nm_produto;
            
            fornece.nm_produto = fornecedor.nm_produto;            

            db.SaveChanges();
        }
        public void RemoverFornecedor(int id)
        {

            Entityes.tb_fornecedor remover = db.tb_fornecedor.First(r => r.id_fornecedor == id);
            db.tb_fornecedor.Remove(remover);

            db.SaveChanges();
        }
    }
}
