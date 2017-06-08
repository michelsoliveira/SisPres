using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controle;
using Modelo;

namespace SisPres
{
    public partial class FrmLogin : Form
    {

        #region Atributos
        private string key = "LASALLEPRES"; 
        #endregion
        #region Métodos Privados

        public FrmLogin()
        {
            InitializeComponent();
        }

        #endregion
        #region Métodos Públicos
        
        #endregion
         #region Eventos

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario user = new Usuario();

                user.Login = txbLogin.Text;
                user.Senha = Criptografia.encrypt(txbSenha.Text,key);

                UsuarioCtrl controlUser = new UsuarioCtrl();

                if (controlUser.ValidarUsuario(user))
                {
                    this.Tag = user;
                    this.DialogResult = DialogResult.Yes;

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario ou senha inválidos!!");
                    //lblMsg.Text = "Usuário ou Senha inválidos!!!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        #endregion


       

        

                          
      
    }
}
