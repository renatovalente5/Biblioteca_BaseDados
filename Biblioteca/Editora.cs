using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Editora
    {
        private int _id_editora;
        private String _nome_editora;

        public Editora() : base() { }

        public override String ToString()
        {
            return _nome_editora;
        }

        public int Id_editora
        {
            get { return _id_editora; }
            set { _id_editora = value; }
        }
       
        public String Nome_editora
        {
            get { return _nome_editora; }
            set { _nome_editora = value; }
        }
    }
}
