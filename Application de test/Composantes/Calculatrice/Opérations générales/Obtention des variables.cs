using System;

namespace Console_multi_fonctionnelle_basique
{
    public partial class Calculatrice
    {
        private (decimal, decimal, decimal) ObtentionDesVariables(int nbVal, out decimal valX, out decimal valY, out decimal valZ)
        {
            valX = 0;
            valY = 0;
            valZ = 0;
            if (nbVal == 1)
            {
                ObtentionValX(out valX);
            }
            else if (nbVal == 2)
            {
                ObtentionValX(out valX);
                ObtentionValY(out valY);
            }
            else if (nbVal == 3)
            {
                ObtentionValX(out valX);
                ObtentionValY(out valY);
                ObtentionValZ(out valZ);
            }
            else
            {
                Console.WriteLine("Une erreur s'est produite dans l'exécution de la fonction, veuillez le reporter sur le GitHub où vous avez trouver cette console pour aider le développeur à régler tout bug possible");
                Console.WriteLine("Après avoir rapporté cette erreur, appuyez sur une touche pour fermer la console...");
                Console.ReadKey();
                Environment.Exit(0);
            }
            return (valX, valY, valZ);
        }
    }
}