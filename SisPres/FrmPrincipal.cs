using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace SisPres
{
    public partial class FrmPrincipal : Form
    {

        #region Atributos

        Usuario user;
        
        #endregion
        #region Métodos Privados

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void EfetuarLogin()
        {
            FrmLogin form = new FrmLogin();

            if (!(form.ShowDialog() == DialogResult.Yes))
            {
                this.Close();
            }

            user = (Usuario)form.Tag;
        }

        #endregion
        #region Métodos Públicos
        
        #endregion
        #region Eventos

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            EfetuarLogin();
            TssUsuario.Text = "Usuario: " + user.Login;
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMdiCadUsuario CadUsuario = new FrmMdiCadUsuario();
            CadUsuario.MdiParent = this;
            CadUsuario.Show();
        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTeste teste = new FrmTeste();
            teste.MdiParent = this;
            teste.Show();
        }
        
        
        
        private void eventosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmMdiCadEvento CadEvento = new FrmMdiCadEvento();
            CadEvento.MdiParent = this;
            CadEvento.Show();
        }

        private void locaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMdiCadLocalizacao CadLocalizacao = new FrmMdiCadLocalizacao();
            CadLocalizacao.MdiParent = this;
            CadLocalizacao.Show();

        }

        private void presençaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMdiCadPresenca CadPresenca = new FrmMdiCadPresenca();
            CadPresenca.MdiParent = this;
            CadPresenca.Show();
        }

        #endregion

     

        
        

        

        

        
    }   
}
