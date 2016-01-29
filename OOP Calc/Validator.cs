using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Calc
{
    public static class Validator
    {
        private static string title = "Invalid Number Entry Error";
        public static string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }

        }
        public static bool IsPresent(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(textBox.Tag + " Enter a number and try again. ", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsDecimal(TextBox textBox)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
                MessageBox.Show(textBox.Tag + " must be a decimal value.", "Entry Error");
            return false;
        }
    }
}