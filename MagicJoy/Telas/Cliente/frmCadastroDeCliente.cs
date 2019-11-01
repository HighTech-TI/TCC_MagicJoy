using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicJoy.Telas.Cliente
{
    public partial class frmCadastroDeCliente : Form
    {
        public frmCadastroDeCliente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Entityes.tb_cliente tabela = new Entityes.tb_cliente();

            txtnome.Text = tabela.nm_nome;
            txtendereco.Text = tabela.ds_endereço;
            dtpnascimento.MinDate = tabela.dt_nascimento;
            mkttele.Text = tabela.ds_telefone;
            mktcell.Text = tabela.ds_celular;
            DataBase.Financeiro.ClienteDataBase.Cpf(txtcpf.Text);
            string cpf = DataBase.Financeiro.ClienteDataBase.maskCpf(txtcpf.Text);
            cpf = tabela.ds_cpf;

            Business.Financeiro.ClienteBusiness business = new Business.Financeiro.ClienteBusiness();
            business.InserirCliente(tabela);

            MessageBox.Show("Cliente inserido com sucesso");

            
        }

        private void txtcpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
