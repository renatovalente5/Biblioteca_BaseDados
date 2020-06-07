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
    public partial class Form4 : Form
    {
        private SqlConnection cn;
        private int currentLivro;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = " SELECT li.ISBN, li.titulo, li.ano, li.id_editora, ed.nome_editora , li.categoria, COUNT(li.titulo) as countTitulos " +
                         " FROM Biblioteca.Livro as li  " +
                         "                                         JOIN Biblioteca.Editora as ed ON li.id_editora = ed.id_editora " +
                         " GROUP BY li.ISBN, li.titulo, li.ano, li.id_editora, ed.nome_editora, li.categoria ";
            cmd.Connection = cn;
            SqlDataReader reader = cmd.ExecuteReader();
            listBox1.Items.Clear();

            while (reader.Read())
            {
                Emprestimo l = new Emprestimo();
                l.ISBN = (String)reader["ISBN"];
                l.Titulo = (String)reader["titulo"];
                l.Ano = (int)reader["ano"];
                l.Id_editora = (int)reader["id_editora"];
                if (reader["categoria"].ToString() != "")
                    l.Categoria = (String)reader["categoria"];
                l.CountTilulos = (int)reader["countTitulos"];
                l.Nome_editora = (String)reader["nome_editora"];
                //l.Estado = (String)reader["estado"];
                //l.Cota = (String)reader["cota"];
                //l.Numero_exemplar = (int)reader["numero_exemplar"];
                listBox1.Items.Add(l);
            }
            listBox1.Sorted = true;
            cn.Close();
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
                Form4_Load(sender, e);
            }
            else
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = " SELECT li.ISBN, li.titulo, li.ano, li.id_editora, ed.nome_editora , li.categoria, COUNT(li.titulo) as countTitulos " +
                             " FROM Biblioteca.Livro as li " +
                             "                                         JOIN Biblioteca.Editora as ed ON li.id_editora = ed.id_editora " +
                             " WHERE li.titulo LIKE @varSearch " +
                             " GROUP BY li.ISBN, li.titulo, li.ano, li.id_editora, ed.nome_editora, li.categoria ";
                cmd.Parameters.AddWithValue("@varSearch", "%" + textSearch.Text + "%");
                cmd.Connection = cn;
                SqlDataReader reader = cmd.ExecuteReader();
                listBox1.Items.Clear();

                while (reader.Read())
                {
                    Emprestimo l = new Emprestimo();
                    l.ISBN = (String)reader["ISBN"];
                    l.Titulo = (String)reader["titulo"];
                    l.Ano = (int)reader["ano"];
                    l.Id_editora = (int)reader["id_editora"];
                    if (reader["categoria"].ToString() != "")
                        l.Categoria = (String)reader["categoria"];
                    l.CountTilulos = (int)reader["countTitulos"];
                    l.Nome_editora = (String)reader["nome_editora"];
                    //l.Estado = (String)reader["estado"];
                    //l.Cota = (String)reader["cota"];
                    //l.Numero_exemplar = (int)reader["numero_exemplar"];
                    listBox1.Items.Add(l);
                }
                cn.Close();
                listBox1.Sorted = true;
                currentLivro = 0;
                //ShowLivro();
                //ShowButtons();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentLivro = listBox1.SelectedIndex;
            if (listBox1.Items.Count == 0 || currentLivro < 0) return;
            Emprestimo livro = new Emprestimo();
            livro = (Emprestimo)listBox1.Items[currentLivro];

            cn = getSGBDConnection();

            if (!verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand("SELECT * FROM BIBLIOTECA.listarExemplaresDeUmLivro(@ISBN)", cn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ISBN", livro.ISBN);
            cmd.Connection = cn;
            SqlDataReader reader = cmd.ExecuteReader();
            listBox2.Items.Clear();

            while (reader.Read())
            {
                Emprestimo em = new Emprestimo();
                em.ISBN = (String)reader["ISBN"];
                if (reader["data_chegada"].ToString() != "")
                    em.Data_chegada = (DateTime)reader["data_chegada"];

                //em.Data_chegada = ((DateTime?)reader["data_chegada"]) == null ? DateTime.Parse("11/11/2020") : (DateTime)reader["data_chegada"];
                //em.Id_editora = (int)reader["id_editora"];
                //em.Categoria = (String)reader["categoria"];
                //em.CountTilulos = (int)reader["countTitulos"];
                //em.Nome_editora = (String)reader["nome_editora"];
                //fazer data de aquisição?? no Livro
                em.Estado = (String)reader["estado"];
                em.Cota = (String)reader["cota"];
                em.Numero_exemplar = (int)reader["numero_exemplar"];
                em.N_emprestimo = (int)reader["n_emprestimo"];
                listBox2.Items.Add(em);
            }

            cn.Close();
            ContarLivrosDisponiveis(livro.ISBN);
            PossoRemover(livro.ISBN);
            //ShowLivro();
        }

        private void PossoRemover(string isbn)
        {
            if (!verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand("SELECT BIBLIOTECA.CheckRemoveLivro(@ISBN)", cn);
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@ISBN", SqlDbType.VarChar).Value=isbn;
            cmd.Connection = cn;
            bool remove = (bool)cmd.ExecuteScalar();
            if (remove)
                buttonRemoveLivro.Show();
            else
                buttonRemoveLivro.Hide();
        }

        private void ContarLivrosDisponiveis(string iSBN)
        {
            //currentLivro = listBox1.SelectedIndex;
            //if (listBox1.Items.Count == 0 | currentLivro < 0) return;
            //Livro livro = new Livro();
            //livro = (Livro)listBox1.Items[currentLivro];

            cn = getSGBDConnection();

            if (!verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand("SELECT * FROM BIBLIOTECA.ContarLivrosDisponiveis(@ISBN)", cn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ISBN", iSBN);
            cmd.Connection = cn;
            SqlDataReader reader = cmd.ExecuteReader();

            textBoxDisponiveis.Text = "0";

            while (reader.Read())
            {
                Emprestimo em = new Emprestimo();
                
                em.ISBN = (String)reader["ISBN"];
                em.CountTilulos = (int)reader["Disponiveis"];
                textBoxDisponiveis.Text = em.CountTilulos.ToString();
            }
            
            cn.Close();
        }

        //public void ShowLivro()
        //{
        //    currentLivro = listBox1.SelectedIndex;
        //    if (listBox1.Items.Count == 0 | currentLivro < 0) return;
        //    Livro livro = new Livro();
        //    livro = (Livro)listBox1.Items[currentLivro];
        //    textBoxDisponiveis.Text = livro.CountTilulos.ToString();
        //}

        private void buttonAddLivros_Click(object sender, EventArgs e)
        {
            var form5 = new Form5();
            form5.Show();
        }

        private void buttonRemoveLivro_Click(object sender, EventArgs e)
        {
            currentLivro = listBox1.SelectedIndex;
            if (listBox1.Items.Count == 0 || currentLivro < 0)
            {
                MessageBox.Show("Escolhe um livro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Emprestimo livro = new Emprestimo();
            livro = (Emprestimo)listBox1.Items[currentLivro];

            if (!verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "DELETE Biblioteca.Livro WHERE ISBN=@isbn ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@isbn", livro.ISBN);
            cmd.Connection = cn;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to delete livro in database. \n ERROR MESSAGE: \n" + ex.Message);
            }
            finally
            {
                MessageBox.Show("Livro removido com sucesso", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                cn.Close();
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            currentLivro = listBox1.SelectedIndex;
            if (listBox1.Items.Count == 0 || currentLivro < 0)
            {
                MessageBox.Show("Escolhe um livro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Emprestimo livro = new Emprestimo();
            livro = (Emprestimo)listBox1.Items[currentLivro];
            var form6 = new Form6(livro.ISBN);
            form6.Show();
        }
    }
}
