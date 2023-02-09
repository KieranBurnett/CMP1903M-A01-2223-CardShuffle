using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        List<Card> pack;

        public Pack()
        {
            //Initialise the card pack here
        }

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
    }
}
