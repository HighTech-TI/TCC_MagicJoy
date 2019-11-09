using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicJoy.Telas.Suprimentos
{
    public partial class frmFornecedor : Form
    {
        public frmFornecedor()
        {
            InitializeComponent();
        }

        Business.Suprimentos.FornecedorBusiness business = new Business.Suprimentos.FornecedorBusiness();

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Entityes.tb_fornecedor fornece = new Entityes.tb_fornecedor();

                fornece.nm_fornecedor = txtnome.Text;
                fornece.nm_produto = txtproduto.Text;
                fornece.ds_cnpj = mktcnpj.Text;
                fornece.ds_cpf = mktcpf.Text;
                fornece.ds_email = txtemail.Text;
                fornece.ds_endereço = txtendereco.Text;
                fornece.ds_telefone = mkttele.Text;
                fornece.ds_celular = mkttcell.Text;

                business.Salvar(fornece);

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
            dataGridView1.DataSource = business.ListarTodos();
        }
        private void Limpar()
        {
            nudidfornecedor.Value = 0;
            txtnome.Text = string.Empty;
            txtproduto.Text = string.Empty;
            mktcnpj.Text = string.Empty;
            mktcpf.Text = string.Empty;
            mkttcell.Text = string.Empty;
            mkttele.Text = string.Empty;
            txtemail.Text = string.Empty;
            txtendereco.Text = string.Empty;
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var fornece = dataGridView1.CurrentRow.DataBoundItem as Entityes.tb_fornecedor;

            if (e.ColumnIndex == 9)
            {
                Alterar(fornece);
            }

            if (e.ColumnIndex == 10)
            {
                Remover(fornece);
            }
        }

        private void Alterar(Entityes.tb_fornecedor fornece)
        {
            nudidfornecedor.Value = fornece.id_fornecedor;
            txtnome.Text = fornece.nm_fornecedor;
            txtproduto.Text = fornece.nm_produto;
            mktcnpj.Text = fornece.ds_cnpj;
            mktcpf.Text = fornece.ds_cpf;
            mkttcell.Text = fornece.ds_celular;
            mkttele.Text = fornece.ds_telefone;
            txtemail.Text = fornece.ds_email;
            txtendereco.Text = fornece.ds_endereço;

            

        }

        private void Remover(Entityes.tb_fornecedor fornecedor)
        {
            DialogResult pergunta = MessageBox.Show("Você realmente deseja excluir está linha selecionada?",
                                                    "Magic Joy", MessageBoxButtons.YesNo,
                                                                 MessageBoxIcon.Question);
            if (pergunta == DialogResult.Yes)
            {
                business.Remover(fornecedor);
                ListarTudo();
                Limpar();
            }
        }

        private void nudpesquisa_ValueChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(nudpesquisa.Value);

            List<Entityes.tb_fornecedor> com = business.PesquisarPorID(id);

            dataGridView1.DataSource = com;
        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = txtpesquisa.Text;

           List<Entityes.tb_fornecedor> com = business.PesquisarPorNome(nome);

            dataGridView1.DataSource = com;
        }

        private void txtpesquisanome_TextChanged(object sender, EventArgs e)
        {
            string produto = txtpesquisanome.Text;
            
           List<Entityes.tb_fornecedor> com = business.PesquisarPorNomedeProduto(produto);

            dataGridView1.DataSource = com;
        }

        private void frmFornecedor_Load(object sender, EventArgs e)
        {
            ListarTudo();
        }

        private void mktcnpj_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtproduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudidfornecedor_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Telas.Menu.btnforne tela = new Menu.btnforne();
            tela.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
