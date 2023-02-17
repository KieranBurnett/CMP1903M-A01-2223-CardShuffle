using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
	class Card
	{
		//Base for the Card class.
		//Value: numbers 1 - 13
		//Suit: numbers 1 - 4
		//The 'set' methods for these properties could have some validation
		private int Value;
		public int card_value
		{
			get { return Value; }
			set
			{
				if (1 <= value && value <= 13) { Value = value; }
				else { Console.WriteLine("Card value must be inbetween 1 - 13. "); }
			}
		}
		private int Suit;
		public int card_suit
		{
			get { return Suit; }
			set
			{
				if (1 <= value && value <= 4) { Suit = value; }
				else { Console.WriteLine("Card suit must be inbetween 1 - 4"); }
			}
		}
	}
}
