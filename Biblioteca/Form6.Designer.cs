namespace Biblioteca
{
    partial class Form6
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
            this.buttonAddAutor = new System.Windows.Forms.Button();
            this.textBoxCreateNomeEditora = new System.Windows.Forms.TextBox();
            this.buttonAddEditora = new System.Windows.Forms.Button();
            this.textBoxCreateEditoraEndereco = new System.Windows.Forms.TextBox();
            this.textBoxCreateEditoraTelefone = new System.Windows.Forms.TextBox();
            this.labelCreateEditoraNome = new System.Windows.Forms.Label();
            this.labelCreateTelefoneEditora = new System.Windows.Forms.Label();
            this.labelCreateEndercoEditora = new System.Windows.Forms.Label();
            this.textBoxCreateNomeAutor = new System.Windows.Forms.TextBox();
            this.textBoxCreateDataAutor = new System.Windows.Forms.TextBox();
            this.textBoxCreateTelefoneAutor = new System.Windows.Forms.TextBox();
            this.labelCreateNomeAutor = new System.Windows.Forms.Label();
            this.labelCreateTelefoneAutor = new System.Windows.Forms.Label();
            this.labelCreateEnderecoAutor = new System.Windows.Forms.Label();
            this.labelCreateApelidoAutor = new System.Windows.Forms.Label();
            this.textBoxCreateApelidoAutor = new System.Windows.Forms.TextBox();
            this.buttonAddCreateEditora = new System.Windows.Forms.Button();
            this.buttonAddCreateAutor = new System.Windows.Forms.Button();
            this.buttonAddLivro = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.textBoxAno = new System.Windows.Forms.TextBox();
            this.labelCreateAno = new System.Windows.Forms.Label();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.labelCreateISBN = new System.Windows.Forms.Label();
            this.comboBoxNomeEditora = new System.Windows.Forms.ComboBox();
            this.labelNomeEditora = new System.Windows.Forms.Label();
            this.labelAutor = new System.Windows.Forms.Label();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.textBoxIdEditora = new System.Windows.Forms.TextBox();
            this.labelIdEditora = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.comboBoxAutores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdicionarAutor = new System.Windows.Forms.Button();
            this.buttonRemoverAutor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxIDPessoa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAddAutor
            // 
            this.buttonAddAutor.Location = new System.Drawing.Point(725, 66);
            this.buttonAddAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddAutor.Name = "buttonAddAutor";
            this.buttonAddAutor.Size = new System.Drawing.Size(172, 25);
            this.buttonAddAutor.TabIndex = 68;
            this.buttonAddAutor.Text = "Criar Autor";
            this.buttonAddAutor.UseVisualStyleBackColor = true;
            this.buttonAddAutor.Click += new System.EventHandler(this.buttonCriarAutor_Click);
            // 
            // textBoxCreateNomeEditora
            // 
            this.textBoxCreateNomeEditora.Location = new System.Drawing.Point(801, 368);
            this.textBoxCreateNomeEditora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCreateNomeEditora.Name = "textBoxCreateNomeEditora";
            this.textBoxCreateNomeEditora.Size = new System.Drawing.Size(181, 22);
            this.textBoxCreateNomeEditora.TabIndex = 70;
            // 
            // buttonAddEditora
            // 
            this.buttonAddEditora.Location = new System.Drawing.Point(725, 324);
            this.buttonAddEditora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddEditora.Name = "buttonAddEditora";
            this.buttonAddEditora.Size = new System.Drawing.Size(172, 25);
            this.buttonAddEditora.TabIndex = 71;
            this.buttonAddEditora.Text = "Criar Editora";
            this.buttonAddEditora.UseVisualStyleBackColor = true;
            this.buttonAddEditora.Click += new System.EventHandler(this.buttonCriarEditora_Click);
            // 
            // textBoxCreateEditoraEndereco
            // 
            this.textBoxCreateEditoraEndereco.Location = new System.Drawing.Point(801, 400);
            this.textBoxCreateEditoraEndereco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCreateEditoraEndereco.Name = "textBoxCreateEditoraEndereco";
            this.textBoxCreateEditoraEndereco.Size = new System.Drawing.Size(224, 22);
            this.textBoxCreateEditoraEndereco.TabIndex = 73;
            // 
            // textBoxCreateEditoraTelefone
            // 
            this.textBoxCreateEditoraTelefone.Location = new System.Drawing.Point(801, 430);
            this.textBoxCreateEditoraTelefone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCreateEditoraTelefone.Name = "textBoxCreateEditoraTelefone";
            this.textBoxCreateEditoraTelefone.Size = new System.Drawing.Size(148, 22);
            this.textBoxCreateEditoraTelefone.TabIndex = 74;
            // 
            // labelCreateEditoraNome
            // 
            this.labelCreateEditoraNome.AutoSize = true;
            this.labelCreateEditoraNome.Location = new System.Drawing.Point(696, 368);
            this.labelCreateEditoraNome.Name = "labelCreateEditoraNome";
            this.labelCreateEditoraNome.Size = new System.Drawing.Size(94, 17);
            this.labelCreateEditoraNome.TabIndex = 75;
            this.labelCreateEditoraNome.Text = "Nome Editora";
            // 
            // labelCreateTelefoneEditora
            // 
            this.labelCreateTelefoneEditora.AutoSize = true;
            this.labelCreateTelefoneEditora.Location = new System.Drawing.Point(696, 430);
            this.labelCreateTelefoneEditora.Name = "labelCreateTelefoneEditora";
            this.labelCreateTelefoneEditora.Size = new System.Drawing.Size(64, 17);
            this.labelCreateTelefoneEditora.TabIndex = 76;
            this.labelCreateTelefoneEditora.Text = "Telefone";
            // 
            // labelCreateEndercoEditora
            // 
            this.labelCreateEndercoEditora.AutoSize = true;
            this.labelCreateEndercoEditora.Location = new System.Drawing.Point(696, 400);
            this.labelCreateEndercoEditora.Name = "labelCreateEndercoEditora";
            this.labelCreateEndercoEditora.Size = new System.Drawing.Size(69, 17);
            this.labelCreateEndercoEditora.TabIndex = 77;
            this.labelCreateEndercoEditora.Text = "Endereço";
            // 
            // textBoxCreateNomeAutor
            // 
            this.textBoxCreateNomeAutor.Location = new System.Drawing.Point(807, 113);
            this.textBoxCreateNomeAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCreateNomeAutor.Name = "textBoxCreateNomeAutor";
            this.textBoxCreateNomeAutor.Size = new System.Drawing.Size(181, 22);
            this.textBoxCreateNomeAutor.TabIndex = 78;
            // 
            // textBoxCreateDataAutor
            // 
            this.textBoxCreateDataAutor.Location = new System.Drawing.Point(807, 175);
            this.textBoxCreateDataAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCreateDataAutor.Name = "textBoxCreateDataAutor";
            this.textBoxCreateDataAutor.Size = new System.Drawing.Size(148, 22);
            this.textBoxCreateDataAutor.TabIndex = 79;
            // 
            // textBoxCreateTelefoneAutor
            // 
            this.textBoxCreateTelefoneAutor.Location = new System.Drawing.Point(807, 203);
            this.textBoxCreateTelefoneAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCreateTelefoneAutor.Name = "textBoxCreateTelefoneAutor";
            this.textBoxCreateTelefoneAutor.Size = new System.Drawing.Size(148, 22);
            this.textBoxCreateTelefoneAutor.TabIndex = 80;
            // 
            // labelCreateNomeAutor
            // 
            this.labelCreateNomeAutor.AutoSize = true;
            this.labelCreateNomeAutor.Location = new System.Drawing.Point(740, 118);
            this.labelCreateNomeAutor.Name = "labelCreateNomeAutor";
            this.labelCreateNomeAutor.Size = new System.Drawing.Size(45, 17);
            this.labelCreateNomeAutor.TabIndex = 81;
            this.labelCreateNomeAutor.Text = "Nome";
            // 
            // labelCreateTelefoneAutor
            // 
            this.labelCreateTelefoneAutor.AutoSize = true;
            this.labelCreateTelefoneAutor.Location = new System.Drawing.Point(723, 207);
            this.labelCreateTelefoneAutor.Name = "labelCreateTelefoneAutor";
            this.labelCreateTelefoneAutor.Size = new System.Drawing.Size(64, 17);
            this.labelCreateTelefoneAutor.TabIndex = 82;
            this.labelCreateTelefoneAutor.Text = "Telefone";
            // 
            // labelCreateEnderecoAutor
            // 
            this.labelCreateEnderecoAutor.AutoSize = true;
            this.labelCreateEnderecoAutor.Location = new System.Drawing.Point(668, 178);
            this.labelCreateEnderecoAutor.Name = "labelCreateEnderecoAutor";
            this.labelCreateEnderecoAutor.Size = new System.Drawing.Size(116, 17);
            this.labelCreateEnderecoAutor.TabIndex = 83;
            this.labelCreateEnderecoAutor.Text = "Data Nascimento";
            // 
            // labelCreateApelidoAutor
            // 
            this.labelCreateApelidoAutor.AutoSize = true;
            this.labelCreateApelidoAutor.Location = new System.Drawing.Point(732, 148);
            this.labelCreateApelidoAutor.Name = "labelCreateApelidoAutor";
            this.labelCreateApelidoAutor.Size = new System.Drawing.Size(55, 17);
            this.labelCreateApelidoAutor.TabIndex = 84;
            this.labelCreateApelidoAutor.Text = "Apelido";
            // 
            // textBoxCreateApelidoAutor
            // 
            this.textBoxCreateApelidoAutor.Location = new System.Drawing.Point(807, 145);
            this.textBoxCreateApelidoAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCreateApelidoAutor.Name = "textBoxCreateApelidoAutor";
            this.textBoxCreateApelidoAutor.Size = new System.Drawing.Size(181, 22);
            this.textBoxCreateApelidoAutor.TabIndex = 85;
            // 
            // buttonAddCreateEditora
            // 
            this.buttonAddCreateEditora.Location = new System.Drawing.Point(801, 463);
            this.buttonAddCreateEditora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddCreateEditora.Name = "buttonAddCreateEditora";
            this.buttonAddCreateEditora.Size = new System.Drawing.Size(59, 25);
            this.buttonAddCreateEditora.TabIndex = 86;
            this.buttonAddCreateEditora.Text = "Add";
            this.buttonAddCreateEditora.UseVisualStyleBackColor = true;
            this.buttonAddCreateEditora.Click += new System.EventHandler(this.buttonAddCreateEditora_Click);
            // 
            // buttonAddCreateAutor
            // 
            this.buttonAddCreateAutor.Location = new System.Drawing.Point(807, 242);
            this.buttonAddCreateAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddCreateAutor.Name = "buttonAddCreateAutor";
            this.buttonAddCreateAutor.Size = new System.Drawing.Size(59, 25);
            this.buttonAddCreateAutor.TabIndex = 87;
            this.buttonAddCreateAutor.Text = "Add";
            this.buttonAddCreateAutor.UseVisualStyleBackColor = true;
            this.buttonAddCreateAutor.Click += new System.EventHandler(this.buttonAddCreateAutor_Click);
            // 
            // buttonAddLivro
            // 
            this.buttonAddLivro.Location = new System.Drawing.Point(47, 504);
            this.buttonAddLivro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddLivro.Name = "buttonAddLivro";
            this.buttonAddLivro.Size = new System.Drawing.Size(542, 39);
            this.buttonAddLivro.TabIndex = 90;
            this.buttonAddLivro.Text = "Editar";
            this.buttonAddLivro.UseVisualStyleBackColor = true;
            this.buttonAddLivro.Click += new System.EventHandler(this.buttonAddLivro_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(47, 336);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(224, 100);
            this.listBox1.TabIndex = 111;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 110;
            this.label2.Text = "Titulo";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(155, 68);
            this.textBoxTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(360, 22);
            this.textBoxTitulo.TabIndex = 109;
            // 
            // textBoxAno
            // 
            this.textBoxAno.Location = new System.Drawing.Point(155, 110);
            this.textBoxAno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAno.Name = "textBoxAno";
            this.textBoxAno.Size = new System.Drawing.Size(116, 22);
            this.textBoxAno.TabIndex = 108;
            // 
            // labelCreateAno
            // 
            this.labelCreateAno.AutoSize = true;
            this.labelCreateAno.Location = new System.Drawing.Point(41, 114);
            this.labelCreateAno.Name = "labelCreateAno";
            this.labelCreateAno.Size = new System.Drawing.Size(33, 17);
            this.labelCreateAno.TabIndex = 107;
            this.labelCreateAno.Text = "Ano";
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(155, 23);
            this.textBoxISBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.ReadOnly = true;
            this.textBoxISBN.Size = new System.Drawing.Size(88, 20);
            this.textBoxISBN.TabIndex = 106;
            // 
            // labelCreateISBN
            // 
            this.labelCreateISBN.AutoSize = true;
            this.labelCreateISBN.Location = new System.Drawing.Point(41, 21);
            this.labelCreateISBN.Name = "labelCreateISBN";
            this.labelCreateISBN.Size = new System.Drawing.Size(39, 17);
            this.labelCreateISBN.TabIndex = 105;
            this.labelCreateISBN.Text = "ISBN";
            // 
            // comboBoxNomeEditora
            // 
            this.comboBoxNomeEditora.FormattingEnabled = true;
            this.comboBoxNomeEditora.Location = new System.Drawing.Point(155, 153);
            this.comboBoxNomeEditora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxNomeEditora.Name = "comboBoxNomeEditora";
            this.comboBoxNomeEditora.Size = new System.Drawing.Size(315, 24);
            this.comboBoxNomeEditora.TabIndex = 104;
            this.comboBoxNomeEditora.SelectedIndexChanged += new System.EventHandler(this.comboBoxNomeEditora_SelectedIndexChanged);
            this.comboBoxNomeEditora.Click += new System.EventHandler(this.comboBoxNomeEditora_Click);
            // 
            // labelNomeEditora
            // 
            this.labelNomeEditora.AutoSize = true;
            this.labelNomeEditora.Location = new System.Drawing.Point(41, 156);
            this.labelNomeEditora.Name = "labelNomeEditora";
            this.labelNomeEditora.Size = new System.Drawing.Size(94, 17);
            this.labelNomeEditora.TabIndex = 103;
            this.labelNomeEditora.Text = "Nome Editora";
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Location = new System.Drawing.Point(44, 306);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(57, 17);
            this.labelAutor.TabIndex = 102;
            this.labelAutor.Text = "Autores";
            this.labelAutor.Click += new System.EventHandler(this.labelAutor_Click);
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(155, 238);
            this.comboBoxCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(224, 24);
            this.comboBoxCategoria.TabIndex = 101;
            // 
            // textBoxIdEditora
            // 
            this.textBoxIdEditora.Location = new System.Drawing.Point(155, 194);
            this.textBoxIdEditora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxIdEditora.Name = "textBoxIdEditora";
            this.textBoxIdEditora.Size = new System.Drawing.Size(65, 22);
            this.textBoxIdEditora.TabIndex = 100;
            // 
            // labelIdEditora
            // 
            this.labelIdEditora.AutoSize = true;
            this.labelIdEditora.Location = new System.Drawing.Point(44, 194);
            this.labelIdEditora.Name = "labelIdEditora";
            this.labelIdEditora.Size = new System.Drawing.Size(68, 17);
            this.labelIdEditora.TabIndex = 99;
            this.labelIdEditora.Text = "Id Editora";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(44, 238);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(69, 17);
            this.labelCategoria.TabIndex = 98;
            this.labelCategoria.Text = "Categoria";
            // 
            // comboBoxAutores
            // 
            this.comboBoxAutores.FormattingEnabled = true;
            this.comboBoxAutores.Location = new System.Drawing.Point(368, 336);
            this.comboBoxAutores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxAutores.Name = "comboBoxAutores";
            this.comboBoxAutores.Size = new System.Drawing.Size(221, 24);
            this.comboBoxAutores.TabIndex = 113;
            this.comboBoxAutores.SelectedIndexChanged += new System.EventHandler(this.comboBoxAutores_SelectedIndexChanged);
            this.comboBoxAutores.Click += new System.EventHandler(this.comboBoxAutores_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 112;
            this.label1.Text = "Autor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonAdicionarAutor
            // 
            this.buttonAdicionarAutor.Location = new System.Drawing.Point(456, 411);
            this.buttonAdicionarAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdicionarAutor.Name = "buttonAdicionarAutor";
            this.buttonAdicionarAutor.Size = new System.Drawing.Size(133, 25);
            this.buttonAdicionarAutor.TabIndex = 114;
            this.buttonAdicionarAutor.Text = "Adicionar Autor";
            this.buttonAdicionarAutor.UseVisualStyleBackColor = true;
            this.buttonAdicionarAutor.Click += new System.EventHandler(this.buttonAdicionarAutor_Click);
            // 
            // buttonRemoverAutor
            // 
            this.buttonRemoverAutor.Location = new System.Drawing.Point(304, 411);
            this.buttonRemoverAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRemoverAutor.Name = "buttonRemoverAutor";
            this.buttonRemoverAutor.Size = new System.Drawing.Size(131, 25);
            this.buttonRemoverAutor.TabIndex = 115;
            this.buttonRemoverAutor.Text = "Remover Autor";
            this.buttonRemoverAutor.UseVisualStyleBackColor = true;
            this.buttonRemoverAutor.Click += new System.EventHandler(this.buttonRemoverAutor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 117;
            this.label3.Text = "Id Autor";
            // 
            // textBoxIDPessoa
            // 
            this.textBoxIDPessoa.Location = new System.Drawing.Point(368, 368);
            this.textBoxIDPessoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxIDPessoa.Name = "textBoxIDPessoa";
            this.textBoxIDPessoa.Size = new System.Drawing.Size(42, 22);
            this.textBoxIDPessoa.TabIndex = 116;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxIDPessoa);
            this.Controls.Add(this.buttonRemoverAutor);
            this.Controls.Add(this.buttonAdicionarAutor);
            this.Controls.Add(this.comboBoxAutores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.textBoxAno);
            this.Controls.Add(this.labelCreateAno);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.labelCreateISBN);
            this.Controls.Add(this.comboBoxNomeEditora);
            this.Controls.Add(this.labelNomeEditora);
            this.Controls.Add(this.labelAutor);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.textBoxIdEditora);
            this.Controls.Add(this.labelIdEditora);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.buttonAddLivro);
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
            this.Controls.Add(this.buttonAddEditora);
            this.Controls.Add(this.textBoxCreateNomeEditora);
            this.Controls.Add(this.buttonAddAutor);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddAutor;
        private System.Windows.Forms.TextBox textBoxCreateNomeEditora;
        private System.Windows.Forms.Button buttonAddEditora;
        private System.Windows.Forms.TextBox textBoxCreateEditoraEndereco;
        private System.Windows.Forms.TextBox textBoxCreateEditoraTelefone;
        private System.Windows.Forms.Label labelCreateEditoraNome;
        private System.Windows.Forms.Label labelCreateTelefoneEditora;
        private System.Windows.Forms.Label labelCreateEndercoEditora;
        private System.Windows.Forms.TextBox textBoxCreateNomeAutor;
        private System.Windows.Forms.TextBox textBoxCreateDataAutor;
        private System.Windows.Forms.TextBox textBoxCreateTelefoneAutor;
        private System.Windows.Forms.Label labelCreateNomeAutor;
        private System.Windows.Forms.Label labelCreateTelefoneAutor;
        private System.Windows.Forms.Label labelCreateEnderecoAutor;
        private System.Windows.Forms.Label labelCreateApelidoAutor;
        private System.Windows.Forms.TextBox textBoxCreateApelidoAutor;
        private System.Windows.Forms.Button buttonAddCreateEditora;
        private System.Windows.Forms.Button buttonAddCreateAutor;
        private System.Windows.Forms.Button buttonAddLivro;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.TextBox textBoxAno;
        private System.Windows.Forms.Label labelCreateAno;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.Label labelCreateISBN;
        private System.Windows.Forms.ComboBox comboBoxNomeEditora;
        private System.Windows.Forms.Label labelNomeEditora;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.TextBox textBoxIdEditora;
        private System.Windows.Forms.Label labelIdEditora;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.ComboBox comboBoxAutores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdicionarAutor;
        private System.Windows.Forms.Button buttonRemoverAutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxIDPessoa;
    }
}