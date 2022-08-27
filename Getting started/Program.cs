using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getting_started
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arrNumbers = new int[] { 1, 2, 3, 4, 5, 6 };

            for(int i = 0; i < arrNumbers.Length; i++)
            {
                Console.WriteLine(arrNumbers[i]);
            }
            

            Console.ReadLine();
        }
    }
}
