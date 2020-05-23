using System;

namespace Biblioteca
{
    partial class Form1
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
            this.textID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textDataNascimento = new System.Windows.Forms.TextBox();
            this.textTelefone = new System.Windows.Forms.TextBox();
            this.labelDataNascimento = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.buttonEmprestimo = new System.Windows.Forms.Button();
            this.buttonHistorico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(24, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(326, 356);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(232, 399);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(118, 39);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(400, 43);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(133, 22);
            this.textID.TabIndex = 3;
            this.textID.TextChanged += new System.EventHandler(this.textID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(372, 399);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(101, 34);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(400, 97);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(133, 22);
            this.textFirstName.TabIndex = 6;
            this.textFirstName.TextChanged += new System.EventHandler(this.textFirstName_TextChanged);
            // 
            // textLastName
            // 
            this.textLastName.BackColor = System.Drawing.SystemColors.Window;
            this.textLastName.Location = new System.Drawing.Point(577, 97);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(110, 22);
            this.textLastName.TabIndex = 7;
            this.textLastName.TextChanged += new System.EventHandler(this.textLastName_TextChanged);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(397, 77);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(76, 17);
            this.labelFirstName.TabIndex = 8;
            this.labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(574, 77);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(76, 17);
            this.labelLastName.TabIndex = 9;
            this.labelLastName.Text = "Last Name";
            // 
            // textDataNascimento
            // 
            this.textDataNascimento.Location = new System.Drawing.Point(400, 153);
            this.textDataNascimento.Name = "textDataNascimento";
            this.textDataNascimento.Size = new System.Drawing.Size(133, 22);
            this.textDataNascimento.TabIndex = 10;
            // 
            // textTelefone
            // 
            this.textTelefone.Location = new System.Drawing.Point(400, 207);
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.Size = new System.Drawing.Size(133, 22);
            this.textTelefone.TabIndex = 11;
            this.textTelefone.TextChanged += new System.EventHandler(this.textTelefone_TextChanged);
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Location = new System.Drawing.Point(397, 133);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(136, 17);
            this.labelDataNascimento.TabIndex = 12;
            this.labelDataNascimento.Text = "Data de Nascimento";
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(397, 187);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(64, 17);
            this.labelTelefone.TabIndex = 13;
            this.labelTelefone.Text = "Telefone";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(479, 399);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(101, 34);
            this.buttonEdit.TabIndex = 14;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(586, 399);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(101, 34);
            this.buttonRemove.TabIndex = 15;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(693, 399);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(101, 34);
            this.buttonOk.TabIndex = 16;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(693, 359);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(101, 34);
            this.buttonCancel.TabIndex = 17;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(24, 407);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(202, 22);
            this.textSearch.TabIndex = 18;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // buttonEmprestimo
            // 
            this.buttonEmprestimo.Location = new System.Drawing.Point(400, 259);
            this.buttonEmprestimo.Name = "buttonEmprestimo";
            this.buttonEmprestimo.Size = new System.Drawing.Size(101, 34);
            this.buttonEmprestimo.TabIndex = 19;
            this.buttonEmprestimo.Text = "Empréstimo";
            this.buttonEmprestimo.UseVisualStyleBackColor = true;
            this.buttonEmprestimo.Click += new System.EventHandler(this.buttonEmprestimo_Click);
            // 
            // buttonHistorico
            // 
            this.buttonHistorico.Location = new System.Drawing.Point(507, 259);
            this.buttonHistorico.Name = "buttonHistorico";
            this.buttonHistorico.Size = new System.Drawing.Size(101, 34);
            this.buttonHistorico.TabIndex = 20;
            this.buttonHistorico.Text = "Histórico";
            this.buttonHistorico.UseVisualStyleBackColor = true;
            this.buttonHistorico.Click += new System.EventHandler(this.buttonHistorico_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.buttonHistorico);
            this.Controls.Add(this.buttonEmprestimo);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.labelDataNascimento);
            this.Controls.Add(this.textTelefone);
            this.Controls.Add(this.textDataNascimento);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textDataNascimento;
        private System.Windows.Forms.TextBox textTelefone;
        private System.Windows.Forms.Label labelDataNascimento;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button buttonEmprestimo;
        private System.Windows.Forms.Button buttonHistorico;
    }
}

