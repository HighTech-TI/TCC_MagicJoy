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
            Business.LoginBusiness logbusiness = new Business.LoginBusiness();

            List<Entityes.tb_usuario> users = logbusiness.ListarTodosUsuarios();

            cbousuario.DisplayMember = nameof(Entityes.tb_usuario.nm_usuario);
            cbousuario.DataSource = users;
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
                string nome = cbousuario.Text;
                string senha = txtsenha.Text;
                Entityes.tb_usuario ds = new Entityes.tb_usuario();
                Business.LoginBusiness businesslog = new Business.LoginBusiness();
                Entityes.tb_usuario usuario = businesslog.PesquisarParaLogar(nome, senha);

                try
                {
                    if (nome == usuario.nm_usuario && senha == usuario.nm_senha)
                    {
                        Objetos.UsuarioLogado.id = usuario.id_usuario;
                        Objetos.UsuarioLogado.nome = usuario.nm_usuario;
                       
                        

                        Telas.Menu.btnforne tela = new Menu.btnforne();
                        tela.Show();
                        this.Hide();
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Senha incorreta!", "login", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ocorreu um erro, tente novamente mais tarde!", "login", MessageBoxButtons.OK);

            }
                
                
           
        }

        private void cbousuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        } 

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            frmNovoUsuario tela = new frmNovoUsuario();
            tela.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Telas.Login.frmEsqueciSenha tela = new frmEsqueciSenha();
            tela.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            if(txtsenha.UseSystemPasswordChar == false)
            {
                txtsenha.UseSystemPasswordChar = true;
            }
            else
            {
                txtsenha.UseSystemPasswordChar = false;
            }
        }
    }
}
