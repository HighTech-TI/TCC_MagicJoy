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

        }
    }
}
