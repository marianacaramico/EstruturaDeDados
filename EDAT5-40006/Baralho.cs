using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDAT540006
{
    class Baralho
    {
        private PilhaObj deck;

        internal PilhaObj Deck { get => deck; set => deck = value; }

        public Baralho()
        {
            string[] faces = new string[] {"Ás", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Valete", "Dama", "Rei"};
            string[] naipes = new string[] {"Ouros", "Espadas", "Copas", "Paus"};
            this.deck = new PilhaObj(52);
            for(int i=0; i<naipes.Length; i++)
            {
                for(int j=0; j<faces.Length; j++)
                {
                    Carta carta = new Carta(faces[j], i + 1, naipes[i]);
                    deck.Push(carta);                    
                }
            }
        }
        
        public Carta RemoveCarta(int ind)
        {
            PilhaObj aux = new PilhaObj(52);
            for (int i = 0; i < ind; i++)
            {
                aux.Push(deck.Pop());
            }
            Carta alvo = (Carta)deck.Pop();
            while(!aux.IsEmpty()) deck.Push(aux.Pop());            return alvo;
        }

        public void Embaralhar()
        {
            Random numero = new Random();
            for(int r=0; r<52; r++)
            {
                int indice = numero.Next(52);
                if (indice != 0) deck.Push(RemoveCarta(indice));
            }
        }

        public Carta VirarCarta()
        {
            return (Carta)deck.Pop();
        }

        public void Exibir()
        {
            deck.ExibePilhaBaseParaTopo();
        }

    }
}
