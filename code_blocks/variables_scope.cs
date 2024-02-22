using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VariableScope
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string prenom = "Nicolas";
            string civilite = "M.";
            if (prenom == "Nicolas")
            {
                int age = 30;  
                Console.WriteLine("Votre age est : " + age);
                switch (civilite)
                {
                    case "M.":
                        Console.WriteLine("Vous êtes un homme de " + age + "
                        ans");
                        break;
                    case "Mme":
                        Console.WriteLine("Vous êtes une femme de " + age +
                        " ans");
                        break;
                } 
            }
            if (age >= 18)
            {
                Console.WriteLine(prenom + ", vous êtes majeur");
            }
        }
    }
}

/*
    ** Explication **
    string prenom = "Nicolas" est definie explicitement dans la methode 
    Main et est donc accessible a tous les endroits de cette methode. De 
    mm pour civilite.

    int age = 30 a ete definie uniquement dans le bloc if. Et donc son 
    utilisation est restreint a cette boucle.

    De ce fait, 
    if (age >= 18)
            {
                Console.WriteLine(prenom + ", vous êtes majeur");
            }
    qui est une boucle hors du bloc if dans lequel on a cree cette variable
    va generer des erreurs. Car la methode Main() ne contient pas de variable age.
*/