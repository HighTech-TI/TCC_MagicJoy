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

        Business.Financeiro.ClienteBusiness business = new Business.Financeiro.ClienteBusiness();
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Entityes.tb_cliente cliente = new Entityes.tb_cliente();

                cliente.nm_nome = txtnome.Text;
                cliente.dt_nascimento = dtpnascimento.Value;
                cliente.ds_telefone = mkttele.Text;
                cliente.ds_celular = mktcell.Text;
                cliente.ds_cpf = mktcpf.Text;
                cliente.ds_rg = mktrg.Text;
                cliente.ds_endereço = txtendereco.Text;
                cliente.id_compras = Convert.ToInt32(txtidcompra.Text);
                

                business.Salvar(cliente);

                MessageBox.Show("Salvo com sucesso!",
                                "Magic Joy", MessageBoxButtons.OK, MessageBoxIcon.Information);


                ListarTudo();
                Limpar();
            }


           catch (Exception)
            {

              MessageBox.Show("Ocorreu um erro tente novamente mais tarde, ou contate seu administrador do sistema",
                                "Magic Joy", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ListarTudo()
        {

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = business.ListarTudo();
        }

        private void Limpar()
        {
            txtnome.Text = string.Empty;
            txtidcompra.Text = string.Empty;
            txtidCliente.Text = string.Empty;
            txtendereco.Text = string.Empty;            
            mktcell.Text = string.Empty;
            mktcpf.Text = string.Empty;
            mktrg.Text = string.Empty;
            mkttele.Text = string.Empty;
            
        }

        private void Alterar(Entityes.tb_cliente cliente)
        {
            txtidCliente.Text = cliente.id_cliente.ToString();
            txtnome.Text = cliente.nm_nome;
            txtidcompra.Text = cliente.id_compras.ToString();
            txtendereco.Text = cliente.ds_endereço;
            mktcell.Text = cliente.ds_celular;
            mktcpf.Text = cliente.ds_cpf;
            mktrg.Text = cliente.ds_rg;
            mkttele.Text = cliente.ds_telefone;
            dtpnascimento.Value = cliente.dt_nascimento;
        }
        private void Remover(Entityes.tb_cliente cliente)
        {
            DialogResult pergunta = MessageBox.Show("Você realmente deseja excluir está linha selecionada?",
                                                    "Magic Joy", MessageBoxButtons.YesNo,
                                                                 MessageBoxIcon.Question);
            if (pergunta == DialogResult.Yes)
            {
                business.Remover(cliente);
                ListarTudo();
                Limpar();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var produto = dataGridView1.CurrentRow.DataBoundItem as Entityes.tb_cliente;

            if (e.ColumnIndex == 9)
            {
                Alterar(produto);
            }

            if (e.ColumnIndex == 10)
            {
                Remover(produto);
            }
        }

        private void frmCadastroDeCliente_Load(object sender, EventArgs e)
        {
            ListarTudo();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox4.Text);

            List<Entityes.tb_cliente> lista = business.PesquisarPorID(id);
            dataGridView1.DataSource = lista;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string nome = txttnme.Text;

            List<Entityes.tb_cliente> lista = business.PesquisarPorNome(nome);
            dataGridView1.DataSource = lista;
        }

        private void txtcpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string cpf = txtcpf.Text;

            List<Entityes.tb_cliente> lista = business.PesquisarPorCpf(cpf);
            dataGridView1.DataSource = lista;
        }
    }

}

