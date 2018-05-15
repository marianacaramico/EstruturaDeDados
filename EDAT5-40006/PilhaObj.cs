using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDAT540006
{
    class PilhaObj
    {
        private int topo;
        private Object[] pilha;

        public PilhaObj(int tam)
        {
            this.pilha = new Object[tam];
            this.topo = -1;
        }

        public bool IsEmpty()
        {
            return topo == -1;
        }

        public bool IsFull()
        {
            return topo == pilha.Length - 1;
        }

        public void Push(Object info)
        {
            if (IsFull()) Console.WriteLine("Baralho completo!");
            else
            {
                topo++;
                pilha[topo] = info;
            }
        }

        public Object Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Acabaram as cartas!");
                return null;
            }
            else return pilha[topo--];
        }

        public void ExibePilhaBaseParaTopo()
        {
            Console.WriteLine("Exibindo a pilha da base para o topo");
            for (int i = 0; i <= topo; i++)
            {
                Console.WriteLine(pilha[i]);
            }
        }
        
        public void ExibePilhaTopoParaBase()
        {
            Console.WriteLine("Exibindo a pilha do topo para base");
            for (int i = topo; i >= 0; i--)
            {
                Console.WriteLine(pilha[i]);
            }
        }

    }
}
