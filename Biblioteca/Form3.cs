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
        private Cliente c;
        private int selectedIndex;

        public Form3(Cliente c = null)
        {
            InitializeComponent();
            this.c = c;
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

            //cmd.CommandText = " DROP FUNCTION GetLivrosEmprestados " +
            //    " GO " +
            //    " CREATE FUNCTION GetLivrosEmprestados(@idCliente INT) RETURNS TABLE " +
            //    " AS " +
            //    " RETURN ( Select c.id_cliente, count(e.cliente) as numero " +
            //    " FROM Biblioteca.Cliente as c JOIN Biblioteca.Emprestimo as e ON c.id_cliente=e.cliente " +
            //    " WHERE c.id_cliente=@idCliente " +
            //    " GROUP BY c.id_cliente " +
            //    " ) " +
            //    " GO " +
            //    " SELECT * FROM GetLivrosEmprestados(5) " + //Tens de passar aqui o clienteID
            //    " GO ";
            cmd.CommandText = "SELECT * FROM Biblioteca.GetClientHistorico(@id_cliente)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id_cliente", c.Id);
            cmd.Connection = cn;
            SqlDataReader reader = cmd.ExecuteReader();
            listBox1.Items.Clear();

            while (reader.Read())
            {
                Emprestimo em = new Emprestimo();
                em.N_emprestimo = (int)reader["n_emprestimo"];
                em.Data_Saida = (DateTime)reader["data_Saida"];
                em.Data_entrega = (DateTime)reader["data_entrega"];
                em.Data_Saida = (DateTime)reader["data_Saida"];
                if (reader["data_chegada"].ToString() != "")
                    em.Data_chegada = (DateTime)reader["data_chegada"];
                em.ISBN = (String)reader["ISBN"];
                em.Titulo = (String)reader["titulo"];
                em.Ano = (int)reader["ano"];
                //e.Id_editora = (int)reader["id_editora"];
                if (reader["categoria"].ToString() != "")
                    em.Categoria = (String)reader["categoria"];
                //e.CountTilulos = (int)reader["countTitulos"];
                em.Nome_editora = (String)reader["nome_editora"];
                listBox1.Items.Add(em);
            }
            cn.Close();

            ShowEmprestimo();
            ClearFields();
        }

        private void ClearFields()
        {
            textEditora.Text = "";
            textBoxDataSaida.Text = "";
            textBoxDataEntrada.Text = "";
            textBoxDataChegada.Text = "";
            textCategoria.Text = "";
        }

        private void ShowEmprestimo()
        {
            if (listBox1.Items.Count == 0 | currentLivro < 0) return;
            Emprestimo emprestimo = new Emprestimo();
            emprestimo = (Emprestimo)listBox1.Items[currentLivro];
            textEditora.Text = emprestimo.Nome_editora;
            textBoxDataSaida.Text = emprestimo.Data_Saida.ToString().Split(' ')[0];
            textBoxDataEntrada.Text = emprestimo.Data_entrega.ToString().Split(' ')[0];
            textBoxDataChegada.Text = emprestimo.Data_chegada.ToString().Split(' ')[0];
            textCategoria.Text = emprestimo.Categoria;
            if (textBoxDataChegada.Text != "")
                buttonEntrega.Hide();
            else
                buttonEntrega.Show();
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
                cmd.CommandText = "SELECT * FROM Biblioteca.GetClientHistorico(@id_cliente) where titulo like @varsearch";
                //cmd.CommandText = "SELECT * FROM Biblioteca.Livro WHERE titulo LIKE '%" + textSearch.Text + "%'";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@varSearch", "%" + textSearch.Text + "%");
                cmd.Parameters.AddWithValue("@id_cliente", c.Id);

                cmd.Connection = cn;
                SqlDataReader reader = cmd.ExecuteReader();
                listBox1.Items.Clear();

                while (reader.Read())
                {
                    Emprestimo em = new Emprestimo();
                    em.N_emprestimo = (int)reader["n_emprestimo"];
                    em.Data_Saida = (DateTime)reader["data_Saida"];
                    em.Data_entrega = (DateTime)reader["data_entrega"];
                    em.Data_Saida = (DateTime)reader["data_Saida"];
                    if (reader["data_chegada"].ToString() != "")
                        em.Data_chegada = (DateTime)reader["data_chegada"];
                    em.ISBN = (String)reader["ISBN"];
                    em.Titulo = (String)reader["titulo"];
                    em.Ano = (int)reader["ano"];
                    //e.Id_editora = (int)reader["id_editora"];
                    if (reader["categoria"].ToString() != "")
                        em.Categoria = (String)reader["categoria"];
                    //e.CountTilulos = (int)reader["countTitulos"];
                    em.Nome_editora = (String)reader["nome_editora"];
                    listBox1.Items.Add(em);
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
            Emprestimo livro = new Emprestimo();
            livro = (Emprestimo)listBox1.Items[currentLivro];
            textCategoria.Text = livro.Categoria;
            textEditora.Text = livro.Nome_editora.ToString();

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                currentLivro = listBox1.SelectedIndex;
                ShowEmprestimo();
            }
        }

        private void buttonEntrega_Click(object sender, EventArgs e)
        {
            int rows = 0;
            if (listBox1.Items.Count == 0 | currentLivro < 0) return;
            Emprestimo emprestimo = new Emprestimo();
            emprestimo = (Emprestimo)listBox1.Items[currentLivro];

            if (!verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand("Biblioteca.FazerEntrega",cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@emprestimo", SqlDbType.Int).Value = emprestimo.N_emprestimo;

            try
            {
                rows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed fazendo entrega in database. \n ERROR MESSAGE: \n" + ex.Message);
            }
            finally
            {
                if (rows == 1)
                    MessageBox.Show("Update OK");
                else
                    MessageBox.Show("Update NOT OK");

                cn.Close();
            }

            Form3_Load(sender, e);
        }

    }
}
