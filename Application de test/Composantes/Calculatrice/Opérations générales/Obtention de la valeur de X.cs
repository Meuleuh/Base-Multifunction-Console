using System;

namespace Console_multi_fonctionnelle_basique
{
    public partial class Calculatrice
    {
        private decimal ObtentionValX(out decimal valX)
        {
            bool exception = false;
            Console.Clear();
            Console.Write("Entrez la valeur de X: ");
            string valXTemp = Console.ReadLine();
            try
            {
                valX = Convert.ToDecimal(valXTemp);
            }
            catch (Exception)
            {
                exception = true;
                Console.WriteLine("La valeur entrée n'est pas valide...");
                Console.WriteLine("Appuyez sur une touche pour re-entrer la valeur de X...");
                Console.ReadKey();
                ObtentionValX(out valX);
            }
            if (exception == false)
            {
                valX = Convert.ToDecimal(valXTemp);
                return (valX);
            }
            else
            {
                return (0);
            }
        }
    }
}