using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT711_Lab3
{
    class Deck
    {
        private int suit;
        private int rank;
        public static List<string> shuffledDeck = new List<string>();
        int count = 0;
        
        public int Count
        {
            get
            {
                return shuffledDeck.Count;
            }
        }

        Random sourceGen = new Random();
     
        public Deck() {}

        public void PopulateDeck()
        {
            int s;
            int r;
            Card c = new Card(suit, rank);
            count = 0;

            s = c.GetSuitLength();
            r = c.GetRankLength();

            for (suit = 0; suit < s; suit++)
            {
                for (rank = 0; rank < r; rank++)
                {
                    c = new Card(suit, rank);
                    shuffledDeck.Add(c.ToString());
                    count++;
                }
            }
        }
        
        public string GetShuffledDeck(int i)
        {
            return shuffledDeck.ElementAt(i);
        }

        public int GetShuffledDeckLength()
        {
            return shuffledDeck.Count();
        }

        public string Deal()
        {
               string topCard = shuffledDeck.ElementAt(0);
               shuffledDeck.RemoveAt(0);
               return topCard;
           
        }

        //indexer
        public string this[int position]
        {
            get
            {
                if (position < 0 || position >= shuffledDeck.Count)
                    throw new ArgumentOutOfRangeException("Invalid Position " + position.ToString());
                else
                    return shuffledDeck[position];
            }

            set
            {
                shuffledDeck[position] = value;
            }
        }

        public void Shuffle()
        {
            int n1;
            string n2;

            for (int a = 0; a < shuffledDeck.Count; a++)
            {
                n1 = sourceGen.Next(shuffledDeck.Count);
                n2 = shuffledDeck[a];
                shuffledDeck[a] = shuffledDeck[n1];
                shuffledDeck[n1] = n2;
            }

        }
    }
}
