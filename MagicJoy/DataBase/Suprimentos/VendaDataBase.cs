using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicJoy.DataBase.Suprimentos
{
    class VendaDataBase
    {
        public void InserirVenda(Entityes.tb_venda venda)
        {

            db.tb_venda.Add(venda);

            db.SaveChanges();
        }
        public List<Entityes.tb_venda> ListarTodasVendas()
        {
            List<Entityes.tb_venda> tabela = db.tb_venda.ToList();
            return tabela;

        }
        public List<Entityes.tb_venda> PesquisarPorDataVenda(DateTime data)
        {
            List<Entityes.tb_venda> venda = db.tb_venda.Where
                                                      (s => s.dt_compra == data).ToList();
            return venda;

        }
        public List<Entityes.tb_venda> PesquisarPorIdVenda(int id)
        {
            List<Entityes.tb_venda> venda = db.tb_venda.Where
                                                      (s => s.id_venda == id).ToList();
            return venda;
        }
        public void AlterarVenda(Entityes.tb_venda venda)
        {

            Entityes.tb_venda altera = db.tb_venda.First(a => a.id_venda == venda.id_venda);
            altera.nm_produto = venda.nm_produto;
            altera.qts_produtos = venda.qts_produtos;
            altera.dt_compra = venda.dt_compra;
            altera.vl_total = venda.vl_total;

            db.SaveChanges();
        }
        public void AlterarVendaPorData(Entityes.tb_venda data)
        {

            Entityes.tb_venda altera = db.tb_venda.First(a => a.dt_compra == data.dt_compra);
            altera.nm_produto = data.nm_produto;
            altera.qts_produtos = data.qts_produtos;
            altera.dt_compra = data.dt_compra;
            altera.vl_total = data.vl_total;

            db.SaveChanges();
        }
        public void RemoverVenda(int id)
        {

            Entityes.tb_venda remover = db.tb_venda.First(r => r.id_venda == id);
            db.tb_venda.Remove(remover);

            db.SaveChanges();
        }
        public void RemoverVendaData(DateTime data)
        {

            Entityes.tb_venda remover = db.tb_venda.First(r => r.dt_compra == data);
            db.tb_venda.Remove(remover);

            db.SaveChanges();
        }
    }
}
