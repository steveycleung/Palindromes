using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    public class PalindromesCheck
    {
        private string inputString;

        /// <summary>
        ///     constructor
        /// </summary>
        /// <param name="s">input string</param>
        public PalindromesCheck(string s)
        {
            if(string.IsNullOrEmpty(s))
            {
                inputString = "";
            } 
            else
            {
                inputString = s;
            }
            
        }

        /// <summary>
        ///     get input string
        /// </summary>
        public string InputString
        {
            get { return inputString; }
        }

        /// <summary>
        ///     validate the input string and the reverse string
        /// </summary>
        /// <returns>true if the input string and the reverse string are same, false for otherwises</returns>
        public bool IsValidate()
        {
            string reverseString = Reverse(inputString);
            if(inputString.ToLower() == reverseString.ToLower())
            {
                 return true;
            }
            return false;

        }

        /// <summary>
        ///     Reverse the character sequence of the input string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
