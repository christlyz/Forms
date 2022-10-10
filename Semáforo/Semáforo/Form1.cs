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
            movimento.Enabled = true;

            picVermelho.Visible = false;
            picAmarelo.Visible = false;
            picVerde.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
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
            amareloBotao.Enabled = false;
            movimento.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(picAmarelo.Visible == true)
            {
                picCarro.Top -= 2;
            }
            if(picVerde.Visible == true)
            {
                picCarro.Top -= 3;
            }
            
            if(picVermelho.Visible == true)
            {
                picPedestre.Left += 1;
            }
            if(picCarro.Location.Y < 0)
            {
                picCarro.Location = new Point(560, 891);
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            amareloBotao.Enabled = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
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
            amareloCartao.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picVerde.Visible = true;
        }

        private void amareloCartao_Tick(object sender, EventArgs e)
        {
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
            Form2 formulario2 = new Form2();
            formulario2.ShowDialog();
        }
    }
}
