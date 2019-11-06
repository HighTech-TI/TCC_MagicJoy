using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicJoy.Telas.Estoque
{
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }
       
        Business.Estoque.ProdutoBusiness business = new Business.Estoque.ProdutoBusiness();
        private void btnsalvar_Click(object sender, EventArgs e)
        {            
            try
            {
                Entityes.tb_produto produto = new Entityes.tb_produto();

                produto.nm_produto = txtproduto.Text;
                produto.vl_preco = Convert.ToDecimal(txtpreco.Text);
                produto.id_estoque = Convert.ToInt32(txtidestoque.Text);
                
                business.Salvar(produto);

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
            dataGridView1.DataSource = business.ListarTodosProdutos();
        }
        private void frmProduto_Load(object sender, EventArgs e)
        {
            ListarTudo();
        }

        private void Limpar()
        {
            txtidproduto.Text = string.Empty;           
            txtproduto.Text = string.Empty;
            txtpreco.Text = string.Empty;
            txtidestoque.Text = string.Empty;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var produto = dataGridView1.CurrentRow.DataBoundItem as Entityes.tb_produto;

            if (e.ColumnIndex == 6)
            {
                Alterar(produto);
            }

            if (e.ColumnIndex == 7)
            {
                Remover(produto);
            }


        }
        private void Alterar(Entityes.tb_produto produto)
        {
            txtidproduto.Text = produto.id_produto.ToString();
            txtproduto.Text = produto.nm_produto;
            txtidestoque.Text = produto.id_estoque.ToString();
            txtpreco.Text = produto.vl_preco.ToString();           

        }
        private void Remover(Entityes.tb_produto produto)
        {
            DialogResult pergunta = MessageBox.Show("Você realmente deseja excluir está linha selecionada?",
                                                    "Magic Joy", MessageBoxButtons.YesNo,
                                                                 MessageBoxIcon.Question);
            if (pergunta == DialogResult.Yes)
            {
                business.Remover(produto);
                ListarTudo();
                Limpar();
            }
        }

      

        private void txtprodutopesquisa_TextChanged(object sender, EventArgs e)
        {
            string produto = txtprodutopesquisa.Text;

            List<Entityes.tb_produto> lista = business.PesquisarPorPodruto(produto);
        }

        private void txtidpesquisa_TextChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtidpesquisa.Text);

            List<Entityes.tb_produto> lista = business.PesquisarPorID(id);
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var produto = dataGridView1.CurrentRow.DataBoundItem as Entityes.tb_produto;

            if (e.ColumnIndex == 4)
            {
                Alterar(produto);
            }

            if (e.ColumnIndex == 5)
            {
                Remover(produto);
            }
        }

        private void txtidestoque_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Telas.Menu.btnforne tela = new Menu.btnforne();
            tela.Show();
            this.Hide();
        }
    }
}
