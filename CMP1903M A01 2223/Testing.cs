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
			Pack.shuffleCardPack(4);
			//Calls the deal method
			//Check what is returned
		}
	}
}
