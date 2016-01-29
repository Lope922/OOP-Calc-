using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Calc
{
	public class Memory_Calc : Calculator
	{
		// just need a variable to store the number in  memory 
		private decimal memNum;

		public decimal MemoryNumber
		{
			get
			{ return memNum; }

			set { memNum = value; }
		}
	}
}
