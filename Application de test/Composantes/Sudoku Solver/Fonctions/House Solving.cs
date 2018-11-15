using System;
using System.Collections.Generic;

namespace Console_multi_fonctionnelle_basique
{
    public partial class SudokuSolver
    {
        GridValue[,] HouseSolving(GridValue[,] SudokuGrid, int i, int j)
        {
            for (int possibleAnswer = 1; possibleAnswer < 10; possibleAnswer++)
            {
                bool canBeThis = true;
                if ((i == 0 || i == 1 || i == 2) && (j == 0 || j == 1 | j == 2))
                {
                    for (int hi = 0; hi < 3; hi++)
                    {
                        for (int hj = 0; hj < 3; hj++)
                        {
                            if (SudokuGrid[hi, hj].AlreadySolved == false)
                            {
                                if (SudokuGrid[i, j].PossibleValues.Contains(possibleAnswer))
                                {
                                    if (SudokuGrid[hi, hj].PossibleValues.Contains(possibleAnswer))
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
                    }
                } //Maison numéro 1 (x = {1,2,3} et y = {1,2,3})
                if ((i == 5 || i == 4 || i == 5) && (j == 0 || j == 1 | j == 2))
                {
                    for (int hi = 3; hi < 6; hi++)
                    {
                        for (int hj = 0; hj < 3; hj++)
                        {
                            if (SudokuGrid[hi, hj].AlreadySolved == false)
                            {
                                if (SudokuGrid[i, j].PossibleValues.Contains(possibleAnswer))
                                {
                                if (SudokuGrid[hi, hj].PossibleValues.Contains(possibleAnswer))
                                    {
                                        if (SudokuGrid[hi, hj].PossibleValues.Contains(possibleAnswer))
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
                        }
                    }
                } //Maison numéro 2 (x = {4,5,6} et y = {1,2,3})
                if ((i == 6 || i == 7 || i == 8) && (j == 0 || j == 1 | j == 2))
                {
                    for (int hi = 6; hi < 9; hi++)
                    {
                        for (int hj = 0; hj < 3; hj++)
                        {
                            if (SudokuGrid[hi, hj].AlreadySolved == false)
                            {
                                if (SudokuGrid[i, j].PossibleValues.Contains(possibleAnswer))
                                {
                                if (SudokuGrid[hi, hj].PossibleValues.Contains(possibleAnswer))
                                    {
                                        if (SudokuGrid[hi, hj].PossibleValues.Contains(possibleAnswer))
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
                        }
                    }
                } //Maison numéro 3 (x = {7,8,9} et y = {1,2,3})
                if ((i == 0 || i == 1 || i == 2) && (j == 3 || j == 4 | j == 5))
                {
                    for (int hi = 0; hi < 3; hi++)
                    {
                        for (int hj = 3; hj < 6; hj++)
                        {
                            if (SudokuGrid[hi, hj].AlreadySolved == false)
                            {
                                if (SudokuGrid[i, j].PossibleValues.Contains(possibleAnswer))
                                {
                                if (SudokuGrid[hi, hj].PossibleValues.Contains(possibleAnswer))
                                    {
                                        if (SudokuGrid[hi, hj].PossibleValues.Contains(possibleAnswer))
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
                        }
                    }
                } //Maison numéro 4 (x = {1,2,3} et y = {4,5,6})
                if ((i == 3 || i == 4 || i == 5) && (j == 3 || j == 4 | j == 5))
                {
                    for (int hi = 3; hi < 6; hi++)
                    {
                        for (int hj = 3; hj < 6; hj++)
                        {
                            if (SudokuGrid[hi, hj].AlreadySolved == false)
                            {
                                if (SudokuGrid[i, j].PossibleValues.Contains(possibleAnswer))
                                {
                                if (SudokuGrid[hi, hj].PossibleValues.Contains(possibleAnswer))
                                    {
                                        if (SudokuGrid[hi, hj].PossibleValues.Contains(possibleAnswer))
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
                        }
                    }
                } //Maison numéro 5 (x = {4,5,6} et y = {4,5,6})
                if ((i == 6 || i == 7 || i == 8) && (j == 3 || j == 4 | j == 5))
                {
                    for (int hi = 6; hi < 9; hi++)
                    {
                        for (int hj = 3; hj < 6; hj++)
                        {
                            if (SudokuGrid[hi, hj].AlreadySolved == false)
                            {
                                if (SudokuGrid[i, j].PossibleValues.Contains(possibleAnswer))
                                {
                                if (SudokuGrid[hi, hj].PossibleValues.Contains(possibleAnswer))
                                    {
                                        if (SudokuGrid[hi, hj].PossibleValues.Contains(possibleAnswer))
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
                        }
                    }
                } //Maison numéro 6 (x = {7,8,9} et y = {4,5,6})
                if ((i == 0 || i == 1 || i == 2) && (j == 6 || j == 7 | j == 8))
                {
                    for (int hi = 0; hi < 3; hi++)
                    {
                        for (int hj = 6; hj < 9; hj++)
                        {
                            if (SudokuGrid[hi, hj].AlreadySolved == false)
                            {
                                if (SudokuGrid[i, j].PossibleValues.Contains(possibleAnswer))
                                {
                                if (SudokuGrid[hi, hj].PossibleValues.Contains(possibleAnswer))
                                    {
                                        if (SudokuGrid[hi, hj].PossibleValues.Contains(possibleAnswer))
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
                        }
                    }
                } //Maison numéro 7 (x = {1,2,3} et y = {7,8,9})
                if ((i == 3 || i == 4 || i == 5) && (j == 6 || j == 7 | j == 8))
                {
                    for (int hi = 3; hi < 6; hi++)
                    {
                        for (int hj = 6; hj < 9; hj++)
                        {
                            if (SudokuGrid[hi, hj].AlreadySolved == false)
                            {
                                if (SudokuGrid[i, j].PossibleValues.Contains(possibleAnswer))
                                {
                                if (SudokuGrid[hi, hj].PossibleValues.Contains(possibleAnswer))
                                    {
                                        if (SudokuGrid[hi, hj].PossibleValues.Contains(possibleAnswer))
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
                        }
                    }
                } //Maison numéro 8 (x = {4,5,6} et y = {7,8,9})
                if ((i == 6 || i == 7 || i == 8) && (j == 6 || j == 7 | j == 8))
                {
                    for (int hi = 6; hi < 9; hi++)
                    {
                        for (int hj = 6; hj < 9; hj++)
                        {
                            if (SudokuGrid[hi, hj].AlreadySolved == false)
                            {
                                if (SudokuGrid[i, j].PossibleValues.Contains(possibleAnswer))
                                {
                                if (SudokuGrid[hi, hj].PossibleValues.Contains(possibleAnswer))
                                    {
                                        if (SudokuGrid[hi, hj].PossibleValues.Contains(possibleAnswer))
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
                        }
                    }
                } //Maison numéro 9 (x = {7,8,9} et y = {7,8,9})
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