namespace Biblioteca
{
    partial class Form5
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
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelIdEditora = new System.Windows.Forms.Label();
            this.textBoxIdEditora = new System.Windows.Forms.TextBox();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.labelQuantidade = new System.Windows.Forms.Label();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.labelAutor = new System.Windows.Forms.Label();
            this.comboBoxAutores = new System.Windows.Forms.ComboBox();
            this.buttonAddAutor = new System.Windows.Forms.Button();
            this.labelNomeEditora = new System.Windows.Forms.Label();
            this.textBoxCreateNomeEditora = new System.Windows.Forms.TextBox();
            this.buttonAddEditora = new System.Windows.Forms.Button();
            this.comboBoxNomeEditora = new System.Windows.Forms.ComboBox();
            this.textBoxCreateEditoraEndereco = new System.Windows.Forms.TextBox();
            this.textBoxCreateEditoraTelefone = new System.Windows.Forms.TextBox();
            this.labelCreateEditoraNome = new System.Windows.Forms.Label();
            this.labelCreateTelefoneEditora = new System.Windows.Forms.Label();
            this.labelCreateEndercoEditora = new System.Windows.Forms.Label();
            this.labelCreateEnderecoAutor = new System.Windows.Forms.Label();
            this.labelCreateTelefoneAutor = new System.Windows.Forms.Label();
            this.labelCreateNomeAutor = new System.Windows.Forms.Label();
            this.textBoxCreateTelefoneAutor = new System.Windows.Forms.TextBox();
            this.textBoxCreateDataAutor = new System.Windows.Forms.TextBox();
            this.textBoxCreateNomeAutor = new System.Windows.Forms.TextBox();
            this.labelCreateApelidoAutor = new System.Windows.Forms.Label();
            this.textBoxCreateApelidoAutor = new System.Windows.Forms.TextBox();
            this.buttonAddCreateEditora = new System.Windows.Forms.Button();
            this.buttonAddCreateAutor = new System.Windows.Forms.Button();
            this.buttonAddExemplares = new System.Windows.Forms.Button();
            this.textBoxIDPessoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddLivro = new System.Windows.Forms.Button();
            this.textBoxCreateISBN = new System.Windows.Forms.TextBox();
            this.labelCreateISBN = new System.Windows.Forms.Label();
            this.labelCreateTitulo = new System.Windows.Forms.Label();
            this.textBoxCreateTituloExemplares = new System.Windows.Forms.TextBox();
            this.textBoxCreateAno = new System.Windows.Forms.TextBox();
            this.labelCreateAno = new System.Windows.Forms.Label();
            this.textBoxCreateISBNExemplares = new System.Windows.Forms.TextBox();
            this.labelAddISBNExemplares = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCreateTitulo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(10, 193);
            this.labelCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(52, 13);
            this.labelCategoria.TabIndex = 9;
            this.labelCategoria.Text = "Categoria";
            // 
            // labelIdEditora
            // 
            this.labelIdEditora.AutoSize = true;
            this.labelIdEditora.Location = new System.Drawing.Point(10, 161);
            this.labelIdEditora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIdEditora.Name = "labelIdEditora";
            this.labelIdEditora.Size = new System.Drawing.Size(52, 13);
            this.labelIdEditora.TabIndex = 10;
            this.labelIdEditora.Text = "Id Editora";
            // 
            // textBoxIdEditora
            // 
            this.textBoxIdEditora.Location = new System.Drawing.Point(85, 161);
            this.textBoxIdEditora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxIdEditora.Name = "textBoxIdEditora";
            this.textBoxIdEditora.Size = new System.Drawing.Size(50, 20);
            this.textBoxIdEditora.TabIndex = 16;
            this.textBoxIdEditora.TextChanged += new System.EventHandler(this.textBoxIdEditora_TextChanged);
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Location = new System.Drawing.Point(573, 458);
            this.textBoxQuantidade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(49, 20);
            this.textBoxQuantidade.TabIndex = 19;
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.AutoSize = true;
            this.labelQuantidade.Location = new System.Drawing.Point(429, 457);
            this.labelQuantidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(134, 13);
            this.labelQuantidade.TabIndex = 20;
            this.labelQuantidade.Text = "Quantidade de Exemplares";
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(86, 193);
            this.comboBoxCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(169, 21);
            this.comboBoxCategoria.TabIndex = 17;
            this.comboBoxCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Location = new System.Drawing.Point(14, 223);
            this.labelAutor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(32, 13);
            this.labelAutor.TabIndex = 21;
            this.labelAutor.Text = "Autor";
            // 
            // comboBoxAutores
            // 
            this.comboBoxAutores.FormattingEnabled = true;
            this.comboBoxAutores.Location = new System.Drawing.Point(86, 223);
            this.comboBoxAutores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxAutores.Name = "comboBoxAutores";
            this.comboBoxAutores.Size = new System.Drawing.Size(276, 21);
            this.comboBoxAutores.TabIndex = 23;
            this.comboBoxAutores.SelectedIndexChanged += new System.EventHandler(this.comboBoxAutores_SelectedIndexChanged);
            this.comboBoxAutores.Click += new System.EventHandler(this.comboBoxAutores_Click);
            // 
            // buttonAddAutor
            // 
            this.buttonAddAutor.Location = new System.Drawing.Point(701, 165);
            this.buttonAddAutor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddAutor.Name = "buttonAddAutor";
            this.buttonAddAutor.Size = new System.Drawing.Size(129, 20);
            this.buttonAddAutor.TabIndex = 24;
            this.buttonAddAutor.Text = "Adicionar Autor";
            this.buttonAddAutor.UseVisualStyleBackColor = true;
            this.buttonAddAutor.Click += new System.EventHandler(this.buttonAddAutor_Click);
            // 
            // labelNomeEditora
            // 
            this.labelNomeEditora.AutoSize = true;
            this.labelNomeEditora.Location = new System.Drawing.Point(10, 130);
            this.labelNomeEditora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNomeEditora.Name = "labelNomeEditora";
            this.labelNomeEditora.Size = new System.Drawing.Size(71, 13);
            this.labelNomeEditora.TabIndex = 25;
            this.labelNomeEditora.Text = "Nome Editora";
            // 
            // textBoxCreateNomeEditora
            // 
            this.textBoxCreateNomeEditora.Location = new System.Drawing.Point(88, 353);
            this.textBoxCreateNomeEditora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCreateNomeEditora.Name = "textBoxCreateNomeEditora";
            this.textBoxCreateNomeEditora.Size = new System.Drawing.Size(137, 20);
            this.textBoxCreateNomeEditora.TabIndex = 26;
            // 
            // buttonAddEditora
            // 
            this.buttonAddEditora.Location = new System.Drawing.Point(212, 458);
            this.buttonAddEditora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddEditora.Name = "buttonAddEditora";
            this.buttonAddEditora.Size = new System.Drawing.Size(129, 20);
            this.buttonAddEditora.TabIndex = 27;
            this.buttonAddEditora.Text = "Adicionar Editora";
            this.buttonAddEditora.UseVisualStyleBackColor = true;
            this.buttonAddEditora.Click += new System.EventHandler(this.buttonAddEditora_Click);
            // 
            // comboBoxNomeEditora
            // 
            this.comboBoxNomeEditora.FormattingEnabled = true;
            this.comboBoxNomeEditora.Location = new System.Drawing.Point(86, 128);
            this.comboBoxNomeEditora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxNomeEditora.Name = "comboBoxNomeEditora";
            this.comboBoxNomeEditora.Size = new System.Drawing.Size(237, 21);
            this.comboBoxNomeEditora.TabIndex = 28;
            this.comboBoxNomeEditora.SelectedIndexChanged += new System.EventHandler(this.comboBoxNomeEditora_SelectedIndexChanged);
            this.comboBoxNomeEditora.Click += new System.EventHandler(this.comboBoxNomeEditora_Click);
            // 
            // textBoxCreateEditoraEndereco
            // 
            this.textBoxCreateEditoraEndereco.Location = new System.Drawing.Point(88, 379);
            this.textBoxCreateEditoraEndereco.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCreateEditoraEndereco.Name = "textBoxCreateEditoraEndereco";
            this.textBoxCreateEditoraEndereco.Size = new System.Drawing.Size(169, 20);
            this.textBoxCreateEditoraEndereco.TabIndex = 29;
            // 
            // textBoxCreateEditoraTelefone
            // 
            this.textBoxCreateEditoraTelefone.Location = new System.Drawing.Point(88, 402);
            this.textBoxCreateEditoraTelefone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCreateEditoraTelefone.Name = "textBoxCreateEditoraTelefone";
            this.textBoxCreateEditoraTelefone.Size = new System.Drawing.Size(112, 20);
            this.textBoxCreateEditoraTelefone.TabIndex = 30;
            // 
            // labelCreateEditoraNome
            // 
            this.labelCreateEditoraNome.AutoSize = true;
            this.labelCreateEditoraNome.Location = new System.Drawing.Point(9, 353);
            this.labelCreateEditoraNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCreateEditoraNome.Name = "labelCreateEditoraNome";
            this.labelCreateEditoraNome.Size = new System.Drawing.Size(71, 13);
            this.labelCreateEditoraNome.TabIndex = 31;
            this.labelCreateEditoraNome.Text = "Nome Editora";
            // 
            // labelCreateTelefoneEditora
            // 
            this.labelCreateTelefoneEditora.AutoSize = true;
            this.labelCreateTelefoneEditora.Location = new System.Drawing.Point(9, 402);
            this.labelCreateTelefoneEditora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCreateTelefoneEditora.Name = "labelCreateTelefoneEditora";
            this.labelCreateTelefoneEditora.Size = new System.Drawing.Size(49, 13);
            this.labelCreateTelefoneEditora.TabIndex = 32;
            this.labelCreateTelefoneEditora.Text = "Telefone";
            // 
            // labelCreateEndercoEditora
            // 
            this.labelCreateEndercoEditora.AutoSize = true;
            this.labelCreateEndercoEditora.Location = new System.Drawing.Point(9, 379);
            this.labelCreateEndercoEditora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCreateEndercoEditora.Name = "labelCreateEndercoEditora";
            this.labelCreateEndercoEditora.Size = new System.Drawing.Size(53, 13);
            this.labelCreateEndercoEditora.TabIndex = 33;
            this.labelCreateEndercoEditora.Text = "Endereço";
            // 
            // labelCreateEnderecoAutor
            // 
            this.labelCreateEnderecoAutor.AutoSize = true;
            this.labelCreateEnderecoAutor.Location = new System.Drawing.Point(484, 94);
            this.labelCreateEnderecoAutor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCreateEnderecoAutor.Name = "labelCreateEnderecoAutor";
            this.labelCreateEnderecoAutor.Size = new System.Drawing.Size(89, 13);
            this.labelCreateEnderecoAutor.TabIndex = 40;
            this.labelCreateEnderecoAutor.Text = "Data Nascimento";
            // 
            // labelCreateTelefoneAutor
            // 
            this.labelCreateTelefoneAutor.AutoSize = true;
            this.labelCreateTelefoneAutor.Location = new System.Drawing.Point(524, 117);
            this.labelCreateTelefoneAutor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCreateTelefoneAutor.Name = "labelCreateTelefoneAutor";
            this.labelCreateTelefoneAutor.Size = new System.Drawing.Size(49, 13);
            this.labelCreateTelefoneAutor.TabIndex = 39;
            this.labelCreateTelefoneAutor.Text = "Telefone";
            // 
            // labelCreateNomeAutor
            // 
            this.labelCreateNomeAutor.AutoSize = true;
            this.labelCreateNomeAutor.Location = new System.Drawing.Point(538, 45);
            this.labelCreateNomeAutor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCreateNomeAutor.Name = "labelCreateNomeAutor";
            this.labelCreateNomeAutor.Size = new System.Drawing.Size(35, 13);
            this.labelCreateNomeAutor.TabIndex = 38;
            this.labelCreateNomeAutor.Text = "Nome";
            // 
            // textBoxCreateTelefoneAutor
            // 
            this.textBoxCreateTelefoneAutor.Location = new System.Drawing.Point(587, 114);
            this.textBoxCreateTelefoneAutor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCreateTelefoneAutor.Name = "textBoxCreateTelefoneAutor";
            this.textBoxCreateTelefoneAutor.Size = new System.Drawing.Size(112, 20);
            this.textBoxCreateTelefoneAutor.TabIndex = 37;
            // 
            // textBoxCreateDataAutor
            // 
            this.textBoxCreateDataAutor.Location = new System.Drawing.Point(587, 91);
            this.textBoxCreateDataAutor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCreateDataAutor.Name = "textBoxCreateDataAutor";
            this.textBoxCreateDataAutor.Size = new System.Drawing.Size(112, 20);
            this.textBoxCreateDataAutor.TabIndex = 36;
            // 
            // textBoxCreateNomeAutor
            // 
            this.textBoxCreateNomeAutor.Location = new System.Drawing.Point(587, 41);
            this.textBoxCreateNomeAutor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCreateNomeAutor.Name = "textBoxCreateNomeAutor";
            this.textBoxCreateNomeAutor.Size = new System.Drawing.Size(137, 20);
            this.textBoxCreateNomeAutor.TabIndex = 35;
            // 
            // labelCreateApelidoAutor
            // 
            this.labelCreateApelidoAutor.AutoSize = true;
            this.labelCreateApelidoAutor.Location = new System.Drawing.Point(532, 69);
            this.labelCreateApelidoAutor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCreateApelidoAutor.Name = "labelCreateApelidoAutor";
            this.labelCreateApelidoAutor.Size = new System.Drawing.Size(42, 13);
            this.labelCreateApelidoAutor.TabIndex = 42;
            this.labelCreateApelidoAutor.Text = "Apelido";
            // 
            // textBoxCreateApelidoAutor
            // 
            this.textBoxCreateApelidoAutor.Location = new System.Drawing.Point(587, 67);
            this.textBoxCreateApelidoAutor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCreateApelidoAutor.Name = "textBoxCreateApelidoAutor";
            this.textBoxCreateApelidoAutor.Size = new System.Drawing.Size(137, 20);
            this.textBoxCreateApelidoAutor.TabIndex = 43;
            // 
            // buttonAddCreateEditora
            // 
            this.buttonAddCreateEditora.Location = new System.Drawing.Point(212, 426);
            this.buttonAddCreateEditora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddCreateEditora.Name = "buttonAddCreateEditora";
            this.buttonAddCreateEditora.Size = new System.Drawing.Size(44, 20);
            this.buttonAddCreateEditora.TabIndex = 44;
            this.buttonAddCreateEditora.Text = "Add";
            this.buttonAddCreateEditora.UseVisualStyleBackColor = true;
            this.buttonAddCreateEditora.Click += new System.EventHandler(this.buttonAddCreateEditora_Click);
            // 
            // buttonAddCreateAutor
            // 
            this.buttonAddCreateAutor.Location = new System.Drawing.Point(701, 141);
            this.buttonAddCreateAutor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddCreateAutor.Name = "buttonAddCreateAutor";
            this.buttonAddCreateAutor.Size = new System.Drawing.Size(44, 20);
            this.buttonAddCreateAutor.TabIndex = 45;
            this.buttonAddCreateAutor.Text = "Add";
            this.buttonAddCreateAutor.UseVisualStyleBackColor = true;
            this.buttonAddCreateAutor.Click += new System.EventHandler(this.buttonAddCreateAutor_Click);
            // 
            // buttonAddExemplares
            // 
            this.buttonAddExemplares.Location = new System.Drawing.Point(660, 448);
            this.buttonAddExemplares.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddExemplares.Name = "buttonAddExemplares";
            this.buttonAddExemplares.Size = new System.Drawing.Size(194, 37);
            this.buttonAddExemplares.TabIndex = 46;
            this.buttonAddExemplares.Text = "Adicionar Exemplares";
            this.buttonAddExemplares.UseVisualStyleBackColor = true;
            this.buttonAddExemplares.Click += new System.EventHandler(this.buttonAddExemplares_Click);
            // 
            // textBoxIDPessoa
            // 
            this.textBoxIDPessoa.Location = new System.Drawing.Point(85, 249);
            this.textBoxIDPessoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxIDPessoa.Name = "textBoxIDPessoa";
            this.textBoxIDPessoa.Size = new System.Drawing.Size(62, 20);
            this.textBoxIDPessoa.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 251);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Id Autor";
            // 
            // buttonAddLivro
            // 
            this.buttonAddLivro.Location = new System.Drawing.Point(238, 275);
            this.buttonAddLivro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddLivro.Name = "buttonAddLivro";
            this.buttonAddLivro.Size = new System.Drawing.Size(129, 20);
            this.buttonAddLivro.TabIndex = 49;
            this.buttonAddLivro.Text = "Adicionar Livro";
            this.buttonAddLivro.UseVisualStyleBackColor = true;
            this.buttonAddLivro.Click += new System.EventHandler(this.buttonAddLivro_Click);
            // 
            // textBoxCreateISBN
            // 
            this.textBoxCreateISBN.Location = new System.Drawing.Point(85, 31);
            this.textBoxCreateISBN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCreateISBN.Name = "textBoxCreateISBN";
            this.textBoxCreateISBN.Size = new System.Drawing.Size(88, 20);
            this.textBoxCreateISBN.TabIndex = 53;
            // 
            // labelCreateISBN
            // 
            this.labelCreateISBN.AutoSize = true;
            this.labelCreateISBN.Location = new System.Drawing.Point(14, 34);
            this.labelCreateISBN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCreateISBN.Name = "labelCreateISBN";
            this.labelCreateISBN.Size = new System.Drawing.Size(32, 13);
            this.labelCreateISBN.TabIndex = 52;
            this.labelCreateISBN.Text = "ISBN";
            this.labelCreateISBN.Click += new System.EventHandler(this.labelCreateISBN_Click);
            // 
            // labelCreateTitulo
            // 
            this.labelCreateTitulo.AutoSize = true;
            this.labelCreateTitulo.Location = new System.Drawing.Point(524, 399);
            this.labelCreateTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCreateTitulo.Name = "labelCreateTitulo";
            this.labelCreateTitulo.Size = new System.Drawing.Size(33, 13);
            this.labelCreateTitulo.TabIndex = 51;
            this.labelCreateTitulo.Text = "Titulo";
            // 
            // textBoxCreateTituloExemplares
            // 
            this.textBoxCreateTituloExemplares.Location = new System.Drawing.Point(573, 399);
            this.textBoxCreateTituloExemplares.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCreateTituloExemplares.Name = "textBoxCreateTituloExemplares";
            this.textBoxCreateTituloExemplares.Size = new System.Drawing.Size(271, 20);
            this.textBoxCreateTituloExemplares.TabIndex = 50;
            // 
            // textBoxCreateAno
            // 
            this.textBoxCreateAno.Location = new System.Drawing.Point(86, 98);
            this.textBoxCreateAno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCreateAno.Name = "textBoxCreateAno";
            this.textBoxCreateAno.Size = new System.Drawing.Size(88, 20);
            this.textBoxCreateAno.TabIndex = 55;
            // 
            // labelCreateAno
            // 
            this.labelCreateAno.AutoSize = true;
            this.labelCreateAno.Location = new System.Drawing.Point(10, 102);
            this.labelCreateAno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCreateAno.Name = "labelCreateAno";
            this.labelCreateAno.Size = new System.Drawing.Size(26, 13);
            this.labelCreateAno.TabIndex = 54;
            this.labelCreateAno.Text = "Ano";
            // 
            // textBoxCreateISBNExemplares
            // 
            this.textBoxCreateISBNExemplares.Location = new System.Drawing.Point(573, 430);
            this.textBoxCreateISBNExemplares.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCreateISBNExemplares.Name = "textBoxCreateISBNExemplares";
            this.textBoxCreateISBNExemplares.Size = new System.Drawing.Size(83, 20);
            this.textBoxCreateISBNExemplares.TabIndex = 56;
            // 
            // labelAddISBNExemplares
            // 
            this.labelAddISBNExemplares.AutoSize = true;
            this.labelAddISBNExemplares.Location = new System.Drawing.Point(524, 432);
            this.labelAddISBNExemplares.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddISBNExemplares.Name = "labelAddISBNExemplares";
            this.labelAddISBNExemplares.Size = new System.Drawing.Size(32, 13);
            this.labelAddISBNExemplares.TabIndex = 57;
            this.labelAddISBNExemplares.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Titulo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxCreateTitulo
            // 
            this.textBoxCreateTitulo.Location = new System.Drawing.Point(85, 66);
            this.textBoxCreateTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCreateTitulo.Name = "textBoxCreateTitulo";
            this.textBoxCreateTitulo.Size = new System.Drawing.Size(271, 20);
            this.textBoxCreateTitulo.TabIndex = 58;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 508);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCreateTitulo);
            this.Controls.Add(this.labelAddISBNExemplares);
            this.Controls.Add(this.textBoxCreateISBNExemplares);
            this.Controls.Add(this.textBoxCreateAno);
            this.Controls.Add(this.labelCreateAno);
            this.Controls.Add(this.textBoxCreateISBN);
            this.Controls.Add(this.labelCreateISBN);
            this.Controls.Add(this.labelCreateTitulo);
            this.Controls.Add(this.textBoxCreateTituloExemplares);
            this.Controls.Add(this.buttonAddLivro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIDPessoa);
            this.Controls.Add(this.buttonAddExemplares);
            this.Controls.Add(this.buttonAddCreateAutor);
            this.Controls.Add(this.buttonAddCreateEditora);
            this.Controls.Add(this.textBoxCreateApelidoAutor);
            this.Controls.Add(this.labelCreateApelidoAutor);
            this.Controls.Add(this.labelCreateEnderecoAutor);
            this.Controls.Add(this.labelCreateTelefoneAutor);
            this.Controls.Add(this.labelCreateNomeAutor);
            this.Controls.Add(this.textBoxCreateTelefoneAutor);
            this.Controls.Add(this.textBoxCreateDataAutor);
            this.Controls.Add(this.textBoxCreateNomeAutor);
            this.Controls.Add(this.labelCreateEndercoEditora);
            this.Controls.Add(this.labelCreateTelefoneEditora);
            this.Controls.Add(this.labelCreateEditoraNome);
            this.Controls.Add(this.textBoxCreateEditoraTelefone);
            this.Controls.Add(this.textBoxCreateEditoraEndereco);
            this.Controls.Add(this.comboBoxNomeEditora);
            this.Controls.Add(this.buttonAddEditora);
            this.Controls.Add(this.textBoxCreateNomeEditora);
            this.Controls.Add(this.labelNomeEditora);
            this.Controls.Add(this.buttonAddAutor);
            this.Controls.Add(this.comboBoxAutores);
            this.Controls.Add(this.labelAutor);
            this.Controls.Add(this.labelQuantidade);
            this.Controls.Add(this.textBoxQuantidade);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.textBoxIdEditora);
            this.Controls.Add(this.labelIdEditora);
            this.Controls.Add(this.labelCategoria);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelIdEditora;
        private System.Windows.Forms.TextBox textBoxIdEditora;
        private System.Windows.Forms.TextBox textBoxQuantidade;
        private System.Windows.Forms.Label labelQuantidade;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.ComboBox comboBoxAutores;
        private System.Windows.Forms.Button buttonAddAutor;
        private System.Windows.Forms.Label labelNomeEditora;
        private System.Windows.Forms.TextBox textBoxCreateNomeEditora;
        private System.Windows.Forms.Button buttonAddEditora;
        private System.Windows.Forms.ComboBox comboBoxNomeEditora;
        private System.Windows.Forms.TextBox textBoxCreateEditoraEndereco;
        private System.Windows.Forms.TextBox textBoxCreateEditoraTelefone;
        private System.Windows.Forms.Label labelCreateEditoraNome;
        private System.Windows.Forms.Label labelCreateTelefoneEditora;
        private System.Windows.Forms.Label labelCreateEndercoEditora;
        private System.Windows.Forms.Label labelCreateEnderecoAutor;
        private System.Windows.Forms.Label labelCreateTelefoneAutor;
        private System.Windows.Forms.Label labelCreateNomeAutor;
        private System.Windows.Forms.TextBox textBoxCreateTelefoneAutor;
        private System.Windows.Forms.TextBox textBoxCreateDataAutor;
        private System.Windows.Forms.TextBox textBoxCreateNomeAutor;
        private System.Windows.Forms.Label labelCreateApelidoAutor;
        private System.Windows.Forms.TextBox textBoxCreateApelidoAutor;
        private System.Windows.Forms.Button buttonAddCreateEditora;
        private System.Windows.Forms.Button buttonAddCreateAutor;
        private System.Windows.Forms.Button buttonAddExemplares;
        private System.Windows.Forms.TextBox textBoxIDPessoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddLivro;
        private System.Windows.Forms.TextBox textBoxCreateISBN;
        private System.Windows.Forms.Label labelCreateISBN;
        private System.Windows.Forms.Label labelCreateTitulo;
        private System.Windows.Forms.TextBox textBoxCreateTituloExemplares;
        private System.Windows.Forms.TextBox textBoxCreateAno;
        private System.Windows.Forms.Label labelCreateAno;
        private System.Windows.Forms.TextBox textBoxCreateISBNExemplares;
        private System.Windows.Forms.Label labelAddISBNExemplares;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCreateTitulo;
    }
}