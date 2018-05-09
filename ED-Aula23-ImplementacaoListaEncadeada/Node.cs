using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_Aula23_ImplementacaoListaEncadeada
{
    class Node
    {
        private int info;
        private Node next;

        internal Node Next { get => next; set => next = value; }
        public int Info { get => info; set => info = value; }

        public Node(int info)
        {
            this.Info = info;
            this.Next = null;
        }


    }
}
