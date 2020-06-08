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
    

    public partial class Form6 : Form
    {

        private SqlConnection cn;
        private int currentLivro;
        private string isbn;
        public Form6(string livro)
        {
            isbn = livro;
            InitializeComponent();
            String[] categorias = new String[] { "Action", "Adventure", "Animation", "Comedy", "Crime", "Drama", "Ficção" };
            comboBoxCategoria.Items.AddRange(categorias);
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            HideCreateAutor();
            HideCreateEditora();

            if (!verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = " SELECT li.ISBN, li.titulo, li.ano, li.id_editora, ed.nome_editora , li.categoria, es.id_autor,p.first_name,p.last_name" +
                         " FROM Biblioteca.Livro as li  " +
                         "                       JOIN Biblioteca.Editora as ed ON li.id_editora = ed.id_editora " +
                         "                       left outer JOIN Biblioteca.Escreve as es ON li.ISBN = es.id_livro " +
                         "                       left outer JOIN Biblioteca.Pessoa as p ON es.id_autor = p.id where li.ISBN = @isbn";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@isbn", isbn);
            cmd.Connection = cn;
            SqlDataReader reader = cmd.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                if(i == 0)
                {
                    textBoxISBN.Text = (String)reader["ISBN"];
                    textBoxTitulo.Text = (String)reader["titulo"];
                    textBoxAno.Text = reader["ano"].ToString();
                    textBoxIdEditora.Text = reader["id_editora"].ToString();
                    if(!comboBoxCategoria.Items.Contains((String)reader["categoria"]))
                        comboBoxCategoria.Items.Add((String)reader["categoria"]);
                    comboBoxCategoria.SelectedItem = (String)reader["categoria"];
                    Editora editora = new Editora();
                    editora.Nome_editora = (String)reader["nome_editora"];
                    editora.Id_editora = (int)reader["id_editora"];
                    comboBoxNomeEditora.Items.Add(editora);
                    comboBoxNomeEditora.SelectedItem = editora;
                    i++;
                }
                if (reader["id_autor"].ToString() != "")
                {
                    Pessoa autor = new Pessoa((int)reader["id_autor"], (string)reader["first_name"], (string)reader["last_name"]);
                    listBox1.Items.Add(autor);
                }
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


        private void buttonCriarEditora_Click(object sender, EventArgs e)
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

        private void buttonCriarAutor_Click(object sender, EventArgs e)
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

        private void buttonRemoverAutor_Click(object sender, EventArgs e)
        {
            currentLivro = listBox1.SelectedIndex;
            if (listBox1.Items.Count == 0 | currentLivro < 0)
            {
                MessageBox.Show("Escolha um autor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            listBox1.Items.RemoveAt(currentLivro);
        }

        private void buttonAdicionarAutor_Click(object sender, EventArgs e)
        {
            int index = comboBoxAutores.SelectedIndex;
            if (comboBoxAutores.Items.Count == 0 || index < 0) {
                MessageBox.Show("Escolha um autor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!listBox1.Items.Contains(comboBoxAutores.Items[index]))
                listBox1.Items.Add(comboBoxAutores.Items[index]);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                buttonAdicionarAutor.Visible = true;
                buttonRemoverAutor.Visible = false;
            }
            else
            {
                buttonAdicionarAutor.Visible = false;
                buttonRemoverAutor.Visible = true;
            }
        }

        private void comboBoxAutores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAutores.SelectedIndex == -1)
            {
                buttonAdicionarAutor.Visible = false;
                buttonRemoverAutor.Visible = false;
            }
            else
            {
                buttonAdicionarAutor.Visible = true;
                buttonRemoverAutor.Visible = false;

                currentLivro = comboBoxAutores.SelectedIndex;

                Pessoa pessoa = new Pessoa();
                pessoa = (Pessoa)comboBoxAutores.Items[currentLivro];
                textBoxIDPessoa.Text = pessoa.Id.ToString();
            }           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelAutor_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddLivro_Click(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;

            int rows = 0;
            string ids = "";
            SqlCommand cmd = new SqlCommand("BIBLIOTECA.EditarLivro", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@isbn", SqlDbType.VarChar).Value = textBoxISBN.Text;
            cmd.Parameters.Add("@titulo", SqlDbType.VarChar).Value = textBoxTitulo.Text;
            cmd.Parameters.Add("@ano", SqlDbType.Int).Value = textBoxAno.Text;
            cmd.Parameters.Add("@editora", SqlDbType.Int).Value = textBoxIdEditora.Text;
            cmd.Parameters.Add("@categoria", SqlDbType.VarChar).Value = comboBoxCategoria.SelectedItem;
            listBox1.Items.Cast<Pessoa>().ToList().ForEach(p => ids = ids + p.Id + ";");

            cmd.Parameters.Add("@autores", SqlDbType.VarChar).Value = ids;
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
                if (rows != 4)
                    MessageBox.Show("Create OK"+rows);
                else
                    MessageBox.Show("Create NOT OK");

                cn.Close();
            }
        }
    }
}
