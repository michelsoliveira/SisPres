namespace SisPres
{
    partial class FrmMdiCadEvento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbEventos = new System.Windows.Forms.GroupBox();
            this.lblQtdHoras = new System.Windows.Forms.Label();
            this.txbQtdHoras = new System.Windows.Forms.TextBox();
            this.lblCursoEvento = new System.Windows.Forms.Label();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.lblEventoPrincipal = new System.Windows.Forms.Label();
            this.cmbEventoPrincipal = new System.Windows.Forms.ComboBox();
            this.dtpHoraFim = new System.Windows.Forms.DateTimePicker();
            this.dtpDataFim = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.lblDataFim = new System.Windows.Forms.Label();
            this.lblHoraFim = new System.Windows.Forms.Label();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
            this.txbDescricao = new System.Windows.Forms.TextBox();
            this.lblDescEvento = new System.Windows.Forms.Label();
            this.txbTituloEvento = new System.Windows.Forms.TextBox();
            this.lblTituloEvento = new System.Windows.Forms.Label();
            this.tsCadEventos = new System.Windows.Forms.ToolStrip();
            this.tsbNovoEvento = new System.Windows.Forms.ToolStripButton();
            this.tsbSalvarEvento = new System.Windows.Forms.ToolStripButton();
            this.tsbDeletarEvento = new System.Windows.Forms.ToolStripButton();
            this.tsbAtualizarGrid = new System.Windows.Forms.ToolStripButton();
            this.gbTipoEvento = new System.Windows.Forms.GroupBox();
            this.rdbEventoMultiplo = new System.Windows.Forms.RadioButton();
            this.rdbEventoUnico = new System.Windows.Forms.RadioButton();
            this.gbLocalizacao = new System.Windows.Forms.GroupBox();
            this.lblSalaEvento = new System.Windows.Forms.Label();
            this.cmbSalaEvento = new System.Windows.Forms.ComboBox();
            this.cmbAndarEvento = new System.Windows.Forms.ComboBox();
            this.lblAndarEvento = new System.Windows.Forms.Label();
            this.cmbBlocoEvento = new System.Windows.Forms.ComboBox();
            this.lblBlocoEvento = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbEspEvento = new System.Windows.Forms.GroupBox();
            this.rdbSubEvento = new System.Windows.Forms.RadioButton();
            this.rdbPrincipal = new System.Windows.Forms.RadioButton();
            this.txbDescSalaEvento = new System.Windows.Forms.TextBox();
            this.lblDescSalaEvento = new System.Windows.Forms.Label();
            this.gbEventos.SuspendLayout();
            this.tsCadEventos.SuspendLayout();
            this.gbTipoEvento.SuspendLayout();
            this.gbLocalizacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbEspEvento.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEventos
            // 
            this.gbEventos.Controls.Add(this.lblQtdHoras);
            this.gbEventos.Controls.Add(this.txbQtdHoras);
            this.gbEventos.Controls.Add(this.lblCursoEvento);
            this.gbEventos.Controls.Add(this.cmbCurso);
            this.gbEventos.Controls.Add(this.lblEventoPrincipal);
            this.gbEventos.Controls.Add(this.cmbEventoPrincipal);
            this.gbEventos.Controls.Add(this.dtpHoraFim);
            this.gbEventos.Controls.Add(this.dtpDataFim);
            this.gbEventos.Controls.Add(this.dtpHoraInicio);
            this.gbEventos.Controls.Add(this.lblDataFim);
            this.gbEventos.Controls.Add(this.lblHoraFim);
            this.gbEventos.Controls.Add(this.lblHoraInicio);
            this.gbEventos.Controls.Add(this.lblDataInicio);
            this.gbEventos.Controls.Add(this.dtpDataInicio);
            this.gbEventos.Controls.Add(this.txbDescricao);
            this.gbEventos.Controls.Add(this.lblDescEvento);
            this.gbEventos.Controls.Add(this.txbTituloEvento);
            this.gbEventos.Controls.Add(this.lblTituloEvento);
            this.gbEventos.Location = new System.Drawing.Point(12, 152);
            this.gbEventos.Name = "gbEventos";
            this.gbEventos.Size = new System.Drawing.Size(316, 259);
            this.gbEventos.TabIndex = 0;
            this.gbEventos.TabStop = false;
            this.gbEventos.Text = "Informações do Evento:";
            // 
            // lblQtdHoras
            // 
            this.lblQtdHoras.AutoSize = true;
            this.lblQtdHoras.Location = new System.Drawing.Point(181, 74);
            this.lblQtdHoras.Name = "lblQtdHoras";
            this.lblQtdHoras.Size = new System.Drawing.Size(106, 13);
            this.lblQtdHoras.TabIndex = 20;
            this.lblQtdHoras.Text = "Qtd. de horas comp.:";
            // 
            // txbQtdHoras
            // 
            this.txbQtdHoras.Location = new System.Drawing.Point(179, 90);
            this.txbQtdHoras.Name = "txbQtdHoras";
            this.txbQtdHoras.Size = new System.Drawing.Size(121, 20);
            this.txbQtdHoras.TabIndex = 19;
            // 
            // lblCursoEvento
            // 
            this.lblCursoEvento.AutoSize = true;
            this.lblCursoEvento.Location = new System.Drawing.Point(8, 120);
            this.lblCursoEvento.Name = "lblCursoEvento";
            this.lblCursoEvento.Size = new System.Drawing.Size(37, 13);
            this.lblCursoEvento.TabIndex = 18;
            this.lblCursoEvento.Text = "Curso:";
            // 
            // cmbCurso
            // 
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Location = new System.Drawing.Point(9, 136);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(128, 21);
            this.cmbCurso.TabIndex = 17;
            // 
            // lblEventoPrincipal
            // 
            this.lblEventoPrincipal.AutoSize = true;
            this.lblEventoPrincipal.Location = new System.Drawing.Point(176, 27);
            this.lblEventoPrincipal.Name = "lblEventoPrincipal";
            this.lblEventoPrincipal.Size = new System.Drawing.Size(86, 13);
            this.lblEventoPrincipal.TabIndex = 16;
            this.lblEventoPrincipal.Text = "Evento principal:";
            this.lblEventoPrincipal.Visible = false;
            // 
            // cmbEventoPrincipal
            // 
            this.cmbEventoPrincipal.FormattingEnabled = true;
            this.cmbEventoPrincipal.Location = new System.Drawing.Point(179, 44);
            this.cmbEventoPrincipal.Name = "cmbEventoPrincipal";
            this.cmbEventoPrincipal.Size = new System.Drawing.Size(121, 21);
            this.cmbEventoPrincipal.TabIndex = 15;
            this.cmbEventoPrincipal.Visible = false;
            // 
            // dtpHoraFim
            // 
            this.dtpHoraFim.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFim.Location = new System.Drawing.Point(179, 227);
            this.dtpHoraFim.Name = "dtpHoraFim";
            this.dtpHoraFim.Size = new System.Drawing.Size(100, 20);
            this.dtpHoraFim.TabIndex = 14;
            // 
            // dtpDataFim
            // 
            this.dtpDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFim.Location = new System.Drawing.Point(179, 185);
            this.dtpDataFim.Name = "dtpDataFim";
            this.dtpDataFim.Size = new System.Drawing.Size(100, 20);
            this.dtpDataFim.TabIndex = 13;
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicio.Location = new System.Drawing.Point(9, 228);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.Size = new System.Drawing.Size(100, 20);
            this.dtpHoraInicio.TabIndex = 12;
            // 
            // lblDataFim
            // 
            this.lblDataFim.AutoSize = true;
            this.lblDataFim.Location = new System.Drawing.Point(176, 169);
            this.lblDataFim.Name = "lblDataFim";
            this.lblDataFim.Size = new System.Drawing.Size(64, 13);
            this.lblDataFim.TabIndex = 11;
            this.lblDataFim.Text = "Data de fim:";
            // 
            // lblHoraFim
            // 
            this.lblHoraFim.AutoSize = true;
            this.lblHoraFim.Location = new System.Drawing.Point(176, 211);
            this.lblHoraFim.Name = "lblHoraFim";
            this.lblHoraFim.Size = new System.Drawing.Size(64, 13);
            this.lblHoraFim.TabIndex = 9;
            this.lblHoraFim.Text = "Hora do fim:";
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Location = new System.Drawing.Point(6, 211);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(77, 13);
            this.lblHoraInicio.TabIndex = 6;
            this.lblHoraInicio.Text = "Hora de ínicio:";
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Location = new System.Drawing.Point(6, 169);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(77, 13);
            this.lblDataInicio.TabIndex = 5;
            this.lblDataInicio.Text = "Data de ínicio:";
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicio.Location = new System.Drawing.Point(9, 185);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.Size = new System.Drawing.Size(100, 20);
            this.dtpDataInicio.TabIndex = 4;
            // 
            // txbDescricao
            // 
            this.txbDescricao.Location = new System.Drawing.Point(9, 91);
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.Size = new System.Drawing.Size(128, 20);
            this.txbDescricao.TabIndex = 3;
            // 
            // lblDescEvento
            // 
            this.lblDescEvento.AutoSize = true;
            this.lblDescEvento.Location = new System.Drawing.Point(6, 74);
            this.lblDescEvento.Name = "lblDescEvento";
            this.lblDescEvento.Size = new System.Drawing.Size(58, 13);
            this.lblDescEvento.TabIndex = 2;
            this.lblDescEvento.Text = "Descrição:";
            // 
            // txbTituloEvento
            // 
            this.txbTituloEvento.Location = new System.Drawing.Point(9, 44);
            this.txbTituloEvento.Name = "txbTituloEvento";
            this.txbTituloEvento.Size = new System.Drawing.Size(130, 20);
            this.txbTituloEvento.TabIndex = 1;
            // 
            // lblTituloEvento
            // 
            this.lblTituloEvento.AutoSize = true;
            this.lblTituloEvento.Location = new System.Drawing.Point(6, 27);
            this.lblTituloEvento.Name = "lblTituloEvento";
            this.lblTituloEvento.Size = new System.Drawing.Size(89, 13);
            this.lblTituloEvento.TabIndex = 0;
            this.lblTituloEvento.Text = "Título do evento:";
            // 
            // tsCadEventos
            // 
            this.tsCadEventos.AutoSize = false;
            this.tsCadEventos.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsCadEventos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNovoEvento,
            this.tsbSalvarEvento,
            this.tsbDeletarEvento,
            this.tsbAtualizarGrid});
            this.tsCadEventos.Location = new System.Drawing.Point(0, 0);
            this.tsCadEventos.Name = "tsCadEventos";
            this.tsCadEventos.Size = new System.Drawing.Size(687, 35);
            this.tsCadEventos.Stretch = true;
            this.tsCadEventos.TabIndex = 1;
            this.tsCadEventos.Text = "toolStrip1";
            // 
            // tsbNovoEvento
            // 
            this.tsbNovoEvento.AutoSize = false;
            this.tsbNovoEvento.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNovoEvento.Image = global::SisPres.Properties.Resources.add_icon1;
            this.tsbNovoEvento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNovoEvento.Name = "tsbNovoEvento";
            this.tsbNovoEvento.Size = new System.Drawing.Size(29, 32);
            this.tsbNovoEvento.Text = "toolStripButton1";
            this.tsbNovoEvento.Click += new System.EventHandler(this.tsbNovoEvento_Click);
            // 
            // tsbSalvarEvento
            // 
            this.tsbSalvarEvento.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSalvarEvento.Image = global::SisPres.Properties.Resources.Save_icon;
            this.tsbSalvarEvento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalvarEvento.Name = "tsbSalvarEvento";
            this.tsbSalvarEvento.Size = new System.Drawing.Size(23, 32);
            this.tsbSalvarEvento.Text = "toolStripButton2";
            // 
            // tsbDeletarEvento
            // 
            this.tsbDeletarEvento.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDeletarEvento.Image = global::SisPres.Properties.Resources.delete_icon;
            this.tsbDeletarEvento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeletarEvento.Name = "tsbDeletarEvento";
            this.tsbDeletarEvento.Size = new System.Drawing.Size(23, 32);
            this.tsbDeletarEvento.Text = "toolStripButton2";
            // 
            // tsbAtualizarGrid
            // 
            this.tsbAtualizarGrid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAtualizarGrid.Image = global::SisPres.Properties.Resources.refresh_icon;
            this.tsbAtualizarGrid.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAtualizarGrid.Name = "tsbAtualizarGrid";
            this.tsbAtualizarGrid.Size = new System.Drawing.Size(23, 32);
            this.tsbAtualizarGrid.Text = "toolStripButton2";
            // 
            // gbTipoEvento
            // 
            this.gbTipoEvento.Controls.Add(this.rdbEventoMultiplo);
            this.gbTipoEvento.Controls.Add(this.rdbEventoUnico);
            this.gbTipoEvento.Location = new System.Drawing.Point(12, 54);
            this.gbTipoEvento.Name = "gbTipoEvento";
            this.gbTipoEvento.Size = new System.Drawing.Size(316, 43);
            this.gbTipoEvento.TabIndex = 2;
            this.gbTipoEvento.TabStop = false;
            this.gbTipoEvento.Text = "Tipo de Evento:";
            // 
            // rdbEventoMultiplo
            // 
            this.rdbEventoMultiplo.AutoSize = true;
            this.rdbEventoMultiplo.Location = new System.Drawing.Point(179, 19);
            this.rdbEventoMultiplo.Name = "rdbEventoMultiplo";
            this.rdbEventoMultiplo.Size = new System.Drawing.Size(61, 17);
            this.rdbEventoMultiplo.TabIndex = 1;
            this.rdbEventoMultiplo.TabStop = true;
            this.rdbEventoMultiplo.Text = "Múltiplo";
            this.rdbEventoMultiplo.UseVisualStyleBackColor = true;
            this.rdbEventoMultiplo.CheckedChanged += new System.EventHandler(this.rdbEventoMultiplo_CheckedChanged);
            // 
            // rdbEventoUnico
            // 
            this.rdbEventoUnico.AutoSize = true;
            this.rdbEventoUnico.Location = new System.Drawing.Point(10, 19);
            this.rdbEventoUnico.Name = "rdbEventoUnico";
            this.rdbEventoUnico.Size = new System.Drawing.Size(53, 17);
            this.rdbEventoUnico.TabIndex = 0;
            this.rdbEventoUnico.TabStop = true;
            this.rdbEventoUnico.Text = "Único";
            this.rdbEventoUnico.UseVisualStyleBackColor = true;
            this.rdbEventoUnico.CheckedChanged += new System.EventHandler(this.rdbEventoUnico_CheckedChanged);
            // 
            // gbLocalizacao
            // 
            this.gbLocalizacao.Controls.Add(this.lblDescSalaEvento);
            this.gbLocalizacao.Controls.Add(this.txbDescSalaEvento);
            this.gbLocalizacao.Controls.Add(this.lblSalaEvento);
            this.gbLocalizacao.Controls.Add(this.cmbSalaEvento);
            this.gbLocalizacao.Controls.Add(this.cmbAndarEvento);
            this.gbLocalizacao.Controls.Add(this.lblAndarEvento);
            this.gbLocalizacao.Controls.Add(this.cmbBlocoEvento);
            this.gbLocalizacao.Controls.Add(this.lblBlocoEvento);
            this.gbLocalizacao.Location = new System.Drawing.Point(13, 418);
            this.gbLocalizacao.Name = "gbLocalizacao";
            this.gbLocalizacao.Size = new System.Drawing.Size(315, 115);
            this.gbLocalizacao.TabIndex = 3;
            this.gbLocalizacao.TabStop = false;
            this.gbLocalizacao.Text = "Localização Evento:";
            // 
            // lblSalaEvento
            // 
            this.lblSalaEvento.AutoSize = true;
            this.lblSalaEvento.Location = new System.Drawing.Point(7, 67);
            this.lblSalaEvento.Name = "lblSalaEvento";
            this.lblSalaEvento.Size = new System.Drawing.Size(31, 13);
            this.lblSalaEvento.TabIndex = 6;
            this.lblSalaEvento.Text = "Sala:";
            // 
            // cmbSalaEvento
            // 
            this.cmbSalaEvento.FormattingEnabled = true;
            this.cmbSalaEvento.Location = new System.Drawing.Point(10, 83);
            this.cmbSalaEvento.Name = "cmbSalaEvento";
            this.cmbSalaEvento.Size = new System.Drawing.Size(121, 21);
            this.cmbSalaEvento.TabIndex = 5;
            // 
            // cmbAndarEvento
            // 
            this.cmbAndarEvento.FormattingEnabled = true;
            this.cmbAndarEvento.Location = new System.Drawing.Point(178, 36);
            this.cmbAndarEvento.Name = "cmbAndarEvento";
            this.cmbAndarEvento.Size = new System.Drawing.Size(121, 21);
            this.cmbAndarEvento.TabIndex = 4;
            // 
            // lblAndarEvento
            // 
            this.lblAndarEvento.AutoSize = true;
            this.lblAndarEvento.Location = new System.Drawing.Point(178, 20);
            this.lblAndarEvento.Name = "lblAndarEvento";
            this.lblAndarEvento.Size = new System.Drawing.Size(38, 13);
            this.lblAndarEvento.TabIndex = 3;
            this.lblAndarEvento.Text = "Andar:";
            // 
            // cmbBlocoEvento
            // 
            this.cmbBlocoEvento.FormattingEnabled = true;
            this.cmbBlocoEvento.Location = new System.Drawing.Point(10, 37);
            this.cmbBlocoEvento.Name = "cmbBlocoEvento";
            this.cmbBlocoEvento.Size = new System.Drawing.Size(121, 21);
            this.cmbBlocoEvento.TabIndex = 1;
            // 
            // lblBlocoEvento
            // 
            this.lblBlocoEvento.AutoSize = true;
            this.lblBlocoEvento.Location = new System.Drawing.Point(7, 20);
            this.lblBlocoEvento.Name = "lblBlocoEvento";
            this.lblBlocoEvento.Size = new System.Drawing.Size(37, 13);
            this.lblBlocoEvento.TabIndex = 0;
            this.lblBlocoEvento.Text = "Bloco:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(353, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(322, 210);
            this.dataGridView1.TabIndex = 4;
            // 
            // gbEspEvento
            // 
            this.gbEspEvento.Controls.Add(this.rdbSubEvento);
            this.gbEspEvento.Controls.Add(this.rdbPrincipal);
            this.gbEspEvento.Location = new System.Drawing.Point(12, 103);
            this.gbEspEvento.Name = "gbEspEvento";
            this.gbEspEvento.Size = new System.Drawing.Size(316, 43);
            this.gbEspEvento.TabIndex = 5;
            this.gbEspEvento.TabStop = false;
            this.gbEspEvento.Text = "Evento:";
            this.gbEspEvento.Visible = false;
            // 
            // rdbSubEvento
            // 
            this.rdbSubEvento.AutoSize = true;
            this.rdbSubEvento.Location = new System.Drawing.Point(179, 19);
            this.rdbSubEvento.Name = "rdbSubEvento";
            this.rdbSubEvento.Size = new System.Drawing.Size(81, 17);
            this.rdbSubEvento.TabIndex = 1;
            this.rdbSubEvento.TabStop = true;
            this.rdbSubEvento.Text = "Sub-Evento";
            this.rdbSubEvento.UseVisualStyleBackColor = true;
            this.rdbSubEvento.CheckedChanged += new System.EventHandler(this.rdbSubEvento_CheckedChanged);
            // 
            // rdbPrincipal
            // 
            this.rdbPrincipal.AutoSize = true;
            this.rdbPrincipal.Location = new System.Drawing.Point(10, 19);
            this.rdbPrincipal.Name = "rdbPrincipal";
            this.rdbPrincipal.Size = new System.Drawing.Size(65, 17);
            this.rdbPrincipal.TabIndex = 0;
            this.rdbPrincipal.TabStop = true;
            this.rdbPrincipal.Text = "Principal";
            this.rdbPrincipal.UseVisualStyleBackColor = true;
            this.rdbPrincipal.CheckedChanged += new System.EventHandler(this.rdbPrincipal_CheckedChanged);
            // 
            // txbDescSalaEvento
            // 
            this.txbDescSalaEvento.Location = new System.Drawing.Point(178, 83);
            this.txbDescSalaEvento.Name = "txbDescSalaEvento";
            this.txbDescSalaEvento.Size = new System.Drawing.Size(121, 20);
            this.txbDescSalaEvento.TabIndex = 7;
            // 
            // lblDescSalaEvento
            // 
            this.lblDescSalaEvento.AutoSize = true;
            this.lblDescSalaEvento.Location = new System.Drawing.Point(178, 67);
            this.lblDescSalaEvento.Name = "lblDescSalaEvento";
            this.lblDescSalaEvento.Size = new System.Drawing.Size(58, 13);
            this.lblDescSalaEvento.TabIndex = 8;
            this.lblDescSalaEvento.Text = "Descricao:";
            // 
            // FrmMdiCadEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(687, 545);
            this.Controls.Add(this.gbEspEvento);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbLocalizacao);
            this.Controls.Add(this.gbTipoEvento);
            this.Controls.Add(this.tsCadEventos);
            this.Controls.Add(this.gbEventos);
            this.Name = "FrmMdiCadEvento";
            this.Text = "Cadastro de Eventos";
            this.Load += new System.EventHandler(this.FrmMdiCadEvento_Load);
            this.gbEventos.ResumeLayout(false);
            this.gbEventos.PerformLayout();
            this.tsCadEventos.ResumeLayout(false);
            this.tsCadEventos.PerformLayout();
            this.gbTipoEvento.ResumeLayout(false);
            this.gbTipoEvento.PerformLayout();
            this.gbLocalizacao.ResumeLayout(false);
            this.gbLocalizacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbEspEvento.ResumeLayout(false);
            this.gbEspEvento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEventos;
        private System.Windows.Forms.TextBox txbTituloEvento;
        private System.Windows.Forms.Label lblTituloEvento;
        private System.Windows.Forms.DateTimePicker dtpHoraFim;
        private System.Windows.Forms.DateTimePicker dtpDataFim;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.Label lblDataFim;
        private System.Windows.Forms.Label lblHoraFim;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.DateTimePicker dtpDataInicio;
        private System.Windows.Forms.TextBox txbDescricao;
        private System.Windows.Forms.Label lblDescEvento;
        private System.Windows.Forms.Label lblEventoPrincipal;
        private System.Windows.Forms.ComboBox cmbEventoPrincipal;
        private System.Windows.Forms.GroupBox gbTipoEvento;
        private System.Windows.Forms.RadioButton rdbEventoMultiplo;
        private System.Windows.Forms.RadioButton rdbEventoUnico;
        private System.Windows.Forms.GroupBox gbLocalizacao;
        private System.Windows.Forms.Label lblBlocoEvento;
        private System.Windows.Forms.ComboBox cmbBlocoEvento;
        private System.Windows.Forms.ToolStrip tsCadEventos;
        private System.Windows.Forms.Label lblSalaEvento;
        private System.Windows.Forms.ComboBox cmbSalaEvento;
        private System.Windows.Forms.ComboBox cmbAndarEvento;
        private System.Windows.Forms.Label lblAndarEvento;
        private System.Windows.Forms.ToolStripButton tsbNovoEvento;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton tsbSalvarEvento;
        private System.Windows.Forms.ToolStripButton tsbDeletarEvento;
        private System.Windows.Forms.ToolStripButton tsbAtualizarGrid;
        private System.Windows.Forms.GroupBox gbEspEvento;
        private System.Windows.Forms.RadioButton rdbSubEvento;
        private System.Windows.Forms.RadioButton rdbPrincipal;
        private System.Windows.Forms.Label lblCursoEvento;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.Label lblQtdHoras;
        private System.Windows.Forms.TextBox txbQtdHoras;
        private System.Windows.Forms.Label lblDescSalaEvento;
        private System.Windows.Forms.TextBox txbDescSalaEvento;
    }
}