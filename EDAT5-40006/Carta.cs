using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDAT540006
{
    class Carta
    {
        private string face;
        private int valor;
        private string naipe;

        public string Face { get => face; set => face = value; }
        public int Valor { get => valor; set => valor = value; }
        public string Naipe { get => naipe; set => naipe = value; }

        public Carta(string face, int valor, string naipe)
        {
            this.face = face;
            this.valor = valor;
            this.naipe = naipe;
        }

        public override string ToString()
        {
            return this.face + " de " + this.naipe;
        }

    }
}
