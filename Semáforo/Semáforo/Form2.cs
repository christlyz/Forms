using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Semáforo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void movimento_Tick(object sender, EventArgs e)
        {
            
            if (picAmarelo1.Visible == true)
            {
                picCarroPreto.Top -= 2;
            }
            else if (picVerde1.Visible == true)
            {
                picCarroPreto.Top -= 3;
            }
            else if (picVermelho1.Visible == true)
            {
                picPedestre.Left += 1;
            }

            if(picAmarelo2.Visible == true)
            {
                picCarroBranco.Left -= 2;
            }
            else if(picVerde2.Visible == true)
            {
                picCarroBranco.Left -= 3;
            }
            else if(picVermelho2.Visible == true)
            {
                picCadeirante.Top += 1;
            }
        }

        private void f(object sender, EventArgs e)
        {

        }

        private void amareloBotao_Tick(object sender, EventArgs e)
        {
            if(picVerde1.Visible == true)
            {
                picVermelho1.Visible = false;
                picAmarelo1.Visible = true;
                picVerde1.Visible = false;
            }
            else if(picVerde2.Visible == true)
            {
                picVermelho2.Visible = false;
                picAmarelo2.Visible = true;
                picVerde2.Visible = false;
            }
            vermelhoBotao.Enabled = true;
            amareloBotao.Enabled = false;
        }
        private void verdeBotao_Tick(object sender, EventArgs e)
        {
            if(picVermelho1.Visible == true)
            {
                picVermelho1.Visible = false;
                picAmarelo1.Visible = false;
                picVerde1.Visible = true;
            }
            else if(picVermelho2.Visible == true)
            {
                picVermelho2.Visible = false;
                picAmarelo2.Visible = false;
                picVerde2.Visible = true;
            }

            verdeBotao.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            amareloBotao.Enabled = true;
        }

        private void vermelhoBotao_Tick(object sender, EventArgs e)
        {
            if(picAmarelo1.Visible == true)
            {
                picVermelho1.Visible = true;
                picAmarelo1.Visible = false;
                picVerde1.Visible = false;
            }
            if(picAmarelo2.Visible == true)
            {
                picVermelho2.Visible = true;
                picAmarelo2.Visible = false;
                picVerde2.Visible = false;
            }

            verdeBotao.Enabled = true;
            vermelhoBotao.Enabled = false;
        }

        private void btnComecar_Click(object sender, EventArgs e)
        {
            picVerde1.Visible = false;
            picVerde2.Visible = true;

            picAmarelo1.Visible = false;
            picAmarelo2.Visible = false;

            picVermelho1.Visible = true;
            picVermelho2.Visible = false;

            movimento.Enabled = true;
        }
    }
}
