using System;

namespace Console_multi_fonctionnelle_basique
{
    public partial class SudokuSolver
    {
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
    }
}