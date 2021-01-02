/*
*********************************************************************
* Name: Edson Lopes dos Santos
* Date: 30/12/2020
* Description:  Welcome 2021
* Observation :  Programming concepts in C #
* Start Project: 30/12/2020
* End Project :  30/12/2020
* Review:1.0
*********************************************************************
*/
using System;
using System.Collections.Generic;

namespace Welcome_2021
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<char, int> Dictionary_1 = ChaineCaractere("bienvenu 2021");
            foreach (var item in Dictionary_1)
            {
                Console.Write(item);

            }
            Console.ReadKey();


            static Dictionary<char, int> ChaineCaractere(string chaine)
            {
                if (chaine == null)
                {
                    return null;
                }
                Dictionary<char, int> dictionnaire = new Dictionary<char, int>();

                string chaineFinale = chaine.ToLower();
                const int COMPTEUR = 1;

                for (int i = 0; i < chaineFinale.Length; i++)
                {

                    if (char.IsLetterOrDigit(chaineFinale[i]))
                    {
                        if (!dictionnaire.ContainsKey(chaineFinale[i]))
                        {
                            dictionnaire.Add(chaineFinale[i], COMPTEUR);
                        }
                        else
                        {
                            dictionnaire[chaineFinale[i]] += 1;
                        }
                    }
                }

                return dictionnaire;
            }
        }
    }
}
