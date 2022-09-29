using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Ver
{
    public partial class formCadastro : Form
    {
        public formCadastro()
        {
            InitializeComponent();
        }

        private void formCadastro_Load(object sender, EventArgs e)
        {
            Form1 Cadastro = new Form1();
            Cadastro.Show();
        }

        private void btnTrocar_Click(object sender, EventArgs e)
        {
            String string_conexao = "Server = localhost; Database = Projeto_Imagens; Uid = root; pwd = root";
            MySqlConnection connection = new MySqlConnection(string_conexao);
            MySqlCommand comando_buscar = new MySqlCommand("Select * From Imagens Order By Rand() Limit 1,connection");
            MySqlDataReader meu_reader;
            try
            {
                connection.Open();
                meu_reader = comando_buscar.ExecuteReader();
                while (meu_reader.Read())
                {
                    String nome = meu_reader.GetString("nome");
                    txtNome.Text = nome.ToString();
                    byte[] imagem = (byte[])(meu_reader["imagem"]);
                    if(imagem == null)
                    {
                        pictureBox1.Image = null;
                    }
                    else
                    {
                        MemoryStream mstream = new MemoryStream(imagem);
                        pictureBox1.Image = System.Drawing.Image.FromStream(mstream);
                    }
                    MessageBox.Show("Muito Bom, " + nome.ToString() + "!");
                }
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message.ToString());
            }
            finally
            {
                connection.Close();
            }

        }
    }
}
