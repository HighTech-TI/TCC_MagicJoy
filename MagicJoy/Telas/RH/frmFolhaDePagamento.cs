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
    public partial class txt : Form
    {
        public txt()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmFolhaDePagamento_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
            

        }

        private void txtbruto_TextChanged(object sender, EventArgs e)
        {
            {
                decimal salario = Convert.ToDecimal(txtbruto.Text);

                Objetos.Folha funcao = new Objetos.Folha();
                decimal vt = funcao.CalcularVT(salario);

                txtvaletranposter.Text = Convert.ToString(vt);

                decimal total = 0;
                
                if (salario <= 1751.81m)
                {
                    total = salario * 0;
                }
                if (salario == 1751.81m)
                {
                    total = salario * 0.08m;
                }

                if (salario == 1751.82m && salario <= 2919.72m)
                {
                    total = salario * 0.09m;
                }
                if (salario == 2919.73m && salario <= 5839.45m)
                {
                    total = salario * 0.11m;
                }
                
                txtinss.Text = Convert.ToString(total);

            }         
           

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfaltas_TextChanged(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            Entityes.tb_folha_pagamento tabela = new Entityes.tb_folha_pagamento();

            tabela.ds_inss = Convert.ToDecimal(txtinss.Text);
            tabela.dt_pagamento = dtpdata.Value;
            tabela.id_funcionario = Convert.ToInt32(nudid.Value);
            tabela.vl_bruto = Convert.ToDecimal(txtbruto.Text);
            tabela.vl_gratificacao = Convert.ToDecimal(txtgratificacao.Text);
            tabela.vl_irrf = Convert.ToDecimal(txtirrf.Text);
            tabela.vl_liquido = Convert.ToDecimal(txtliquido.Text);
            tabela.vl_salario_familia = Convert.ToDecimal(txtfamilia.Text);
            tabela.vl_VT = Convert.ToDecimal(txtvaletranposter.Text);
            tabela.

        }
    }
}
