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
            //timer1.Enabled = true;
            timer2.Enabled = true;

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
            if(picAmarelo.Visible == true)
            {
                picVermelho.Visible = true;
                picAmarelo.Visible = false;
                picVerde.Visible = false;
            }

            timer3.Enabled = true;
            timer1.Enabled = false;
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(picAmarelo.Visible == true)
            {
                picCarro.Left += 2;
            }
            if(picVerde.Visible == true)
            {
                picCarro.Left += 3;
            }
            
            if(picVermelho.Visible == true)
            {
                picPedestre.Top -= 1;
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            picVerde.Visible = false;
            picAmarelo.Visible = true;
            timer1.Enabled = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            picVerde.Visible = true;
            if(picVerde.Visible == true)
            {

            picVermelho.Visible = false;
            picAmarelo.Visible = false;
            }
        }
    }
}
