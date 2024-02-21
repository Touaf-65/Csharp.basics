using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfConditional
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            string hasRight = 'OK';
            if (hasRight == 'OK')
            Console.WriteLine("Voua avez les droits d'acces");

            //2
            decimal compteEnBanque = 300;
            if (compteEnBanque >= 0)
            Console.WriteLine("Votre compte est créditeur");
            else
            Console.WriteLine("Votre compte est débiteur");

            //3
            bool estVrai = true;
            if (estVrai)
            Console.WriteLine("C'est vrai !");
            else
            Console.WriteLine("C'est faux !");

            //4
            bool estVrai = false;
            if (!estVrai)
            Console.WriteLine("C'est vrai !");
            else
            Console.WriteLine("C'est faux !");

            //5
            string login = "Nicolas";
            string motDePasse = "test";
            if (login == "Nicolas" && motDePasse == "test")
            Console.WriteLine("Bienvenue Nicolas");
            else
            Console.WriteLine("Login incorrect");

            //6
            if (civilite == "Mme" || civilite == "Mlle")
            Console.WriteLine("Vous êtes une femme");
            else
            Console.WriteLine("Vous êtes un homme");
        }
    }
}