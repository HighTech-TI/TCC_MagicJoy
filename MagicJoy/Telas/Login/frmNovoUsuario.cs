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
    public partial class frmNovoUsuario : Form
    {
        public frmNovoUsuario()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    string usuario = txtUsuario.Text;
                    string email = txtEmail.Text;
                    string cargo = txtCargo.Text;
                    string senha = txtSenha.Text;
                    string confirmsenha = txtonfirmaao.Text;

                    Business.LoginBusiness businesslog = new Business.LoginBusiness();
                    Entityes.tb_usuario user = businesslog.PesquisarusuariosIguasi(usuario);

                    Entityes.tb_usuario tabela = new Entityes.tb_usuario();

                    if (txtonfirmaao.Text == txtSenha.Text)
                    {
                        tabela.nm_usuario = txtUsuario.Text;
                        businesslog.inserir(tabela);
                    }

                    if (txtonfirmaao.Text != txtSenha.Text)
                    {
                        try
                        {
                            throw new Exception();
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Senhas não se coincidem!",
                                            "Cadastro de usuário", MessageBoxButtons.OK);
                        }
                    }
                }
                catch (Exception)
                {


                    MessageBox.Show("cdastrado com sucesso",
                                "Cadastro de usuário", MessageBoxButtons.OK);

                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Erro",
                                "Cadastro de usuário", MessageBoxButtons.OK);

            }

                         
                                      
        }


            private void pictureBox1_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

            private void pictureBox2_Click(object sender, EventArgs e)
            {
                if (this.WindowState == FormWindowState.Minimized)
                {
                    this.Hide();
                }
                else
                {
                    this.Show();
                    this.BringToFront();
                }
            }
                                                           
            private void txtUsuario_TextChanged(object sender, EventArgs e)
            {

                Business.LoginBusiness businesslog = new Business.LoginBusiness();
                Entityes.tb_usuario usuario = businesslog.PesquisarusuariosIguasi(txtUsuario.Text);

                if (txtUsuario.Text == usuario.nm_usuario || usuario.nm_usuario == txtUsuario.Text)
                {
                   try
                   {

                    txtUsuario.BackColor = System.Drawing.Color.Red;
                    lblusuario.Visible = true;
                    
                    throw new Exception();
                   }
                   
                   catch (Exception)
                   {

                    MessageBox.Show("Nome de usuário já está em uso!",
                                    "Cadastro de usuário", MessageBoxButtons.OK);
                   }

               
                }
               
                if (txtUsuario.Text != usuario.nm_usuario || usuario.nm_usuario != txtUsuario.Text)
                {
                    Entityes.tb_usuario tabela = new Entityes.tb_usuario();
                   

                   businesslog.inserir(tabela);
                   string usuariiio = txtUsuario.Text;

                   txtUsuario.BackColor = System.Drawing.Color.White;
                   lblusuario.Visible = false;

                }


            }
            private void txtonfirmaao_TextChanged(object sender, EventArgs e)
            {

                if (txtonfirmaao.Text != txtSenha.Text)
                {
                    txtonfirmaao.BackColor = System.Drawing.Color.Red;
                    lblsenhas.Visible = true;
                }
                else
                {
                    txtonfirmaao.BackColor = System.Drawing.Color.White;
                    lblsenhas.Visible = false;

                }

            }
        
}   }
