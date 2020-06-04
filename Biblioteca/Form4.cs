﻿using System;
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
                         " FROM Biblioteca.Livros_Exemplares as le JOIN Biblioteca.Livro as li ON li.ISBN = le.ISBN " +
                         "                                         JOIN Biblioteca.Editora as ed ON li.id_editora = ed.id_editora " +
                         " GROUP BY li.ISBN, li.titulo, li.ano, li.id_editora, ed.nome_editora, li.categoria ";
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
                             " FROM Biblioteca.Livros_Exemplares as le JOIN Biblioteca.Livro as li ON li.ISBN = le.ISBN " +
                             "                                         JOIN Biblioteca.Editora as ed ON li.id_editora = ed.id_editora " +
                             " WHERE titulo LIKE @varSearch " +
                             " GROUP BY li.ISBN, li.titulo, li.ano, li.id_editora, ed.nome_editora, li.categoria ";
                cmd.Parameters.AddWithValue("@varSearch", "%" + textSearch.Text + "%");
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
                    l.Estado = (String)reader["estado"];
                    //l.Cota = (String)reader["cota"];
                    l.Numero_exemplar = (int)reader["numero_exemplar"];
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
            if (listBox1.Items.Count == 0 | currentLivro < 0) return;
            Livro livro = new Livro();
            livro = (Livro)listBox1.Items[currentLivro];

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
                //em.Titulo = (String)reader["titulo"];
                //em.Ano = (int)reader["ano"];
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

            ShowLivro();
        }
        public void ShowLivro()
        {
            currentLivro = listBox1.SelectedIndex;
            if (listBox1.Items.Count == 0 | currentLivro < 0) return;
            Livro livro = new Livro();
            livro = (Livro)listBox1.Items[currentLivro];
            textBoxDisponiveis.Text = livro.CountTilulos.ToString();
        }

        private void buttonAddLivros_Click(object sender, EventArgs e)
        {
            var form5 = new Form5();
            form5.Show();
        }
    }
}