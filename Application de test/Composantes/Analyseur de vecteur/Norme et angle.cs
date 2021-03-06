﻿using System;

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
            Console.Write("Entrez l'angle: ");
            string TempAngle = Console.ReadLine();
            try
            {
                angle = Convert.ToDecimal(TempAngle);
            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine("Votre valeur entrée n'est valide");
                Console.WriteLine("Appuyez sur une touche pour entrer de nouveau les vairables");
                Console.ReadKey();
                NormeEtAngle(out norme, out angle, out x, out y);
            }
            angle = Convert.ToDecimal(TempAngle);
            Console.WriteLine("L'entrée est valide, calcul en cours...");
            if (angle == 90 || angle == 270)
            {
                x = 0;
            }
            else
            {
                x = Convert.ToDecimal(decimal.ToDouble(norme) * Math.Cos(decimal.ToDouble(angle) * (Math.PI / 180)));
            }
            if (angle == 0 || angle == 180)
            {
                y = 0;
            }
            else
            {
                y = Convert.ToDecimal(decimal.ToDouble(norme) * Math.Sin(decimal.ToDouble(angle) * (Math.PI / 180)));
            }
            Console.WriteLine("Calcul effectué");
        }
    }
}