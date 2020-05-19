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

        private bool SavePessoa()
        {
            Pessoa pessoa = new Pessoa();
            try
            {
                //pessoa.Id = int.Parse(textID.Text);
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
                pessoa = SubmitPessoa(pessoa);
                listBox1.Items.Add(pessoa);
            }
            else
            {
                UpdatePessoa(pessoa);
                listBox1.Items[currentPessoa] = pessoa;
            }
            return true;
        }

        private Pessoa SubmitPessoa(Pessoa p)
        {
            if (!verifySGBDConnection())
                return null;
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT Biblioteca.Pessoa (first_name, last_name, data_nascimento, telefone) output INSERTED.ID VALUES ( @first_name, @last_name, @data_nascimento, @telefone); ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@first_name", p.First_name);
            cmd.Parameters.AddWithValue("@last_name", p.Last_name);
            cmd.Parameters.AddWithValue("@data_nascimento", p.Data_nascimento);
            cmd.Parameters.AddWithValue("@telefone", p.Telefone);
            cmd.Connection = cn;

            try
            {
                int id = (int)cmd.ExecuteScalar();
                p.Id = id;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update contact in database. \n ERROR MESSAGE: \n" + ex.Message);
            }
            finally
            {
                cn.Close();
            }
            return p;
        }

        private void UpdatePessoa(Pessoa p)
        {
            int rows = 0;

            if (!verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "UPDATE Biblioteca.Pessoa " + "SET first_name = @first_name, " + "    last_name = @last_name, " + "    data_nascimento = @data_nascimento, " + "    telefone = @telefone " + " WHERE id = @id";
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

        private void RemovePessoa(int id)
        {
            if (!verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "DELETE Biblioteca.Pessoa WHERE id=@id ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = cn;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to delete contact in database. \n ERROR MESSAGE: \n" + ex.Message);
            }
            finally
            {
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
            buttonEdit.Visible = true;
            buttonRemove.Visible = true;
            buttonOk.Visible = false;
            buttonCancel.Visible = false;

        }

        public void HideButtons()
        {
            UnlockControls();
            buttonAdd.Visible = false;
            buttonEdit.Visible = false;
            buttonRemove.Visible = false;
            buttonOk.Visible = true;
            buttonCancel.Visible = true;
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            adding = true;
            ClearFields();
            HideButtons();
            listBox1.Enabled = false;
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

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            currentPessoa = listBox1.SelectedIndex;
            if (currentPessoa < 0)
            {
                MessageBox.Show("Please select a contact to edit");
                return;
            }
            adding = false;
            HideButtons();
            listBox1.Enabled = false;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                try
                {
                    RemovePessoa(((Pessoa)listBox1.SelectedItem).Id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                if (currentPessoa == listBox1.Items.Count)
                    currentPessoa = listBox1.Items.Count - 1;
                if (currentPessoa == -1)
                {
                    ClearFields();
                    MessageBox.Show("There are no more contacts");
                }
                else
                {
                    ShowPessoa();
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            listBox1.Enabled = true;
            if (listBox1.Items.Count > 0)
            {
                currentPessoa = listBox1.SelectedIndex;
                if (currentPessoa < 0)
                    currentPessoa = 0;
                ShowPessoa();
            }
            else
            {
                ClearFields();
                LockControls();
            }
            ShowButtons();
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
        private void textFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

            if (!verifySGBDConnection())
                return;

            if (textSearch.Text == "")
            {
                Form1_Load(sender, e);
            }
            else
            {

                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "SELECT * FROM Biblioteca.Pessoa WHERE first_name = @varSearch";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@varSearch", textSearch.Text);
                cmd.Connection = cn;
                SqlDataReader reader = cmd.ExecuteReader();
                listBox1.Items.Clear();

                while (reader.Read())
                {
                    Pessoa p = new Pessoa();
                    p.Id = (int)reader["id"];
                    p.First_name = reader["first_name"].ToString();
                    p.Last_name = reader["last_name"].ToString();
                    p.Data_nascimento = (DateTime)reader["data_nascimento"];
                    p.Telefone = (decimal)reader["telefone"];
                    listBox1.Items.Add(p);
                }


                cn.Close();


                currentPessoa = 0;
                ShowPessoa();
                ShowButtons();
            }
        }

        private void buttonEmprestimo_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Show();

            //currentPessoa = 0;
            //ShowPessoa();
            //ShowButtons();
        }
    }
}
