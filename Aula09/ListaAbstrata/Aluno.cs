using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAbstrata
{
    public abstract class Aluno
    {
        private string nome;
        private string ra;
        public string Nome { get => nome; set => nome = value; }
        public string Ra { get => ra; set => ra = value; }

        public Aluno(string nome, string ra)
        {
            this.nome = nome;
            this.ra = ra;
        }

        public abstract double CalculaMedia();

        public override string ToString()
        {
            return nome +" - RA: "+ ra;
        }


    }
}
