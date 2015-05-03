using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT711_Lab3
{
    class Card
    {
        private int suit;
        private int rank;
        
        //0 = Clubs, 1 = Diamonds, 2 = Hearts, 3 = Spades
        char[] suitChar = { '\u2663', '\u2666', '\u2665', '\u2660' };
        string[] rankString = {" A", " 2", " 3", " 4", " 5", " 6", " 7", " 8", " 9", " 10", " J", " Q", " K" };

        public Card() {}

        public Card(int s, int r)
        {
            suit = s;
            rank = r;
        }

        public int GetSuitLength()
        {
            return suitChar.Length;
        }
        
        public int GetRankLength()
        {
            return rankString.Length;
        }

        public override string ToString()
        {
            return suitChar[suit].ToString() + rankString[rank];
        }
    }
}
