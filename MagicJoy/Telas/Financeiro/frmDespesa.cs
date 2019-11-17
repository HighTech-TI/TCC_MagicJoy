using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicJoy.Telas.Financeiro
{
    public partial class frmDespesa : Form
    {
        public frmDespesa()
        {
            InitializeComponent();
        }

        Business.Financeiro.DespesaBusiness business = new Business.Financeiro.DespesaBusiness();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Entityes.tb_despesa despesa = new Entityes.tb_despesa();

                despesa.ds_descricao = txtdespesa.Text;
                despesa.vl_valor = Convert.ToDecimal(txtvalor.Text);
                despesa.dt_datadevencimento = dtpvencimento.Value;
                despesa.dt_pagamento = dtppagamento.Value;
                business.Salvar(despesa);

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
            txtid.Text = string.Empty;
            txtdespesa.Text = string.Empty;
            txtvalor.Text = string.Empty;           

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var produto = dataGridView1.CurrentRow.DataBoundItem as Entityes.tb_despesa;

            if (e.ColumnIndex == 5)
            {
                Alterar(produto);
            }

            if (e.ColumnIndex == 6)
            {
                Remover(produto);
            }
        }
        private void Alterar(Entityes.tb_despesa despesa)
        {
            txtid.Text = despesa.id_despesa.ToString();
            txtdespesa.Text = despesa.ds_descricao;
            txtvalor.Text = despesa.vl_valor.ToString();
            dtpvencimento.Value = despesa.dt_datadevencimento;
            dtppagamento.Value = despesa.dt_pagamento;


        }
        private void Remover(Entityes.tb_despesa despesa)
        {
            DialogResult pergunta = MessageBox.Show("Você realmente deseja excluir está linha selecionada?",
                                                    "Magic Joy", MessageBoxButtons.YesNo,
                                                                 MessageBoxIcon.Question);
            if (pergunta == DialogResult.Yes)
            {
                business.Remover(despesa);
                ListarTudo();
                Limpar();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);

            List<Entityes.tb_despesa> lista = business.PesquisarPorID(id);
            dataGridView1.DataSource = lista;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string despesa = textBox2.Text;

            List<Entityes.tb_despesa> lista = business.PesquisarPorNome(despesa);
            dataGridView1.DataSource = lista;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime data = dateTimePicker1.Value;

            List<Entityes.tb_despesa> lista = business.PesquisarPorData(data);
            dataGridView1.DataSource = lista;
        }

        private void frmDespesa_Load(object sender, EventArgs e)
        {
            ListarTudo();
        }

        private void label5_Click(object sender, EventArgs e)
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
