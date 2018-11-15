using System;
using System.Collections.Generic;

namespace Console_multi_fonctionnelle_basique
{
    public partial class SudokuSolver
    {
        GridValue[,] ColumnSolving(GridValue[,] SudokuGrid, int i, int j)
        {
            for (int possibleAnswer = 1; possibleAnswer < 10; possibleAnswer++)
            {
                bool canBeThis = true;
                for (int k = 0; k < 9; k++)
                {
                    if (SudokuGrid[i, k].AlreadySolved == false)
                    {
                        if (SudokuGrid[i, j].PossibleValues.Contains(possibleAnswer))
                        {
                            if (SudokuGrid[i, k].PossibleValues.Contains(possibleAnswer))
                            {
                                canBeThis = false;
                            }
                        }
                        else
                        {
                            canBeThis = false;
                        }
                    }
                }
                if (canBeThis == true)
                {
                    SudokuGrid[i, j].AlreadySolved = true;
                    SudokuGrid[i, j].Value = possibleAnswer;
                    //On supprime la possibité de contenir d'autres nombres
                    for (int value = 1; value < 10; value++)
                    {
                        if (SudokuGrid[i, j].Value != value)
                        {

                            SudokuGrid[i, j].PossibleValues.Remove(value);
                        }
                    }
                    break;
                }
                else
                {
                    SudokuGrid[i, j].Value = 0;
                }
            }
            return SudokuGrid;
        }
    }
}