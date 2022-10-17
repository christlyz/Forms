using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semáforo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComecar_Click(object sender, EventArgs e)
        {
            // botão começar simulação
            movimento.Enabled = true;

            picVermelho.Visible = false;
            picAmarelo.Visible = false;
            picVerde.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // inicia amarelo botão
            if(picVerde.Visible == true)
            {
                picVermelho.Visible = false;
                picAmarelo.Visible = true;
                picVerde.Visible = false;
            }
            vermelhoBotao.Enabled = true;
            amareloBotao.Enabled = false;
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            // botão parar simulação
            amareloBotao.Enabled = false;
            movimento.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // movimento dos objetos
            /*if (picVerde.Visible == true)
            {
                picCarro.Top -= 3;
            }

            else if (picVermelho.Visible == true)
            {
                picPedestre.Left += 1;
            }
            else if(picAmarelo.Visible == true && picCarro.Location.Y >= 233)
            {
                picCarro.Top -= 3;
            }
            else
            {
                picCarro.Top -= 2;
            }
            */
            if (picCarro.Location.Y < -200)
            {
                picCarro.Location = new Point(490, 668);
            }
            if (picAmarelo.Visible)
                picCarro.Top -= 2;

            if (picVerde.Visible)
                picCarro.Top -= 3;

            if (picVermelho.Visible)
            {
                picPedestre.Left += 3;

                picCarro.Top -= (picCarro.Location.Y != 373) ? 3 : 0;

            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            // simula botão
            amareloBotao.Enabled = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            // inicia verde botão
            picVerde.Visible = true;
            if(picVerde.Visible == true)
            {
                picVermelho.Visible = false;
                picAmarelo.Visible = false;
            }
            verdeBotao.Enabled = false;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            // inicia vermelho botão
            if (picAmarelo.Visible == true)
            {
                picVermelho.Visible = true;
                picAmarelo.Visible = false;
                picVerde.Visible = false;
            }

            verdeBotao.Enabled = true;
            vermelhoBotao.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // simula cartao
            amareloCartao.Enabled = true;
        }

        private void amareloCartao_Tick(object sender, EventArgs e)
        {
            // inicia amarelo cartao
            if (picVerde.Visible == true)
            {
                picVermelho.Visible = false;
                picAmarelo.Visible = true;
                picVerde.Visible = false;
            }
            vermelhoCartao.Enabled = true;
            amareloCartao.Enabled = false;
        }

        private void vermelhoCartao_Tick(object sender, EventArgs e)
        {
            // inicia vermelho cartao
            if (picAmarelo.Visible == true)
            {
                picVermelho.Visible = true;
                picAmarelo.Visible = false;
                picVerde.Visible = false;
            }

            verdeBotao.Enabled = true;
            vermelhoCartao.Enabled = false;
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            // abre simulação cruzammento
            Form2 formulario2 = new Form2();
            formulario2.ShowDialog();
        }
    }
}
