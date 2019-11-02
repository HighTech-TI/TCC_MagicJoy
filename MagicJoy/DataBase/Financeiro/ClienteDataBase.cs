using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicJoy.DataBase.Financeiro
{
    class ClienteDataBase
    {
        Entityes.magicjoydbEntities3 db = new Entityes.magicjoydbEntities3();
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
            altera.ds_cpf = cliente.ds_cpf;
                     

            db.SaveChanges();
        }
        public void AlterarClientePorNome(Entityes.tb_cliente cliente)
        {

            Entityes.tb_cliente altera = db.tb_cliente.First(a => a.nm_nome == cliente.nm_nome);
            altera.ds_telefone = cliente.ds_telefone;
            altera.ds_endereço = cliente.ds_endereço;
            altera.nm_nome = cliente.nm_nome;
            altera.dt_nascimento = cliente.dt_nascimento;
            altera.ds_cpf = cliente.ds_cpf;
          
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

        public static bool Cpf(string CPF)
        {
            int[] mt1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] mt2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string TempCPF;
            string Digito;
            int soma;
            int resto;

            CPF = CPF.Trim();
            CPF = CPF.Replace(".", "").Replace("-", "");

            if (CPF.Length != 11)
                return false;

            TempCPF = CPF.Substring(0, 9);
            soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(TempCPF[i].ToString()) * mt1[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            Digito = resto.ToString();
            TempCPF = TempCPF + Digito;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(TempCPF[i].ToString()) * mt2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            Digito = Digito + resto.ToString();

            return CPF.EndsWith(Digito);
        }

        public static string maskCpf(string cpf)
        {
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            return Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
        }
    }
}
