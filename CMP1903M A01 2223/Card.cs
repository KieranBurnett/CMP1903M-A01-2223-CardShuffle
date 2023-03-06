using System;

namespace CMP1903M_A01_2223
{
	class Card
	{
		//Base for the Card class.
		//Value: numbers 1 - 13
		//Suit: numbers 1 - 4
		//The 'set' methods for these properties could have some validation
		private int Value; //Ensures the Value of each card is privatised and cannot be changed once set **Encapsulation**
		public int card_value
		{
			get { return Value; }
			set
			{
				if (1 <= value && value <= 13) { Value = value; } //Ensures the value of the card is between 1-13 to prevent errors
				else { Console.WriteLine("Card value must be inbetween 1 - 13. "); } 
			}
		}
		private int Suit; //Ensures the Suit of each card is privatised and cannot be changed once set
		public int card_suit
		{
			get { return Suit; }
			set
			{
				if (1 <= value && value <= 4) { Suit = value; } //Ensures the suit of the card is between 1-4 to prevent errors
				else { Console.WriteLine("Card suit must be inbetween 1 - 4"); }
			}
		}
	}
}