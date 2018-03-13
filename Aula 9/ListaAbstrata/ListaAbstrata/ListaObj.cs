using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAbstrata
{
    class ListaObj
    {
        private Object[] vetor;
        private int nroElem;

        public int NroElem { get => nroElem; set => nroElem = value; }

        public ListaObj(int tam)
        {
            vetor = new Object[tam];
            nroElem = 0;
        }

        public int Adicionar(Object elem)
        {
            if (this.nroElem < vetor.Length)
            {
                vetor[nroElem] = elem;
                nroElem++;
                return 0;
            }
            else
            {
                return -1;
            }
        }

        public void Exibir()
        {
            for (int i = 0; i < this.nroElem; i++)
            {
                Console.WriteLine(vetor[i]);
            }
        }

        public int Buscar(Object elemento)
        {
            for (int i = 0; i < this.nroElem; i++)
            {
                if (vetor[i] == elemento) return i;
            }
            return -1;
        }

        public Object BuscarPeloI(int i)
        {
            if (i >= 0 && i < nroElem) return vetor[i];
            return 0;
        }

        public int RemoverPeloIndice(int indice)
        {
            if (indice >= 0 && indice < nroElem)
            {
                for (int i = indice; i < this.nroElem - 1; i++)
                {
                    vetor[i] = vetor[i + 1];
                }
                nroElem--;
                vetor[nroElem] = 0;
                return 0;
            }
            return -1;
        }

        public int RemoverElemento(Object elementoRemovido)
        {
            return this.RemoverPeloIndice(this.Buscar(elementoRemovido));
        }
    }
}

