using System;

namespace Console_multi_fonctionnelle_basique
{
    public partial class Calculatrice
    {
        private decimal ObtentionValZ(out decimal valZ)
        {
            bool exception = false;
            Console.Clear();
            Console.Write("Entrez la valeur de Z: ");
            string valZTemp = Console.ReadLine();
            try
            {
                valZ = Convert.ToDecimal(valZTemp);
            }
            catch (Exception)
            {
                exception = true;
                Console.WriteLine("La valeur entrée n'est pas valide...");
                Console.WriteLine("Appuyez sur une touche pour re-entrer la valeur de Z...");
                Console.ReadKey();
                ObtentionValZ(out valZ);
            }
            if (exception == false)
            {
                valZ = Convert.ToDecimal(valZTemp);
                return (valZ);
            }
            else
            {
                return (0);
            }
        }
    }
}