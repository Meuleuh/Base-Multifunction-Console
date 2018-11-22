using System;

namespace Console_multi_fonctionnelle_basique
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Title = "Console multi-fonctionnelle basique";
            bool repeatIt = true;

            while (repeatIt == true)
            {
                Console.Clear();
                Console.WriteLine("Entrez le programme voulu");
                Console.WriteLine("Liste des programmes (aucune erreur de frappe est accepté, incluant l'absence d'une majuscule");
                Console.WriteLine("- Calculatrice");
                Console.WriteLine("- Sudoku Solver");
                Console.WriteLine();
                string PrgChoisi = Console.ReadLine();
                if (PrgChoisi.ToLower() == "calculatrice")
                {
                    Calculatrice calculatrice = new Calculatrice();
                    repeatIt = false;
                }
                else if (PrgChoisi.ToLower() == "sudoku solver")
                {
                    SudokuSolver sudokuSolver = new SudokuSolver();
                    repeatIt = false;
                }
                else
                {
                    Console.WriteLine("Programme invalide");
                    Console.WriteLine("Appuyez sur une touche pour écrire à nouveau le programme voulu");
                    Console.ReadKey();
                }
            }
        } //Version 2.1.0
    }
}
