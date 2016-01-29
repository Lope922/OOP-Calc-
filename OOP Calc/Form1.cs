using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Calc
{
	public partial class BasicCalculator : Form
	{
		public BasicCalculator()
		{
			InitializeComponent();
		}

		string numberBuilder;
		decimal officialNumber = .0m;

		

		// create a new instance of the object and make the variable public to this. instance of the running application. 
		public Calculator mathObj = new Calculator();

		public Memory_Calc newThing = new Memory_Calc();
		//public Validator vlad = new Validator();
		public MathForms mathObjOperand = new MathForms();


		// still need to finish writing the math class, but first i am going to start building the calculator and usin it 

		// 
		#region CalcButton_clickEvents
		private void button1_Click(object sender, EventArgs e)
		{
			numberBuilder += 1;
			updateTextBoxNums(textBoxVal1);
		}
		private void buttonNum2_Click(object sender, EventArgs e)
		{
			numberBuilder += 2;
			updateTextBoxNums(textBoxVal1);
		}
		private void buttonNum3_Click(object sender, EventArgs e)
		{
			numberBuilder += 3;
			updateTextBoxNums(textBoxVal1);
		}
		private void button4_Click(object sender, EventArgs e)
		{
			numberBuilder += 4;
			updateTextBoxNums(textBoxVal1);
		}
		private void button5_Click(object sender, EventArgs e)
		{
			numberBuilder += 5;
			updateTextBoxNums(textBoxVal1);
		}
		private void button6_Click(object sender, EventArgs e)
		{
			numberBuilder += 6;
			updateTextBoxNums(textBoxVal1);
		}
		private void button7_Click(object sender, EventArgs e)
		{
			numberBuilder += 7;
			updateTextBoxNums(textBoxVal1);
		}
		private void button8_Click(object sender, EventArgs e)
		{
			numberBuilder += 8;
			updateTextBoxNums(textBoxVal1);
		}
		private void button9_Click(object sender, EventArgs e)
		{
			numberBuilder += 9;
			updateTextBoxNums(textBoxVal1);
		}
		private void button10_Click(object sender, EventArgs e)
		{
			if (CheckDoubleZero(textBoxVal1) == true)
			{
				numberBuilder += 0;
				updateTextBoxNums(textBoxVal1);
			}
			else ; 
				// do nothing 
		}



		// this btn can be deleted it's for experimental purposes only 
		private void impressMeButton_Click(object sender, EventArgs e)
		{
			ClearValues();
		}

		// Add Operand selection. 
		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if (Validator.IsPresent(textBoxVal1) == true)
			{
				mathObj.RetrieveOperand = "Addition";
				mathObj.Variable1 = Convert.ToDecimal(textBoxVal1.Text);
				textBoxVal1.Text = "";
				numberBuilder = null;
			}
		}
		// Multiply Operand 
		private void button11_Click(object sender, EventArgs e)
		{
			if (Validator.IsPresent(textBoxVal1) == true)
			{
				mathObj.RetrieveOperand = "Multiplication";
				mathObj.Variable1 = Convert.ToDecimal(textBoxVal1.Text);
				textBoxVal1.Text = "";
				numberBuilder = null;
			}
		}
		// Equal Button 
		private void buttonEqual_Click(object sender, EventArgs e)
		{
			// when this button is clicked add the second value entered and do math 

			if (textBoxVal1.Text.Length > 0)
			{
				try
				{
					mathObj.Variable2 = Convert.ToDecimal(textBoxVal1.Text);
					// get the math type 

					// calculate the answer based on the numbers passed in as well as the math type 
					officialNumber = mathObj.DoMath(mathObj.Variable1, mathObj.Variable2, mathObj.RetrieveOperand, officialNumber);

					//mathObj.getAnswer = officialNumber; 
					textBoxVal1.Text = officialNumber.ToString();
					
					// set variable 1 

				}
				catch (DivideByZeroException ex)
				{
					MessageBox.Show(ex.Message.ToString() + "...does not compute", "Divide by zero error");
				}
			}

		}
		// Subtraction button click 
		private void buttonSubtract_Click(object sender, EventArgs e)
		{
			if (Validator.IsPresent(textBoxVal1) == true)
			{
				mathObj.RetrieveOperand = "Subtraction";
				mathObj.Variable1 = Convert.ToDecimal(textBoxVal1.Text);
				textBoxVal1.Text = "";
				numberBuilder = null;
			}
		}
		// Divide Button 
		private void buttonDivide_Click(object sender, EventArgs e)
		{
			if (Validator.IsPresent(textBoxVal1) == true)
			{
				mathObj.RetrieveOperand = "Division";
				mathObj.Variable1 = Convert.ToDecimal(textBoxVal1.Text);
				textBoxVal1.Text = "";
				numberBuilder = null;
			}
		}
		// Recip button
		private void buttonReciprical_Click(object sender, EventArgs e)
		{
			// write this method as well as enumeration 
			if (Validator.IsPresent(textBoxVal1) == true)
			{
				mathObj.RetrieveOperand = "Recipricol";
				mathObj.Variable1 = Convert.ToDecimal(textBoxVal1.Text);
				officialNumber = mathObj.DoMath(mathObj.Variable1, mathObj.RetrieveOperand, officialNumber);
				textBoxVal1.Text = officialNumber.ToString();
				numberBuilder = null;
			}
		}
		// Sqrt Method 
		private void buttonSquareRoot_Click(object sender, EventArgs e)
		{
			if (Validator.IsPresent(textBoxVal1) == true)
			{
				mathObj.RetrieveOperand = "SquareRoot";
				mathObj.Variable1 = Convert.ToDecimal(textBoxVal1.Text);
				officialNumber = mathObj.DoMath(mathObj.Variable1, mathObj.RetrieveOperand, officialNumber);
				textBoxVal1.Text = officialNumber.ToString();
				numberBuilder = null;
			}
		}
		// backspace button 
		private void buttonBackSpace_Click(object sender, EventArgs e)
		{
			if (textBoxVal1.Text.Length > 0)
			{
				string textEntered = textBoxVal1.Text;
				textEntered = textEntered.Remove(textBoxVal1.Text.Length - 1);
				textBoxVal1.Text = "";
				textBoxVal1.Text = textEntered;
			}

			if (textBoxVal1.Text.Length == 0)
				numberBuilder = null;

		}

		// plus minus button 
		private void buttonOpposite_Click(object sender, EventArgs e)
		{
			decimal tester = Convert.ToDecimal(textBoxVal1.Text);
			if (tester > 0)
			{
				tester *= -1;

			}
			else if (tester < 0)
			{
				tester *= -1 / 1;

			}
			else if (tester == 0)
			{
			}
			textBoxVal1.Text = tester.ToString();
		}
	
		// dot for a decimal number button 
		private void button2_Click(object sender, EventArgs e)
		{
			char dot = '.';
			if (textBoxVal1.Text.Contains(dot) == true)
			{

				// do nothing
			}
			else
			{
				textBoxVal1.Text += ".";
				numberBuilder = textBoxVal1.Text;
			}
		}
		// EXIT button click event 
		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion


		#region MyMethods
		private void updateTextBoxNums(TextBox num1textbox)
		{
			textBoxVal1.Text = numberBuilder;
		}

		private void ClearValues()
		{
			numberBuilder = null;
			officialNumber = 0;
			textBoxVal1.Text = "";
			mathObj.Variable1 = 0;
			mathObj.Variable2 = 0;
		}


		#endregion

		// Form load just sets the division sign on the calculator
		private void Form1_Load(object sender, EventArgs e)
		{
			var division = '÷';
			buttonDivide.Text = division.ToString();
			var sqrt = "x²";
			buttonSquareRoot.Text = sqrt.ToString();
			var backspace = "˿";
			buttonBackSpace.Text = backspace.ToString();

		}


		// key press events to allow keyboard input 
		private void Form1_KeyPress(object sender, KeyPressEventArgs e)
		{

			// would like to map the number button press to the corresponding button clicks. 
			// this is just good for key characters 0 - 9 
			//if (e.KeyChar >= 48 && e.KeyChar <= 57)
	//		{ MessageBox.Show("Key pressed was : " + e.KeyChar.ToString()); }
		//	else
		//	{
		//		MessageBox.Show("Key pressed was : " + e.KeyChar.ToString() + e.GetType().ToString());
			//}
			switch (e.KeyChar)
			{
				case (char)49:
					{
						textBoxVal1.Text += 1;
						break;
					}
				case (char)50:
					{
						textBoxVal1.Text += 2;
						break;
					}
				case (char)51:
					{
						textBoxVal1.Text += 3;
						break;
					}
				case (char)52:
					{
						textBoxVal1.Text += 4;
						break;
					}
				case (char)53:
					{
						textBoxVal1.Text += 5;
						break;
					}
				case (char)54:
					{
						textBoxVal1.Text += 6;
						break;
					}
				case (char)55:
					{
						textBoxVal1.Text += 7;
						break;
					}
				case (char)56:
					{
						textBoxVal1.Text += 8;
						break;
					}
				case (char)57:
					{
						textBoxVal1.Text += 9;
						break;
					}
				case (char)48:
					{
						textBoxVal1.Text += 0;
						break;
					}
				case (char)46:
					{
						if (textBoxVal1.Text.Contains(".") == false)
						{
							textBoxVal1.Text += ".";

						}
						break;
					}
				case (char)42: // then it's multiplication 
					mathObj.RetrieveOperand = "Multiplication";
					mathObj.Variable1 = Convert.ToDecimal(textBoxVal1.Text);
					textBoxVal1.Text = "";
					break;
					
				case (char)43: // addition key pressed  
					mathObj.RetrieveOperand = "Addition";
					mathObj.Variable1 = Convert.ToDecimal(textBoxVal1.Text);
					textBoxVal1.Text = "";
					break;
			
				case (char)45: // minus key pressed 
					mathObj.RetrieveOperand = "Subtraction";
					mathObj.Variable1 = Convert.ToDecimal(textBoxVal1.Text);
					textBoxVal1.Text = "";
					break;
		
						case (char)47: // then it's multiplication 
					mathObj.RetrieveOperand = "Division";
					mathObj.Variable1 = Convert.ToDecimal(textBoxVal1.Text);
					textBoxVal1.Text = "";
					break;
			}
		}

	//method to check and see if allow user to enter multiple zeros for begining number 
		private bool CheckDoubleZero(TextBox tb)
		{
			if (tb.Text.Length.Equals(1))
			{
				if (tb.Text.ToString().Equals("0"))
				{
					return false; 
				}
			}

				return true;
		}
		// memory clear button 
		private void btnMemoryClear_Click(object sender, EventArgs e)
		{
			//todoo empty the memory 
 //newThing.MemClear();
 btnMemStatus.Text = "";
		}
		// memory add 
		private void btnMemoryAdd_Click(object sender, EventArgs e)
		{
			if (textBoxVal1.Text != "")
			{
				// set the variable1 first 
				mathObj.Variable1 = Convert.ToDecimal(textBoxVal1.Text);

				newThing.MemoryNumber = mathObj.Variable1; 
				// update display 
				btnMemStatus.Text = "M";
				// clear the textbox 
				textBoxVal1.Text = "";
			}
		}

		private void btnMemRecall_Click(object sender, EventArgs e)
		{

			textBoxVal1.Text = newThing.MemoryNumber.ToString(); 
		}

		// although this is labeled memeory store it is actually adding the current value displayed in the number text box to the current value in memory 
		private void buttonMemoryStore_Click(object sender, EventArgs e)
		{
			//todo handle negative values
			try
			{
				if (textBoxVal1.Text != "")
				{

					btnMemStatus.Text = "M";
					string Numberconcat = newThing.MemoryNumber.ToString() + textBoxVal1.Text;
					newThing.MemoryNumber += Convert.ToDecimal(Numberconcat);
					textBoxVal1.Text = "";
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show("An error has occured " + ex.Message, "Calculator Memory Error");
			}
		}

		private void buttonMemoryClear_Click(object sender, EventArgs e)
		{
			newThing.MemoryNumber = default(decimal); 
			btnMemStatus.Text = "";
			
		}
	
	}
	public enum MathForms
	{
		Addition,
		Subtraction,
		Multiplication,
		Division,
		SquareRoot,
		Recipricol
	}
}

