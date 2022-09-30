using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oktoberfest
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            FormInformacoes info = new FormInformacoes();
            info.ShowDialog();
        }

        private void btnIngressos_Click(object sender, EventArgs e)
        {
            FormIngressos ingressos = new FormIngressos();
            ingressos.ShowDialog();
        }

        private void btnCardapio_Click(object sender, EventArgs e)
        {
            FormCardapio cardapio = new FormCardapio();
            cardapio.ShowDialog();
        }

        private void btnPogramacao_Click(object sender, EventArgs e)
        {
            FormProgramacao programacao = new FormProgramacao();
            programacao.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormSujestoes sujestoes = new FormSujestoes();
            sujestoes.ShowDialog();
        }
    }
}
