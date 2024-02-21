using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CharStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Concatenation avec (+)
            string firstName = "Thia";
            string title = " Miss";
            string director = title + " " + firstName;

            Console.WriteLine(director); // Miss Thia

            // Caracteres speciaux
            string presentation1 = "My name is \"Touaf\"";
            Console.WriteLine(presentation1); // My name is "Touaf"
            
            string presentation2 = "Her name is 'Thia'"; 
            Console.WriteLine(presentation1); // Her name is 'Thia'
            
            string presentation3 = 'Weare are \'Thia\' and \'Touaf\'';
            Console.WriteLine(presentation1); // We are 'Thia' and 'Touaf'

            // \n , \t
            Console.WriteLine(" Hello World !! \nHow are you?");
            /*
                Hello World!!
                How are you ?
            */

            Console.WriteLine(" The sevens days of the week are : \n\t-Monday \t-Thursday \t-Wednesday \t-Tuesday \t-Friday \t-Saturday \t-Sunday");
            /*
                The sevens days of the week are :
                    -Monday
                    -Thursday
                    -Wednesday
                    -Tuesday
                    -Friday
                    -Saturday
                    -Sunday
            */

        }
    }
}

/*
        ** Explication **

    L'addition (+) permet de faire de la concatenation entre chaines de caracteres

    \ est un caractere d'echappement. Devant ' ou " dans des string qui sont 
    respectivement dans l'ordre '...' ; "...", il permet de ne pas marquer fin 
    a la chaine de caracteres et de l'afficher aussi.

    \n permet un retour a la ligne

    \t permet de faire une tabulation

*/