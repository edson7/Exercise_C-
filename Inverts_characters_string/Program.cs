/*
*********************************************************************
* Name: Edson Lopes dos Santos
* Date: 30/12/2020
* Description: Method that reverses the characters of a string. 
* Be careful not to crash if the string is null or empty or with only one character.
* Observation :  Programming concepts in C #
* Start Project: 30/12/2020
* End Project :  30/12/2020
* Review:1.0
*********************************************************************
*/
using System;
using System.Text;

namespace Inverts_characters_string
{
    class Program
    {
        static void Main(string[] args)
        {   
            ReverseChar sb = new ReverseChar();

            Console.WriteLine(sb.ProcessWord("La vie est belle"));

            Console.ReadKey();
        }
    }
}