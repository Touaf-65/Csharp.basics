using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World !");
        }
    }
}

/* 
       ** Explication du code **

    - using
    Mot cle permettant d'importer les espaces de noms (namespace)

    - namespace (espace de noms)
    un espace de noms en C# est une collection de classes, d'interfaces et 
    d'autres constructions de code associées. Les espaces de noms permettent
    d'organiser le code et d'éviter les conflits de noms. Ils aident également
    à encapsuler le code et à le rendre réutilisable

        Exemples de namespace: 
        ~ System : il s'agit de l'espace de noms de base pour tout le code C#. 
          Il donne accès aux types essentiels tels que Console, String et Int32.
        ~ System.Collections.Generic : cet espace de noms fournit des types de collections
          génériques tels que List<T>, Dictionary<TKey, TValue> et Queue<T>.
        ~ System.Linq : cet espace de noms fournit des méthodes d'extension pour interroger 
          des collections, telles que Where, Select et OrderBy.
        ~ System.Text : cet espace de noms fournit des classes pour encoder et décoder le texte, 
          telles que Encoding et StringBuilder.
    
    - namespace HelloWorld
    namespace HelloWorld déclare un espace de noms nommé "HelloWorld". Cet espace de noms agit 
    comme un conteneur pour la classe Program dans le code.

    - class Program { ..... }
    represente la classe principale du programme. Elle est accessible suivant HelloWorld.Program

    - static void Main(string [] args) { ... }
    C'est le point d'entrée du programme. Il prend en parametre un tableau de chaînes de caracteres: 
    (args) en entrée, qui peut être utilisé pour transmettre des arguments de ligne de commande au 
    programme.
    Le corps de la méthode Main contient le code qui sera exécuté lors de l’exécution du programme.

    - Console.WriteLine("Hello World !"); 
    Cette instruction écrit la chaîne "Hello World !" à la console. 
    La méthode Console.WriteLine est utilisée pour ecrire/afficher du texte sur la console.
*/
