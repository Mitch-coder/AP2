using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AED_AP2
{
     static class ValidateTextBox
    {
        public static void justLetters(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    //backspace
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static void justNumbers(KeyPressEventArgs e)
        {

            try
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    //backspace
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        public static void allowDecimals(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    //backspace
                    e.Handled = false;
                }
                else if (e.KeyChar==46)
                {
                    //punto
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
