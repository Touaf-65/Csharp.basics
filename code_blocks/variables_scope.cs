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