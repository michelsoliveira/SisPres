namespace SisPres
{
    partial class FrmMdiCadLocal
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
            this.txbLocalSala = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAtualizarLocal = new System.Windows.Forms.ToolStripButton();
            this.tsbDeletarLocal = new System.Windows.Forms.ToolStripButton();
            this.lblLocalSala = new System.Windows.Forms.Label();
            this.tsbNovoLocal = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbLocalSala
            // 
            this.txbLocalSala.Location = new System.Drawing.Point(12, 69);
            this.txbLocalSala.Name = "txbLocalSala";
            this.txbLocalSala.Size = new System.Drawing.Size(100, 20);
            this.txbLocalSala.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNovoLocal,
            this.tsbAtualizarLocal,
            this.tsbDeletarLocal});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(473, 34);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAtualizarLocal
            // 
            this.tsbAtualizarLocal.AutoSize = false;
            this.tsbAtualizarLocal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAtualizarLocal.ForeColor = System.Drawing.SystemColors.Control;
            this.tsbAtualizarLocal.Image = global::SisPres.Properties.Resources.Save_icon;
            this.tsbAtualizarLocal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAtualizarLocal.Name = "tsbAtualizarLocal";
            this.tsbAtualizarLocal.Size = new System.Drawing.Size(30, 30);
            this.tsbAtualizarLocal.Text = "toolStripButton1";
            // 
            // tsbDeletarLocal
            // 
            this.tsbDeletarLocal.AutoSize = false;
            this.tsbDeletarLocal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDeletarLocal.Image = global::SisPres.Properties.Resources.delete_icon;
            this.tsbDeletarLocal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeletarLocal.Name = "tsbDeletarLocal";
            this.tsbDeletarLocal.Size = new System.Drawing.Size(29, 29);
            this.tsbDeletarLocal.Text = "toolStripButton1";
            // 
            // lblLocalSala
            // 
            this.lblLocalSala.AutoSize = true;
            this.lblLocalSala.Location = new System.Drawing.Point(12, 50);
            this.lblLocalSala.Name = "lblLocalSala";
            this.lblLocalSala.Size = new System.Drawing.Size(31, 13);
            this.lblLocalSala.TabIndex = 2;
            this.lblLocalSala.Text = "Sala:";
            // 
            // tsbNovoLocal
            // 
            this.tsbNovoLocal.AutoSize = false;
            this.tsbNovoLocal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsbNovoLocal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tsbNovoLocal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNovoLocal.Image = global::SisPres.Properties.Resources.new_user_icon1;
            this.tsbNovoLocal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNovoLocal.Name = "tsbNovoLocal";
            this.tsbNovoLocal.Size = new System.Drawing.Size(30, 30);
            this.tsbNovoLocal.Text = "toolStripButton1";
            // 
            // FrmMdiCadLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(473, 261);
            this.Controls.Add(this.lblLocalSala);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txbLocalSala);
            this.Name = "FrmMdiCadLocal";
            this.Text = "Cadastro de Locais";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbLocalSala;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAtualizarLocal;
        private System.Windows.Forms.ToolStripButton tsbDeletarLocal;
        private System.Windows.Forms.Label lblLocalSala;
        private System.Windows.Forms.ToolStripButton tsbNovoLocal;
    }
}