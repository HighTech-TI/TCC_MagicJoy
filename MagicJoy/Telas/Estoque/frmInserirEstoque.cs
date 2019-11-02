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
    public partial class frmInserirEstoque : Form
    {
        public frmInserirEstoque()
        {
            InitializeComponent();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                Entityes.tb_estoque estoque = new Entityes.tb_estoque();

                estoque.nm_produto = txtproduto.Text;
                estoque.ds_qtd = Convert.ToInt32(txtqtds.Text);
                estoque.vl_custo = Convert.ToDecimal(txtvlcusto.Text);
                estoque.tb_Fornecedor_id_fornecedor = Convert.ToInt32(nudidforncedor.Value);

                Business.Estoque.EstoqueBusiness business = new Business.Estoque.EstoqueBusiness();
                business.InserirEstoque(estoque);

                MessageBox.Show("Cadastrado com sucesso", 
                                "Estqoeu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MessageBox.Show("Ocorreu um erro tente novamente mais tarde.", 
                                "Estoque", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          

        }
    }
}
