using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public  class Cliente : Pessoa
    {
        private int _id;
        private String _morada;
        private String _mail;
        private decimal _nif;

        public Cliente() : base() { }

        public Cliente( int id, String first_name, String last_name, DateTime date, decimal telefone,
                                String morada, String mail, decimal nif ) : base() {
            this.Id = id;
            this.First_name = first_name;
            this.Last_name = last_name;
            this.Data_nascimento = date;
            this.Telefone = telefone;
            this.Morada = morada;
            this.Mail = mail;
            this.Nif = nif;
        }

        public String Morada
        {
            get { return _morada; }
            set { _morada = value; }
        }
        public String Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }
        public decimal Nif
        {
            get { return _nif; }
            set { _nif = value; }
        }
    }
}
