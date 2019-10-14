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
                Entityes.tb_usuario usuario = new Entityes.tb_usuario();
                usuario.nm_usuario = txtUsuario.Text;
                usuario.ds_email = txtEmail.Text;
                usuario.nm_senha = txtSenha.Text;
                usuario.ds_cargo = txtCargo.Text;

                Business.LoginBusiness logbusiness = new Business.LoginBusiness();
                logbusiness.inserir(usuario);

                MessageBox.Show("Cadastrado com sucesso!",
                 "Login", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro, tente novamente mais tarde.",
                  "Login", MessageBoxButtons.OK);

            }
        }
    }
}
