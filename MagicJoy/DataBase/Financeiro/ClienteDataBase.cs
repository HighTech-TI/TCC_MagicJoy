﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicJoy.DataBase.Financeiro
{
    class ClienteDataBase
    {
        Entityes.magicjoydbEntities11 db = new Entityes.magicjoydbEntities11();
        public void InserirClientes(Entityes.tb_cliente cliente)
        {

            db.tb_cliente.Add(cliente);

            db.SaveChanges();
        }
        public List<Entityes.tb_cliente> ListarTodosControlePontos()
        {
            List<Entityes.tb_cliente> tabela = db.tb_cliente.ToList();
            return tabela;

        }
        public List<Entityes.tb_cliente> PesquisarPorNome(string nome)
        {
            List<Entityes.tb_cliente> cliente = db.tb_cliente.Where
                                                      (s => s.nm_nome == nome).ToList();
            return cliente;

        }
        public List<Entityes.tb_cliente> PesquisarPorIdCliente(int id)
        {
            List<Entityes.tb_cliente> cliente = db.tb_cliente.Where
                                                      (s => s.id_cliente == id).ToList();
            return cliente;
        }
        public void AlterarCliente(Entityes.tb_cliente cliente)
        {

            Entityes.tb_cliente altera = db.tb_cliente.First(a => a.id_cliente == cliente.id_cliente);
            altera.ds_telefone = cliente.ds_telefone;
            altera.ds_endereço = cliente.ds_endereço;
            altera.nm_nome = cliente.nm_nome;
            altera.dt_nascimento = cliente.dt_nascimento;
            altera.ds_CPF = cliente.ds_CPF;
            altera.tb_compra_id_compras = cliente.tb_compra_id_compras;            

            db.SaveChanges();
        }
        public void AlterarClientePorNome(Entityes.tb_cliente cliente)
        {

            Entityes.tb_cliente altera = db.tb_cliente.First(a => a.nm_nome == cliente.nm_nome);
            altera.ds_telefone = cliente.ds_telefone;
            altera.ds_endereço = cliente.ds_endereço;
            altera.nm_nome = cliente.nm_nome;
            altera.dt_nascimento = cliente.dt_nascimento;
            altera.ds_CPF = cliente.ds_CPF;
            altera.tb_compra_id_compras = cliente.tb_compra_id_compras;
        }
        public void RemoverCliente(int id)
        {

            Entityes.tb_cliente remover = db.tb_cliente.First(r => r.id_cliente == id);
            db.tb_cliente.Remove(remover);

            db.SaveChanges();
        }
        public void RemoverClientePorNome(string nome)
        {

            Entityes.tb_cliente remover = db.tb_cliente.First(r => r.nm_nome == nome);
            db.tb_cliente.Remove(remover);

            db.SaveChanges();
        }
    }
}