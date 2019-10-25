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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Entityes.tb_controle_ponto db = new Entityes.tb_controle_ponto();

                db.tb_funcionario_id_funcionario = Convert.ToInt32(nudId.Value);
                db.dt_dia = dtDia.Value;
                db.hr_entrada = dtpEntrada.Value;
                db.hr_intervalo = dtpIntervalo.Value;
                db.hr_retorno = dtpRetornoIntervalo.Value;
                db.hr_saida = dtpSaida.Value;

                Business.RH.ControleDePontoBusiness businesslog = new Business.RH.ControleDePontoBusiness();
                businesslog.InserirControleDePonto(db);

                MessageBox.Show("Cadastrado com sucesso.", "Controle de Ponto", MessageBoxButtons.OK);
            }
            catch (Exception)
            {

                MessageBox.Show("Ocorreu um erro tente novamente mais tarde.", "Controle de Ponto", MessageBoxButtons.OK);
            }

            
           
        }

        private void dtpEntrada_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmConsultaControleDePonto tela = new frmConsultaControleDePonto();
            tela.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }
    }
}
