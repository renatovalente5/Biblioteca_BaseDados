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
    public partial class Form2 : Form
    {
        private SqlConnection cn;
        private int currentLivro;
        private int currentLivroAdded = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM Biblioteca.Livro ORDER BY titulo";
            cmd.Connection = cn;
            SqlDataReader reader = cmd.ExecuteReader();
            listBox1.Items.Clear();

            while (reader.Read())
            {
                Livro l = new Livro();
                l.ISBN = (String)reader["ISBN"];
                l.Titulo = (String)reader["titulo"];
                l.Ano = (int)reader["ano"];
                l.Id_editora = (int)reader["id_editora"];
                l.Categoria = (String)reader["categoria"];
                listBox1.Items.Add(l);
            }
            cn.Close();
            buttonRemove.Visible = false;
        }

        public static SqlConnection getSGBDConnection()
        {
            return new SqlConnection("data source= localhost;integrated security=true;initial catalog=Biblioteca");
            //return new SqlConnection("Data Source = tcp:mednat.ieeta.pt\\SQLSERVER,8101; Initial Catalog = p1g2; uid = p1g2;" + "password = Sqlgang.99");
            //return new SqlConnection("data source= localhost;integrated security=true;");// initial catalog=Biblioteca");
        }
        private bool verifySGBDConnection()
        {
            if (cn == null)
                cn = getSGBDConnection();

            if (cn.State != ConnectionState.Open)
                cn.Open();

            return cn.State == ConnectionState.Open;
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;

            if (textSearch.Text == "")
            {
                Form2_Load(sender, e);
            }
            else
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "SELECT * FROM Biblioteca.Livro WHERE titulo LIKE '%" + textSearch.Text + "%'";
                cmd.Connection = cn;
                SqlDataReader reader = cmd.ExecuteReader();
                listBox1.Items.Clear();

                while (reader.Read())
                {
                    Livro l = new Livro();
                    l.ISBN = (String)reader["ISBN"];
                    l.Titulo = (String)reader["titulo"];
                    l.Ano = (int)reader["ano"];
                    l.Id_editora = (int)reader["id_editora"];
                    l.Categoria = (String)reader["categoria"];
                    listBox1.Items.Add(l);
                }
                cn.Close();

                currentLivro = 0;
                //ShowLivro();
                //ShowButtons();
            }
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0 | currentLivro < 0 | listBox1.SelectedIndex == -1) return;

            currentLivro = listBox1.SelectedIndex;
            if (currentLivro < 0)
            {
                MessageBox.Show("Please select a Book");
                return;
            }
            Livro livro = new Livro();
            livro = (Livro)listBox1.Items[currentLivro];
            listBox2.Items.Add(livro.Titulo);
            currentLivroAdded++;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count == 0 | currentLivroAdded < 0 | listBox2.SelectedIndex == -1) return;
            currentLivroAdded = listBox2.SelectedIndex;
            listBox2.Items.RemoveAt(currentLivroAdded);
            currentLivroAdded--;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonAdd.Visible = true;
            buttonRemove.Visible = false;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex == -1)
            {
                buttonAdd.Visible = true;
                buttonRemove.Visible = false;
            }
            else
            {
                buttonAdd.Visible = false;
                buttonRemove.Visible = true;
            }
        }
    }
}
