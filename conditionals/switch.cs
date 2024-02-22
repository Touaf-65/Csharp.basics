using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwitchConditional
{
    class Program
    {
        static void Main(string[] args)
        {

            //1 gestion de plusieurs valeurs avec if
            if (civilite == "Mme")
            Console.WriteLine("Vous êtes une femme");
            else if (civilite == "Mlle")
            Console.WriteLine("Vous êtes une femme non mariée");
            else if (civilite == "M.")
            Console.WriteLine("Vous êtes un homme");
            else
            Console.WriteLine("Je n'ai pas pu déterminer votre civilité");

            //2
            string civilite = "M.";
            switch (civilite)
            {
            case "M." :
            Console.WriteLine("Bonjour monsieur");
            break;
            case "Mme":
            Console.WriteLine("Bonjour madame");
            break;
            case "Mlle":
            Console.WriteLine("Bonjour mademoiselle");   

            //3
            string mois = "Janvier";
            if (mois == "Mars" || mois == "Avril" || mois == "Mai")
            Console.WriteLine("C'est le printemps");
            if (mois == "Juin" || mois == "Juillet" || mois == "Aout")
            Console.WriteLine("C'est l'été");
            if (mois == "Septembre" || mois == "Octobre" || mois == "Novembre")
            Console.WriteLine("C'est l'automne");
            if (mois == "Decembre" || mois == "Janvier" || mois == "Février")
            Console.WriteLine("C'est l'hiver");

            //4
            switch (mois)
            {
            case "Mars":
            case "Avril":
            case "Mai":
            Console.WriteLine("C'est le printemps");
            break;
            case "Juin":
            case "Juillet":
            case "Aout":
            Console.WriteLine("C'est l'été");
            break;
            case "Septembre":
            case "Octobre":
            case "Novembre":
            Console.WriteLine("C'est l'automne");
            break;
            case "Décembre":
            case "Janvier":
            case "Février":
            Console.WriteLine("C'est l'hiver");
            break;
        }
    }
}
