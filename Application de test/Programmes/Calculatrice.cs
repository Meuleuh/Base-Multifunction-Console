using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_de_test
{
    partial class Program
    {
        static void Calculatrice()
        {
            Console.Clear();
            Console.WriteLine("Voici les opérations pouvant être sélectionnées");
            FonctionsSelectionnables();
            Console.Write("Fonction voulue:");
            string FonctionSelectionne = Console.ReadLine();
            if (FonctionSelectionne == "Addition" || FonctionSelectionne == "Add")
            {
                Addition();
            }
            else
            {
                Console.WriteLine("Cette fonction n'existe pas dans le contexte donné");
                Console.WriteLine("Appuyez sur une touche pour continuer");
                Console.ReadKey();
                Calculatrice();
            }

            //Les fonctions essentielles et universelles de la calculatrice

            (decimal, decimal) GetTwoVariable(out decimal valX, out decimal valY)
            {
                Console.Clear();
                Console.WriteLine("Quel est la valeur de X ?");
                string valXTemp = Console.ReadLine();
                try
                {
                    decimal valXError = Convert.ToDecimal(valXTemp);
                }
                catch
                {
                    ExceptionCaughtInTheVariable();
                }
                valX = Convert.ToDecimal(valXTemp);
                Console.WriteLine("Quel est la valeur de Y ?");
                string valYTemp = Console.ReadLine();
                try
                {
                    decimal valYError = Convert.ToDecimal(valYTemp);
                }
                catch
                {
                    ExceptionCaughtInTheVariable();
                }
                valY = Convert.ToDecimal(valYTemp);
                return (valY, valY);
            }

            void ExceptionCaughtInTheVariable()
            {
                Console.WriteLine("La variable ne peut pas être autre chose qu'un nombre");
                Console.WriteLine("Appuyez sur une touche pour recommencer la calculatrice");
                Console.ReadKey();
                Calculatrice();
            }
            //Fonction utile pour éviter les répétition d'un message d'erreur dans le code.
            //Il va falloir que l'on rajoutes le fait de recommencer la fonction en cours au lieu de recommencer la calculatrice

            void FonctionsSelectionnables()
            {
                Console.WriteLine("- Addition");
            } //Fonction pour écrire toutes les fonctions sélectionnables

            //Les fonctions de la calculatrice

            void Addition()
            {
                decimal valX;
                decimal valY;
                GetTwoVariable(out valX, out valY);
                Console.Clear();
                Console.WriteLine("Valeur de X: " + valX);
                Console.WriteLine("Valeur de Y: " + valY);
                Console.WriteLine("Somme (X + Y): " + (valX + valY));
                Console.WriteLine("Appuyez sur une touche pour fermer la console");
                Console.ReadKey();
            }
        } //Version 1.0.1
    }
}
