/*
*********************************************************************
* Name: Edson Lopes dos Santos
* Date: 30/12/2020
* Description: Palindrme #
* Observation :  Programming concepts in C #
* Start Project: 30/12/2020
* End Project :  30/12/2020
* Review:1.0
*********************************************************************
*/

using System;
using System.Text;

namespace PalindromeString
{
    class Program
    {
        static void Main(string[] args)
        {
            PalindromeWord word = new PalindromeWord();

            string palindrome = "ana";

            string traiteWord = word.EstPalindrome(palindrome);

            bool result2 = word.PalindromeVraiFaux(traiteWord, palindrome);

            Console.WriteLine(result2);

            Console.ReadKey();

        }
    }
}