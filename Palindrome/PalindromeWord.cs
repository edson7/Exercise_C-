/*
*********************************************************************
* Name: Edson Lopes dos Santos
* Date: 30/12/2020
* Description: Palindrome #
* Observation :  Programming concepts in C #
* Start Project: 30/12/2020
* End Project :  30/12/2020
* Review:1.0
*********************************************************************
*/

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
