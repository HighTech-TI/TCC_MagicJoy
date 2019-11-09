using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicJoy.Telas.Menu
{
    public partial class btnforne : Form
    {
        public btnforne()
        {
            InitializeComponent();

            lblLogado.Text = "Seja Bem-Vindo " + Objetos.UsuarioLogado.nome;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMenuu_Load(object sender, EventArgs e)
        {
            label4.Text = DateTime.Today.ToShortDateString();
          

        }       

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {



        }

        private void timer3_Tick(object sender, EventArgs e)
        {






        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void opçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            btndespesa.Visible = true;
            btnclientes.Visible = true;
            btncontrole.Visible = false;
            btnfluxo.Visible = true;
            btnpedido.Visible = false;
            btnestoque.Visible = false;
            btnproduto.Visible = false;
            btncompras.Visible = false;
            btnvendas.Visible = false;
            btnforr.Visible = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            btncompras.Visible = true;
            btnvendas.Visible = true;
            btnforr.Visible = true;
            btnpedido.Visible = false;
            btncontrole.Visible = false;
            btnestoque.Visible = false;
            btnproduto.Visible = false;
            btndespesa.Visible = false;
            btnclientes.Visible = false;
            btnfluxo.Visible = false;
            btnfolha.Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            btnpedido.Visible = true;
            btnestoque.Visible = true;
            btnproduto.Visible = true;
            btndespesa.Visible = false;
            btncontrole.Visible = false;
            btnclientes.Visible = false;
            btnfluxo.Visible = false;
            btncompras.Visible = false;
            btnvendas.Visible = false;
            btnforr.Visible = false;
            btnfolha.Visible = false;
        }

        private void menuFC_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lblLogado_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            btnpedido.Visible = false;
            btnestoque.Visible = false;
            btnproduto.Visible = false;
            btncompras.Visible = false;
            btnvendas.Visible = false;
            btnforr.Visible = false;
            btndespesa.Visible = false;
            btnclientes.Visible = false;
            btnfluxo.Visible = false;
            btnfunciona.Visible = true;
            btnfolha.Visible = true;
            btncontrole.Visible = true;
        }

        private void btnestoque_Click(object sender, EventArgs e)
        {
            Telas.Estoque.frmInserirEstoque tela = new Estoque.frmInserirEstoque();
            tela.Show();
            this.Hide();
        }

        private void btnproduto_Click(object sender, EventArgs e)
        {
            Telas.Estoque.frmProduto tela = new Estoque.frmProduto();
            tela.Show();
            this.Hide();
        }

        private void btnpedido_Click(object sender, EventArgs e)
        {
            Telas.Estoque.frmPedido tela = new Estoque.frmPedido();
            tela.Show();
            this.Hide();
        }

        private void btndespesa_Click(object sender, EventArgs e)
        {
            Telas.Financeiro.frmDespesa tela = new Financeiro.frmDespesa();
            tela.Show();
            this.Hide();
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            Telas.Cliente.frmCadastroDeCliente tela = new Cliente.frmCadastroDeCliente();
            tela.Show();
            this.Hide();
        }

        private void btnforr_Click(object sender, EventArgs e)
        {
            Telas.Suprimentos.frmFornecedor tela = new Suprimentos.frmFornecedor();
            tela.Show();
            this.Hide(); 
        }

        private void btnvendas_Click(object sender, EventArgs e)
        {
            Telas.Suprimentos.test tela = new Suprimentos.test();
            tela.Show();
            this.Hide();
        }

        private void btncompras_Click(object sender, EventArgs e)
        {
            Telas.Suprimentos.frmCompra tela = new Suprimentos.frmCompra();
            tela.Show();
            this.Hide();
        }

        private void btncontrole_Click(object sender, EventArgs e)
        {
            Telas.RH.frmControleDePonto tela = new RH.frmControleDePonto();
            tela.Show();
            this.Hide();
        }

        private void btnfunciona_Click(object sender, EventArgs e)
        {
            Telas.RH.frmCadastroDeFuncionários tela = new RH.frmCadastroDeFuncionários();
            tela.Show
                ();
            this.Hide();
        }

        private void pictureBox24_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox26_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnfolha_Click(object sender, EventArgs e)
        {
            Telas.RH.frmFolhaDePagamento tela = new RH.frmFolhaDePagamento();
            tela.Show();
            this.Hide();
        }

        private void btnfluxo_Click(object sender, EventArgs e)
        {
            Telas.Financeiro.frmFluxoDeCaixa tela = new Financeiro.frmFluxoDeCaixa();
            tela.Show();
            this.Hide();
        }
    }
}
