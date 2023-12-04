using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSys
{
    public class Utils
    {
        //Check to see if the correct number of digits 
        public static bool IsCorrectNumberOfDigits(int number, int requiredDigits)
        {
            string numberStr = number.ToString();

            if (!(numberStr.Length == requiredDigits))
            {
                return false;
            }

            return true;
        }
    }
}
