using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
		public List<Card> pack = new List<Card>();
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
            Console.WriteLine(pack[4].card_value);
            //Initialise the card pack here
        }
        /*
        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            if (typeOfShuffle == 1 ) //Fisher-Yates Shuffle
            {
                return true;
            }
            else if (typeOfShuffle == 2) //Riffle Shuffle
			{
                return true;
            }
            else if (typeOfShuffle == 3) //No Shuffle
			{
                return true;
            }

        }
        public static Card deal()
        {
            //Deals one card

        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
        }
        */
    }
}
