using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeBlocks
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal compteEnBanque = 300;
            if (compteEnBanque >= 0)
            Console.WriteLine("Votre compte est crediteur");
            Console.WriteLine("Voullez-vous effectuer une transaction?");


            decimal compteEnBanque = 300;
            if (compteEnBanque >= 0)
            {
                Console.WriteLine("Votre compte est crediteur");
                Console.WriteLine("Voullez-vous effectuer une transaction?");
            }
            else
            { 
                Console.WriteLine("Vous ne pouvez qu'effectuer une operation  de transaction");

            }

        }
    }
}