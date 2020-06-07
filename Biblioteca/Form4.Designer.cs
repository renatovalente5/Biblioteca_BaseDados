namespace Biblioteca
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBoxDisponiveis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAddLivros = new System.Windows.Forms.Button();
            this.buttonRemoveLivro = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(28, 42);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(376, 264);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventário da Biblioteca";
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(28, 328);
            this.textSearch.Margin = new System.Windows.Forms.Padding(2);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(147, 20);
            this.textSearch.TabIndex = 3;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(187, 322);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(74, 31);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(461, 117);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(348, 121);
            this.listBox2.TabIndex = 5;
            // 
            // textBoxDisponiveis
            // 
            this.textBoxDisponiveis.Location = new System.Drawing.Point(596, 43);
            this.textBoxDisponiveis.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDisponiveis.Name = "textBoxDisponiveis";
            this.textBoxDisponiveis.Size = new System.Drawing.Size(50, 20);
            this.textBoxDisponiveis.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Disponíveis na Biblioteca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(459, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Livros Exemplares";
            // 
            // buttonAddLivros
            // 
            this.buttonAddLivros.Location = new System.Drawing.Point(646, 314);
            this.buttonAddLivros.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddLivros.Name = "buttonAddLivros";
            this.buttonAddLivros.Size = new System.Drawing.Size(163, 39);
            this.buttonAddLivros.TabIndex = 10;
            this.buttonAddLivros.Text = "Adicionar Livros à Biblioteca";
            this.buttonAddLivros.UseVisualStyleBackColor = true;
            this.buttonAddLivros.Click += new System.EventHandler(this.buttonAddLivros_Click);
            // 
            // buttonRemoveLivro
            // 
            this.buttonRemoveLivro.Location = new System.Drawing.Point(510, 314);
            this.buttonRemoveLivro.Name = "buttonRemoveLivro";
            this.buttonRemoveLivro.Size = new System.Drawing.Size(122, 39);
            this.buttonRemoveLivro.TabIndex = 11;
            this.buttonRemoveLivro.Text = "Remover Livro";
            this.buttonRemoveLivro.UseVisualStyleBackColor = true;
            this.buttonRemoveLivro.Click += new System.EventHandler(this.buttonRemoveLivro_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(375, 314);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(117, 39);
            this.buttonEditar.TabIndex = 12;
            this.buttonEditar.Text = "Editar Livro";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 366);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonRemoveLivro);
            this.Controls.Add(this.buttonAddLivros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDisponiveis);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox textBoxDisponiveis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAddLivros;
        private System.Windows.Forms.Button buttonRemoveLivro;
        private System.Windows.Forms.Button buttonEditar;
    }
}