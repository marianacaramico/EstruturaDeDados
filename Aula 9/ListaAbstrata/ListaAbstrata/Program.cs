using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAbstrata
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno euJovem = new AlunoFundamental(10, 10, 10, 10, "Mariana", "19");
            Aluno euAgora = new AlunoGraduacao(8, 9, "Mariana", "40006");
            Aluno euVelha = new AlunoPos(10, 10, 2, "Mariana", "314159265");

            euJovem.CalculaMedia();
            euAgora.CalculaMedia();
            euVelha.CalculaMedia();

            Console.WriteLine(euJovem.ToString());
            Console.WriteLine(euAgora.ToString());
            Console.WriteLine(euVelha.ToString());

            Cadastro cadastro = new Cadastro(3);
            cadastro.AdicionaAluno(euJovem);
            cadastro.AdicionaAluno(euAgora);
            cadastro.AdicionaAluno(euVelha);

            cadastro.ExibeTodos();

            Console.ReadKey();

        }
    }
}
