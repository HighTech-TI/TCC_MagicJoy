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
    public partial class frmPedido : Form
    {
        public frmPedido()
        {
            InitializeComponent();
        }

        Business.Estoque.PedidoBusiness business = new Business.Estoque.PedidoBusiness();

        private void frmPedido_Load(object sender, EventArgs e)
        {
            ListarTudo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entityes.tb_pedido pedido = new Entityes.tb_pedido();

            try
            {
               
                    pedido.nm_pedido = txtpedido.Text;
                    pedido.nm_pedinte = txtpedinte.Text;
                    pedido.dt_pedido = dtpdata.Value;

                    business.Salvar(pedido);

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
            dataGridView1.DataSource = business.ListarTodosProdutos();
        }
        private void Limpar()
        {
            txtidpedidopessquisa.Text = string.Empty;
            txtpedido.Text = string.Empty;
            txtpedinte.Text = string.Empty;
           
        }
        private void Alterar(Entityes.tb_pedido pedido)
        {
            
            txtidpedidopessquisa.Text = pedido.nm_pedido;
            txtpedinte.Text = pedido.nm_pedinte;
            dtpdata.Value = pedido.dt_pedido;                      

        }
        private void Remover(Entityes.tb_pedido pedido)
        {
            DialogResult pergunta = MessageBox.Show("Você realmente deseja excluir está linha selecionada?",
                                                    "Magic Joy", MessageBoxButtons.YesNo,
                                                                 MessageBoxIcon.Question);
            if (pergunta == DialogResult.Yes)
            {
                business.Remover(pedido);
                ListarTudo();
                Limpar();
            }
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
            Telas.Menu.btnforne tela = new Telas.Menu.btnforne();
            tela.Show();
            this.Hide();
        }

        private void txtidpedidopessquisa_TextChanged(object sender, EventArgs e)
        {
            List<Entityes.tb_pedido> pedido = business.PesquisarPorID(Convert.ToInt32(txtidpedidopessquisa.Text));
            dataGridView1.DataSource = pedido;
        }

        private void txtpesquisapedinet_TextChanged(object sender, EventArgs e)
        {
            string pedinte = txtpesquisapedinet.Text;

            List<Entityes.tb_pedido> pedido = business.PesquisarPedinte(pedinte);
            dataGridView1.DataSource = pedido;
        }
    }
    
}
  
        
    

