using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICT711_Lab3
{
    /***********************************************************
    * This form displays a 52 card deck and allows shuffling as
    * well as dealing to 4 players.
    * Created December 2014 by Whitney Haddow and Michael Dupuis
    * **********************************************************/
    public partial class Form1 : Form
    {
       //WH
        Deck d = new Deck();
        Player p = new Player();
        int numOfCards;

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            d.PopulateDeck();
            DisplayCards();
        }

        public void btnShuffle_Click(object sender, EventArgs e)
        {
            d.Shuffle();
            DisplayCards();
        }

        public void btnDeal_Click(object sender, EventArgs e)
        {
            
            //WH
            if (d.Count < (Player.HAND_COUNT * Player.NUM_PLAYERS)) 
            {
                MessageBox.Show("There are not enough cards left in the deck to deal again."); 
                btnDeal.Enabled = false;
            }
            else
            {
                string line;
                int count;

                p.ClearHands();
                lstP1.Items.Clear();
                lstP2.Items.Clear();
                lstP3.Items.Clear();
                lstP4.Items.Clear();

                p.DealHands();

                               
               //MD
                    for (count = 0; count < 5; count++)
                    {
                
                        line = p.GetDealtHandP1(count);
                        lstP1.Items.Add(line);
                        line = p.GetDealtHandP2(count);
                        lstP2.Items.Add(line);
                        line = p.GetDealtHandP3(count);
                        lstP3.Items.Add(line);
                        line = p.GetDealtHandP4(count);
                        lstP4.Items.Add(line);
                    }
                    DisplayCards();
            }
        }

       //MD
        public void DisplayCards() 
        {
            numOfCards = d.GetShuffledDeckLength();
            int count;
            string line;

            lstDeck.Items.Clear();

            for (count = 0; count < numOfCards; count++)
            {
                line = d.GetShuffledDeck(count);
                lstDeck.Items.Add(line);
            }
        }

        

        //WH
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       //WH
        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear lists
            Player.p1.Clear();
            Player.p2.Clear();
            Player.p3.Clear();
            Player.p4.Clear();
            Deck.shuffledDeck.Clear();

            //clear list boxes
            lstDeck.Items.Clear();
            lstP1.Items.Clear();
            lstP2.Items.Clear();
            lstP3.Items.Clear();
            lstP4.Items.Clear();

            
            //start again with sequential deck
            d.PopulateDeck();
            DisplayCards();

            //re-enable deal
            btnDeal.Enabled = true;
                    
        }


    }
}
