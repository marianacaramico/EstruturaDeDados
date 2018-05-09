using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_Aula23_ImplementacaoListaEncadeada
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaLigada lista = new ListaLigada();
            lista.InsereNode(2);
            lista.InsereNode(41);
            lista.InsereNode(26);
            lista.Imprime();
            Console.WriteLine(lista.BuscaNode(41).Info);
            Console.WriteLine(lista.BuscaNode(33));
            Console.WriteLine(lista.RemoveNode(2));
            lista.Imprime();

            Console.ReadKey();
        }
    }
}
