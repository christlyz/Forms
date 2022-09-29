using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto_Ver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "JPG Files(*.jpg) | *.jpg | PNG Files(*.png) | *.png | All Files(*.*) | *.*";

            if(file.ShowDialog() == DialogResult.OK)
            {
                String imagem = file.FileName.ToString();
                txtImagens.Text = imagem;
                pictureBox1.ImageLocation = imagem;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            byte[] imagem_byte = null;
            FileStream fStream = new FileStream(this.txtImagens.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fStream);
            imagem_byte = br.ReadBytes((int)fStream.Length);
            String sintax = "Insert Into Imagens(nome, imagem) values (@nome, @imagem)";
            string conexao = "Server=localhost; Database = Projeto_Imagens; User id = root; pwd = root";
            MySqlConnection connection = new MySqlConnection(conexao);
            MySqlCommand comando_inserir = new MySqlCommand(sintax, connection);
            MySqlDataReader meu_reader;
            try
            {
                connection.Open();
                comando_inserir.Parameters.Add(new MySqlParameter("@imagem", imagem_byte));
                meu_reader = comando_inserir.ExecuteReader();
                MessageBox.Show("Imagem Salva!!");
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
