using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_Aula23_ImplementacaoListaEncadeada
{
    class ListaLigada
    {
        private Node head;

        public ListaLigada()
        {
            this.head = new Node(0);
        }

        public void InsereNode(int valor)
        {
            Node novo = new Node(valor);
            novo.Next = head.Next;
            head.Next = novo;
        }

        public void Imprime()
        {
            Node atual = head.Next;
            while (atual != null)
            {
                Console.WriteLine(atual.Info);
                atual = atual.Next;
            }
        }

        public Node BuscaNode(int valor)
        {
            Node atual = head.Next;
            while (atual != null)
            {
                if (atual.Info == valor) return atual;
                atual = atual.Next;
            }
            return null;
        }

        public bool RemoveNode(int valor)
        {
            Node anterior = head;
            Node atual = head.Next;
            while (atual != null)
            {
                if (atual.Info == valor)
                {
                    anterior.Next = atual.Next;
                    return true;
                }
                anterior = atual;
                atual = atual.Next;
            }
            return false;
        }

        public int Tamanho()
        {
            Node atual = head.Next;
            int tamanho = 0;
            while (atual != null)
            {
                tamanho++;
                atual = atual.Next;
            }
            return tamanho;
        }

    }
}
