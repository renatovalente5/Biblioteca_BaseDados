using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Livro
    {
        private String _ISBN;
        private String _titulo;
        private int _ano;
        private int _id_editora;
        private String _categoria;
        private int _countTilulos;
        private String _nome_editora;

        public Livro() : base() { }

        public override String ToString()
        {
            return _countTilulos + " - " + _titulo;
        }

        public String ISBN
        {
            get { return _ISBN; }
            set { _ISBN = value; }
        }
        public String Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }
        public int Ano
        {
            get { return _ano; }
            set { _ano = value; }
        }
        public int Id_editora
        {
            get { return _id_editora; }
            set { _id_editora = value; }
        }
        public String Categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }
        public int CountTilulos
        {
            get { return _countTilulos; }
            set { _countTilulos = value; }
        }
        public String Nome_editora
        {
            get { return _nome_editora; }
            set { _nome_editora = value; }
        }
    }
}
