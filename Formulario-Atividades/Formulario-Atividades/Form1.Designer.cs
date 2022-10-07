
namespace Formulario_Atividades
{
    partial class form_Cadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnJogar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(373, 267);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(10, 332);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(373, 22);
            this.txtNome.TabIndex = 2;
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(135, 360);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(112, 51);
            this.btnJogar.TabIndex = 3;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(394, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // form_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 450);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "form_Cadastro";
            this.Text = "Form Cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
    }
}

