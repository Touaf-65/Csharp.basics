using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Numerics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operations sur les types numeriques

            int note1 = 15;
            int note2 = 19;

            int moyenne = (note1 + note2) / 2; // moyenne = 17

            int note1 = 5;                     // mise a jour de note1 : Desormais , note1 = 5 et note2 = 19
            int moyenne = (note1 + note2) / 2  // moyenne = (5 + 19) / 2 = 12

            int diff = note2 - note1;

            int note1_coeff2 = note1 * 2;

            // Entier # Double, Decimal ..

            int moyenne = 5 / 2;
            Console.WriteLine(moyenne); // moyenne = 2

            double moyenne = 5.0 / 2.0;
            Console.WriteLine(moyenne); // moyenne = 2.5

            // Operateurs particuliers
            int age = 20;
            age = age + 10;     // age contient 30 (addition)
            age++;              // age contient 31 (incrémentation de 1)
            age--;              // age contient 30 (décrémentation de 1)
            age += 10;          // équivalent à age = age + 10 (age contient 40)
            age /= 2;           // équivalent à age = age / 2 => (age contient 20)
        }
    }
}
