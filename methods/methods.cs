using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            DireBonjour("Thia", 15);  

            double hyp = LongueurHypotenuse(3,5);
            Console.WriteLine(hyp);

            Console.WriteLine(" Valeur de l'hypotenuse (10,10): " + LongueurHypotenuse(10,10));  
        }

        static void DireBonjour(string prenom, int age)
        {
            Console.WriteLine("Bonjour " + prenom);
            Console.WriteLine("Vous avez " + age + " ans");
        }

        static double LongueurHypotenuse(double a, double b)
        {
            double sommeDesCarres = a * a + b * b;
            double resultat = Math.Sqrt(sommeDesCarres);
            return resultat;
        }
    }
}