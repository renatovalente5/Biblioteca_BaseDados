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
                               " FROM Biblioteca.Editora as e JOIN Biblioteca.Livro as l ON e.id_editora=l.id_editora " +
                               " ORDER BY e.nome_editora, e.id_editora ";
            cmd2.Connection = cn;
            SqlDataReader reader2 = cmd2.ExecuteReader();
            comboBoxAutores.Items.Clear();

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
            cmd.CommandText = " SELECT DISTINCT p.first_name, p.last_name " +
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
            labelCreateIdEditora.Show();
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
        }
        private void HideCreateEditora()
        {
            labelCreateIdEditora.Hide();
            labelCreateEditoraNome.Hide();
            labelCreateEndercoEditora.Hide();
            labelCreateTelefoneEditora.Hide();
            textBoxCreateNomeEditora.Hide();
            textBoxCreateEditoraEndereco.Hide();
            textBoxCreateEditoraTelefone.Hide();
            buttonAddCreateEditora.Hide();
        }

        private void buttonAddAutor_Click(object sender, EventArgs e)
        {
            ShowCreateAutor();
        }

        private void ShowCreateAutor()
        {
            labelCreateIdAutor.Show();
            labelCreateNomeAutor.Show();
            labelCreateApelidoAutor.Show();
            labelCreateEnderecoAutor.Show();
            labelCreateTelefoneAutor.Show();
            textBoxCreateNomeAutor.Show();
            textBoxCreateApelidoAutor.Show();
            textBoxCreateEnderecoAutor.Show();
            textBoxCreateTelefoneAutor.Show();
            buttonAddCreateAutor.Show();
        }

        private void buttonAddCreateAutor_Click(object sender, EventArgs e)
        {
            HideCreateAutor();
            //Falta Adicionar o noo Autor à BD e atualizar o ComboBox
        }
        private void HideCreateAutor()
        {
            labelCreateIdAutor.Hide();
            labelCreateNomeAutor.Hide();
            labelCreateApelidoAutor.Hide();
            labelCreateEnderecoAutor.Hide();
            labelCreateTelefoneAutor.Hide();
            textBoxCreateNomeAutor.Hide();
            textBoxCreateApelidoAutor.Hide();
            textBoxCreateEnderecoAutor.Hide();
            textBoxCreateTelefoneAutor.Hide();
            buttonAddCreateAutor.Hide();
        }

        private void buttonAddExemplares_Click(object sender, EventArgs e)
        {
            //Adicionar quantidade de Livros Exemplares à BD
        }
    }
}
