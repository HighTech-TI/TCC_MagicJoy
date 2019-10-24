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
    public partial class frmConsultaControleDePonto : Form
    {
        public frmConsultaControleDePonto()
        {
            InitializeComponent();
        }
      

       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == edit.Index)
            {
                Entityes.tb_controle_ponto controleponto = dtpcontrole.Rows[e.RowIndex].DataBoundItem as Entityes.tb_controle_ponto;

                Telas.RH.frmControleDePonto tela = new frmControleDePonto();
                tela.Show();
                this.Hide();

                return;
            }

            else if (e.ColumnIndex == exclit.Index)
            {
                Entityes.tb_controle_ponto controleponto = dtpcontrole.Rows[e.RowIndex].DataBoundItem as Entityes.tb_controle_ponto;

                DialogResult pergunta = MessageBox.Show("Deseja excluir esse registro?",
                                                        "Controle de Ponto", MessageBoxButtons.YesNo,
                                                                             MessageBoxIcon.Question);

                if (pergunta == DialogResult.Yes)
                {
                    Business.RH.ControleDePontoBusiness businesslog = new Business.RH.ControleDePontoBusiness();
                    businesslog.Remover(controleponto.id_controle_ponto);

                    MessageBox.Show("Registro Removido com sucesso!", "Controle de Ponto", MessageBoxButtons.OK);

                    businesslog.ListarTodosUsuarios();
                }
            }
        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            
                int id = Convert.ToInt32(numericUpDown1.Value);

                Business.RH.ControleDePontoBusiness businesslog = new Business.RH.ControleDePontoBusiness();
                List<Entityes.tb_controle_ponto> consultar = businesslog.PesquisarPorID(id);

                dtpcontrole.AutoGenerateColumns = false;
                dtpcontrole.DataSource = consultar;
            
        }

        private void frmConsultaControleDePonto_Load(object sender, EventArgs e)
        {

        }
    }
}
