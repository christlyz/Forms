
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.picPedestre = new System.Windows.Forms.PictureBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
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
            this.picVermelho.Location = new System.Drawing.Point(490, 12);
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
            this.picAmarelo.Location = new System.Drawing.Point(490, 12);
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
            this.picVerde.Location = new System.Drawing.Point(490, 12);
            this.picVerde.Name = "picVerde";
            this.picVerde.Size = new System.Drawing.Size(140, 188);
            this.picVerde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVerde.TabIndex = 2;
            this.picVerde.TabStop = false;
            this.picVerde.Visible = false;
            // 
            // picCarro
            // 
            this.picCarro.Image = ((System.Drawing.Image)(resources.GetObject("picCarro.Image")));
            this.picCarro.Location = new System.Drawing.Point(-174, 412);
            this.picCarro.Name = "picCarro";
            this.picCarro.Size = new System.Drawing.Size(176, 113);
            this.picCarro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCarro.TabIndex = 3;
            this.picCarro.TabStop = false;
            // 
            // btnComecar
            // 
            this.btnComecar.Location = new System.Drawing.Point(1040, 12);
            this.btnComecar.Name = "btnComecar";
            this.btnComecar.Size = new System.Drawing.Size(112, 45);
            this.btnComecar.TabIndex = 4;
            this.btnComecar.Text = "Começar";
            this.btnComecar.UseVisualStyleBackColor = true;
            this.btnComecar.Click += new System.EventHandler(this.btnComecar_Click);
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(1040, 91);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(112, 45);
            this.btnParar.TabIndex = 5;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // picPedestre
            // 
            this.picPedestre.Image = ((System.Drawing.Image)(resources.GetObject("picPedestre.Image")));
            this.picPedestre.Location = new System.Drawing.Point(533, 561);
            this.picPedestre.Name = "picPedestre";
            this.picPedestre.Size = new System.Drawing.Size(71, 101);
            this.picPedestre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPedestre.TabIndex = 6;
            this.picPedestre.TabStop = false;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(632, 600);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(112, 45);
            this.btnAbrir.TabIndex = 7;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // timer3
            // 
            this.timer3.Interval = 4000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 674);
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox picPedestre;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Timer timer3;
    }
}

