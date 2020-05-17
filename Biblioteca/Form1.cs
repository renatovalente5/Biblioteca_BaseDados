using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Form1 : Form
    {
        private SqlConnection cn;
        private int currentPessoa;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cn = getSGBDConnection();

            if (!verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand("SELECT * FROM Pessoa", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            listBox1.Items.Clear();

            while (reader.Read())
            {
                Pessoa p = new Pessoa();
                p.Id = (int) reader["id"];
                p.First_name = reader["first_name"].ToString();
                p.Last_name = reader["last_name"].ToString();
                p.Data_nascimento = (DateTime) reader["_data_nascimento"];
                p.Telefone = (int) reader["telefone"];
                listBox1.Items.Add(p);
            }

            cn.Close();


            currentPessoa = 0;
            ShowPessoa();
        }

        private SqlConnection getSGBDConnection()
        {
            return new SqlConnection("Server=tcp:mednat.ieeta.pt\\SQLSERVER,8101;Database=Biblioteca;User Id=p1g2;Password=Sqlgang.99;");

        }
        private bool verifySGBDConnection()
        {
            if (cn == null)
                cn = getSGBDConnection();

            if (cn.State != ConnectionState.Open)
                cn.Open();

            return cn.State == ConnectionState.Open;
        }

        public void ShowPessoa()
        {
            if (listBox1.Items.Count == 0 | currentPessoa < 0) return;
            Pessoa pessoa = new Pessoa();
            pessoa = (Pessoa)listBox1.Items[currentPessoa];
            textID.Text = pessoa.Id.ToString();
            textFirstName.Text = pessoa.First_name;
            textLastName.Text = pessoa.Last_name;
            textDataNascimento.Text = pessoa.Data_nascimento.ToString();
            textTelefone.Text = pessoa.Telefone.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                currentPessoa = listBox1.SelectedIndex;
                ShowPessoa();
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textID_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private void textFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textTelefone_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
