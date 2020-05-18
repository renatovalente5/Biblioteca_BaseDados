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
        private bool adding;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cn = getSGBDConnection();

            if (!verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand("SELECT * FROM Biblioteca.Pessoa", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            listBox1.Items.Clear();

            while (reader.Read())
            {
                Pessoa p = new Pessoa();
                p.Id = (int) reader["id"];
                p.First_name = reader["first_name"].ToString();
                p.Last_name = reader["last_name"].ToString();
                p.Data_nascimento = (DateTime) reader["data_nascimento"];
                p.Telefone = (decimal) reader["telefone"];
                listBox1.Items.Add(p);
            }

            cn.Close();


            currentPessoa = 0;
            ShowPessoa();
            ShowButtons();
        }

        private SqlConnection getSGBDConnection()
        {
            return new SqlConnection("data source= localhost;integrated security=true;initial catalog=Biblioteca");

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textID_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            adding = true;
            ClearFields();
            HideButtons();
            listBox1.Enabled = false;
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

        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                SavePessoa();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            listBox1.Enabled = true;
            int idx = listBox1.FindString(textID.Text);
            listBox1.SelectedIndex = idx;
            ShowButtons();
        }
        private bool SavePessoa()
        {
            Pessoa pessoa = new Pessoa();
            try
            {
                pessoa.Id = int.Parse(textID.Text);
                pessoa.First_name = textFirstName.Text;
                pessoa.Last_name = textLastName.Text;
                pessoa.Data_nascimento = DateTime.Parse(textDataNascimento.Text);
                pessoa.Telefone = decimal.Parse(textTelefone.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            if (adding)
            {
                SubmitPessoa(pessoa);
                listBox1.Items.Add(pessoa);
            }
            else
            {
                UpdatePessoa(pessoa);
                listBox1.Items[currentPessoa] = pessoa;
            }
            return true;
        }

        private void SubmitPessoa(Pessoa p)
        {
            if (!verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT Biblioteca.Pessoa (id, first_name, last_name, data_nascimento, telefone) " + "VALUES (@id, @first_name, @last_name, @data_nascimento, @telefone) ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", p.Id);
            cmd.Parameters.AddWithValue("@first_name", p.First_name);
            cmd.Parameters.AddWithValue("@last_name", p.Last_name);
            cmd.Parameters.AddWithValue("@data_nascimento", p.Data_nascimento);
            cmd.Parameters.AddWithValue("@telefone", p.Telefone);
            cmd.Connection = cn;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update contact in database. \n ERROR MESSAGE: \n" + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void UpdatePessoa(Pessoa p)
        {
            int rows = 0;

            if (!verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "UPDATE Biblioteca.Pessoa " + "SET id = @id, " + "    first_name = @first_name, " + "    last_name = @last_name, " + "    data_nascimento = @data_nascimento, " + "    telefone = @telefone";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", p.Id);
            cmd.Parameters.AddWithValue("@first_name", p.First_name);
            cmd.Parameters.AddWithValue("@last_name", p.Last_name);
            cmd.Parameters.AddWithValue("@data_nascimento", p.Data_nascimento);
            cmd.Parameters.AddWithValue("@telefone", p.Telefone);
            cmd.Connection = cn;

            try
            {
                rows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update contact in database. \n ERROR MESSAGE: \n" + ex.Message);
            }
            finally
            {
                if (rows == 1)
                    MessageBox.Show("Update OK");
                else
                    MessageBox.Show("Update NOT OK");

                cn.Close();
            }
        }

        public void ClearFields()
        {
            textID.Text = "";
            textFirstName.Text = "";
            textLastName.Text = "";
            textDataNascimento.Text = "";
            textTelefone.Text = "";
        }

        public void ShowButtons()
        {
            LockControls();
            buttonAdd.Visible = true;
            buttonOk.Visible = false;
            buttonEdit.Visible = true;
            buttonDelete.Visible = true;
            //bttnCancel.Visible = false;
        }

        public void HideButtons()
        {
            UnlockControls();
            buttonAdd.Visible = false;
            buttonOk.Visible = true;
            buttonEdit.Visible = false;
            buttonDelete.Visible = false;
            //bttnCancel.Visible = true;
        }

        public void LockControls()
        {
            textID.ReadOnly = true;
            textFirstName.ReadOnly = true;
            textLastName.ReadOnly = true;
            textDataNascimento.ReadOnly = true;
            textTelefone.ReadOnly = true;
        }

        public void UnlockControls()
        {
            textID.ReadOnly = false;
            textFirstName.ReadOnly = false;
            textLastName.ReadOnly = false;
            textDataNascimento.ReadOnly = false;
            textTelefone.ReadOnly = false;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            currentPessoa = listBox1.SelectedIndex;
            if (currentPessoa <= 0)
            {
                MessageBox.Show("Please select a contact to edit");
                return;
            }
            adding = false;
            HideButtons();
            listBox1.Enabled = false;
        }
    }
}
