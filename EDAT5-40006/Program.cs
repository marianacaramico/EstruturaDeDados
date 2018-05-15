using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDAT540006
{
    class Program
    {
        static void Main(string[] args)
        {
            Baralho baralho = new Baralho();
            baralho.Exibir();
            baralho.Embaralhar();
            baralho.Exibir();

            int numero = 0;
            while(numero < 2 || numero > 9)
            {
                Console.WriteLine("Informe quantas cartas deseja virar: (2 a 9)");
                numero = int.Parse(Console.ReadLine());
            }

            int guess = -1;
            while (guess < 0)
            {
                Console.WriteLine("Adivinhe o valor da soma das cartas viradas de naipe preto:");
                guess = int.Parse(Console.ReadLine());
            }

            int soma = 0;

            for(int i=0; i<numero; i++)
            {
                Console.WriteLine(baralho.VirarCarta());
                if(baralho.VirarCarta().Naipe == "Espadas" || baralho.VirarCarta().Naipe == "Paus")
                {
                    soma += baralho.VirarCarta().Valor;
                }
            }

            if (soma == guess) Console.WriteLine("Você ganhou!");
            else Console.WriteLine("Você perdeu...");

            Console.ReadKey();            

        }
    }
}
