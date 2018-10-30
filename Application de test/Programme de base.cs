using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_de_test
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeatIt = true;

            while (repeatIt == true)
            {
                Console.Clear();
                Console.WriteLine("Entrez le programme voulu");
                Console.WriteLine("Liste des programmes (aucune erreur de frappe est accepté, incluant l'absence d'une majuscule");
                Console.WriteLine("- Calculatrice");
                string PrgChoisi = Console.ReadLine();
                if (PrgChoisi == "Calculatrice")
                {
                    Calculatrice();
                    repeatIt = false;
                }
                else
                {
                    Console.WriteLine("Programme invalide");
                    Console.WriteLine("Appuyez sur une touche pour écrire à nouveau le programme voulu");
                    Console.ReadKey();
                }
            }

            //Les fonctions

            void Calculatrice()
            {
                void ExceptionCaughtInTheVariable()
                {
                    Console.WriteLine("Il est impossible de calculer autre chose que des chiffres ensemble");
                    Console.WriteLine("Appuyez sur une touche pour redémarrer la calculatrice");
                    Console.ReadKey();
                    Calculatrice();
                }
                Console.Clear();
                Console.WriteLine("Entrez la valeur de X");
                string strValX = Console.ReadLine();
                try
                {
                    Double valXErr = Convert.ToDouble(strValX);
                }
                catch (Exception)
                {
                    ExceptionCaughtInTheVariable();
                }
                Console.WriteLine("Entrez la valeur de Y");
                string strValY = Console.ReadLine();
                try
                {
                    Double valYErr = Convert.ToDouble(strValY);
                }
                catch (Exception)
                {
                    ExceptionCaughtInTheVariable();
                }
                Double valX = Convert.ToDouble(strValX);
                Double valY = Convert.ToDouble(strValY);
                Console.WriteLine("Addition :" + (valX + valY));
                Console.WriteLine("Soustraction :" + (valX - valY));
                Console.WriteLine("Multiplication :" + (valX * valY));
                try
                {
                    Console.WriteLine("Division :" + (valX / valY));
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Il est impossible de diviser par zéro");
                }
                Console.WriteLine("Appuyez sur une touche pour terminer le programme");
                Console.ReadKey();
            }
        }

    }
}

/* [Résumé]
 * Ce programme est la console de base.
 * 
 * [Notes]
 * Dans le futur, cette console aura un code encore plus simple car les autres programmes seront dans d'autres
 * fichiers au lieu d'être des fonctions à part entière de celle-ci. De plus, le programme calculatrice devra,
 * dans ses futures versions, pouvoir faire toutes les opérations de bases d'une calculatrice au choix de
 * l'utilisateur au lieu de les faire automatiquement comme dans sa version 1.0.0 .
 * Les opérations qui devront être faisables sont: Addition, soustraction, multiplication, division, exposant,
 * racine. Les autres opérations seront ajoutées dans "Calculatrice 2.X" au minimum. En fait, lorsque
 * le programme calculatrice ne fera plus partie de le programme de base, les deux auront atteint la version 1.0.0 .
 * Lorsque le programme de base se vera attribué une nouvelle application, on augmentera à 1.(+=1).x .
 * De plus, Il est prévu de rendre l'interface plus beau et plus facile d'utilisation dans ses versions finales
 * (ça comptera également comme une mise à jour majeure)
 * 
 * [Journal de modifications]
 * (La version 1.0.0 n'est pas encore atteinte) 
 */
