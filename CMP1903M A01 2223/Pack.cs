using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
		public static List<Card> pack = new List<Card>();
		//Initialise the card pack here
		public Pack()
        {
			for (int suit=1; suit<=4; suit++)
            {
                for (int value=1; value<=13; value++)
                {
					Card card = new Card();
					card.card_value = value;
                    card.card_suit = suit;
                    pack.Add(card);
                }
            }
        }
        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            if (typeOfShuffle == 1 ) //Fisher-Yates Shuffle
            {
                Random rnd = new Random();
                Card temp;
                for (int i = 0; i <= 52; i++)
                {
                    int card_pick = rnd.Next(0,52-i);
                    temp = pack[card_pick];
                    pack.RemoveAt(card_pick);
                    pack.Add(temp);
                }
				return true;
            }
            else if (typeOfShuffle == 2) //Riffle Shuffle
			{
                Card temp;
                for (int i = 0; i<=25; i++)
                {
					temp = pack[0];
					pack.RemoveAt(0);
                    pack.Add(temp);
					temp = pack[25-i];
					pack.RemoveAt(25-i);
                    pack.Add(temp);
                }
				return true;
            }
            else if (typeOfShuffle == 3) //No Shuffle
			{
				return true;
            }
            else 
            {
                Console.WriteLine("Incorrect type of shuffle");
                return false;
            }

        }
        
        public static Card deal()
        {
            //Deals one card
            Card deal_card = pack[51];
            pack.RemoveAt(51);
            return deal_card;

        }
        /*
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
        }*/
        
    }
}
