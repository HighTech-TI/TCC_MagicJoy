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
                decimal bruto = Convert.ToDecimal(txtbruto.Text);

                decimal vt = bruto * 0.06m;

                txtvaletranposter.Text = Convert.ToString(vt);
            }

          
           

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfaltas_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
