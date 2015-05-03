using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT711_Lab3
{
    class Player
    {
        public const int HAND_COUNT = 5;
        public const int NUM_PLAYERS = 4;
        Deck d = new Deck();

        public static List<Card> p1 = new List<Card>();
        public static List<Card> p2 = new List<Card>();
        public static List<Card> p3 = new List<Card>();
        public static List<Card> p4 = new List<Card>();

        public Player() { }

        public void DealHands()
        {
            try //prevent from crashing
            {
                int count;

                for (count = 0; count < HAND_COUNT; count++)
                {
                    p1.Add(d.Deal());
                    p2.Add(d.Deal());
                    p3.Add(d.Deal());
                    p4.Add(d.Deal());
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                throw;
            }
        }

        public Card GetDealtHandP1(int i)
        {
            return p1.ElementAt(i);
        }
        public Card GetDealtHandP2(int i)
        {
            return p2.ElementAt(i);
        }
        public Card GetDealtHandP3(int i)
        {
            return p3.ElementAt(i);
        }
        public Card GetDealtHandP4(int i)
        {
            return p4.ElementAt(i);
        }

        public void ClearHands()
        {
            p1.Clear();
            p2.Clear();
            p3.Clear();
            p4.Clear();

        }

    }
}
