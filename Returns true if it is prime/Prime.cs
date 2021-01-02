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
using System.Collections.Generic;
using System.Text;

namespace Returns_true_if_it_is_prime
{
    class Prime
    {
        public bool EstPremier(int nombre)
        {
            int nbDivisions = 0;

            for (int i = 1; i <= nombre; i++)
            {
                if (nombre % i == 0)
                {
                    nbDivisions++;
                }
            }
            return nbDivisions == 2;
        }

    }
}
