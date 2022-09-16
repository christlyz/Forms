using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTeclas
{
    public partial class Form1 : Form
    {
        private int qtdeKeyPress = 0;
        private int qtdeKeyDown = 0;
        private int qtdeKeyUp = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            qtdeKeyPress++;
            MostrarResultado();
            //MessageBox.Show("Evento KeyPress");
            lblKeyChar.Text = (e.KeyChar.ToString());
            //if (e.KeyChar == 'A' || e.KeyChar == 'a')
                //MessageBox.Show("O usuário digitou a letra A");
        }
        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            qtdeKeyDown++;
            MostrarResultado();
            //MessageBox.Show("Evento KeyDown");
            lblKeyCode.Text = e.Control.ToString();
            lblControl.Text = e.Control.ToString();
            lblAlt.Text = e.Alt.ToString();
            lblShift.Text = e.Shift.ToString();
            if (e.Control && e.Alt && e.KeyCode.ToString() == "X")
                MessageBox.Show("pressionou Control + Alt + X");
        }

        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
            qtdeKeyUp++;
            MostrarResultado();
            //MessageBox.Show("Evento KeyUp");
        }
        private void MostrarResultado()
        {
        lblResultado.Text = "KeyPress: " + qtdeKeyPress.ToString() + 
            "KeyDown: " + qtdeKeyDown.ToString() +
            "KeyUp: " + qtdeKeyUp.ToString();
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnInicializar_Click(object sender, EventArgs e)
        {
            Inicializar();
        }
        private void Inicializar() {
            txtNome.Clear();
            qtdeKeyPress = 0;
            qtdeKeyDown = 0;
            qtdeKeyUp = 0;

            lblControl.Text = null;
            lblAlt.Text = null;
            lblShift.Text = String.Empty;

            lblKeyChar.Text = "";
            lblKeyCode.Text = "";
        }
    }
}
