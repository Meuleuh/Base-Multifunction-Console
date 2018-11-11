using System;
using System.Collections.Generic;

namespace Console_multi_fonctionnelle_basique
{
    public partial class SudokuSolver
    {
        GridValue[,] ColumnDetection(GridValue[,] SudokuGrid, int i, int j)
        {
            for (int k = 0; k < 9; k++)
            {
                //On vérifie si la case en question a déjà été résolue
                if (SudokuGrid[i, k].AlreadySolved == true)
                {
                    //Si oui, on vérifie si la valeur qu'elle contient a déjà été supprimé auparavant
                    if (SudokuGrid[i, j].PossibleValues.Contains(SudokuGrid[i, k].Value))
                    {
                        //Si la valeur n'a pas été supprimé, on la supprime
                        SudokuGrid[i, j].PossibleValues.Remove(SudokuGrid[i, k].Value);
                    }
                }
            }
            return SudokuGrid;
        }
    }
}