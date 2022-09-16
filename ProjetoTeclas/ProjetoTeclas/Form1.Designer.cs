
namespace ProjetoTeclas
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnInicializar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblControl = new System.Windows.Forms.Label();
            this.lblAlt = new System.Windows.Forms.Label();
            this.lblShift = new System.Windows.Forms.Label();
            this.lblKeyChar = new System.Windows.Forms.Label();
            this.lblKeyCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(89, 75);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(654, 27);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            this.txtNome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyUp);
            // 
            // lblResultado
            // 
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Location = new System.Drawing.Point(89, 121);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(384, 25);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(89, 158);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(654, 27);
            this.textBox2.TabIndex = 2;
            // 
            // btnInicializar
            // 
            this.btnInicializar.Location = new System.Drawing.Point(344, 247);
            this.btnInicializar.Name = "btnInicializar";
            this.btnInicializar.Size = new System.Drawing.Size(129, 50);
            this.btnInicializar.TabIndex = 3;
            this.btnInicializar.Text = "Inicializar";
            this.btnInicializar.UseVisualStyleBackColor = true;
            this.btnInicializar.Click += new System.EventHandler(this.btnInicializar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(249, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Alt";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(391, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Shift";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(545, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "KeyChar";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(702, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "KeyCode";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(89, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Control";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblControl
            // 
            this.lblControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblControl.Location = new System.Drawing.Point(89, 359);
            this.lblControl.Name = "lblControl";
            this.lblControl.Size = new System.Drawing.Size(60, 22);
            this.lblControl.TabIndex = 10;
            this.lblControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAlt
            // 
            this.lblAlt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAlt.Location = new System.Drawing.Point(233, 359);
            this.lblAlt.Name = "lblAlt";
            this.lblAlt.Size = new System.Drawing.Size(60, 22);
            this.lblAlt.TabIndex = 11;
            this.lblAlt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShift
            // 
            this.lblShift.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShift.Location = new System.Drawing.Point(381, 359);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(60, 22);
            this.lblShift.TabIndex = 12;
            this.lblShift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKeyChar
            // 
            this.lblKeyChar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKeyChar.Location = new System.Drawing.Point(545, 359);
            this.lblKeyChar.Name = "lblKeyChar";
            this.lblKeyChar.Size = new System.Drawing.Size(65, 22);
            this.lblKeyChar.TabIndex = 13;
            this.lblKeyChar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKeyCode
            // 
            this.lblKeyCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKeyCode.Location = new System.Drawing.Point(702, 359);
            this.lblKeyCode.Name = "lblKeyCode";
            this.lblKeyCode.Size = new System.Drawing.Size(70, 22);
            this.lblKeyCode.TabIndex = 14;
            this.lblKeyCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.Controls.Add(this.lblKeyCode);
            this.Controls.Add(this.lblKeyChar);
            this.Controls.Add(this.lblShift);
            this.Controls.Add(this.lblAlt);
            this.Controls.Add(this.lblControl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnInicializar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnInicializar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblControl;
        private System.Windows.Forms.Label lblAlt;
        private System.Windows.Forms.Label lblShift;
        private System.Windows.Forms.Label lblKeyChar;
        private System.Windows.Forms.Label lblKeyCode;
    }
}

