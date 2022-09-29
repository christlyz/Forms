using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Conectando
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = "server=localhost; database = turma; user id=root; password = root; port=3306";
                con.Open();

                MySqlCommand objCmd = new MySqlCommand("insert into Aluno (id_Aluno, nome, telefone, email) values (null, ?, ?, ?)", con);
                
                objCmd.Parameters.Add("@nome", MySqlDbType.VarChar, 45).Value = txtNome.Text;
                objCmd.Parameters.Add("@telefone", MySqlDbType.VarChar, 14).Value = txtFone.Text;
                objCmd.Parameters.Add("@email", MySqlDbType.VarChar, 45).Value = txtEmail.Text;

                objCmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não conectou" + erro);
            }
        }
    }
}