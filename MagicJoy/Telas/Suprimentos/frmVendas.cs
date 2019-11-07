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
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        Business.Suprimentos.VendaBusiness business = new Business.Suprimentos.VendaBusiness();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Entityes.tb_venda venda = new Entityes.tb_venda();

                venda.nm_produto = txtproduto.Text;
                venda.qts_produtos = Convert.ToInt32(txtqtd.Text);
                venda.dt_venda = dtpdatavenda.Value;
                venda.vl_total = Convert.ToDecimal(txtvalor.Text);

                business.Salvar(venda);

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
            nudidvendaaa.Value = 0;
            txtproduto.Text = string.Empty;
            txtvalor.Text = string.Empty;
            txtqtd.Text = string.Empty;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var venda = dataGridView1.CurrentRow.DataBoundItem as Entityes.tb_venda;

            if (e.ColumnIndex == 5)
            {
                Alterar(venda);
            }

            if (e.ColumnIndex == 6)
            {
                Remover(venda);
            }
        }
        private void Alterar(Entityes.tb_venda venda)
        {
            nudidvendaaa.Value = venda.id_venda_d;
            txtproduto.Text = venda.nm_produto;
            txtqtd.Text = venda.qts_produtos.ToString();
            txtvalor.Text = venda.vl_total.ToString();
            dtpdatavenda.Value = venda.dt_venda;


        }
        private void Remover(Entityes.tb_venda venda)
        {
            DialogResult pergunta = MessageBox.Show("Você realmente deseja excluir está linha selecionada?",
                                                    "Magic Joy", MessageBoxButtons.YesNo,
                                                                 MessageBoxIcon.Question);
            if (pergunta == DialogResult.Yes)
            {
                business.Remover(venda);
                ListarTudo();
                Limpar();
            }
        }

        private void test_Load(object sender, EventArgs e)
        {
            ListarTudo();
        }

        private void nudpesquidass_ValueChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(nudpesquidass.Value);

            business.PesquisarPorID(id);
        }

        private void txtpesquida_TextChanged(object sender, EventArgs e)
        {
            string produto = txtpesquida.Text;

            business.PesquisarPorProduto(produto);
        }

        private void dtppesquias_ValueChanged(object sender, EventArgs e)
        {
            DateTime data = dtppesquias.Value;

            business.PesquisarPorData(data);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Telas.Menu.btnforne tela = new Menu.btnforne();
            tela.Show();
            this.Hide();
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

