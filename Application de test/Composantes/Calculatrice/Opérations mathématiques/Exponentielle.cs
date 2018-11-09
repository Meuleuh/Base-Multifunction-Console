using System;

namespace Console_multi_fonctionnelle_basique
{
    public partial class Calculatrice
    {
        private decimal Exponentielle(out decimal reponse)
        {
            Console.Title = "Calcultrice.Exponentielle";
            ObtentionDesVariables(2, out decimal valX, out decimal valY, out _);
            reponse = Convert.ToDecimal(Math.Pow(Convert.ToDouble(valX), Convert.ToDouble(valY)));
            Console.Clear();
            Console.WriteLine(Convert.ToDouble(valX) + " ^ " + Convert.ToDouble(valY));
            Console.WriteLine();
            return reponse;
        }
    }
}