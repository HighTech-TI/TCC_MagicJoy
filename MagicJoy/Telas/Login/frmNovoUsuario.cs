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
                Entityes.tb_usuario tabela = new Entityes.tb_usuario();
                                
                tabela.ds_email = txtemail.Text;
                tabela.ds_cargo = txtCargo.Text;
                tabela.nm_usuario = txtUsuario.Text;
                tabela.nm_senha = txtSenha.Text; 

                Business.LoginBusiness businesslog = new Business.LoginBusiness();
                Entityes.tb_usuario usuario = businesslog.PesquisarusuariosIguasi(txtUsuario.Text);
            
                if (txtUsuario.Text != tabela.nm_usuario)
                {
                    txtUsuario.BackColor = System.Drawing.Color.White;

                    businesslog.inserir(tabela);
                                                       
                }

                
                  


                if (txtonfirmaao.Text != txtSenha.Text)
                {
                    txtonfirmaao.BackColor = System.Drawing.Color.Red;


                    throw new Exception();
                }

                else if (txtonfirmaao.Text == txtSenha.Text)
                {
                    txtSenha.BackColor = System.Drawing.Color.White;

                   
                    businesslog.inserir(tabela);
                }
                                

                MessageBox.Show("Cadastrado com sucesso!",
                               "Cadastro", MessageBoxButtons.OK);

                
                
           }
            catch (Exception)
            {

                MessageBox.Show("Ocorreu um erro, " +
                                "tente novamente mais tarde", "Login", 
                           MessageBoxButtons.OK);
                return;
            }

          
            

        
        }


            private void pictureBox1_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

            private void pictureBox2_Click(object sender, EventArgs e)
            {
              this.WindowState = FormWindowState.Minimized;
            }
                                                           
            private void txtUsuario_TextChanged(object sender, EventArgs e)
            {
            
            
                Business.LoginBusiness businesslog = new Business.LoginBusiness();
                Entityes.tb_usuario usuario = businesslog.PesquisarusuariosIguasi(txtUsuario.Text);

                if(usuario == null)
                {
                  txtUsuario.BackColor = System.Drawing.Color.White;
                  lblusuario.Visible = false;
                  return;
                }

               
                if(txtUsuario.Text == usuario.nm_usuario)
                {
                    try
                    {

                        txtUsuario.BackColor = System.Drawing.Color.Red;
                        lblusuario.Visible = true;
                    }

                    catch (Exception)

                    {

                        MessageBox.Show("Nome de usuário já está em uso!",
                                        "Cadastro de usuário", MessageBoxButtons.OK);
                    }

                }
                  
               
                        
                if (txtUsuario.Text != usuario.nm_usuario)
                {
                    Entityes.tb_usuario tabela = new Entityes.tb_usuario();


                    businesslog.inserir(tabela);
                    tabela.nm_usuario = txtUsuario.Text;

                    txtUsuario.BackColor = System.Drawing.Color.White;
                    lblusuario.Visible = false;

                }

                 return;
                                    
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

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Telas.Login.frmLogin tela = new frmLogin();
            tela.Show();
            this.Hide();
        }
    }   }
