using System;

namespace Console_multi_fonctionnelle_basique
{
    public partial class AnalyseurDeVecteur
    {
        public void NormeEtAngle(out decimal norme, out decimal angle, out decimal x, out decimal y)
        {
            Console.Clear();
            Console.Write("Entrez la norme: ");
            string TempNorme = Console.ReadLine();
            try
            {
                norme = Convert.ToDecimal(TempNorme);
            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine("Votre valeur entrée n'est valide");
                Console.WriteLine("Appuyez sur une touche pour entrer de nouveau les vairables");
                Console.ReadKey();
                NormeEtAngle(out norme, out angle, out x, out y);
            }
            norme = Convert.ToDecimal(TempNorme);
        }
    }
}