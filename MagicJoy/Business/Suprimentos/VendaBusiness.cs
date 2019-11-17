using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicJoy.Business.Suprimentos
{
    class VendaBusiness
    {
        public void Inserir(Entityes.tb_venda venda)
        {

            DataBase.Suprimentos.VendaDataBase db = new DataBase.Suprimentos.VendaDataBase();
            db.Inserir(venda);

        }
        public void Salvar(Entityes.tb_venda venda)
        {
            if (venda.id_venda_d == 0)
            {
                this.Inserir(venda);
            }
            else
            {
                this.Alterar(venda);
            }
        }
        public List<Entityes.tb_venda> ListarTodos()
        {
            DataBase.Suprimentos.VendaDataBase db = new DataBase.Suprimentos.VendaDataBase();
            List<Entityes.tb_venda> pesquisa = db.ListarTodu();

            return pesquisa;
        }

        public List<Entityes.tb_venda> PesquisarPorData(DateTime data)
        {
            DataBase.Suprimentos.VendaDataBase db = new DataBase.Suprimentos.VendaDataBase();
            List < Entityes.tb_venda> pesquisa = db.PesquisarPorDataVenda(data);

            return pesquisa;
        }
        public List<Entityes.tb_venda> PesquisarPorProduto(string nome)
        {
            DataBase.Suprimentos.VendaDataBase db = new DataBase.Suprimentos.VendaDataBase();
            List<Entityes.tb_venda> pesquisa = db.PesquisarPorProduto(nome);

            return pesquisa;
        }

        public List<Entityes.tb_venda> PesquisarPorID(int id)
        {
            DataBase.Suprimentos.VendaDataBase db = new DataBase.Suprimentos.VendaDataBase();
            List<Entityes.tb_venda> pesquisa = db.PesquisarPorIdVenda(id);

            return pesquisa;
        }
        public void Alterar(Entityes.tb_venda venda)
        {
            DataBase.Suprimentos.VendaDataBase db = new DataBase.Suprimentos.VendaDataBase();
            db.Alterar(venda);

        }

        public void Remover(Entityes.tb_venda venda)
        {
            DataBase.Suprimentos.VendaDataBase db = new DataBase.Suprimentos.VendaDataBase();
            db.Remover(venda);
        }

    }
}
