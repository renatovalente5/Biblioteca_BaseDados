using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Pessoa
    {
        private int _id;
        private String _first_name;
        private String _last_name;
        private DateTime _data_nascimento;
        private Double _telefone;

        public Pessoa() : base() { }
        public Pessoa(int id, String first_name, String last_name) : base() {
            this.Id = id;
            this.First_name = first_name;
            this.Last_name = last_name;
        }
        public Pessoa(int id, String first_name, String last_name, DateTime date) : base()
        {
            this.Id = id;
            this.First_name = first_name;
            this.Last_name = last_name;
            this.Data_nascimento = date;
        }
        public Pessoa(int id, String first_name, String last_name, Double telefone) : base()
        {
            this.Id = id;
            this.First_name = first_name;
            this.Last_name = last_name;
            this.Telefone = telefone;
        }
        public Pessoa(int id, String first_name, String last_name, DateTime date, Double telefone) : base()
        {
            this.Id = id;
            this.First_name = first_name;
            this.Last_name = last_name;
            this.Data_nascimento = date;
            this.Telefone = telefone;
        }



        public int Id {
            get { return _id; }
            set { _id = value; }
        }
        public String First_name
        {
            get { return _first_name; }
            set { _first_name = value; }
        }
        public String Last_name
        {
            get { return _last_name; }
            set { _last_name = value; }
        }
        public DateTime Data_nascimento
        {
            get { return _data_nascimento; }
            set { _data_nascimento = value; }
        }
        public Double Telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }
    }
}
