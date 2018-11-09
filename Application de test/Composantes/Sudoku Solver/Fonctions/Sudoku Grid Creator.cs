using System;

namespace Console_multi_fonctionnelle_basique
{
    //Création de toutes les objets pour que la grille fonctionne
    public partial class SudokuSolver
    {
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