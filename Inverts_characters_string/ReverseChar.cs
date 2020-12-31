/*
*********************************************************************
* Name: Edson Lopes dos Santos
* Date: 30/12/2020
* Description: class ReverseChar #
* Observation :  Programming concepts in C #
* Start Project: 30/12/2020
* End Project :  30/12/2020
* Review:1.0
*********************************************************************
*/

using System.Text;

namespace Inverts_characters_string
{
    class ReverseChar
    {
        public string ProcessWord(string word)
        {
            string[] result = word.Split(' ');
            StringBuilder sb = new StringBuilder();

            for (int i = result.Length - 1; i >= 0; i--)
            {
                sb.Append(result[i] + " ");
            }
            return sb.ToString().Trim();
        }

    }
}
