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
    public partial class FrmMdiCadUsuario : Form
    {

        #region Atributos

        public int codUsuario;
        private UsuarioCtrl controle;
        private Usuario usuario;
        private string key = "LASALLEPRES";
        #endregion

        #region Construtor

        public FrmMdiCadUsuario()
        {
            InitializeComponent();
            
        }

        #endregion

        #region Métodos Privados

        private void limparFormulario()
        {
            txbUsuario.Clear();
            txbNome.Clear();
            txbSobrenome.Clear();
            txbEmail.Clear();
            rdbAdministrador.Checked = false;
            rdbSecretaria.Checked = false;
            rdbUsuario.Checked = false;
        }


        private void CarregarFormDeUsuario(DataGridViewRow line)
        {
            try
            {
                codUsuario = Int16.Parse(line.Cells[0].Value.ToString());
                txbUsuario.Text = line.Cells[1].Value.ToString();
                txbNome.Text = line.Cells[3].Value.ToString();
                txbSobrenome.Text = line.Cells[4].Value.ToString();
                txbEmail.Text = line.Cells[5].Value.ToString();
                int perfilCod = Int16.Parse(line.Cells[6].Value.ToString());

                switch (perfilCod)
                {
                    case 1: rdbAdministrador.Checked = true; break;
                    case 2: rdbSecretaria.Checked = true; break;
                    case 3: rdbUsuario.Checked = true; break;
                    default: break;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
        }

        private void CarregarGrid()
        {
            UsuarioCtrl usr = new UsuarioCtrl();

            // Carrega os dados do grid de Usuario
            var usuario = usr.BuscarTodosUsuarios();
                    
            dgvUsuario.DataSource = usuario.ToList();

            dgvUsuario.Columns[2].Visible = false;
        }

        #endregion

        #region Métodos Públicos
        #endregion

        #region Eventos
        
        private void FrmMdiCadUsuario_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void txbConfSenha_TextChanged(object sender, EventArgs e)
        {
            controle = new UsuarioCtrl();
            lbl_avisosenha.Visible = controle.verificaSenha(txbSenha.Text, txbConfSenha.Text);
        }

        private void tsbNovoUsuario_Click(object sender, EventArgs e)
        {
            #region Verificação do Perfil
            int codPerfil = 0;

            if (rdbAdministrador.Checked)
                codPerfil = 1;
            if (rdbSecretaria.Checked)
                codPerfil = 2;
            if (rdbUsuario.Checked)
                codPerfil = 3;
            #endregion
            try
            {
                //Instancia um novo controle de usuario
                controle = new UsuarioCtrl();
                //instancia um novo usuario
                usuario = new Usuario();

                //carrega as variavéis a partir dos valores dos textbox
                usuario.Login = txbUsuario.Text;
                usuario.Senha = Criptografia.encrypt(txbSenha.Text,key);
                usuario.Nome = txbNome.Text;
                usuario.Sobrenome = txbSobrenome.Text;
                usuario.Email = txbEmail.Text;
                usuario.Perfilcod = codPerfil;
                
                controle.InserirUsuario(usuario);
                
                //int id = controle.InserirUsuarioGetId(usuario);
                //MessageBox.Show(id.ToString());
                //tsbAtualizarGrid.PerformClick();

                MessageBox.Show("Usuário Cadastro com sucesso!!!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void tsbSalvarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                #region Verificação do Perfil
                int codPerfil = 0;

                if (rdbAdministrador.Checked)
                    codPerfil = 1;
                if (rdbSecretaria.Checked)
                    codPerfil = 2;
                if (rdbUsuario.Checked)
                    codPerfil = 3;
                #endregion
                UsuarioCtrl controle = new UsuarioCtrl();

                Usuario usuario = new Usuario();

                usuario.Cod = codUsuario;
                usuario.Login = txbUsuario.Text;
                usuario.Senha = txbSenha.Text;
                usuario.Nome = txbNome.Text;
                usuario.Sobrenome = txbSobrenome.Text;
                usuario.Email = txbEmail.Text;
                usuario.Perfilcod = codPerfil;

                controle.AtualizarUsuario(usuario);

                MessageBox.Show("Usuário Atualizado com sucesso!!!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void tsbAtualizarGrid_Click_1(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void tsbDeletarUsuario_Click(object sender, EventArgs e)
        {
            UsuarioCtrl controle = new UsuarioCtrl();

            Usuario usuario = new Usuario();

            usuario.Cod = codUsuario;

            controle.DeletarUsuario(codUsuario);

            MessageBox.Show("Usuário Excluído!!");


        }

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linha = dgvUsuario.CurrentRow;
            CarregarFormDeUsuario(linha);
        }

        #endregion       
    }
}
