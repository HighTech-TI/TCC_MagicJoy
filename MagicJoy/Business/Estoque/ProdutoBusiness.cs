using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicJoy.Business.Estoque
{
    class ProdutoBusiness
    {
        public void InserirProduto(Entityes.tb_produto produto)
        {
            if (produto.nm_produto == string.Empty)
            {
                throw new ArgumentException("Nome do produto é obrigatório");
            }
            if(produto.vl_preco == 0)
            {
                throw new ArgumentException("Preço do produto é obrigatótio");
            }

            if(produto.id_estoque == 0)
            {
                throw new ArgumentException("Id do estoque é obrigatório");
            }                    
        }

        public List<Entityes.tb_controle_ponto> ListarTodosUsuarios()
        {
            DataBase.RH.ControleDePontoDataBase ddb = new DataBase.RH.ControleDePontoDataBase();
            List<Entityes.tb_controle_ponto> pesquisa = ddb.ListarTodosControlePontos();

            return pesquisa;
        }

        public List<Entityes.tb_controle_ponto> PesquisarPorData(DateTime data)
        {
            DataBase.RH.ControleDePontoDataBase ddb = new DataBase.RH.ControleDePontoDataBase();
            List<Entityes.tb_controle_ponto> pesquisa = ddb.PesquisarPorData(data);

            return pesquisa;
        }
        public List<Entityes.tb_controle_ponto> PesquisarPorID(int id)
        {
            DataBase.RH.ControleDePontoDataBase ddb = new DataBase.RH.ControleDePontoDataBase();
            List<Entityes.tb_controle_ponto> pesquisa = ddb.PesquisarPorIdControleDePonto(id);

            return pesquisa;
        }
        public void Alterar(Entityes.tb_controle_ponto ponto)
        {
            DataBase.RH.ControleDePontoDataBase db = new DataBase.RH.ControleDePontoDataBase();
            db.AlterarControleDePonto(ponto);

        }
        public void AlterarPorData(Entityes.tb_controle_ponto ponto)
        {
            DataBase.RH.ControleDePontoDataBase db = new DataBase.RH.ControleDePontoDataBase();
            db.AlterarPontoPorData(ponto);

        }
        public void Remover(int id)
        {
            DataBase.RH.ControleDePontoDataBase db = new DataBase.RH.ControleDePontoDataBase();
            db.RemoverControleDePOnto(id);
        }
        public void RemoverPorData(DateTime data)
        {
            DataBase.RH.ControleDePontoDataBase db = new DataBase.RH.ControleDePontoDataBase();
            db.RemoverPontoPorData(data);
        }
    }
}
