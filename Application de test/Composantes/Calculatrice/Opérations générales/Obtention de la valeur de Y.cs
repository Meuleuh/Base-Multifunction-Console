using System;

namespace Console_multi_fonctionnelle_basique
{
    public partial class Calculatrice
    {
        private decimal ObtentionValY(out decimal valY)
        {
            bool exception = false;
            Console.Clear();
            Console.Write("Entrez la valeur de Y: ");
            string valYTemp = Console.ReadLine();
            try
            {
                valY = Convert.ToDecimal(valYTemp);
            }
            catch (Exception)
            {
                exception = true;
                Console.WriteLine("La valeur entrée n'est pas valide...");
                Console.WriteLine("Appuyez sur une touche pour re-entrer la valeur de Y...");
                Console.ReadKey();
                ObtentionValX(out valY);
            }
            if (exception == false)
            {
                valY = Convert.ToDecimal(valYTemp);
                return (valY);
            }
            else
            {
                return (0);
            }
        }
    }
}