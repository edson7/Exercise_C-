/*
*********************************************************************
* Name: Edson Lopes dos Santos
* Date: 30/12/2020
* Description: Returns true if it is prime and false otherwise.
* Observation :  Programming concepts in C #
* Start Project: 30/12/2020
* End Project :  30/12/2020
* Review:1.0
*********************************************************************
*/
using System;

namespace Returns_true_if_it_is_prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 2;
            Prime PrimeN = new Prime();
            
            Console.WriteLine(PrimeN.EstPremier(numero));
            Console.ReadKey();
        }
    }
}

