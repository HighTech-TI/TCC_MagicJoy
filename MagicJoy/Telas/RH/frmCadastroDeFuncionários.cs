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

        private void button4_Click(object sender, EventArgs e)
        {
            Entityes.tb_funcionario db = new Entityes.tb_funcionario();

            db.nm_nome = txtNome.Text;

            Business.RH.FuncionarioBusiness businesslog = new Business.RH.FuncionarioBusiness();
            businesslog.InserirFuncionario(db);
        }
    }
}
