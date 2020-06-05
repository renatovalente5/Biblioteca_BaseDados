using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Emprestimo : Livro
    {
        private int n_emprestimo;
        private DateTime data_saida;
        private DateTime data_entrega;
        private DateTime? data_chegada;

        public Emprestimo() : base() { }

        public override String ToString()
        {
            return (N_emprestimo.ToString() == null ? "" : "nº emprestimo: " + N_emprestimo.ToString()) + (Numero_exemplar is null ? "" : ",   nº exemplar: " + Numero_exemplar.ToString()) + (Data_chegada is null ? "" : " - Disponivel")  + (Titulo == null ? "" : " - " + Titulo);
        }

        public int N_emprestimo
        {
            get { return n_emprestimo; }
            set { n_emprestimo = value; }
        }
        public DateTime Data_Saida {
            get { return data_saida; }
            set { data_saida = value; }
        }
        public DateTime Data_entrega
        {
            get { return data_entrega; }
            set { data_entrega = value; }
        }
        public DateTime? Data_chegada
        {
            get { return data_chegada; }
            set { data_chegada = value; }
        }
    }
}
