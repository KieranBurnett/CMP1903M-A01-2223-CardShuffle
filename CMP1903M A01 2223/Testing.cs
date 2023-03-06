using System;
using System.Collections.Generic;

namespace CMP1903M_A01_2223
{
	class Testing
	{
		public Testing()
		{
			//Creates a pack object
			new Pack();
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
			int amount;
			while(true)
			{
				try
				{
					Console.WriteLine("How many Cards: "); // for debugging, allows for input of wanted amount of cards to be dealt
					amount = int.Parse(Console.ReadLine()); // reads input
					if(amount > 0 && amount <= Pack.pack.Count) { break; } // checks it is within the correct boundaries
					else { Console.WriteLine("Not a valid number in this case"); } // prevents out of bounds errors
				}
				catch { Console.WriteLine("Not a valid number"); } // prevents data type errors
			}
			List<Card> cards = Pack.dealCard(amount);
			//Check what is returned
			for (int i = 0; i < amount; i++)
			{
				Console.WriteLine($"Card number {i}'s Suit: {cards[i].card_suit}, Card number {i}'s Value: {cards[i].card_value}");
			}
		}
	}
}