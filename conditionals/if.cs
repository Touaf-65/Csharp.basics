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
            Console.WriteLine("Vous avez les droits d'acces");

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

/*
        ** Explication **

    //1
    Ce code vérifie la valeur de la variable hasRight. S'il est égal 
    à 'OK', le message "Vous avez les droits d'accès" s'affiche.

    //2 
    Ce code vérifie la valeur de la variable compteEnBanque. S'il est 
    supérieur ou égal à 0, le message « Votre compte est créditeur » 
    s'affiche. Sinon, le message « Votre compte est débiteur » s'affiche.

    //3
    Ce code vérifie la valeur de la variable estVrai. Si c'est vrai, le 
    message "C'est vrai !" (C'est vrai !) s'affiche. Sinon, le message 
    "C'est faux !" (C'est faux !) s'affiche.

    //4
    Ce code utilise l'opérateur ! pour annuler la valeur de la variable estVrai.
    Puisque estVrai est faux, l'opérateur ! le rend vrai, et le message "C'est vrai !" 
    (C'est vrai !) s'affiche.

    //5 
    Ce code vérifie les valeurs des variables login et motDePasse. S'ils sont tous 
    deux égaux respectivement à "Nicolas" et "test", le message "Bienvenue Nicolas"
    s'affiche. Sinon, le message « Login incorrect » (Connexion incorrecte) s'affiche.

    //6
    Ce code vérifie la valeur de la variable civilité. S'il est égal à "Mme" ou "Mlle", 
    le message "Vous êtes une femme" s'affiche. Sinon, le message « Vous êtes un homme »
    s'affiche.
*/
