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
    public partial class frmControleDePonto : Form
    {
        public frmControleDePonto()
        {
            InitializeComponent();
        }
        Business.RH.ControleDePontoBusiness business = new Business.RH.ControleDePontoBusiness();
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           try
            {
                Entityes.tb_controle_ponto ponto = new Entityes.tb_controle_ponto();

                ponto.dt_dia = dtDia.Value;
                ponto.id_funcionario = Convert.ToInt32(nudfuncionario.Value);
                ponto.hr_entrada = dtpEntrada.Value;
                ponto.hr_intervalo = dtpIntervalo.Value;
                ponto.hr_retorno = dtpRetornoIntervalo.Value;
                ponto.hr_saida = dtpSaida.Value;

                business.Salvar(ponto);

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
            dataGridView1.DataSource = business.ListarTodosUsuarios();
        }
        private void Limpar()
        {
            nudcontrole.Value = 0;
            nudfuncionario.Value = 0;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var ponto = dataGridView1.CurrentRow.DataBoundItem as Entityes.tb_controle_ponto;

            if (e.ColumnIndex == 8)
            {
                Alterar(ponto);
            }

            if (e.ColumnIndex == 9)
            {
                Remover(ponto);
            }
        }

        private void Alterar(Entityes.tb_controle_ponto ponto)
        {
            dtDia.Value = ponto.dt_dia;
            nudcontrole.Value = ponto.id_controle_ponto;
            nudfuncionario.Value = ponto.id_funcionario;
        }
        private void Remover(Entityes.tb_controle_ponto ponto)
        {
            DialogResult pergunta = MessageBox.Show("Você realmente deseja excluir está linha selecionada?",
                                                    "Magic Joy", MessageBoxButtons.YesNo,
                                                                 MessageBoxIcon.Question);
            if (pergunta == DialogResult.Yes)
            {
                business.Remover(ponto);
                ListarTudo();
                Limpar();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string nome = textBox1.Text;

            List<Entityes.tb_controle_ponto> lista = business.PesquisarPorNome(nome);
            dataGridView1.DataSource = lista;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(numericUpDown1.Value);

            List<Entityes.tb_controle_ponto> lista = business.PesquisarPorID(id);
            dataGridView1.DataSource = lista;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dia = dtDia.Value;

            List<Entityes.tb_controle_ponto> lista = business.PesquisarPorData(dia);
            dataGridView1.DataSource = lista;
        }

        private void frmControleDePonto_Load(object sender, EventArgs e)
        {
            ListarTudo();
        }
    }
         
}
