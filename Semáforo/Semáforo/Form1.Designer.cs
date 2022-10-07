
namespace Semáforo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picVermelho = new System.Windows.Forms.PictureBox();
            this.picAmarelo = new System.Windows.Forms.PictureBox();
            this.picVerde = new System.Windows.Forms.PictureBox();
            this.picCarro = new System.Windows.Forms.PictureBox();
            this.btnComecar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.amareloBotao = new System.Windows.Forms.Timer(this.components);
            this.movimento = new System.Windows.Forms.Timer(this.components);
            this.picPedestre = new System.Windows.Forms.PictureBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.verdeBotao = new System.Windows.Forms.Timer(this.components);
            this.vermelhoBotao = new System.Windows.Forms.Timer(this.components);
            this.btnAbreCartao = new System.Windows.Forms.Button();
            this.amareloCartao = new System.Windows.Forms.Timer(this.components);
            this.vermelhoCartao = new System.Windows.Forms.Timer(this.components);
            this.verdeCartao = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picVermelho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAmarelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPedestre)).BeginInit();
            this.SuspendLayout();
            // 
            // picVermelho
            // 
            this.picVermelho.Image = ((System.Drawing.Image)(resources.GetObject("picVermelho.Image")));
            this.picVermelho.Location = new System.Drawing.Point(750, 12);
            this.picVermelho.Name = "picVermelho";
            this.picVermelho.Size = new System.Drawing.Size(140, 188);
            this.picVermelho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVermelho.TabIndex = 0;
            this.picVermelho.TabStop = false;
            this.picVermelho.Visible = false;
            // 
            // picAmarelo
            // 
            this.picAmarelo.Image = ((System.Drawing.Image)(resources.GetObject("picAmarelo.Image")));
            this.picAmarelo.Location = new System.Drawing.Point(750, 12);
            this.picAmarelo.Name = "picAmarelo";
            this.picAmarelo.Size = new System.Drawing.Size(140, 188);
            this.picAmarelo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAmarelo.TabIndex = 1;
            this.picAmarelo.TabStop = false;
            this.picAmarelo.Visible = false;
            // 
            // picVerde
            // 
            this.picVerde.Image = ((System.Drawing.Image)(resources.GetObject("picVerde.Image")));
            this.picVerde.Location = new System.Drawing.Point(750, 12);
            this.picVerde.Name = "picVerde";
            this.picVerde.Size = new System.Drawing.Size(140, 188);
            this.picVerde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVerde.TabIndex = 2;
            this.picVerde.TabStop = false;
            this.picVerde.Visible = false;
            // 
            // picCarro
            // 
            this.picCarro.BackColor = System.Drawing.Color.Transparent;
            this.picCarro.Image = ((System.Drawing.Image)(resources.GetObject("picCarro.Image")));
            this.picCarro.Location = new System.Drawing.Point(560, 891);
            this.picCarro.Name = "picCarro";
            this.picCarro.Size = new System.Drawing.Size(140, 177);
            this.picCarro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCarro.TabIndex = 3;
            this.picCarro.TabStop = false;
            // 
            // btnComecar
            // 
            this.btnComecar.Location = new System.Drawing.Point(1309, 12);
            this.btnComecar.Name = "btnComecar";
            this.btnComecar.Size = new System.Drawing.Size(112, 45);
            this.btnComecar.TabIndex = 4;
            this.btnComecar.Text = "Começar";
            this.btnComecar.UseVisualStyleBackColor = true;
            this.btnComecar.Click += new System.EventHandler(this.btnComecar_Click);
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(1309, 91);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(112, 45);
            this.btnParar.TabIndex = 5;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // amareloBotao
            // 
            this.amareloBotao.Interval = 5000;
            this.amareloBotao.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // movimento
            // 
            this.movimento.Interval = 1;
            this.movimento.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // picPedestre
            // 
            this.picPedestre.BackColor = System.Drawing.Color.Transparent;
            this.picPedestre.Image = ((System.Drawing.Image)(resources.GetObject("picPedestre.Image")));
            this.picPedestre.Location = new System.Drawing.Point(354, 230);
            this.picPedestre.Name = "picPedestre";
            this.picPedestre.Size = new System.Drawing.Size(71, 101);
            this.picPedestre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPedestre.TabIndex = 6;
            this.picPedestre.TabStop = false;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(331, 154);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(112, 45);
            this.btnAbrir.TabIndex = 7;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // verdeBotao
            // 
            this.verdeBotao.Interval = 10000;
            this.verdeBotao.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // vermelhoBotao
            // 
            this.vermelhoBotao.Interval = 3000;
            this.vermelhoBotao.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // btnAbreCartao
            // 
            this.btnAbreCartao.Location = new System.Drawing.Point(331, 75);
            this.btnAbreCartao.Name = "btnAbreCartao";
            this.btnAbreCartao.Size = new System.Drawing.Size(112, 61);
            this.btnAbreCartao.TabIndex = 8;
            this.btnAbreCartao.Text = "Abrir com Cartão";
            this.btnAbreCartao.UseVisualStyleBackColor = true;
            this.btnAbreCartao.Click += new System.EventHandler(this.button1_Click);
            // 
            // amareloCartao
            // 
            this.amareloCartao.Interval = 5000;
            this.amareloCartao.Tick += new System.EventHandler(this.amareloCartao_Tick);
            // 
            // vermelhoCartao
            // 
            this.vermelhoCartao.Interval = 3000;
            this.vermelhoCartao.Tick += new System.EventHandler(this.vermelhoCartao_Tick);
            // 
            // verdeCartao
            // 
            this.verdeCartao.Interval = 15000;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 894);
            this.Controls.Add(this.btnAbreCartao);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.picPedestre);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnComecar);
            this.Controls.Add(this.picCarro);
            this.Controls.Add(this.picVerde);
            this.Controls.Add(this.picAmarelo);
            this.Controls.Add(this.picVermelho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picVermelho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAmarelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPedestre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picVermelho;
        private System.Windows.Forms.PictureBox picAmarelo;
        private System.Windows.Forms.PictureBox picVerde;
        private System.Windows.Forms.PictureBox picCarro;
        private System.Windows.Forms.Button btnComecar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Timer amareloBotao;
        private System.Windows.Forms.Timer movimento;
        private System.Windows.Forms.PictureBox picPedestre;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Timer verdeBotao;
        private System.Windows.Forms.Timer vermelhoBotao;
        private System.Windows.Forms.Button btnAbreCartao;
        private System.Windows.Forms.Timer amareloCartao;
        private System.Windows.Forms.Timer vermelhoCartao;
        private System.Windows.Forms.Timer verdeCartao;
    }
}

