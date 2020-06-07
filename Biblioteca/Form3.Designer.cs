namespace Biblioteca
{
    partial class Form3
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelEditora = new System.Windows.Forms.Label();
            this.textCategoria = new System.Windows.Forms.TextBox();
            this.textEditora = new System.Windows.Forms.TextBox();
            this.labelDataSaida = new System.Windows.Forms.Label();
            this.labelDataEntrega = new System.Windows.Forms.Label();
            this.labelDataChegada = new System.Windows.Forms.Label();
            this.textBoxDataSaida = new System.Windows.Forms.TextBox();
            this.textBoxDataEntrada = new System.Windows.Forms.TextBox();
            this.textBoxDataChegada = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEntrega = new System.Windows.Forms.Button();
            this.labelFaltaDevolver = new System.Windows.Forms.Label();
            this.labelEmFalta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(29, 50);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(537, 324);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(252, 397);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(120, 41);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(29, 406);
            this.textSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(217, 22);
            this.textSearch.TabIndex = 19;
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(637, 79);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(69, 17);
            this.labelCategoria.TabIndex = 20;
            this.labelCategoria.Text = "Categoria";
            // 
            // labelEditora
            // 
            this.labelEditora.AutoSize = true;
            this.labelEditora.Location = new System.Drawing.Point(637, 110);
            this.labelEditora.Name = "labelEditora";
            this.labelEditora.Size = new System.Drawing.Size(53, 17);
            this.labelEditora.TabIndex = 21;
            this.labelEditora.Text = "Editora";
            // 
            // textCategoria
            // 
            this.textCategoria.Location = new System.Drawing.Point(723, 79);
            this.textCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCategoria.Name = "textCategoria";
            this.textCategoria.Size = new System.Drawing.Size(208, 22);
            this.textCategoria.TabIndex = 22;
            // 
            // textEditora
            // 
            this.textEditora.Location = new System.Drawing.Point(723, 110);
            this.textEditora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEditora.Name = "textEditora";
            this.textEditora.Size = new System.Drawing.Size(208, 22);
            this.textEditora.TabIndex = 23;
            // 
            // labelDataSaida
            // 
            this.labelDataSaida.AutoSize = true;
            this.labelDataSaida.Location = new System.Drawing.Point(637, 191);
            this.labelDataSaida.Name = "labelDataSaida";
            this.labelDataSaida.Size = new System.Drawing.Size(98, 17);
            this.labelDataSaida.TabIndex = 24;
            this.labelDataSaida.Text = "Data de Saida";
            // 
            // labelDataEntrega
            // 
            this.labelDataEntrega.AutoSize = true;
            this.labelDataEntrega.Location = new System.Drawing.Point(637, 219);
            this.labelDataEntrega.Name = "labelDataEntrega";
            this.labelDataEntrega.Size = new System.Drawing.Size(112, 17);
            this.labelDataEntrega.TabIndex = 25;
            this.labelDataEntrega.Text = "Data de Entrega";
            // 
            // labelDataChegada
            // 
            this.labelDataChegada.AutoSize = true;
            this.labelDataChegada.Location = new System.Drawing.Point(637, 252);
            this.labelDataChegada.Name = "labelDataChegada";
            this.labelDataChegada.Size = new System.Drawing.Size(119, 17);
            this.labelDataChegada.TabIndex = 26;
            this.labelDataChegada.Text = "Data de Chegada";
            // 
            // textBoxDataSaida
            // 
            this.textBoxDataSaida.Location = new System.Drawing.Point(765, 186);
            this.textBoxDataSaida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDataSaida.Name = "textBoxDataSaida";
            this.textBoxDataSaida.Size = new System.Drawing.Size(208, 22);
            this.textBoxDataSaida.TabIndex = 27;
            // 
            // textBoxDataEntrada
            // 
            this.textBoxDataEntrada.Location = new System.Drawing.Point(765, 219);
            this.textBoxDataEntrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDataEntrada.Name = "textBoxDataEntrada";
            this.textBoxDataEntrada.Size = new System.Drawing.Size(208, 22);
            this.textBoxDataEntrada.TabIndex = 28;
            // 
            // textBoxDataChegada
            // 
            this.textBoxDataChegada.Location = new System.Drawing.Point(765, 252);
            this.textBoxDataChegada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDataChegada.Name = "textBoxDataChegada";
            this.textBoxDataChegada.Size = new System.Drawing.Size(208, 22);
            this.textBoxDataChegada.TabIndex = 29;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(875, 398);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(99, 38);
            this.buttonOk.TabIndex = 30;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Histórico Livros Emprestados";
            // 
            // buttonEntrega
            // 
            this.buttonEntrega.Location = new System.Drawing.Point(844, 318);
            this.buttonEntrega.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEntrega.Name = "buttonEntrega";
            this.buttonEntrega.Size = new System.Drawing.Size(131, 42);
            this.buttonEntrega.TabIndex = 32;
            this.buttonEntrega.Text = "Fazer Entrega";
            this.buttonEntrega.UseVisualStyleBackColor = true;
            this.buttonEntrega.Click += new System.EventHandler(this.buttonEntrega_Click);
            // 
            // labelFaltaDevolver
            // 
            this.labelFaltaDevolver.AutoSize = true;
            this.labelFaltaDevolver.Location = new System.Drawing.Point(416, 411);
            this.labelFaltaDevolver.Name = "labelFaltaDevolver";
            this.labelFaltaDevolver.Size = new System.Drawing.Size(103, 17);
            this.labelFaltaDevolver.TabIndex = 34;
            this.labelFaltaDevolver.Text = "Falta Devolver:";
            // 
            // labelEmFalta
            // 
            this.labelEmFalta.AutoSize = true;
            this.labelEmFalta.Location = new System.Drawing.Point(521, 411);
            this.labelEmFalta.Name = "labelEmFalta";
            this.labelEmFalta.Size = new System.Drawing.Size(16, 17);
            this.labelEmFalta.TabIndex = 35;
            this.labelEmFalta.Text = "0";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 450);
            this.Controls.Add(this.labelEmFalta);
            this.Controls.Add(this.labelFaltaDevolver);
            this.Controls.Add(this.buttonEntrega);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxDataChegada);
            this.Controls.Add(this.textBoxDataEntrada);
            this.Controls.Add(this.textBoxDataSaida);
            this.Controls.Add(this.labelDataChegada);
            this.Controls.Add(this.labelDataEntrega);
            this.Controls.Add(this.labelDataSaida);
            this.Controls.Add(this.textEditora);
            this.Controls.Add(this.textCategoria);
            this.Controls.Add(this.labelEditora);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelEditora;
        private System.Windows.Forms.TextBox textCategoria;
        private System.Windows.Forms.TextBox textEditora;
        private System.Windows.Forms.Label labelDataSaida;
        private System.Windows.Forms.Label labelDataEntrega;
        private System.Windows.Forms.Label labelDataChegada;
        private System.Windows.Forms.TextBox textBoxDataSaida;
        private System.Windows.Forms.TextBox textBoxDataEntrada;
        private System.Windows.Forms.TextBox textBoxDataChegada;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEntrega;
        private System.Windows.Forms.Label labelFaltaDevolver;
        private System.Windows.Forms.Label labelEmFalta;
    }
}