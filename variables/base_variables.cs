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

/*
        ** Explication **
    
    Une variable est représentée par son nom, caractérisée 
    par son type et contient une valeur.

    L'exemple d'un montant, d'un taux de reduction, d'une valeur 
    "oui ou non", d'un nom qui peuvent etre stockes.

    Prenant l'exemple de la variable amount(montant), elle peut 
    etre stockee sous forme d'un entier.

                int amount;

    On appelle cela  "Declaration de la variable amount".
    int permet de preciser au compilateur que amount est un entier.

    Ici, la variable  amount n’a pas été initialisée, elle ne pourra 
    pas être utilisée car le compilateur ne sait pas quelle valeur il y 
    a dans la variable amount.

    Alors on l'initialise en lui affectant une valeur:

                int amount;
                amount = 30000;
    Des lors, amount contient la valeur 30000 jusqu'a ce quelle ne subisse 
    une mise a jour.



    Cela dit, il est possible d'initialiser une variable au moment de la 
    declaration de celle ci.

                string firstName = "Cynthia";

    On cree ici notre variable de type string( chaime de caracteres) qui a 
    pour valeur initiale 'Cynthia' 
*/