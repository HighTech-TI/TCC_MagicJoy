using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicJoy.DataBase.Suprimentos
{
    
    class VendaDataBase      
    {
        Entityes.magicjoydbEntities13 db = new Entityes.magicjoydbEntities13();

        public void Inserir(Entityes.tb_venda venda)
        {

            db.tb_venda.Add(venda);

            db.SaveChanges();
        }
        public List<Entityes.tb_venda> ListarTodu()
        {
            List<Entityes.tb_venda> tabela = db.tb_venda.ToList();
            return tabela;

        }
        public List<Entityes.tb_venda> PesquisarPorDataVenda(DateTime data)
        {
            List<Entityes.tb_venda> venda = db.tb_venda.Where
                                                      (s => s.dt_venda == data).ToList();
            return venda;

        }
        public List<Entityes.tb_venda> PesquisarPorIdVenda(int id)
        {
            List<Entityes.tb_venda> venda = db.tb_venda.Where
                                                      (s => s.id_venda_d == id).ToList();
            return venda;
        }
        public List<Entityes.tb_venda> PesquisarPorProduto(string nome)
        {
            List<Entityes.tb_venda> venda = db.tb_venda.Where
                                                      (s => s.nm_produto.Contains(nome)).ToList();
            return venda;
        }
        public void Alterar(Entityes.tb_venda venda)
        {

            Entityes.tb_venda altera = db.tb_venda.First(a => a.id_venda_d == venda.id_venda_d);
            altera.nm_produto = venda.nm_produto;
            altera.qts_produtos = venda.qts_produtos;
            altera.vl_total = venda.vl_total;
            altera.dt_venda = venda.dt_venda;
            
            db.SaveChanges();
        }
        public void Remover(Entityes.tb_venda venda)
        {

            Entityes.tb_venda remover = db.tb_venda.First(r => r.id_venda_d == venda.id_venda_d);
            db.tb_venda.Remove(remover);

            db.SaveChanges();
        }


    }
}
