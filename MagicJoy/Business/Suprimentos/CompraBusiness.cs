using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicJoy.Business.Suprimentos
{
    class CompraBusiness
    {
        public void Inserir(Entityes.tb_compra compra)
        {

            DataBase.Suprimentos.CompraDataBase db = new DataBase.Suprimentos.CompraDataBase();
            db.InserirCompras(compra);

        }
        public void Salvar(Entityes.tb_compra compra)
        {
            if (compra.id_compras == 0)
            {
                this.Inserir(compra);
            }
            else
            {
                this.Alterar(compra);
            }
        }
        public List<Entityes.tb_compra> ListarTodos()
        {
            DataBase.Suprimentos.CompraDataBase db = new DataBase.Suprimentos.CompraDataBase();
            List<Entityes.tb_compra> pesquisa = db.ListarTodasCompras();

            return pesquisa;
        }

        public List<Entityes.tb_compra> PesquisarPorData(DateTime data)
        {
            DataBase.Suprimentos.CompraDataBase db = new DataBase.Suprimentos.CompraDataBase();
            List<Entityes.tb_compra> pesquisa = db.PesquisarPorDataCompra(data);

            return pesquisa;
        }
        public List<Entityes.tb_compra> PesquisarPorProduto(string nome)
        {
            DataBase.Suprimentos.CompraDataBase db = new DataBase.Suprimentos.CompraDataBase();
            List<Entityes.tb_compra> pesquisa = db.PesquisarPorProduto(nome);

            return pesquisa;
        }

        public List<Entityes.tb_compra> PesquisarPorID(int id)
        {
            DataBase.Suprimentos.CompraDataBase db = new DataBase.Suprimentos.CompraDataBase();
            List<Entityes.tb_compra> pesquisa = db.PesquisarPorIdCompras(id);

            return pesquisa;
        }
        public void Alterar(Entityes.tb_compra compra)
        {
            DataBase.Suprimentos.CompraDataBase db = new DataBase.Suprimentos.CompraDataBase();
            db.AlterarCompra(compra);          

        }
       
        public void Remover(Entityes.tb_compra compra)
        {
            DataBase.Suprimentos.CompraDataBase db = new DataBase.Suprimentos.CompraDataBase();
            db.RemoverCompra(compra);
        }
       
    }
}
