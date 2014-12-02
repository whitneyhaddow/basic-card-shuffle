using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT711_Lab3
{
    class Player
    {
       //MD
        public const int HAND_COUNT = 5;
        public const int NUM_PLAYERS = 4;
        Deck d = new Deck();

        public static List<string> p1 = new List<string>();
        public static List<string> p2 = new List<string>();
        public static List<string> p3 = new List<string>();
        public static List<string> p4 = new List<string>();

        public Player() { }

        public void DealHands()
        {

           //WH
            try //prevent from crashing
            {
                int count;

                //MD
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

       
        //MD
        public string GetDealtHandP1(int i)
        {
            return p1.ElementAt(i);
        }
        public string GetDealtHandP2(int i)
        {
            return p2.ElementAt(i);
        }
        public string GetDealtHandP3(int i)
        {
            return p3.ElementAt(i);
        }
        public string GetDealtHandP4(int i)
        {
            return p4.ElementAt(i);
        }

        //WH and MD
        public void ClearHands()
        {
            p1.Clear();
            p2.Clear();
            p3.Clear();
            p4.Clear();

        }

    }
}
