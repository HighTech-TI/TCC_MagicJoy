using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicJoy.Telas.RH
{
    public partial class frmCadastroDeFuncionários : Form
    {
        public frmCadastroDeFuncionários()
        {
            InitializeComponent();
        }

        Business.RH.FuncionarioBusiness business = new Business.RH.FuncionarioBusiness();
        private void button4_Click(object sender, EventArgs e)
        {  
            try
            {
                Entityes.tb_funcionario funcionario = new Entityes.tb_funcionario();

                funcionario.nm_nome = txtNome.Text;
                funcionario.nm_cargo = txtcargo.Text;
                funcionario.ds_cpf = mktcpf.Text;
                funcionario.ds_rg = mktrg.Text;
                funcionario.dt_nascimento = dtpnascmiento.Value;
                funcionario.dt_admissao = dtpadmissao.Value;
                funcionario.dt_demissao = dtpdemissao.Value;
                funcionario.ds_endereco = txtendereco.Text;
                funcionario.ds_telefone = mkttele.Text;
                funcionario.ds_celular = mktcell.Text;
                funcionario.id_beneficios = Convert.ToInt32(nufbeneficio.Value);
                funcionario.id_folha_pagamento = Convert.ToInt32(txtidfolha.Text);

                business.Salvar(funcionario);

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
            nudidfuncio.Value = 0;
            txtNome.Text = string.Empty;
            txtcargo.Text = string.Empty;
            mktcpf.Text = string.Empty;
            mktrg.Text = string.Empty;
            txtendereco.Text = string.Empty;
            mkttele.Text = string.Empty;
            mktcell.Text = string.Empty;
            nufbeneficio.Value = 0;
            txtidfolha.Text = string.Empty;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var funcionario = dataGridView1.CurrentRow.DataBoundItem as Entityes.tb_funcionario;

            if (e.ColumnIndex == 12)
            {
                Alterar(funcionario);
            }

            if (e.ColumnIndex == 13)
            {
                Remover(funcionario);
            }

        }
        private void Alterar(Entityes.tb_funcionario funcionario)
        {
            nudidfuncio.Value = funcionario.id_funcionario;
            txtNome.Text = funcionario.nm_nome;
            mktcpf.Text = funcionario.ds_cpf;
            mktrg.Text = funcionario.ds_rg;
            dtpadmissao.Value = funcionario.dt_admissao;
            dtpdemissao.Value = funcionario.dt_demissao;
            txtcargo.Text = funcionario.nm_cargo;
            dtpnascmiento.Value = funcionario.dt_nascimento;
            txtendereco.Text = funcionario.ds_endereco;
            mkttele.Text = funcionario.ds_telefone;
            mktcell.Text = funcionario.ds_celular;
            nufbeneficio.Value = funcionario.id_beneficios;
            txtidfolha.Text = funcionario.id_folha_pagamento.ToString();

        }
        private void Remover(Entityes.tb_funcionario funcionario)
        {
            DialogResult pergunta = MessageBox.Show("Você realmente deseja excluir está linha selecionada?",
                                                    "Magic Joy", MessageBoxButtons.YesNo,
                                                                 MessageBoxIcon.Question);
            if (pergunta == DialogResult.Yes)
            {
                business.Remover(funcionario);
                ListarTudo();
                Limpar();
            }
        }

        private void nudpesquisa_ValueChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(nudpesquisa.Value);

            List<Entityes.tb_funcionario> lista = business.PesquisarPorID(id);
            dataGridView1.DataSource = lista;
        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = txtpesquisa.Text;
            List<Entityes.tb_funcionario> lista = business.PesquisarPorNome(nome);
            dataGridView1.DataSource = lista;
        }

        private void mktpesuisa_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string rg = mktpesuisa.Text;
            List<Entityes.tb_funcionario> lista = business.PesquisarPorRg(rg);
            dataGridView1.DataSource = lista;
        }

        private void frmCadastroDeFuncionários_Load(object sender, EventArgs e)
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
