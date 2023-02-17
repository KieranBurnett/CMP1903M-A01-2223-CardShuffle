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
			Pack.shuffleCardPack(1);
			Pack.shuffleCardPack(2);
			Pack.shuffleCardPack(3);
			Pack.shuffleCardPack(4);
			//Calls the deal method
			//Check what is returned
		}
	}
}
