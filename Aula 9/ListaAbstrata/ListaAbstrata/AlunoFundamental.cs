using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAbstrata
{
    class AlunoFundamental: Aluno
    {
        private double nota1;
        private double nota2;
        private double nota3;
        private double nota4;

        public AlunoFundamental(double nota1, double nota2, double nota3, double nota4, string nome, string ra)
            : base(nome, ra)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
            this.nota4 = nota4;            
        }

        public override double CalculaMedia()
        {
            return (this.nota1 + this.nota2 + this.nota3 + this.nota4) / 4.0;
        }

        public override string ToString()
        {
            return base.ToString()+" - Notas: " + this.nota1 + ", " + this.nota2 + ", " + this.nota3 + ", " + this.nota4 + ". Média: " + CalculaMedia();
        }

    }
}
