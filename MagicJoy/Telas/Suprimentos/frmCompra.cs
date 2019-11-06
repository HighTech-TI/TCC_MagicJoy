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
    public partial class frmCompra : Form
    {
        public frmCompra()
        {
            InitializeComponent();
        }

        Business.Suprimentos.CompraBusiness business = new Business.Suprimentos.CompraBusiness();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Entityes.tb_compra compra = new Entityes.tb_compra();

                compra.nm_produto = txtproduto.Text;
                compra.qts_produtos = Convert.ToInt32(nudqtd.Value);
                compra.dt_compra = dtpDia.Value;
                compra.vl_total = Convert.ToDecimal(txtValor.Text);

                business.Salvar(compra);

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
            nudidcompra.Value = 0;
            txtproduto.Text = string.Empty;
            nudqtd.Value = 0;
            txtValor.Text = string.Empty;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var compra = dataGridView1.CurrentRow.DataBoundItem as Entityes.tb_compra;

            if (e.ColumnIndex == 5)
            {
                Alterar(compra);
            }

            if (e.ColumnIndex == 6)
            {
                Remover(compra);
            }
        }
        private void Alterar(Entityes.tb_compra compra)
        {
            txtproduto.Text = compra.nm_produto;
            nudqtd.Value = 0;
            txtValor.Text = compra.vl_total.ToString();
            dtpDia.Value = compra.dt_compra;
            nudqtd.Value = compra.qts_produtos;

        }
        private void Remover(Entityes.tb_compra compra)
        {
            DialogResult pergunta = MessageBox.Show("Você realmente deseja excluir está linha selecionada?",
                                                    "Magic Joy", MessageBoxButtons.YesNo,
                                                                 MessageBoxIcon.Question);
            if (pergunta == DialogResult.Yes)
            {
                business.Remover(compra);
                ListarTudo();
                Limpar();
            }
        }

        private void nudpesquisa_ValueChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(nudpesquisa.Value);

            business.PesquisarPorID(id);
        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = txtpesquisa.Text;

            business.PesquisarPorProduto(nome);
        }

        private void dtppesquisa_ValueChanged(object sender, EventArgs e)
        {
            DateTime data = dtppesquisa.Value;

            business.PesquisarPorData(data);
        }

        private void frmCompra_Load(object sender, EventArgs e)
        {
            ListarTudo();
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
    }
}
