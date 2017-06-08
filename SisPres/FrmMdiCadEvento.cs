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
using Controle;

namespace SisPres
{
    public partial class FrmMdiCadEvento : Form
    {

        #region Atributos

        public int codEvento;
        public int codEventoPrincipal;
        public int codLocal;
        
        #endregion
        #region Construtores

        public FrmMdiCadEvento()
        {
            InitializeComponent();
        }
        
        #endregion
        #region Métodos Privados

        private void carregarComboEvento()
        {
            EventoCtrl evtCtrl = new EventoCtrl();

            cmbEventoPrincipal.DataSource = evtCtrl.BuscarTodosEventos();
            cmbEventoPrincipal.DisplayMember = "titulo";
            cmbEventoPrincipal.ValueMember = "cod";

        }

        public void VerficaEventoCadastra()
        {
            if (rdbEventoUnico.Checked)
            {
                try
                {
                    //Instancia um novo controle de usuario
                    EventoCtrl controle = new EventoCtrl();
                    //instancia um novo usuario
                    Evento evento = new Evento();

                    //carrega as variavéis a partir dos valores dos textbox
                    evento.Titulo = txbTituloEvento.Text;
                    evento.Descricao = txbDescricao.Text;
                    evento.Qtdhoras = txbQtdHoras.Text;
                    evento.Data_ini = dtpDataInicio.Value;
                    evento.Hora_ini = dtpHoraInicio.Value;
                    evento.Data_fim = dtpDataFim.Value;
                    evento.Hora_fim = dtpHoraFim.Value;
                    evento.Local_cod = 1;
                    controle.InserirEventoUnico(evento);

                    MessageBox.Show("Evento Cadastro com sucesso!!!");
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            if (rdbEventoMultiplo.Checked && rdbSubEvento.Checked)
            {
                try
                {
                    //Instancia um novo controle de usuario
                    EventoCtrl controle = new EventoCtrl();
                    //instancia um novo usuario
                    Evento evento = new Evento();

                    //carrega as variavéis a partir dos valores dos textbox
                    evento.Evento_cod = Convert.ToInt32(cmbEventoPrincipal.SelectedValue);
                    evento.Titulo = txbTituloEvento.Text;
                    evento.Descricao = txbDescricao.Text;
                    evento.Qtdhoras = txbQtdHoras.Text;
                    evento.Data_ini = dtpDataInicio.Value;
                    evento.Hora_ini = dtpHoraInicio.Value;
                    evento.Data_fim = dtpDataFim.Value;
                    evento.Hora_fim = dtpHoraFim.Value;
                    evento.Local_cod = 1;
                    controle.InserirEventoMultiplo(evento);

                    MessageBox.Show("Evento Cadastro com sucesso!!!");
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

        }

        private void CarregarFormDeEvento(DataGridViewRow line)
        {
            try
            {
                codEvento = Int32.Parse(line.Cells[0].Value.ToString());
                codEventoPrincipal = Int32.Parse(line.Cells[1].Value.ToString());
                txbTituloEvento.Text = line.Cells[2].Value.ToString();
                txbDescricao.Text = line.Cells[3].Value.ToString();
                txbQtdHoras.Text = line.Cells[4].Value.ToString();
                



            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
        }

        //private void CarregarComboLocalizacaoBloco()
        //{
        //    LocalizacaoCtrl locCtrl = new LocalizacaoCtrl();

        //    cmbBlocoEvento.DataSource = locCtrl.BuscarTodasLocalizacoes();
        //    cmbAndarEvento.DataSource = locCtrl.BuscarTodasLocalizacoes();
        //    cmbBlocoEvento.DisplayMember = "bloco";
        //    cmbAndarEvento.DisplayMember = "andar";
        //    cmbBlocoEvento.ValueMember = "cod";

        //}

        //private void CarregarComboLocalizacaoSala()
        //{
        //    LocalizacaoCtrl locCtrl = new LocalizacaoCtrl();


        //    //var localizacao = locCtrl.BuscarTodasLocalizacoes();
        //    var localizacao = from o in locCtrl.BuscarTodasLocalizacoes()
        //                      select new
        //                      {
        //                          //o
        //                      };
        //}
        
        #endregion
        #region Métodos Públicos
        
        

        #endregion
        #region Eventos

        private void FrmMdiCadEvento_Load(object sender, EventArgs e)
        {
            carregarComboEvento();
            //CarregarComboLocalizacaoBloco();
        }
        
        private void rdbSubEvento_CheckedChanged(object sender, EventArgs e)
        {
            cmbEventoPrincipal.Visible = true;
            lblEventoPrincipal.Visible = true;
        }

        private void rdbEventoMultiplo_CheckedChanged(object sender, EventArgs e)
        {
            gbEspEvento.Visible = true;
        }

        private void rdbPrincipal_CheckedChanged(object sender, EventArgs e)
        {
            cmbEventoPrincipal.Visible = false;
            lblEventoPrincipal.Visible = false;
        }

        private void rdbEventoUnico_CheckedChanged(object sender, EventArgs e)
        {
            gbEspEvento.Visible = false;
        }

        private void tsbNovoEvento_Click(object sender, EventArgs e)
        {
            VerficaEventoCadastra();
        }
        #endregion




        

        

       

        

        

    }
}
