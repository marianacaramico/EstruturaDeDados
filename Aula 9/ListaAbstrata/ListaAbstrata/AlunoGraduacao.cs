using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAbstrata
{
    class AlunoGraduacao: Aluno
    {
        private double nota1;
        private double nota2;

        public AlunoGraduacao(double nota1, double nota2, string nome, string ra)
            : base(nome, ra)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
        }

        public override double CalculaMedia()
        {
            return (this.nota1*0.4 + this.nota2*0.6) / 2.0;
        }

        public override string ToString()
        {
            return base.ToString() + " - Notas: " +this.nota1+", " + this.nota2 + ". Média: " + CalculaMedia();
        }

    }
}
