using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pair = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int counter;
            for (counter = 0; counter < pair.Length; counter++)
            {
                if (pair[counter] % 2 == 0) // utilisation de % (modulo) pour obtenir le reste de la division
                {
                    Console.WriteLine(pair[counter]);
                }
            }
        }
    }
}
