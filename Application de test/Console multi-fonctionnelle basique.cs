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
        } //Version Pre-1.0.0
        
        //Les fonctions

        static void Calculatrice()
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
        } //Version Pre-1.0.0
    }
}
