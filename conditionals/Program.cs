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
            int persons = 2;
            bool isWithSomeone = persons >= 2;

            if(age >= 18 || isWithSomeone == true)
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
