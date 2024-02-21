using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Declaration puis affectation de valeur*/
            int amount;
            amount = 30000;
            Console.WriteLine(amount);

            decimal rate;
            rate = 0.6;
            Console.WriteLine(rate);

            bool isTrue;
            isTrue = true;
            Console.WriteLine(isTrue);

            string firstName;
            firstName = 'Thia';
            Console.WriteLine(firstName);


            /* Declaration avec affectation de valeur*/
            int amount = 5000;
            Console.WriteLine(amount);

            decimal rate = 0.9;
            Console.WriteLine(rate);

            bool isTrue = false;
            Console.WriteLine(isTrue);

            string firstName = 'Cynthia';
            Console.WriteLine(firstName);
        }
    }
}

