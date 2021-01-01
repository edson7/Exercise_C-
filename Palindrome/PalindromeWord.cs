using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeString
{
    class PalindromeWord
    {

      public string EstPalindrome(string palindrome)
        {
            StringBuilder pal = new StringBuilder();

            for (int i = palindrome.Length - 1; i >= 0; i--)
            {
                pal.Append(palindrome[i]);
            }

            return pal.ToString();
        }

      public bool PalindromeVraiFaux(string traiterWord, string palindrome)
        {
            if (traiterWord == palindrome)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
