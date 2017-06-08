namespace SisPres
{
    partial class FrmMdiCadUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMdiCadUsuario));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNovoUsuario = new System.Windows.Forms.ToolStripButton();
            this.tsbSalvarUsuario = new System.Windows.Forms.ToolStripButton();
            this.tsbDeletarUsuario = new System.Windows.Forms.ToolStripButton();
            this.tsbAtualizarGrid = new System.Windows.Forms.ToolStripButton();
            this.GbDadosPrincipais = new System.Windows.Forms.GroupBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txbSobrenome = new System.Windows.Forms.TextBox();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.GbDadosLogin = new System.Windows.Forms.GroupBox();
            this.lbl_avisosenha = new System.Windows.Forms.Label();
            this.txbConfSenha = new System.Windows.Forms.TextBox();
            this.lblConfSenha = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.gbPerfil = new System.Windows.Forms.GroupBox();
            this.rdbUsuario = new System.Windows.Forms.RadioButton();
            this.rdbSecretaria = new System.Windows.Forms.RadioButton();
            this.rdbAdministrador = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txbUusario = new System.Windows.Forms.TextBox();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.GbDadosPrincipais.SuspendLayout();
            this.GbDadosLogin.SuspendLayout();
            this.gbPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNovoUsuario,
            this.tsbSalvarUsuario,
            this.tsbDeletarUsuario,
            this.tsbAtualizarGrid});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(896, 35);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNovoUsuario
            // 
            this.tsbNovoUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNovoUsuario.Image = ((System.Drawing.Image)(resources.GetObject("tsbNovoUsuario.Image")));
            this.tsbNovoUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNovoUsuario.Name = "tsbNovoUsuario";
            this.tsbNovoUsuario.Size = new System.Drawing.Size(29, 32);
            this.tsbNovoUsuario.Text = "toolStripButton2";
            this.tsbNovoUsuario.Click += new System.EventHandler(this.tsbNovoUsuario_Click);
            // 
            // tsbSalvarUsuario
            // 
            this.tsbSalvarUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSalvarUsuario.Image = global::SisPres.Properties.Resources.Save_icon;
            this.tsbSalvarUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalvarUsuario.Name = "tsbSalvarUsuario";
            this.tsbSalvarUsuario.Size = new System.Drawing.Size(29, 32);
            this.tsbSalvarUsuario.Text = "toolStripButton1";
            this.tsbSalvarUsuario.Click += new System.EventHandler(this.tsbSalvarUsuario_Click);
            // 
            // tsbDeletarUsuario
            // 
            this.tsbDeletarUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDeletarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeletarUsuario.Image")));
            this.tsbDeletarUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeletarUsuario.Name = "tsbDeletarUsuario";
            this.tsbDeletarUsuario.Size = new System.Drawing.Size(29, 32);
            this.tsbDeletarUsuario.Text = "toolStripButton1";
            this.tsbDeletarUsuario.Click += new System.EventHandler(this.tsbDeletarUsuario_Click);
            // 
            // tsbAtualizarGrid
            // 
            this.tsbAtualizarGrid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAtualizarGrid.Image = ((System.Drawing.Image)(resources.GetObject("tsbAtualizarGrid.Image")));
            this.tsbAtualizarGrid.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAtualizarGrid.Name = "tsbAtualizarGrid";
            this.tsbAtualizarGrid.Size = new System.Drawing.Size(29, 32);
            this.tsbAtualizarGrid.Text = "toolStripButton2";
            this.tsbAtualizarGrid.Click += new System.EventHandler(this.tsbAtualizarGrid_Click_1);
            // 
            // GbDadosPrincipais
            // 
            this.GbDadosPrincipais.Controls.Add(this.txbEmail);
            this.GbDadosPrincipais.Controls.Add(this.lblEmail);
            this.GbDadosPrincipais.Controls.Add(this.txbSobrenome);
            this.GbDadosPrincipais.Controls.Add(this.lblSobrenome);
            this.GbDadosPrincipais.Controls.Add(this.txbNome);
            this.GbDadosPrincipais.Controls.Add(this.lblNome);
            this.GbDadosPrincipais.Location = new System.Drawing.Point(12, 47);
            this.GbDadosPrincipais.Name = "GbDadosPrincipais";
            this.GbDadosPrincipais.Size = new System.Drawing.Size(403, 116);
            this.GbDadosPrincipais.TabIndex = 2;
            this.GbDadosPrincipais.TabStop = false;
            this.GbDadosPrincipais.Text = "Dados Principais:";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(7, 86);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(149, 20);
            this.txbEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblEmail.Location = new System.Drawing.Point(6, 69);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 16);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-Mail:";
            // 
            // txbSobrenome
            // 
            this.txbSobrenome.Location = new System.Drawing.Point(199, 37);
            this.txbSobrenome.Name = "txbSobrenome";
            this.txbSobrenome.Size = new System.Drawing.Size(147, 20);
            this.txbSobrenome.TabIndex = 3;
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblSobrenome.Location = new System.Drawing.Point(196, 18);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(82, 16);
            this.lblSobrenome.TabIndex = 2;
            this.lblSobrenome.Text = "Sobrenome:";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(7, 35);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(149, 20);
            this.txbNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblNome.Location = new System.Drawing.Point(6, 18);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(48, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // GbDadosLogin
            // 
            this.GbDadosLogin.Controls.Add(this.lbl_avisosenha);
            this.GbDadosLogin.Controls.Add(this.txbConfSenha);
            this.GbDadosLogin.Controls.Add(this.lblConfSenha);
            this.GbDadosLogin.Controls.Add(this.txbSenha);
            this.GbDadosLogin.Controls.Add(this.lblSenha);
            this.GbDadosLogin.Controls.Add(this.txbUsuario);
            this.GbDadosLogin.Controls.Add(this.lblUsuario);
            this.GbDadosLogin.Location = new System.Drawing.Point(13, 171);
            this.GbDadosLogin.Name = "GbDadosLogin";
            this.GbDadosLogin.Size = new System.Drawing.Size(402, 81);
            this.GbDadosLogin.TabIndex = 3;
            this.GbDadosLogin.TabStop = false;
            this.GbDadosLogin.Text = "Dados de Login:";
            // 
            // lbl_avisosenha
            // 
            this.lbl_avisosenha.AutoSize = true;
            this.lbl_avisosenha.ForeColor = System.Drawing.Color.Red;
            this.lbl_avisosenha.Location = new System.Drawing.Point(6, 62);
            this.lbl_avisosenha.Name = "lbl_avisosenha";
            this.lbl_avisosenha.Size = new System.Drawing.Size(118, 13);
            this.lbl_avisosenha.TabIndex = 7;
            this.lbl_avisosenha.Text = "*Senhas não conferem!";
            this.lbl_avisosenha.Visible = false;
            // 
            // txbConfSenha
            // 
            this.txbConfSenha.Location = new System.Drawing.Point(252, 39);
            this.txbConfSenha.Name = "txbConfSenha";
            this.txbConfSenha.Size = new System.Drawing.Size(100, 20);
            this.txbConfSenha.TabIndex = 5;
            this.txbConfSenha.UseSystemPasswordChar = true;
            this.txbConfSenha.TextChanged += new System.EventHandler(this.txbConfSenha_TextChanged);
            // 
            // lblConfSenha
            // 
            this.lblConfSenha.AutoSize = true;
            this.lblConfSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblConfSenha.Location = new System.Drawing.Point(249, 20);
            this.lblConfSenha.Name = "lblConfSenha";
            this.lblConfSenha.Size = new System.Drawing.Size(117, 16);
            this.lblConfSenha.TabIndex = 4;
            this.lblConfSenha.Text = "Confirme a Senha:";
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(131, 39);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(100, 20);
            this.txbSenha.TabIndex = 3;
            this.txbSenha.UseSystemPasswordChar = true;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblSenha.Location = new System.Drawing.Point(128, 20);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(50, 16);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha:";
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(8, 39);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(100, 20);
            this.txbUsuario.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblUsuario.Location = new System.Drawing.Point(5, 19);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(58, 16);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuário:";
            // 
            // gbPerfil
            // 
            this.gbPerfil.Controls.Add(this.rdbUsuario);
            this.gbPerfil.Controls.Add(this.rdbSecretaria);
            this.gbPerfil.Controls.Add(this.rdbAdministrador);
            this.gbPerfil.Location = new System.Drawing.Point(13, 258);
            this.gbPerfil.Name = "gbPerfil";
            this.gbPerfil.Size = new System.Drawing.Size(402, 53);
            this.gbPerfil.TabIndex = 4;
            this.gbPerfil.TabStop = false;
            this.gbPerfil.Text = "Perfil:";
            // 
            // rdbUsuario
            // 
            this.rdbUsuario.AutoSize = true;
            this.rdbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.rdbUsuario.Location = new System.Drawing.Point(221, 20);
            this.rdbUsuario.Name = "rdbUsuario";
            this.rdbUsuario.Size = new System.Drawing.Size(73, 20);
            this.rdbUsuario.TabIndex = 2;
            this.rdbUsuario.TabStop = true;
            this.rdbUsuario.Text = "Usuário";
            this.rdbUsuario.UseVisualStyleBackColor = true;
            // 
            // rdbSecretaria
            // 
            this.rdbSecretaria.AutoSize = true;
            this.rdbSecretaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.rdbSecretaria.Location = new System.Drawing.Point(123, 20);
            this.rdbSecretaria.Name = "rdbSecretaria";
            this.rdbSecretaria.Size = new System.Drawing.Size(88, 20);
            this.rdbSecretaria.TabIndex = 1;
            this.rdbSecretaria.TabStop = true;
            this.rdbSecretaria.Text = "Secretaria";
            this.rdbSecretaria.UseVisualStyleBackColor = true;
            // 
            // rdbAdministrador
            // 
            this.rdbAdministrador.AutoSize = true;
            this.rdbAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.rdbAdministrador.Location = new System.Drawing.Point(8, 20);
            this.rdbAdministrador.Name = "rdbAdministrador";
            this.rdbAdministrador.Size = new System.Drawing.Size(109, 20);
            this.rdbAdministrador.TabIndex = 0;
            this.rdbAdministrador.TabStop = true;
            this.rdbAdministrador.Text = "Administrador";
            this.rdbAdministrador.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(8, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // txbUusario
            // 
            this.txbUusario.Location = new System.Drawing.Point(8, 39);
            this.txbUusario.Name = "txbUusario";
            this.txbUusario.Size = new System.Drawing.Size(100, 20);
            this.txbUusario.TabIndex = 1;
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Location = new System.Drawing.Point(446, 47);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.Size = new System.Drawing.Size(430, 265);
            this.dgvUsuario.TabIndex = 5;
            this.dgvUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuario_CellClick);
            // 
            // FrmMdiCadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(896, 324);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.gbPerfil);
            this.Controls.Add(this.GbDadosLogin);
            this.Controls.Add(this.GbDadosPrincipais);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmMdiCadUsuario";
            this.Text = "Cadastro de Usuários";
            this.Load += new System.EventHandler(this.FrmMdiCadUsuario_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.GbDadosPrincipais.ResumeLayout(false);
            this.GbDadosPrincipais.PerformLayout();
            this.GbDadosLogin.ResumeLayout(false);
            this.GbDadosLogin.PerformLayout();
            this.gbPerfil.ResumeLayout(false);
            this.gbPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox GbDadosPrincipais;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.GroupBox GbDadosLogin;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txbSobrenome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.TextBox txbConfSenha;
        private System.Windows.Forms.Label lblConfSenha;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.ToolStripButton tsbSalvarUsuario;
        private System.Windows.Forms.GroupBox gbPerfil;
        private System.Windows.Forms.RadioButton rdbUsuario;
        private System.Windows.Forms.RadioButton rdbSecretaria;
        private System.Windows.Forms.RadioButton rdbAdministrador;
        private System.Windows.Forms.ToolStripButton tsbNovoUsuario;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txbUusario;
        private System.Windows.Forms.Label lbl_avisosenha;
        private System.Windows.Forms.ToolStripButton tsbDeletarUsuario;
        private System.Windows.Forms.ToolStripButton tsbAtualizarGrid;
        private System.Windows.Forms.DataGridView dgvUsuario;

    }
}