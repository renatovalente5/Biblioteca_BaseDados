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
    public partial class Form5 : Form
    {
        private SqlConnection cn;
        private int currentLivro;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            HideCreateAutor();
            HideCreateEditora();
            HideCreateLivro();

            String[] categorias = new String[] { "Action", "Adventure", "Animation", "Comedy", "Crime", "Drama", "Ficção" };
            comboBoxCategoria.Items.AddRange(categorias);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxAutores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAutores.Items.Count == 0 | comboBoxAutores.SelectedIndex == -1) return;

            currentLivro = comboBoxAutores.SelectedIndex;

            Pessoa pessoa = new Pessoa();
            pessoa = (Pessoa)comboBoxAutores.Items[currentLivro];
            textBoxIDPessoa.Text = pessoa.Id.ToString();
        }

        private void comboBoxNomeEditora_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxNomeEditora.Items.Count == 0 | comboBoxNomeEditora.SelectedIndex == -1) return;

            currentLivro = comboBoxNomeEditora.SelectedIndex;

            Editora editora = new Editora();
            editora = (Editora)comboBoxNomeEditora.Items[currentLivro];
            textBoxIdEditora.Text = editora.Id_editora.ToString();
        }

        private void comboBoxNomeEditora_Click(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;

            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandText = " SELECT DISTINCT e.nome_editora, e.id_editora " +
                               " FROM Biblioteca.Editora as e " +
                               " ORDER BY e.nome_editora, e.id_editora ";
            cmd2.Connection = cn;
            SqlDataReader reader2 = cmd2.ExecuteReader();
            comboBoxNomeEditora.Items.Clear();

            while (reader2.Read())
            {
                Editora editora = new Editora();
                editora.Nome_editora = (String)reader2["nome_editora"];
                editora.Id_editora = (int)reader2["id_editora"];
                comboBoxNomeEditora.Items.Add(editora);
            }
            //comboBoxAutores.Sorted = true;
            cn.Close();

        }

        private void comboBoxAutores_Click(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = " SELECT DISTINCT p.first_name, p.last_name, a.id_autor " +
                              " FROM Biblioteca.Autor as a JOIN Biblioteca.Pessoa as p ON p.id = a.id_autor " +
                              " ORDER BY p.first_name, p.last_name";
            cmd.Connection = cn;
            SqlDataReader reader = cmd.ExecuteReader();
            comboBoxAutores.Items.Clear();

            while (reader.Read())
            {
                Pessoa p = new Pessoa();
                p.First_name = (String)reader["first_name"];
                p.Last_name = (String)reader["last_name"];
                p.Id = (int)reader["id_autor"];
                comboBoxAutores.Items.Add(p);
            }
            //comboBoxAutores.Sorted = true;
            cn.Close();
        }

        private void buttonAddEditora_Click(object sender, EventArgs e)
        {
            ShowCreateEditora();
        }

        private void ShowCreateEditora()
        {
            //labelCreateIdEditora.Show();
            labelCreateEditoraNome.Show();
            labelCreateEndercoEditora.Show();
            labelCreateTelefoneEditora.Show();
            textBoxCreateNomeEditora.Show();
            textBoxCreateEditoraEndereco.Show();
            textBoxCreateEditoraTelefone.Show();
            buttonAddCreateEditora.Show();
        }

        private void buttonAddCreateEditora_Click(object sender, EventArgs e)
        {
            HideCreateEditora();
            //Falta Adicionar a Editora à BD e atualizar o ComboBox
            if (!verifySGBDConnection())
                return;

            int rows = 0;

            if (textBoxCreateNomeEditora.Text == "")
                MessageBox.Show("Adiciona nome da editora", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                SqlCommand cmd = new SqlCommand("BIBLIOTECA.CreateEditora", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = textBoxCreateNomeEditora.Text;
                if (textBoxCreateEditoraEndereco.Text != "")
                    cmd.Parameters.Add("@morada", SqlDbType.VarChar).Value = textBoxCreateEditoraEndereco.Text;
                if (textBoxCreateEditoraTelefone.Text != "")
                    cmd.Parameters.Add("@telefone", SqlDbType.Decimal).Value = Decimal.Parse(textBoxCreateEditoraTelefone.Text);
                cmd.Connection = cn;
                try
                {
                    rows = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Failed to create editora in database. \n ERROR MESSAGE: \n" + ex.Message);
                }
                finally
                {
                    if (rows == 1)
                        MessageBox.Show("Create OK");
                    else
                        MessageBox.Show("Create NOT OK");

                    cn.Close();

                    comboBoxNomeEditora_Click(sender, e);
                }
            }

        }
        private void HideCreateEditora()
        {
            //labelCreateIdEditora.Hide();
            labelCreateEditoraNome.Hide();
            labelCreateEndercoEditora.Hide();
            labelCreateTelefoneEditora.Hide();
            textBoxCreateNomeEditora.Hide();
            textBoxCreateEditoraEndereco.Hide();
            textBoxCreateEditoraTelefone.Hide();
            buttonAddCreateEditora.Hide();
        }
        private void HideCreateLivro()
        {
            labelCreateISBN.Hide();
            label2.Hide();
            labelCreateAno.Hide();
            labelNomeEditora.Hide();
            labelIdEditora.Hide();
            labelCategoria.Hide();
            labelAutor.Hide();
            label1.Hide();
            textBoxCreateISBN.Hide();
            textBoxCreateTitulo.Hide();
            textBoxCreateAno.Hide();
            comboBoxNomeEditora.Hide();
            textBoxIdEditora.Hide();
            comboBoxCategoria.Hide();
            comboBoxAutores.Hide();
            textBoxIDPessoa.Hide();
            buttonAddLivro.Hide();
        }

        private void buttonAddAutor_Click(object sender, EventArgs e)
        {
            ShowCreateAutor();
        }

        private void ShowCreateAutor()
        {
            //labelCreateIdAutor.Show();
            labelCreateNomeAutor.Show();
            labelCreateApelidoAutor.Show();
            labelCreateEnderecoAutor.Show();
            labelCreateTelefoneAutor.Show();
            textBoxCreateNomeAutor.Show();
            textBoxCreateApelidoAutor.Show();
            textBoxCreateDataAutor.Show();
            textBoxCreateTelefoneAutor.Show();
            buttonAddCreateAutor.Show();
        }

        private void ShowCreateLivro()
        {
            labelCreateISBN.Show();
            label2.Show();
            labelCreateAno.Show();
            labelNomeEditora.Show();
            labelIdEditora.Show();
            labelCategoria.Show();
            labelAutor.Show();
            label1.Show();
            textBoxCreateISBN.Show();
            textBoxCreateTitulo.Show();
            textBoxCreateAno.Show();
            comboBoxNomeEditora.Show();
            textBoxIdEditora.Show();
            comboBoxCategoria.Show();
            comboBoxAutores.Show();
            textBoxIDPessoa.Show();
            buttonAddLivro.Show();
        }

        private void buttonAddCreateAutor_Click(object sender, EventArgs e)
        {
            HideCreateAutor();

            if (!verifySGBDConnection())
                return;
            int rows = 0;
            if (textBoxCreateNomeAutor.Text == "" || textBoxCreateApelidoAutor.Text == "")
                MessageBox.Show("Adiciona nome e apelido do autor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                SqlCommand cmd = new SqlCommand("BIBLIOTECA.CreateAutor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@first_name", SqlDbType.VarChar).Value = textBoxCreateNomeAutor.Text;
                cmd.Parameters.Add("@last_name", SqlDbType.VarChar).Value = textBoxCreateApelidoAutor.Text;
                if (textBoxCreateDataAutor.Text != "")
                    cmd.Parameters.Add("@nas_data", SqlDbType.Date).Value = DateTime.Parse(textBoxCreateDataAutor.Text);
                if (textBoxCreateTelefoneAutor.Text != "")
                    cmd.Parameters.Add("@telemovel", SqlDbType.Decimal).Value = Decimal.Parse(textBoxCreateTelefoneAutor.Text);
                cmd.Connection = cn;

                try
                {
                    rows = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Failed to create author in database. \n ERROR MESSAGE: \n" + ex.Message);
                }
                finally
                {
                    if (rows == 2)
                        MessageBox.Show("Create OK");
                    else
                        MessageBox.Show("Create NOT OK");

                    cn.Close();
                }
            }

        }
        private void HideCreateAutor()
        {
            //labelCreateIdAutor.Hide();
            labelCreateNomeAutor.Hide();
            labelCreateApelidoAutor.Hide();
            labelCreateEnderecoAutor.Hide();
            labelCreateTelefoneAutor.Hide();
            textBoxCreateNomeAutor.Hide();
            textBoxCreateApelidoAutor.Hide();
            textBoxCreateDataAutor.Hide();
            textBoxCreateTelefoneAutor.Hide();
            buttonAddCreateAutor.Hide();
            buttonAddCreateAutor.Hide();
        }

        private void buttonAddExemplares_Click(object sender, EventArgs e)
        {
            //Adicionar quantidade de Livros Exemplares à BD
            if (!verifySGBDConnection())
                return;

            int rows = 0;

            if (textBoxCreateISBNExemplares.Text == "")
                MessageBox.Show("Selecione um Livro e a quantidade", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                SqlCommand cmd = new SqlCommand("BIBLIOTECA.CreateLivroExemplares", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@isbn", SqlDbType.VarChar).Value = textBoxCreateISBNExemplares.Text;
                cmd.Parameters.Add("@quantidade", SqlDbType.Int).Value = textBoxQuantidade.Text;
                cmd.Connection = cn;
                try
                {
                    rows = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Failed to create livros exemplares in database. \n ERROR MESSAGE: \n" + ex.Message);
                }
                finally
                {
                    if (rows == Int32.Parse(textBoxQuantidade.Text))
                        MessageBox.Show("Create OK");
                    else
                        MessageBox.Show("Create NOT OK");

                    cn.Close();

                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIdEditora_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddLivro_Click(object sender, EventArgs e) //AQUIII
        {
            HideCreateLivro();

            if (!verifySGBDConnection())
                return;

            int rows = 0;

            if (textBoxCreateISBN.Text == "" || textBoxCreateTitulo.Text == "" || textBoxCreateAno.Text == "" || textBoxIdEditora.Text == "" || textBoxIDPessoa.Text == "")
                MessageBox.Show("Adiciona nome do Livro, ISBN, Ano, Editora e Autor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                SqlCommand cmd = new SqlCommand("BIBLIOTECA.CreateLivro", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@isbn", SqlDbType.VarChar).Value = textBoxCreateISBN.Text;
                cmd.Parameters.Add("@titulo", SqlDbType.VarChar).Value = textBoxCreateTitulo.Text;
                if (comboBoxCategoria.SelectedItem != null)
                    cmd.Parameters.Add("@categoria", SqlDbType.VarChar).Value = comboBoxCategoria.SelectedItem.ToString();
                cmd.Parameters.Add("@ano", SqlDbType.Int).Value = textBoxCreateAno.Text;
                cmd.Parameters.Add("@editora", SqlDbType.Int).Value = textBoxIdEditora.Text;
                cmd.Parameters.Add("@autor", SqlDbType.Int).Value = textBoxIDPessoa.Text;
                cmd.Connection = cn;
                try
                {
                    rows = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Failed to create livro in database. \n ERROR MESSAGE: \n" + ex.Message);
                }
                finally
                {
                    if (rows == 2)
                        MessageBox.Show("Create OK");
                    else
                        MessageBox.Show("Create NOT OK");

                    cn.Close();

                }
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelCreateISBN_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCreateTitulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCreateTitulo.Items.Count == 0 | comboBoxCreateTitulo.SelectedIndex == -1) return;

            currentLivro = comboBoxCreateTitulo.SelectedIndex;

            Livro livro = new Livro();
            livro = (Livro)comboBoxCreateTitulo.Items[currentLivro];
            textBoxCreateISBNExemplares.Text = livro.ISBN.ToString();
        }

        private void comboBoxCreateTitulo_Click(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = " SELECT DISTINCT l.ISBN, l.titulo " +
                              " FROM Biblioteca.Livro as l " +
                              " ORDER BY l.titulo";
            cmd.Connection = cn;
            SqlDataReader reader = cmd.ExecuteReader();
            //comboBoxCreateTitulo.Items.Clear();

            while (reader.Read())
            {
                Livro l = new Livro();
                l.ISBN = (String)reader["ISBN"];
                l.Titulo = (String)reader["titulo"];
                comboBoxCreateTitulo.Items.Add(l);
            }
            //comboBoxAutores.Sorted = true;
            cn.Close();
        }

        private void buttonShowLivro_Click(object sender, EventArgs e)
        {
            ShowCreateLivro();
        }
    }
}
