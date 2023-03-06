using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CMP1903M_A01_2223
{
    class Pack
    {
		public static List<Card> pack = new List<Card>();
		//Initialise the card pack here
		public Pack()
        {
			for (int suit=1; suit<=4; suit++) //Repeats 4 times for each Suit
            {
                for (int value=1; value<=13; value++) //Repeats 13 times for each card value 
                {
					Card card = new Card(); //Creates a new instance of Card **Abstraction**
					card.card_value = value; //Sets the value of the card
                    card.card_suit = suit; //Sets the suit of the card
                    pack.Add(card); //Add to the deck
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
                for (int i = 0; i <= 52; i++) //Goes through each card in the deck
                {
                    int card_pick = rnd.Next(0,52-i); //Picks a random card out of the remaining ones
                    temp = pack[card_pick];
                    pack.RemoveAt(card_pick); //Removes the card from the deck 
                    pack.Add(temp); //Adds the card to the top
                }
				return true; //Returns True when done
            }
            else if (typeOfShuffle == 2) //Riffle Shuffle
			{
                Card temp;
                for (int i = 0; i<=25; i++) 
                {
					temp = pack[0]; //Takes the current bottom card
					pack.RemoveAt(0); //Removes the current bottom card from the deck
					pack.Add(temp); //Adds the card to the top
					temp = pack[25-i]; //Takes the current middle card
					pack.RemoveAt(25-i); //Removes the card from the deck
                    pack.Add(temp); //Adds the card to the top
                }
				return true; //Returns True when done
			}
            else if (typeOfShuffle == 3) //No Shuffle
			{
				return true; //Returns True when done
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
			int size = pack.Count(); //Use of pack.count to prevent outs of bounds exception, works on any deck size
			Console.WriteLine(pack[size-1]);
			Card deal_card = pack[size-1]; //Saves the top card as deal_card vairable
            pack.RemoveAt(size-1); //Removes the top card from the deck to prevent it being dealt again
            return deal_card; //Returns the dealt card to the testing class
        }  
        public static List<Card> dealCard(int amount)
        {
			//Deals the number of cards specified by 'amount'
			List<Card> cards = new List<Card>(); //Creates a new list which will contain all the dealt cards
            int size = pack.Count(); //Use of pack.count to prevent outs of bounds exception, works on any deck size
			for (int i = 0; i<amount; i++) //Repeat as many time as the parameter specifies
            {
				cards.Add(pack[size-i-1]); //Add top card to new list
                pack.RemoveAt(size-i-1); //Remove top card from the deck to prevent is being dealt again
            }
			return cards; //Return new list to the testing class
        }
    }
}