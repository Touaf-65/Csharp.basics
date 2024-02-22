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
            //1
            decimal compteEnBanque = 300;
            if (compteEnBanque >= 0)
            Console.WriteLine("Votre compte est crediteur");
            Console.WriteLine("Voullez-vous effectuer une transaction?");

            //2
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

/*
        ** Explication **

    Un bloc de code est un regroupement d'instructions a executer a la suite l'un de l'autre
    dans le meme contexte.

    //1 Absence d'accolades
    Apres la verification de la condition if, l'instruction juste apres if sera executee 
    conformement a la valeur de la condition.

    Donc ici, puisque 300 >= 0; on aura:
        Votre compte est créditeur

    Puis independemment des valeurs de compteEnBanque(que compteEnBanque >= 0 ou compteEnBanque=<0), le systeme affichera en console:
        Voullez-vous effectuer une transaction?

    
    //2 Utilisation d'acolades
    Toutes les lignes d'instructions s'executent seulement dans le contexte de definition.

    Ici, le systeme affiche ses deux lignes seulement si compteEnBanque >=0
        Votre compte est crediteur
        Voullez-vous effectuer une transaction?
    
    Quand compteEnBanque < 0 alors s'affiche le message dans le bloc else.
        Vous ne pouvez qu'effectuer une operation  de transaction

*/