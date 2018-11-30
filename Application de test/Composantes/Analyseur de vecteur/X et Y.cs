using System;

namespace Console_multi_fonctionnelle_basique
{
    public partial class AnalyseurDeVecteur
    {
        public void XEtY(out decimal norme, out decimal angle, out decimal x, out decimal y)
        {
            Console.Clear();
            Console.Write("Entrez la valeur de x: ");
            string TempX = Console.ReadLine();
            try
            {
                x = Convert.ToDecimal(TempX);
            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine("Votre valeur entrée n'est valide");
                Console.WriteLine("Appuyez sur une touche pour entrer de nouveau les vairables");
                Console.ReadKey();
                XEtY(out norme, out angle, out x, out y);
            }
            x = Convert.ToDecimal(TempX);
            Console.Write("Entrez l'angle: ");
            string TempY = Console.ReadLine();
            try
            {
                y = Convert.ToDecimal(TempY);
            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine("Votre valeur entrée n'est valide");
                Console.WriteLine("Appuyez sur une touche pour entrer de nouveau les vairables");
                Console.ReadKey();
                XEtY(out norme, out angle, out x, out y);
            }
            y = Convert.ToDecimal(TempY);
            Console.WriteLine("L'entrée est valide, calcul en cours...");
            norme = Convert.ToDecimal(Math.Abs(Math.Sqrt(Math.Pow(decimal.ToDouble(x),2) + Math.Pow(decimal.ToDouble(y),2))));
            if (x > 0 && y > 0)
            {
                angle = Convert.ToDecimal(Math.Atan(decimal.ToDouble(x)/decimal.ToDouble(y))*(180/Math.PI));
            }
            else if ((x < 0 && y > 0) || (x > 0 && y < 0))
            {
                angle = Convert.ToDecimal(Math.Atan(decimal.ToDouble(x) / decimal.ToDouble(y)) * (180 / Math.PI)) + 180;
            }
            else
            {
                angle = Convert.ToDecimal(Math.Atan(decimal.ToDouble(x) / decimal.ToDouble(y)) * (180 / Math.PI)) + 360;
            }
            Console.WriteLine("Calcul effectué");
        }
    }
}