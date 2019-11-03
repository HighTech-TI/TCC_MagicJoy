using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicJoy.DataBase.Suprimentos
{
    class CompraDataBase
    {
        Entityes.magicjoydbEntities11 db = new Entityes.magicjoydbEntities11();
        public void InserirCompras(Entityes.tb_compra compra)
        {

            db.tb_compra.Add(compra);

            db.SaveChanges();
        }
        public List<Entityes.tb_compra> ListarTodasCompras()
        {
            List<Entityes.tb_compra> tabela = db.tb_compra.ToList();
            return tabela;

        }
        public List<Entityes.tb_compra> PesquisarPorDataCompra(DateTime data)
        {
            List<Entityes.tb_compra> compras = db.tb_compra.Where
                                                      (s => s.dt_compra == data).ToList();
            return compras;

        }
        public List<Entityes.tb_compra> PesquisarPorIdCompras(int id)
        {
            List<Entityes.tb_compra> compra = db.tb_compra.Where
                                                      (s => s.id_compras == id).ToList();
            return compra;
        }
        public List<Entityes.tb_compra> PesquisarPorProduto(string nome)
        {
            List<Entityes.tb_compra> compra = db.tb_compra.Where
                                                      (s => s.nm_produto.Contains(nome)).ToList();
            return compra;
        }
        public void AlterarCompra(Entityes.tb_compra compra)
        {

            Entityes.tb_compra altera = db.tb_compra.First(a => a.id_compras == compra.id_compras);
            altera.nm_produto = compra.nm_produto;
            altera.qts_produtos = compra.qts_produtos;
            altera.dt_compra = compra.dt_compra;
            altera.vl_total = compra.vl_total;

            db.SaveChanges();
        }     
        public void RemoverCompra(Entityes.tb_compra compra)
        {

            Entityes.tb_compra remover = db.tb_compra.First(r => r.id_compras == compra.id_compras);
            db.tb_compra.Remove(remover);

            db.SaveChanges();
        }
       
    }
}
