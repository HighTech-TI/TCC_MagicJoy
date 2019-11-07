using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicJoy.DataBase.Financeiro
{
    class ClienteDataBase
    {
        Entityes.magicjoydbEntities16 db = new Entityes.magicjoydbEntities16();
        public void InserirClientes(Entityes.tb_cliente cliente)
        {

            db.tb_cliente.Add(cliente);

            db.SaveChanges();
        }
        public List<Entityes.tb_cliente> ListarTodosClientes()
        {
            List<Entityes.tb_cliente> tabela = db.tb_cliente.ToList();
            return tabela;

        }
        public List<Entityes.tb_cliente> PesquisarPorNome(string nome)
        {
            List<Entityes.tb_cliente> cliente = db.tb_cliente.Where
                                                      (s => s.nm_nome.Contains(nome)).ToList();
            return cliente;

        }
        public List<Entityes.tb_cliente> PesquisarPorIdCliente(int id)
        {
            List<Entityes.tb_cliente> cliente = db.tb_cliente.Where
                                                      (s => s.id_cliente == id).ToList();
            return cliente;
        }
        public List<Entityes.tb_cliente> PesquisarPorCpf(string cpf)
        {
            List<Entityes.tb_cliente> cliente = db.tb_cliente.Where
                                                      (s => s.ds_cpf == cpf).ToList();
            return cliente;
        }
        public void AlterarCliente(Entityes.tb_cliente cliente)
        {

            Entityes.tb_cliente altera = db.tb_cliente.First(a => a.id_cliente == cliente.id_cliente);
            altera.ds_telefone = cliente.ds_telefone;
            altera.ds_endereço = cliente.ds_endereço;
            altera.nm_nome = cliente.nm_nome;
            altera.dt_nascimento = cliente.dt_nascimento;
            altera.ds_cpf = cliente.ds_cpf;
                     

            db.SaveChanges();
        }
        public void RemoverCliente(Entityes.tb_cliente cliente)
        {

            Entityes.tb_cliente remover = db.tb_cliente.First(r => r.id_cliente == cliente.id_cliente);
            db.tb_cliente.Remove(remover);

            db.SaveChanges();
        }         
    }
}
