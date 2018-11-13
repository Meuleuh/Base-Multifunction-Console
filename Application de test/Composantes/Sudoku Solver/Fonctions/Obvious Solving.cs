using System;
using System.Collections.Generic;

namespace Console_multi_fonctionnelle_basique
{
    public partial class SudokuSolver
    {
        GridValue[,] ObviousSolving(GridValue[,] SudokuGrid, int i, int j)
        {
            if (SudokuGrid[i,j].PossibleValues.Count == 1)
            {
                SudokuGrid[i, j].Value = SudokuGrid[i, j].PossibleValues[0];
                SudokuGrid[i, j].AlreadySolved = true;
            }


            return SudokuGrid;
        }
    }
}