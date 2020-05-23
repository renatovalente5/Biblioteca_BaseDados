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
    public partial class Form3 : Form
    {
        private SqlConnection cn;
        private int currentLivro;

        public Form3()
        {
            InitializeComponent();
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

        private void Form3_Load(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = " DROP FUNCTION GetLivrosEmprestados " +
                " GO " +
                " CREATE FUNCTION GetLivrosEmprestados(@idCliente INT) RETURNS TABLE " +
                " AS " +
                " RETURN ( Select c.id_cliente, count(e.cliente) as numero " +
                " FROM Biblioteca.Cliente as c JOIN Biblioteca.Emprestimo as e ON c.id_cliente=e.cliente " +
                " WHERE c.id_cliente=@idCliente " +
                " GROUP BY c.id_cliente " +
                " ) " +
                " GO " +
                " SELECT * FROM GetLivrosEmprestados(5) " + //Tens de passar aqui o clienteID
                " GO ";
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
                l.CountTilulos = (int)reader["countTitulos"];
                l.Nome_editora = (String)reader["nome_editora"];
                listBox1.Items.Add(l);
            }
            cn.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;

            if (textSearch.Text == "")
            {
                Form3_Load(sender, e);
            }
            else
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = " SELECT li.ISBN, li.titulo, li.ano, li.id_editora, ed.nome_editora , li.categoria, COUNT(li.titulo) as countTitulos " +
                             " FROM Biblioteca.Livros_Exemplares as le JOIN Biblioteca.Livro as li ON li.ISBN = le.ISBN " +
                             "                                         JOIN Biblioteca.Editora as ed ON li.id_editora = ed.id_editora " +
                             " WHERE titulo LIKE '%" + textSearch.Text + "%' " +
                             " GROUP BY li.ISBN, li.titulo, li.ano, li.id_editora, ed.nome_editora, li.categoria ";
                //cmd.CommandText = "SELECT * FROM Biblioteca.Livro WHERE titulo LIKE '%" + textSearch.Text + "%'";
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
                    l.CountTilulos = (int)reader["countTitulos"];
                    l.CountTilulos = (int)reader["countTitulos"];
                    l.Nome_editora = (String)reader["nome_editora"];
                    listBox1.Items.Add(l);
                }
                cn.Close();

                //currentLivro = 0;
                //ShowLivro();
                //ShowButtons();
            }
        }
        public void ShowLivro()
        {
            currentLivro = listBox1.SelectedIndex;
            if (listBox1.Items.Count == 0 | currentLivro < 0) return;
            Livro livro = new Livro();
            livro = (Livro)listBox1.Items[currentLivro];
            textCategoria.Text = livro.Categoria.ToString();
            textEditora.Text = livro.Nome_editora.ToString();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
