using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicJoy.Telas.Login
{
    public partial class frmRecuperarSenha : Form
    {
        public frmRecuperarSenha()
        {
            InitializeComponent();
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataBase.LoginDataBase db = new DataBase.LoginDataBase();
                int cod = Convert.ToInt32(txtcodigo.Text);
                Entityes.tb_codigo tb = new Entityes.tb_codigo();
                tb.ds_codigo = Convert.ToInt32(txtcodigo.Text);

                if (txtcodigo.Text == string.Empty)
                {
                    MessageBox.Show("Código de recuperação está vazio", "Magic Joy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Objetos.EnviarEmail fun = new Objetos.EnviarEmail();
                    if (!fun.codigo(cod))
                    {
                        MessageBox.Show("Código inválido ");

                    }
                    else

                    {
                    MessageBox.Show("Código correto, Continue preenchendo os campos abaixo",
                                    "Magic Joy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            

                        db.remover(tb);
                        groupBox2.Visible = true;
                        groupBox1.Visible = false;

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro, tente novamente mais tarde ou contate seu administrador de sistemas", "Magic Joy",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
     

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Entityes.tb_usuario tabelea = new Entityes.tb_usuario();
                tabelea.nm_usuario = txtUsuario.Text;
                string user = txtUsuario.Text;
                tabelea.nm_senha = txtsenha.Text;

                Objetos.EnviarEmail fun = new Objetos.EnviarEmail();
                if (!fun.usuario(user))
                {
                    MessageBox.Show("Nome de usuário inválido", "Magic Joy",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (txtconfirmarseneha.Text != txtsenha.Text)
                    {
                        txtconfirmarseneha.BackColor = System.Drawing.Color.Red;
                        lblsenhas.Visible = true;
                    }
                    else
                    {
                        txtconfirmarseneha.BackColor = System.Drawing.Color.White;
                        lblsenhas.Visible = false;
                        Business.LoginBusiness log = new Business.LoginBusiness();
                        log.Alterar(tabelea);
                        MessageBox.Show("Senha alterada com sucesso", "Magic Joy",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Telas.Login.frmLogin tela = new frmLogin();
                        tela.Show();
                        this.Hide();

                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro, tente novamente mais tarde ou contate seu administrador de sistemas", "Magic Joy",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void txtconfirmarseneha_TextChanged(object sender, EventArgs e)
        {
            if (txtconfirmarseneha.Text != txtsenha.Text)
            {
                txtconfirmarseneha.BackColor = System.Drawing.Color.Red;
                lblsenhas.Visible = true;
            }
            else
            {
                txtconfirmarseneha.BackColor = System.Drawing.Color.White;
                lblsenhas.Visible = false;
            }
        }
    }
}
