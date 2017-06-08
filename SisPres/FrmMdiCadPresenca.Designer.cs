namespace SisPres
{
    partial class FrmMdiCadPresenca
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
            this.txbMatricula = new System.Windows.Forms.TextBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbInfoAluno = new System.Windows.Forms.GroupBox();
            this.txbTurma = new System.Windows.Forms.TextBox();
            this.lblTurma = new System.Windows.Forms.Label();
            this.txbCurso = new System.Windows.Forms.TextBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.gbInfoEvento = new System.Windows.Forms.GroupBox();
            this.cmbEvento = new System.Windows.Forms.ComboBox();
            this.lblEvento = new System.Windows.Forms.Label();
            this.txbLocal = new System.Windows.Forms.TextBox();
            this.lblLocal = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblPalestrante = new System.Windows.Forms.Label();
            this.gbInfoPresenca = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dtpHora = new System.Windows.Forms.Label();
            this.btnConfPresenca = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbInfoAluno.SuspendLayout();
            this.gbInfoEvento.SuspendLayout();
            this.gbInfoPresenca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbMatricula
            // 
            this.txbMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMatricula.Location = new System.Drawing.Point(38, 33);
            this.txbMatricula.Name = "txbMatricula";
            this.txbMatricula.Size = new System.Drawing.Size(147, 23);
            this.txbMatricula.TabIndex = 1;
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(35, 17);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(55, 13);
            this.lblMatricula.TabIndex = 2;
            this.lblMatricula.Text = "Matrícula:";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(144, 34);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(126, 20);
            this.txbNome.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(143, 18);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(21, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 122);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gbInfoAluno
            // 
            this.gbInfoAluno.Controls.Add(this.lblCurso);
            this.gbInfoAluno.Controls.Add(this.txbCurso);
            this.gbInfoAluno.Controls.Add(this.lblTurma);
            this.gbInfoAluno.Controls.Add(this.pictureBox1);
            this.gbInfoAluno.Controls.Add(this.txbTurma);
            this.gbInfoAluno.Controls.Add(this.lblNome);
            this.gbInfoAluno.Controls.Add(this.txbNome);
            this.gbInfoAluno.Location = new System.Drawing.Point(25, 88);
            this.gbInfoAluno.Name = "gbInfoAluno";
            this.gbInfoAluno.Size = new System.Drawing.Size(293, 183);
            this.gbInfoAluno.TabIndex = 5;
            this.gbInfoAluno.TabStop = false;
            this.gbInfoAluno.Text = "Informações do aluno";
            // 
            // txbTurma
            // 
            this.txbTurma.Location = new System.Drawing.Point(144, 86);
            this.txbTurma.Name = "txbTurma";
            this.txbTurma.Size = new System.Drawing.Size(126, 20);
            this.txbTurma.TabIndex = 5;
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Location = new System.Drawing.Point(143, 70);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(40, 13);
            this.lblTurma.TabIndex = 6;
            this.lblTurma.Text = "Turma:";
            // 
            // txbCurso
            // 
            this.txbCurso.Location = new System.Drawing.Point(146, 136);
            this.txbCurso.Name = "txbCurso";
            this.txbCurso.Size = new System.Drawing.Size(124, 20);
            this.txbCurso.TabIndex = 7;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(144, 120);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(37, 13);
            this.lblCurso.TabIndex = 8;
            this.lblCurso.Text = "Curso:";
            // 
            // gbInfoEvento
            // 
            this.gbInfoEvento.Controls.Add(this.lblPalestrante);
            this.gbInfoEvento.Controls.Add(this.textBox2);
            this.gbInfoEvento.Controls.Add(this.lblLocal);
            this.gbInfoEvento.Controls.Add(this.txbLocal);
            this.gbInfoEvento.Controls.Add(this.lblEvento);
            this.gbInfoEvento.Controls.Add(this.cmbEvento);
            this.gbInfoEvento.Location = new System.Drawing.Point(344, 88);
            this.gbInfoEvento.Name = "gbInfoEvento";
            this.gbInfoEvento.Size = new System.Drawing.Size(208, 183);
            this.gbInfoEvento.TabIndex = 6;
            this.gbInfoEvento.TabStop = false;
            this.gbInfoEvento.Text = "Informações do evento";
            // 
            // cmbEvento
            // 
            this.cmbEvento.FormattingEnabled = true;
            this.cmbEvento.Location = new System.Drawing.Point(40, 35);
            this.cmbEvento.Name = "cmbEvento";
            this.cmbEvento.Size = new System.Drawing.Size(121, 21);
            this.cmbEvento.TabIndex = 0;
            // 
            // lblEvento
            // 
            this.lblEvento.AutoSize = true;
            this.lblEvento.Location = new System.Drawing.Point(37, 19);
            this.lblEvento.Name = "lblEvento";
            this.lblEvento.Size = new System.Drawing.Size(44, 13);
            this.lblEvento.TabIndex = 1;
            this.lblEvento.Text = "Evento:";
            // 
            // txbLocal
            // 
            this.txbLocal.Location = new System.Drawing.Point(40, 86);
            this.txbLocal.Name = "txbLocal";
            this.txbLocal.Size = new System.Drawing.Size(121, 20);
            this.txbLocal.TabIndex = 2;
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Location = new System.Drawing.Point(40, 71);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(36, 13);
            this.lblLocal.TabIndex = 3;
            this.lblLocal.Text = "Local:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(40, 135);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 4;
            // 
            // lblPalestrante
            // 
            this.lblPalestrante.AutoSize = true;
            this.lblPalestrante.Location = new System.Drawing.Point(40, 119);
            this.lblPalestrante.Name = "lblPalestrante";
            this.lblPalestrante.Size = new System.Drawing.Size(63, 13);
            this.lblPalestrante.TabIndex = 5;
            this.lblPalestrante.Text = "Palestrante:";
            // 
            // gbInfoPresenca
            // 
            this.gbInfoPresenca.Controls.Add(this.btnConfPresenca);
            this.gbInfoPresenca.Controls.Add(this.dtpHora);
            this.gbInfoPresenca.Controls.Add(this.dateTimePicker1);
            this.gbInfoPresenca.Controls.Add(this.txbMatricula);
            this.gbInfoPresenca.Controls.Add(this.lblMatricula);
            this.gbInfoPresenca.Location = new System.Drawing.Point(25, 16);
            this.gbInfoPresenca.Name = "gbInfoPresenca";
            this.gbInfoPresenca.Size = new System.Drawing.Size(527, 66);
            this.gbInfoPresenca.TabIndex = 7;
            this.gbInfoPresenca.TabStop = false;
            this.gbInfoPresenca.Text = "Informações da presença";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(216, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(71, 23);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2016, 6, 1, 10, 28, 0, 0);
            // 
            // dtpHora
            // 
            this.dtpHora.AutoSize = true;
            this.dtpHora.Location = new System.Drawing.Point(213, 17);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(33, 13);
            this.dtpHora.TabIndex = 4;
            this.dtpHora.Text = "Hora:";
            // 
            // btnConfPresenca
            // 
            this.btnConfPresenca.AutoEllipsis = true;
            this.btnConfPresenca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfPresenca.Location = new System.Drawing.Point(344, 23);
            this.btnConfPresenca.Name = "btnConfPresenca";
            this.btnConfPresenca.Size = new System.Drawing.Size(144, 33);
            this.btnConfPresenca.TabIndex = 5;
            this.btnConfPresenca.Text = "Confirmar Entrada";
            this.btnConfPresenca.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 289);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(527, 127);
            this.dataGridView1.TabIndex = 8;
            // 
            // FrmMdiCadPresenca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(578, 428);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbInfoPresenca);
            this.Controls.Add(this.gbInfoEvento);
            this.Controls.Add(this.gbInfoAluno);
            this.Name = "FrmMdiCadPresenca";
            this.Text = "Cadastro de presença";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbInfoAluno.ResumeLayout(false);
            this.gbInfoAluno.PerformLayout();
            this.gbInfoEvento.ResumeLayout(false);
            this.gbInfoEvento.PerformLayout();
            this.gbInfoPresenca.ResumeLayout(false);
            this.gbInfoPresenca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txbMatricula;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox gbInfoAluno;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.TextBox txbCurso;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.TextBox txbTurma;
        private System.Windows.Forms.GroupBox gbInfoEvento;
        private System.Windows.Forms.Label lblPalestrante;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.TextBox txbLocal;
        private System.Windows.Forms.Label lblEvento;
        private System.Windows.Forms.ComboBox cmbEvento;
        private System.Windows.Forms.GroupBox gbInfoPresenca;
        private System.Windows.Forms.Button btnConfPresenca;
        private System.Windows.Forms.Label dtpHora;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}