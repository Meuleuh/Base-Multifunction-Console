using System;

namespace Console_multi_fonctionnelle_basique
{
    public partial class Calculatrice
    {
        private decimal Racine(out decimal reponse)
        {
            Console.Title = "Calcultrice.Racine";
            ObtentionDesVariables(2, out decimal valX, out decimal valY, out _);
            reponse = Convert.ToDecimal(Math.Pow(Convert.ToDouble(valX), Convert.ToDouble(1 / valY)));
            Console.Clear();
            Console.WriteLine(Convert.ToDouble(valX) + " ^ 1/" + Convert.ToDouble(valY));
            Console.WriteLine();
            return reponse;
        }
    }
}