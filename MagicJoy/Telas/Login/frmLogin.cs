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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Telas.Login.frmEsqueciSenha tela = new frmEsqueciSenha();
            tela.Show();
            tela.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            try
            {
                Business.LoginBusiness businesslog = new Business.LoginBusiness();
                Entityes.tb_usuario usuario = new Entityes.tb_usuario();

                if (cbousuario.Text == usuario.nm_usuario && txtsenha.Text == usuario.nm_senha)
                {
                    Telas.Menu.frmMenu tela = new Menu.frmMenu();
                    tela.Show();
                    tela.Hide();
                }
                else
                {
                    MessageBox.Show("Senha incorreta",
                        "Login", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro, tente novamente!",
                        "Login", MessageBoxButtons.OK);

            }
           

        }

        private void cbousuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entityes.tb_usuario usuario = new Entityes.tb_usuario();
            cbousuario.Text = usuario.nm_usuario;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Telas.Login.frmNovoUsuario tela = new frmNovoUsuario();
            tela.Show();
            tela.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
