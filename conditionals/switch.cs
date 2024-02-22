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

/*
        ** Explication **
    
    L’instruction switch peut être utilisée lorsqu’une variable peut 
    prendre beaucoup de valeurs. Elle permet de simplifier
    l’écriture.

    ~ Des que la necessite se fait ressentir de faire plusieurs controles 
    sur une variable et mener des actions differentes pour chaque valeur,
    on peut utiliser Switch case.

    Exemple: 1 et 2.
    ~ Case ... :
        ..
        ..
      break;

      break permet de marquer la fin d'un bloc Case.

    ~ Si pour une valeur differente de toutes les valeurs controlees,
    on la specifie dans le bloc default.

    ~ SI pour differentes valeurs de la variable de controle on doit mener 
    la meme action comme dans le bloc de code 3, il suffira de lisser nos blocs 
    Case a la suite l'un de l'autre avec les differentes valeurs.

    Apres la derniere valeur ce controle, on ecrit l'action a executer pour
    ces conditions communes.

    Exemple: 3 et 4 
*/