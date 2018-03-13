using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAbstrata
{
    class Cadastro
    {
        private int tamanho;
        private ListaObj lista;

        public Cadastro(int tamanho)
        {
            lista = new ListaObj(this.tamanho);
            this.tamanho = tamanho;
        }
             

        public void AdicionaAluno(Aluno a)
        {
            lista.Adicionar(a);
        }

        public void ExibeTodos()
        {
            for(int i=0; i<tamanho; i++)
            {
                Console.WriteLine(lista.BuscarPeloI(i).ToString());
            }
        }

        public Aluno BuscaRA(string ra)
        {
            for(int i=0; i<tamanho; i++)
            {
                Aluno a = (Aluno)lista.BuscarPeloI(i);
                if (a.Ra == ra) return a;
            }
            return null;
        }

    }

}
