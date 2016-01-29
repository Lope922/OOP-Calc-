using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Calc
{
	public class Calculator
	{

	   // User cannot enter numbers into the text box. To avoid user error upon user entry is mapped to button clicks. 
		private decimal var1;
	   
		//same for variable2 
		private decimal var2;

		// tells the computer what type of math to do based on button click events. 
		private string mathType;

		public decimal Variable1
		{
			get
			{
				return var1;
			}
			set
			{
				var1 = value;
			}
		}

		public decimal getVariable1()
		{
			return var1;
		}
		public decimal Variable2
		{
			get
			{
				return var2;
			}
			set
			{
				var2 = value;
			}
		}

		// can possibly modify to take an enum rather than a string. 
		public string RetrieveOperand
		{
			get
			{
				return mathType;
			}
			set
			{
				mathType = value;
			}
		}

		// there are two overloaded methods for doing math with one for square root to handle a single value 
		public decimal DoMath(decimal var1, string mathType, decimal answer)
		{
			switch (mathType)
			{
				case "SquareRoot":
					{
						answer = var1 * var1;
						return answer;
					}
				case "Recipricol":
						{
							answer = (1/ var1);
							return answer; 
						}

			}
			// return zero just to return something. May also want to throw an error message. 
			return 0;
		}
		
		// does the math based on user input
		public decimal DoMath(decimal var1, decimal var2, string mathType, decimal answer)
		{
			switch (mathType)
			{
				case "Multiplication":
					{
						answer = (var1 * var2);
						return answer;
					}
				case "Division":
					{
							answer = (var1 / var2);
							return answer;
						}
						
				case "Subtraction":
					{
						answer = (var1 - var2);
						return answer;
					}
				case "Addition":
					{
						answer = (var1 + var2);
						return answer;
					}
				case "Reciprical":
					{
						
						if (var2 == default(decimal)) 
						{
							answer = (1 / var1);
							return answer;
						}
						else
						{
						answer = var2 / var1;
						return answer; 
						}
					}
			}
			// return zero just to return something. May also want to throw an error message. 
			return 0;
		}
	}
}


//todo add delete key function 

// also add label to display number being added and the math type. 