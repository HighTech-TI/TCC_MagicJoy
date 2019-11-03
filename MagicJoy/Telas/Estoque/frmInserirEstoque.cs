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
    public partial class frmInserirEstoque : Form
    {
        Business.Estoque.EstoqueBusiness business = new Business.Estoque.EstoqueBusiness();
        public frmInserirEstoque()
        {
            InitializeComponent();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                Entityes.tb_estoque estoque = new Entityes.tb_estoque();


                estoque.nm_produto = txtproduto.Text;
                estoque.ds_qtd = Convert.ToInt32(txtqtds.Text);
                estoque.vl_custo = Convert.ToDecimal(txtvlcusto.Text);
                estoque.id_fornecedor = Convert.ToInt32(nudidforncedor.Value);


                business.Salvar(estoque);

                MessageBox.Show("Salvo com sucesso!",
                                "Magic Joy", MessageBoxButtons.OK, MessageBoxIcon.Information);


                ListarTudo();
            }


            catch (Exception)
            {

                MessageBox.Show("Ocorreu um erro tente novamente mais tarde, ou contate seu administrador",
                                "Magic Joy", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                    
        }
        private void frmInserirEstoque_Load(object sender, EventArgs e)
        {
            ListarTudo();
        }
        private void ListarTudo()
        {
            
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = business.ListarTodosProdutos();
        }

        private void Limpar()
        {
            txtproduto.Text = string.Empty;
            txtqtds.Text = string.Empty;
            txtvlcusto.Text = string.Empty;
            nudidforncedor.Value = 0;
        }

        private void Alterar(Entityes.tb_estoque estoque)
        {
                       
            txtproduto.Text = estoque.nm_produto;            
            txtqtds.Text = estoque.ds_qtd.ToString();                   
            txtvlcusto.Text = estoque.vl_custo.ToString();
            nudidforncedor.Value = estoque.id_fornecedor;
            
        
        }
        private void Remover(Entityes.tb_estoque estoque)
        {
            DialogResult pergunta = MessageBox.Show("Você realmente deseja excluir está linha selecionada?", 
                                                    "Magic Joy", MessageBoxButtons.YesNo,
                                                                 MessageBoxIcon.Question);
            if(pergunta == DialogResult.Yes)
            {
                business.Remover(estoque);
                ListarTudo();
                Limpar();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string produto = txtpesquisaproduto.Text;

            
            List<Entityes.tb_estoque> ConsultarPorNome = business.PesquisarPorPodruto(produto);

            dataGridView1.DataSource = ConsultarPorNome;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtidestoquepesquisa.Text);

            
            List<Entityes.tb_estoque> PesquisarId = business.PesquisarPorID(id);

            dataGridView1.DataSource = PesquisarId;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int qtd = Convert.ToInt32(txtqtdpesquisa.Text); 

            
            List<Entityes.tb_estoque> PesquisarId = business.PesquisarPorqtd(qtd);

            dataGridView1.DataSource = PesquisarId;
        }

    }
}
