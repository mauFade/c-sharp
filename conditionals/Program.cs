using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 17;

            if(age >= 18)
            {
                Console.WriteLine("You can enter.");
            } 
            else
            {
                Console.WriteLine("You cannot enter.");
            }            

            Console.ReadLine();
            
        }
    }
}
