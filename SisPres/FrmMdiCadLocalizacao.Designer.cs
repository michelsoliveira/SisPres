namespace SisPres
{
    partial class FrmMdiCadLocalizacao
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
            this.tcLocalizacao = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gbInfoSalas = new System.Windows.Forms.GroupBox();
            this.lblSalaNum = new System.Windows.Forms.Label();
            this.txbNomeSala = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.cmbAndar = new System.Windows.Forms.ComboBox();
            this.lblAndar = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gbInfoAndar = new System.Windows.Forms.GroupBox();
            this.lblBloco = new System.Windows.Forms.Label();
            this.cmbBloco = new System.Windows.Forms.ComboBox();
            this.lblAndarDesc = new System.Windows.Forms.Label();
            this.txbAndarDesc = new System.Windows.Forms.TextBox();
            this.txbAndarNome = new System.Windows.Forms.TextBox();
            this.lblAndarNome = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tcLocalizacao.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbInfoSalas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbInfoAndar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tcLocalizacao
            // 
            this.tcLocalizacao.Controls.Add(this.tabPage1);
            this.tcLocalizacao.Controls.Add(this.tabPage2);
            this.tcLocalizacao.Controls.Add(this.tabPage3);
            this.tcLocalizacao.Location = new System.Drawing.Point(12, 12);
            this.tcLocalizacao.Name = "tcLocalizacao";
            this.tcLocalizacao.SelectedIndex = 0;
            this.tcLocalizacao.Size = new System.Drawing.Size(566, 330);
            this.tcLocalizacao.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.gbInfoSalas);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(558, 304);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sala";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.gbInfoAndar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(558, 304);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Andar";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(558, 304);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Bloco";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gbInfoSalas
            // 
            this.gbInfoSalas.Controls.Add(this.lblAndar);
            this.gbInfoSalas.Controls.Add(this.cmbAndar);
            this.gbInfoSalas.Controls.Add(this.lbl);
            this.gbInfoSalas.Controls.Add(this.textBox2);
            this.gbInfoSalas.Controls.Add(this.txbNomeSala);
            this.gbInfoSalas.Controls.Add(this.lblSalaNum);
            this.gbInfoSalas.Location = new System.Drawing.Point(51, 40);
            this.gbInfoSalas.Name = "gbInfoSalas";
            this.gbInfoSalas.Size = new System.Drawing.Size(445, 84);
            this.gbInfoSalas.TabIndex = 0;
            this.gbInfoSalas.TabStop = false;
            this.gbInfoSalas.Text = "Informações de Sala:";
            // 
            // lblSalaNum
            // 
            this.lblSalaNum.AutoSize = true;
            this.lblSalaNum.Location = new System.Drawing.Point(17, 29);
            this.lblSalaNum.Name = "lblSalaNum";
            this.lblSalaNum.Size = new System.Drawing.Size(47, 13);
            this.lblSalaNum.TabIndex = 0;
            this.lblSalaNum.Text = "Número:";
            // 
            // txbNomeSala
            // 
            this.txbNomeSala.Location = new System.Drawing.Point(20, 46);
            this.txbNomeSala.Name = "txbNomeSala";
            this.txbNomeSala.Size = new System.Drawing.Size(100, 20);
            this.txbNomeSala.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(148, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(148, 28);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(58, 13);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "Descrição:";
            // 
            // cmbAndar
            // 
            this.cmbAndar.FormattingEnabled = true;
            this.cmbAndar.Location = new System.Drawing.Point(275, 43);
            this.cmbAndar.Name = "cmbAndar";
            this.cmbAndar.Size = new System.Drawing.Size(106, 21);
            this.cmbAndar.TabIndex = 4;
            // 
            // lblAndar
            // 
            this.lblAndar.AutoSize = true;
            this.lblAndar.Location = new System.Drawing.Point(272, 27);
            this.lblAndar.Name = "lblAndar";
            this.lblAndar.Size = new System.Drawing.Size(38, 13);
            this.lblAndar.TabIndex = 5;
            this.lblAndar.Text = "Andar:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 97);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // gbInfoAndar
            // 
            this.gbInfoAndar.Controls.Add(this.lblBloco);
            this.gbInfoAndar.Controls.Add(this.cmbBloco);
            this.gbInfoAndar.Controls.Add(this.lblAndarDesc);
            this.gbInfoAndar.Controls.Add(this.txbAndarDesc);
            this.gbInfoAndar.Controls.Add(this.txbAndarNome);
            this.gbInfoAndar.Controls.Add(this.lblAndarNome);
            this.gbInfoAndar.Location = new System.Drawing.Point(59, 43);
            this.gbInfoAndar.Name = "gbInfoAndar";
            this.gbInfoAndar.Size = new System.Drawing.Size(445, 84);
            this.gbInfoAndar.TabIndex = 1;
            this.gbInfoAndar.TabStop = false;
            this.gbInfoAndar.Text = "Informações de Andar:";
            // 
            // lblBloco
            // 
            this.lblBloco.AutoSize = true;
            this.lblBloco.Location = new System.Drawing.Point(272, 27);
            this.lblBloco.Name = "lblBloco";
            this.lblBloco.Size = new System.Drawing.Size(37, 13);
            this.lblBloco.TabIndex = 5;
            this.lblBloco.Text = "Bloco:";
            // 
            // cmbBloco
            // 
            this.cmbBloco.FormattingEnabled = true;
            this.cmbBloco.Location = new System.Drawing.Point(275, 43);
            this.cmbBloco.Name = "cmbBloco";
            this.cmbBloco.Size = new System.Drawing.Size(106, 21);
            this.cmbBloco.TabIndex = 4;
            // 
            // lblAndarDesc
            // 
            this.lblAndarDesc.AutoSize = true;
            this.lblAndarDesc.Location = new System.Drawing.Point(148, 28);
            this.lblAndarDesc.Name = "lblAndarDesc";
            this.lblAndarDesc.Size = new System.Drawing.Size(58, 13);
            this.lblAndarDesc.TabIndex = 3;
            this.lblAndarDesc.Text = "Descrição:";
            // 
            // txbAndarDesc
            // 
            this.txbAndarDesc.Location = new System.Drawing.Point(148, 45);
            this.txbAndarDesc.Name = "txbAndarDesc";
            this.txbAndarDesc.Size = new System.Drawing.Size(100, 20);
            this.txbAndarDesc.TabIndex = 2;
            // 
            // txbAndarNome
            // 
            this.txbAndarNome.Location = new System.Drawing.Point(20, 46);
            this.txbAndarNome.Name = "txbAndarNome";
            this.txbAndarNome.Size = new System.Drawing.Size(100, 20);
            this.txbAndarNome.TabIndex = 1;
            // 
            // lblAndarNome
            // 
            this.lblAndarNome.AutoSize = true;
            this.lblAndarNome.Location = new System.Drawing.Point(17, 29);
            this.lblAndarNome.Name = "lblAndarNome";
            this.lblAndarNome.Size = new System.Drawing.Size(47, 13);
            this.lblAndarNome.TabIndex = 0;
            this.lblAndarNome.Text = "Número:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 210);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(546, 88);
            this.dataGridView2.TabIndex = 2;
            // 
            // FrmMdiCadLocalizacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(590, 354);
            this.Controls.Add(this.tcLocalizacao);
            this.Name = "FrmMdiCadLocalizacao";
            this.Text = "Cadatro de Locais";
            this.tcLocalizacao.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.gbInfoSalas.ResumeLayout(false);
            this.gbInfoSalas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbInfoAndar.ResumeLayout(false);
            this.gbInfoAndar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcLocalizacao;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gbInfoSalas;
        private System.Windows.Forms.Label lblAndar;
        private System.Windows.Forms.ComboBox cmbAndar;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txbNomeSala;
        private System.Windows.Forms.Label lblSalaNum;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbInfoAndar;
        private System.Windows.Forms.Label lblBloco;
        private System.Windows.Forms.ComboBox cmbBloco;
        private System.Windows.Forms.Label lblAndarDesc;
        private System.Windows.Forms.TextBox txbAndarDesc;
        private System.Windows.Forms.TextBox txbAndarNome;
        private System.Windows.Forms.Label lblAndarNome;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}