using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cevhermobilya
{
    public static class InputValidator
    {
        public static void AllowAllCharacters(TextBox textBox)
        {
        }
        //letters and space
        public static void AllowOnlyLetters(TextBox textBox)
        {
            string input = textBox.Text;


            if (!string.IsNullOrEmpty(input))
            {
                foreach (char c in input)
                {
                    if (!char.IsLetter(c) && !char.IsControl(c) && c != ' ')
                    {
                        MessageBox.Show("Lütfen sadece harf ve belirli işaretler giriniz!");
                        textBox.Text = string.Empty;
                        return;
                    }
                }
            }

        }
        //only numbers
        public static void AllowOnlyDigits(TextBox textBox)
        {
            string input = textBox.Text;

            if (!string.IsNullOrEmpty(input))
            {
                foreach (char c in input)
                {
                    if (!char.IsDigit(c) && !char.IsControl(c))
                    {
                        MessageBox.Show("Lütfen sadece rakam giriniz!");
                        textBox.Text = string.Empty;
                        return;
                    }
                }
            }
        }
    }


}
