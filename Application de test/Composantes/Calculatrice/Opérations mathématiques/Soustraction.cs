using System;

namespace Console_multi_fonctionnelle_basique
{
    public partial class Calculatrice
    {
        private decimal Soustraction(out decimal reponse)
        {
            Console.Title = "Calcultrice.Soustraction";
            ObtentionDesVariables(2, out decimal valX, out decimal valY, out _);
            reponse = (valX - valY);
            Console.Clear();
            Console.WriteLine(valX + " - " + valY);
            Console.WriteLine();
            return reponse;
        }
    }
}