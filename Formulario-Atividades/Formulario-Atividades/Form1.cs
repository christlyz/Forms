using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_Atividades
{
    public partial class form_Cadastro : Form
    {
        public form_Cadastro()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_Cadastro cadastro = new form_Cadastro();
            cadastro.Show();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            string string_conexao = "server = localhost; database = sorteio; Uid = root;";
            MySqlConnection conexao = new MySqlConnection(string_conexao);
            MySqlCommand comando_busca = new MySqlCommand("Select * From Imagens Order By Rand() limit1,conexao");
            MySqlDataReader meu_reader;
            try
            {
                conexao.Open();
                meu_reader = comando_busca.ExecuteReader();
                while (meu_reader.Read())
                {
                    String nome = meu_reader.GetString("nome");
                    txtNome.Text = nome.ToString();

                    byte[] imagem = (byte[])(meu_reader["foto"]);
                    if(imagem == null)
                    {
                        pictureBox1.Image = null;
                    }
                    else
                    {
                        MemoryStream mstream = new MemoryStream(imagem);
                        pictureBox1.Image = System.Drawing.Image.FromStream(mstream);
                    }
                    MessageBox.Show("Parabéns " + nome.ToString() + "!");
                }
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message.ToString());
            }
            finally
            {
            }
        }
    }
}
