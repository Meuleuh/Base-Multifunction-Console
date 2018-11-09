using System;
using System.Collections.Generic;

namespace Console_multi_fonctionnelle_basique
{
    public class SudokuSolver
    {
        //Code d'initialisation
        public SudokuSolver()
        {
            Console.Clear();
            SudokuGridCreator(out GridValue[,] SudokuGrid);
            SudokuDisplay(SudokuGrid);
            Console.ReadKey();
        }

        //Stocker toutes les variables nécessaires à chaque case
        private class GridValue
        {
            /*
            public bool CanBe1 { get; set; } = false;
            public bool CanBe2 { get; set; } = false;
            public bool CanBe3 { get; set; } = false;
            public bool CanBe4 { get; set; } = false;
            public bool CanBe5 { get; set; } = false;
            public bool CanBe6 { get; set; } = false;
            public bool CanBe7 { get; set; } = false;
            public bool CanBe8 { get; set; } = false;
            public bool CanBe9 { get; set; } = false;
            */
            public List<int> PossibleValues = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            public bool AlreadySolved { get; set; } = false;
            public int Value { get; set; } = 0;
        }

        //Afficher la grille

        private void SudokuDisplay(GridValue[,] Sudoku)
        {
            Console.WriteLine("Tous les 0 représentent des valeurs non assignées");
            Console.WriteLine("┏━━━┯━━━┯━━━┳━━━┯━━━┯━━━┳━━━┯━━━┯━━━┓");
            Console.WriteLine("┃ " + Sudoku[0, 0].Value + " │ " + Sudoku[1, 0].Value + " │ " + Sudoku[2, 0].Value + " ┃ " + Sudoku[3, 0].Value + " │ " + Sudoku[4, 0].Value + " │ " + Sudoku[5, 0].Value + " ┃ " + Sudoku[6, 0].Value + " │ " + Sudoku[7, 0].Value + " │ " + Sudoku[8, 0].Value + " ┃");
            Console.WriteLine("┠───┼───┼───╂───┼───┼───╂───┼───┼───┨");
            Console.WriteLine("┃ " + Sudoku[0, 1].Value + " │ " + Sudoku[1, 1].Value + " │ " + Sudoku[2, 1].Value + " ┃ " + Sudoku[3, 1].Value + " │ " + Sudoku[4, 1].Value + " │ " + Sudoku[5, 1].Value + " ┃ " + Sudoku[6, 1].Value + " │ " + Sudoku[7, 1].Value + " │ " + Sudoku[8, 1].Value + " ┃");
            Console.WriteLine("┠───┼───┼───╂───┼───┼───╂───┼───┼───┨");
            Console.WriteLine("┃ " + Sudoku[0, 2].Value + " │ " + Sudoku[1, 2].Value + " │ " + Sudoku[2, 2].Value + " ┃ " + Sudoku[3, 2].Value + " │ " + Sudoku[4, 2].Value + " │ " + Sudoku[5, 2].Value + " ┃ " + Sudoku[6, 2].Value + " │ " + Sudoku[7, 2].Value + " │ " + Sudoku[8, 2].Value + " ┃");
            Console.WriteLine("┣━━━┿━━━┿━━━╋━━━┿━━━┿━━━╋━━━┿━━━┿━━━┫");
            Console.WriteLine("┃ " + Sudoku[0, 3].Value + " │ " + Sudoku[1, 3].Value + " │ " + Sudoku[2, 3].Value + " ┃ " + Sudoku[3, 3].Value + " │ " + Sudoku[4, 3].Value + " │ " + Sudoku[5, 3].Value + " ┃ " + Sudoku[6, 3].Value + " │ " + Sudoku[7, 3].Value + " │ " + Sudoku[8, 3].Value + " ┃");
            Console.WriteLine("┠───┼───┼───╂───┼───┼───╂───┼───┼───┨");
            Console.WriteLine("┃ " + Sudoku[0, 4].Value + " │ " + Sudoku[1, 4].Value + " │ " + Sudoku[2, 4].Value + " ┃ " + Sudoku[3, 4].Value + " │ " + Sudoku[4, 4].Value + " │ " + Sudoku[5, 4].Value + " ┃ " + Sudoku[6, 4].Value + " │ " + Sudoku[7, 4].Value + " │ " + Sudoku[8, 4].Value + " ┃");
            Console.WriteLine("┠───┼───┼───╂───┼───┼───╂───┼───┼───┨");
            Console.WriteLine("┃ " + Sudoku[0, 5].Value + " │ " + Sudoku[1, 5].Value + " │ " + Sudoku[2, 5].Value + " ┃ " + Sudoku[3, 5].Value + " │ " + Sudoku[4, 5].Value + " │ " + Sudoku[5, 5].Value + " ┃ " + Sudoku[6, 5].Value + " │ " + Sudoku[7, 5].Value + " │ " + Sudoku[8, 5].Value + " ┃");
            Console.WriteLine("┣━━━┿━━━┿━━━╋━━━┿━━━┿━━━╋━━━┿━━━┿━━━┫");
            Console.WriteLine("┃ " + Sudoku[0, 6].Value + " │ " + Sudoku[1, 6].Value + " │ " + Sudoku[2, 6].Value + " ┃ " + Sudoku[3, 6].Value + " │ " + Sudoku[4, 6].Value + " │ " + Sudoku[5, 6].Value + " ┃ " + Sudoku[6, 6].Value + " │ " + Sudoku[7, 6].Value + " │ " + Sudoku[8, 6].Value + " ┃");
            Console.WriteLine("┠───┼───┼───╂───┼───┼───╂───┼───┼───┨");
            Console.WriteLine("┃ " + Sudoku[0, 7].Value + " │ " + Sudoku[1, 7].Value + " │ " + Sudoku[2, 7].Value + " ┃ " + Sudoku[3, 7].Value + " │ " + Sudoku[4, 7].Value + " │ " + Sudoku[5, 7].Value + " ┃ " + Sudoku[6, 7].Value + " │ " + Sudoku[7, 7].Value + " │ " + Sudoku[8, 7].Value + " ┃");
            Console.WriteLine("┠───┼───┼───╂───┼───┼───╂───┼───┼───┨");
            Console.WriteLine("┃ " + Sudoku[0, 8].Value + " │ " + Sudoku[1, 8].Value + " │ " + Sudoku[2, 8].Value + " ┃ " + Sudoku[3, 8].Value + " │ " + Sudoku[4, 8].Value + " │ " + Sudoku[5, 8].Value + " ┃ " + Sudoku[6, 8].Value + " │ " + Sudoku[7, 8].Value + " │ " + Sudoku[8, 8].Value + " ┃");
            Console.WriteLine("┗━━━┷━━━┷━━━┻━━━┷━━━┷━━━┻━━━┷━━━┷━━━┛");
        }

        //Demander la valeur des cases déjà assignées
        //Vérifier si la case peut avoir tel ou tel nombre et si non, utiliser un .Remove()
        //Choisir le nombre le plus approprié pour chaque case
        //Terminer le programme après l'appui de l'usager

        //Création de toutes les objets pour que la grille fonctionne
        private GridValue[,] SudokuGridCreator(out GridValue[,] SudokuGrid)
        {
            SudokuGrid = new GridValue[9, 9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    SudokuGrid[i, j] = new GridValue();
                }
            }

            return SudokuGrid;
        }
    }
}