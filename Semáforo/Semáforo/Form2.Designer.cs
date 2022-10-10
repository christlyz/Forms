
namespace Semáforo
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.picVerde1 = new System.Windows.Forms.PictureBox();
            this.picAmarelo1 = new System.Windows.Forms.PictureBox();
            this.picVermelho1 = new System.Windows.Forms.PictureBox();
            this.picAmarelo2 = new System.Windows.Forms.PictureBox();
            this.picVermelho2 = new System.Windows.Forms.PictureBox();
            this.picCarroPreto = new System.Windows.Forms.PictureBox();
            this.picCarroBranco = new System.Windows.Forms.PictureBox();
            this.picCadeirante = new System.Windows.Forms.PictureBox();
            this.picVerde2 = new System.Windows.Forms.PictureBox();
            this.btnParar = new System.Windows.Forms.Button();
            this.movimento = new System.Windows.Forms.Timer(this.components);
            this.verdeBotao = new System.Windows.Forms.Timer(this.components);
            this.amareloBotao = new System.Windows.Forms.Timer(this.components);
            this.vermelhoBotao = new System.Windows.Forms.Timer(this.components);
            this.verdeCartao = new System.Windows.Forms.Timer(this.components);
            this.amareloCartao = new System.Windows.Forms.Timer(this.components);
            this.vermelhoCartao = new System.Windows.Forms.Timer(this.components);
            this.picPedestre = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnComecar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picVerde1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAmarelo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVermelho1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAmarelo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVermelho2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarroPreto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarroBranco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCadeirante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVerde2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPedestre)).BeginInit();
            this.SuspendLayout();
            // 
            // picVerde1
            // 
            this.picVerde1.Image = ((System.Drawing.Image)(resources.GetObject("picVerde1.Image")));
            this.picVerde1.Location = new System.Drawing.Point(513, 456);
            this.picVerde1.Name = "picVerde1";
            this.picVerde1.Size = new System.Drawing.Size(101, 54);
            this.picVerde1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVerde1.TabIndex = 5;
            this.picVerde1.TabStop = false;
            this.picVerde1.Visible = false;
            // 
            // picAmarelo1
            // 
            this.picAmarelo1.Image = ((System.Drawing.Image)(resources.GetObject("picAmarelo1.Image")));
            this.picAmarelo1.Location = new System.Drawing.Point(513, 456);
            this.picAmarelo1.Name = "picAmarelo1";
            this.picAmarelo1.Size = new System.Drawing.Size(101, 54);
            this.picAmarelo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAmarelo1.TabIndex = 4;
            this.picAmarelo1.TabStop = false;
            this.picAmarelo1.Visible = false;
            // 
            // picVermelho1
            // 
            this.picVermelho1.Image = ((System.Drawing.Image)(resources.GetObject("picVermelho1.Image")));
            this.picVermelho1.Location = new System.Drawing.Point(513, 456);
            this.picVermelho1.Name = "picVermelho1";
            this.picVermelho1.Size = new System.Drawing.Size(101, 54);
            this.picVermelho1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVermelho1.TabIndex = 3;
            this.picVermelho1.TabStop = false;
            this.picVermelho1.Visible = false;
            // 
            // picAmarelo2
            // 
            this.picAmarelo2.Image = ((System.Drawing.Image)(resources.GetObject("picAmarelo2.Image")));
            this.picAmarelo2.Location = new System.Drawing.Point(973, 150);
            this.picAmarelo2.Name = "picAmarelo2";
            this.picAmarelo2.Size = new System.Drawing.Size(101, 54);
            this.picAmarelo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAmarelo2.TabIndex = 7;
            this.picAmarelo2.TabStop = false;
            this.picAmarelo2.Visible = false;
            // 
            // picVermelho2
            // 
            this.picVermelho2.Image = ((System.Drawing.Image)(resources.GetObject("picVermelho2.Image")));
            this.picVermelho2.Location = new System.Drawing.Point(973, 150);
            this.picVermelho2.Name = "picVermelho2";
            this.picVermelho2.Size = new System.Drawing.Size(101, 54);
            this.picVermelho2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVermelho2.TabIndex = 6;
            this.picVermelho2.TabStop = false;
            this.picVermelho2.Visible = false;
            // 
            // picCarroPreto
            // 
            this.picCarroPreto.BackColor = System.Drawing.Color.Transparent;
            this.picCarroPreto.Image = ((System.Drawing.Image)(resources.GetObject("picCarroPreto.Image")));
            this.picCarroPreto.Location = new System.Drawing.Point(695, 888);
            this.picCarroPreto.Name = "picCarroPreto";
            this.picCarroPreto.Size = new System.Drawing.Size(140, 177);
            this.picCarroPreto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCarroPreto.TabIndex = 9;
            this.picCarroPreto.TabStop = false;
            // 
            // picCarroBranco
            // 
            this.picCarroBranco.Image = ((System.Drawing.Image)(resources.GetObject("picCarroBranco.Image")));
            this.picCarroBranco.Location = new System.Drawing.Point(1427, 310);
            this.picCarroBranco.Name = "picCarroBranco";
            this.picCarroBranco.Size = new System.Drawing.Size(222, 109);
            this.picCarroBranco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCarroBranco.TabIndex = 10;
            this.picCarroBranco.TabStop = false;
            // 
            // picCadeirante
            // 
            this.picCadeirante.Image = ((System.Drawing.Image)(resources.GetObject("picCadeirante.Image")));
            this.picCadeirante.Location = new System.Drawing.Point(1080, 150);
            this.picCadeirante.Name = "picCadeirante";
            this.picCadeirante.Size = new System.Drawing.Size(104, 94);
            this.picCadeirante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCadeirante.TabIndex = 11;
            this.picCadeirante.TabStop = false;
            // 
            // picVerde2
            // 
            this.picVerde2.Image = ((System.Drawing.Image)(resources.GetObject("picVerde2.Image")));
            this.picVerde2.Location = new System.Drawing.Point(973, 150);
            this.picVerde2.Name = "picVerde2";
            this.picVerde2.Size = new System.Drawing.Size(101, 54);
            this.picVerde2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVerde2.TabIndex = 12;
            this.picVerde2.TabStop = false;
            this.picVerde2.Visible = false;
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(1327, 53);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(94, 29);
            this.btnParar.TabIndex = 14;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            // 
            // movimento
            // 
            this.movimento.Interval = 1;
            this.movimento.Tick += new System.EventHandler(this.movimento_Tick);
            // 
            // verdeBotao
            // 
            this.verdeBotao.Tick += new System.EventHandler(this.verdeBotao_Tick);
            // 
            // amareloBotao
            // 
            this.amareloBotao.Interval = 5000;
            this.amareloBotao.Tick += new System.EventHandler(this.amareloBotao_Tick);
            // 
            // vermelhoBotao
            // 
            this.vermelhoBotao.Interval = 3000;
            this.vermelhoBotao.Tick += new System.EventHandler(this.vermelhoBotao_Tick);
            // 
            // picPedestre
            // 
            this.picPedestre.Image = ((System.Drawing.Image)(resources.GetObject("picPedestre.Image")));
            this.picPedestre.Location = new System.Drawing.Point(513, 541);
            this.picPedestre.Name = "picPedestre";
            this.picPedestre.Size = new System.Drawing.Size(92, 94);
            this.picPedestre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPedestre.TabIndex = 15;
            this.picPedestre.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(510, 660);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 51);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnComecar
            // 
            this.btnComecar.Location = new System.Drawing.Point(1327, 12);
            this.btnComecar.Name = "btnComecar";
            this.btnComecar.Size = new System.Drawing.Size(94, 29);
            this.btnComecar.TabIndex = 17;
            this.btnComecar.Text = "Começar";
            this.btnComecar.UseVisualStyleBackColor = true;
            this.btnComecar.Click += new System.EventHandler(this.btnComecar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1433, 894);
            this.Controls.Add(this.btnComecar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picPedestre);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.picVerde1);
            this.Controls.Add(this.picVerde2);
            this.Controls.Add(this.picCadeirante);
            this.Controls.Add(this.picCarroBranco);
            this.Controls.Add(this.picCarroPreto);
            this.Controls.Add(this.picAmarelo2);
            this.Controls.Add(this.picVermelho2);
            this.Controls.Add(this.picAmarelo1);
            this.Controls.Add(this.picVermelho1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picVerde1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAmarelo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVermelho1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAmarelo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVermelho2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarroPreto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarroBranco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCadeirante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVerde2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPedestre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picVerde1;
        private System.Windows.Forms.PictureBox picAmarelo1;
        private System.Windows.Forms.PictureBox picVermelho1;
        private System.Windows.Forms.PictureBox picAmarelo2;
        private System.Windows.Forms.PictureBox picVermelho2;
        private System.Windows.Forms.PictureBox picCarroPreto;
        private System.Windows.Forms.PictureBox picCarroBranco;
        private System.Windows.Forms.PictureBox picCadeirante;
        private System.Windows.Forms.PictureBox picVerde2;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Timer movimento;
        private System.Windows.Forms.Timer verdeBotao;
        private System.Windows.Forms.Timer amareloBotao;
        private System.Windows.Forms.Timer vermelhoBotao;
        private System.Windows.Forms.Timer verdeCartao;
        private System.Windows.Forms.Timer amareloCartao;
        private System.Windows.Forms.Timer vermelhoCartao;
        private System.Windows.Forms.PictureBox picPedestre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnComecar;
    }
}