using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_multi_fonctionnelle_basique
{
    public partial class AnalyseurDeVecteur
    {
        public AnalyseurDeVecteur()
        {
            Console.Title = "Analyseur de vecteur";
            Console.Clear();
            Console.WriteLine("Sélectionnez le type d'entrée");
            Console.WriteLine("- Norme et angle");
            Console.WriteLine("- x et y");
            Console.WriteLine();
            string typeInput = Console.ReadLine();
            try
            {
                string verifSiErreur = typeInput.ToLower();
            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine("Le type d'entrée n'est pas valide");
                Console.WriteLine("Appuyez pour recommencer");
                Console.ReadKey();
                AnalyseurDeVecteur analyseurDeVecteur = new AnalyseurDeVecteur();
            }
            typeInput = typeInput.ToLower();
            decimal norme = 0;
            decimal angle = 0;
            decimal x = 0;
            decimal y = 0;
            if (typeInput.Contains("norme") || typeInput.Contains("angle"))
            {
                NormeEtAngle(out norme, out angle, out x, out y);
            }
            else if (typeInput.Contains("x") || typeInput.Contains("y"))
            {
                XEtY(out norme, out angle, out x, out y);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Le type d'entrée n'est pas valide");
                Console.WriteLine("Appuyez pour recommencer");
                Console.ReadKey();
                AnalyseurDeVecteur analyseurDeVecteur = new AnalyseurDeVecteur();
            }
            Console.Clear();
            Console.WriteLine("Norme du vecteur: " + norme);
            Console.WriteLine("Angle du vecteur: " + angle + "˚");
            Console.WriteLine("x: " + x);
            Console.WriteLine("y: " + y);
            Console.WriteLine();
            Console.WriteLine("Appuyez sur une touche pour fermer");
            Console.ReadKey();
        }  // Version 1.0.0
    }
}
