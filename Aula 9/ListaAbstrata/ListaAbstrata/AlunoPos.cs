using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAbstrata
{
    class AlunoPos: Aluno
    {
        private double nota1;
        private double nota2;
        private double notaMonografia;

        public AlunoPos(double nota1, double nota2, double notaMonografia, string nome, string ra)
            :base(nome, ra)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.notaMonografia = notaMonografia;
        }

        public override double CalculaMedia()
        {
            return (this.nota1 + this.nota2) / 2.0 + this.notaMonografia;
        }

        public override string ToString()
        {
            return base.ToString() + " - Notas: " + this.nota1 + ", " + this.nota2 + ", "+this.notaMonografia+". Média: " + CalculaMedia();
        }

    }
}
