namespace Biblioteca
{
    partial class Form2
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.textCota = new System.Windows.Forms.TextBox();
            this.labelCota = new System.Windows.Forms.Label();
            this.textCategoria = new System.Windows.Forms.TextBox();
            this.textEditora = new System.Windows.Forms.TextBox();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelEditora = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.textBoxEstado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(25, 58);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(520, 324);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(237, 400);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(99, 38);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(25, 409);
            this.textSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(195, 22);
            this.textSearch.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(631, 344);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(99, 38);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(920, 344);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(99, 38);
            this.buttonRemove.TabIndex = 4;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(631, 239);
            this.listBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(380, 100);
            this.listBox2.TabIndex = 5;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(920, 400);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(99, 38);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // textCota
            // 
            this.textCota.Location = new System.Drawing.Point(713, 92);
            this.textCota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCota.Name = "textCota";
            this.textCota.Size = new System.Drawing.Size(92, 22);
            this.textCota.TabIndex = 7;
            // 
            // labelCota
            // 
            this.labelCota.AutoSize = true;
            this.labelCota.Location = new System.Drawing.Point(628, 96);
            this.labelCota.Name = "labelCota";
            this.labelCota.Size = new System.Drawing.Size(37, 17);
            this.labelCota.TabIndex = 8;
            this.labelCota.Text = "Cota";
            // 
            // textCategoria
            // 
            this.textCategoria.Location = new System.Drawing.Point(713, 130);
            this.textCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCategoria.Name = "textCategoria";
            this.textCategoria.Size = new System.Drawing.Size(208, 22);
            this.textCategoria.TabIndex = 9;
            // 
            // textEditora
            // 
            this.textEditora.Location = new System.Drawing.Point(713, 165);
            this.textEditora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEditora.Name = "textEditora";
            this.textEditora.Size = new System.Drawing.Size(208, 22);
            this.textEditora.TabIndex = 10;
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(628, 130);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(69, 17);
            this.labelCategoria.TabIndex = 11;
            this.labelCategoria.Text = "Categoria";
            // 
            // labelEditora
            // 
            this.labelEditora.AutoSize = true;
            this.labelEditora.Location = new System.Drawing.Point(628, 168);
            this.labelEditora.Name = "labelEditora";
            this.labelEditora.Size = new System.Drawing.Size(53, 17);
            this.labelEditora.TabIndex = 12;
            this.labelEditora.Text = "Editora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Livros Disponíveis na Biblioteca";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(628, 209);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(52, 17);
            this.labelEstado.TabIndex = 33;
            this.labelEstado.Text = "Estado";
            // 
            // textBoxEstado
            // 
            this.textBoxEstado.Location = new System.Drawing.Point(713, 205);
            this.textBoxEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEstado.Name = "textBoxEstado";
            this.textBoxEstado.Size = new System.Drawing.Size(208, 22);
            this.textBoxEstado.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(628, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(713, 56);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(92, 22);
            this.textBoxID.TabIndex = 36;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 450);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEstado);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelEditora);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.textEditora);
            this.Controls.Add(this.textCategoria);
            this.Controls.Add(this.labelCota);
            this.Controls.Add(this.textCota);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox textCota;
        private System.Windows.Forms.Label labelCota;
        private System.Windows.Forms.TextBox textCategoria;
        private System.Windows.Forms.TextBox textEditora;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelEditora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.TextBox textBoxEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxID;
    }
}