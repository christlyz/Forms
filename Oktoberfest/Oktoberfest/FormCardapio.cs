using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Oktoberfest
{
    public partial class FormCardapio : Form
    {
        public FormCardapio()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormBebida bebida = new FormBebida();
            bebida.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormGastronomia gastronomia = new FormGastronomia();
            gastronomia.ShowDialog();
        }
    }
}
