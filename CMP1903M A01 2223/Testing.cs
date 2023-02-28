using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
	class Testing
	{
		public Testing()
		{
			//Creates a pack object
			Pack card_pack = new Pack();
			//Calls the shuffleCardPack method with each shuffle type
			if (Pack.shuffleCardPack(1)) { Console.WriteLine("Successfully shuffled via Fisher-Yates Shuffle"); }
			if (Pack.shuffleCardPack(2)) { Console.WriteLine("Successfully shuffled via Riffle Shuffle"); }
			if (Pack.shuffleCardPack(3)) { Console.WriteLine("No Shuffle complete"); }

			Console.WriteLine("");
			//Calls the deal method
			Card dealt_card = Pack.deal();
			//Check what is returned
			Console.WriteLine($"Dealt Card's Suit: {dealt_card.card_suit}, Dealt Card's Value: {dealt_card.card_value}");

			Console.WriteLine("");
			//Calls the deal mulltiple method
			List<Card> cards = Pack.dealCard(5);
			//Check what is returned
			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine($"Card number {i}'s Suit: {cards[i].card_suit}, Card number {i}'s Value: {cards[i].card_value}");
			}
		}
	}
}
