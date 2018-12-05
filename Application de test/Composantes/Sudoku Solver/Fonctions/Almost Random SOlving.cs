using System.Collections.Generic;

namespace Console_multi_fonctionnelle_basique
{
    public partial class SudokuSolver
    {
        //Petite note: Ce code est loin d'être optimisé! À lui tout seul, il est plus gros que l'application ne l'a jamais été! Il va falloir l'optimiser!
        private GridValue[,] AlmostRandomSolving(GridValue[,] SudokuGrid)
        {
            GridValue[,] tempSudoku = SudokuGrid;
            bool solved = false;
            List<(int, int)> RemainingGridValue = new List<(int, int)>();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (SudokuGrid[i, j].AlreadySolved == false)
                    {
                        RemainingGridValue[RemainingGridValue.Count + 1] = (i, j);
                    }
                }
            }
            switch (RemainingGridValue.Count)
            {
                case 1:
                    for (int grid1 = 1; grid1 < 10; grid1++)
                    {
                        if (SudokuGrid[RemainingGridValue[1].Item1, RemainingGridValue[1].Item2].PossibleValues.Contains(grid1))
                        {
                            tempSudoku = SudokuGrid;
                            tempSudoku[RemainingGridValue[1].Item1, RemainingGridValue[1].Item2].Value = grid1;
                            //Début du script de vérification de la solution du Sudoku... Un foreach serait envisageable mais il devra tout de même être utilisé dans chaque case à chaque modification de variable!
                            bool tempSolved = true;
                            foreach ((int, int) gridPosition in RemainingGridValue)
                            {
                                if (tempSolved == true)
                                {
                                    for (int i = 1; i < 10; i++)
                                    {
                                        if (i != gridPosition.Item1)
                                        {
                                            if (tempSudoku[i, gridPosition.Item2].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                            {
                                                tempSolved = false;
                                                break;
                                            }
                                        }
                                    }
                                }
                                if (tempSolved == true)
                                {
                                    for (int j = 1; j < 10; j++)
                                    {
                                        if (j != gridPosition.Item2)
                                        {
                                            if (tempSudoku[gridPosition.Item1, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                            {
                                                tempSolved = false;
                                                break;
                                            }
                                        }
                                    }
                                }
                                if (tempSolved == true)
                                {
                                    if (gridPosition.Item1 >= 1 && gridPosition.Item1 <= 3 && gridPosition.Item2 >= 1 && gridPosition.Item2 <= 3)
                                    {
                                        for (int i = 1; i < 4; i++)
                                        {
                                            for (int j = 1; j < 4; j++)
                                            {
                                                if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                {
                                                    if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                    {
                                                        tempSolved = false;
                                                        break;
                                                    }
                                                }
                                            }
                                            if (tempSolved == false)
                                            {
                                                break;
                                            }
                                        }
                                    }
                                    else if (gridPosition.Item1 >= 4 && gridPosition.Item1 <= 6 && gridPosition.Item2 >= 1 && gridPosition.Item2 <= 3)
                                    {
                                        for (int i = 4; i < 7; i++)
                                        {
                                            for (int j = 1; j < 4; j++)
                                            {
                                                if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                {
                                                    if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                    {
                                                        tempSolved = false;
                                                        break;
                                                    }
                                                }
                                            }
                                            if (tempSolved == false)
                                            {
                                                break;
                                            }
                                        }
                                    }
                                    else if (gridPosition.Item1 >= 7 && gridPosition.Item1 <= 9 && gridPosition.Item2 >= 1 && gridPosition.Item2 <= 3)
                                    {
                                        for (int i = 7; i < 10; i++)
                                        {
                                            for (int j = 1; j < 4; j++)
                                            {
                                                if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                {
                                                    if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                    {
                                                        tempSolved = false;
                                                        break;
                                                    }
                                                }
                                            }
                                            if (tempSolved == false)
                                            {
                                                break;
                                            }
                                        }
                                    }
                                    else if (gridPosition.Item1 >= 1 && gridPosition.Item1 <= 3 && gridPosition.Item2 >= 4 && gridPosition.Item2 <= 6)
                                    {
                                        for (int i = 1; i < 4; i++)
                                        {
                                            for (int j = 4; j < 7; j++)
                                            {
                                                if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                {
                                                    if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                    {
                                                        tempSolved = false;
                                                        break;
                                                    }
                                                }
                                            }
                                            if (tempSolved == false)
                                            {
                                                break;
                                            }
                                        }
                                    }
                                    else if (gridPosition.Item1 >= 4 && gridPosition.Item1 <= 6 && gridPosition.Item2 >= 4 && gridPosition.Item2 <= 6)
                                    {
                                        for (int i = 4; i < 7; i++)
                                        {
                                            for (int j = 4; j < 7; j++)
                                            {
                                                if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                {
                                                    if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                    {
                                                        tempSolved = false;
                                                        break;
                                                    }
                                                }
                                            }
                                            if (tempSolved == false)
                                            {
                                                break;
                                            }
                                        }
                                    }
                                    else if (gridPosition.Item1 >= 7 && gridPosition.Item1 <= 9 && gridPosition.Item2 >= 4 && gridPosition.Item2 <= 6)
                                    {
                                        for (int i = 7; i < 10; i++)
                                        {
                                            for (int j = 4; j < 7; j++)
                                            {
                                                if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                {
                                                    if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                    {
                                                        tempSolved = false;
                                                        break;
                                                    }
                                                }
                                            }
                                            if (tempSolved == false)
                                            {
                                                break;
                                            }
                                        }
                                    }
                                    else if (gridPosition.Item1 >= 1 && gridPosition.Item1 <= 3 && gridPosition.Item2 >= 7 && gridPosition.Item2 <= 9)
                                    {
                                        for (int i = 1; i < 4; i++)
                                        {
                                            for (int j = 7; j < 10; j++)
                                            {
                                                if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                {
                                                    if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                    {
                                                        tempSolved = false;
                                                        break;
                                                    }
                                                }
                                            }
                                            if (tempSolved == false)
                                            {
                                                break;
                                            }
                                        }
                                    }
                                    else if (gridPosition.Item1 >= 4 && gridPosition.Item1 <= 6 && gridPosition.Item2 >= 7 && gridPosition.Item2 <= 9)
                                    {
                                        for (int i = 4; i < 7; i++)
                                        {
                                            for (int j = 7; j < 10; j++)
                                            {
                                                if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                {
                                                    if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                    {
                                                        tempSolved = false;
                                                        break;
                                                    }
                                                }
                                            }
                                            if (tempSolved == false)
                                            {
                                                break;
                                            }
                                        }
                                    }
                                    else if (gridPosition.Item1 >= 7 && gridPosition.Item1 <= 9 && gridPosition.Item2 >= 7 && gridPosition.Item2 <= 9)
                                    {
                                        for (int i = 7; i < 10; i++)
                                        {
                                            for (int j = 7; j < 10; j++)
                                            {
                                                if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                {
                                                    if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                    {
                                                        tempSolved = false;
                                                        break;
                                                    }
                                                }
                                            }
                                            if (tempSolved == false)
                                            {
                                                break;
                                            }
                                        }
                                    }
                                }
                                if (tempSolved == false)
                                {
                                    break;
                                }
                            }
                            solved = tempSolved;
                        }
                        if (solved == true)
                        {
                            SudokuGrid = tempSudoku;
                            break;
                        }
                    }
                    break;

                case 2:
                    for (int grid2 = 1; grid2 < 10; grid2++)
                    {
                        tempSudoku = SudokuGrid;
                        if (SudokuGrid[RemainingGridValue[2].Item1, RemainingGridValue[2].Item2].PossibleValues.Contains(grid2))
                        {
                            tempSudoku[RemainingGridValue[2].Item1, RemainingGridValue[2].Item2].Value = grid2;
                            for (int grid1 = 1; grid1 < 10; grid1++)
                            {
                                if (SudokuGrid[RemainingGridValue[1].Item1, RemainingGridValue[1].Item2].PossibleValues.Contains(grid1))
                                {
                                    tempSudoku = SudokuGrid;
                                    tempSudoku[RemainingGridValue[1].Item1, RemainingGridValue[1].Item2].Value = grid1;
                                    //Début du script de vérification de la solution du Sudoku... Un foreach serait envisageable mais il devra tout de même être utilisé dans chaque case à chaque modification de variable!
                                    bool tempSolved = true;
                                    foreach ((int, int) gridPosition in RemainingGridValue)
                                    {
                                        if (tempSolved == true)
                                        {
                                            for (int i = 1; i < 10; i++)
                                            {
                                                if (i != gridPosition.Item1)
                                                {
                                                    if (tempSudoku[i, gridPosition.Item2].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                    {
                                                        tempSolved = false;
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                        if (tempSolved == true)
                                        {
                                            for (int j = 1; j < 10; j++)
                                            {
                                                if (j != gridPosition.Item2)
                                                {
                                                    if (tempSudoku[gridPosition.Item1, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                    {
                                                        tempSolved = false;
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                        if (tempSolved == true)
                                        {
                                            if (gridPosition.Item1 >= 1 && gridPosition.Item1 <= 3 && gridPosition.Item2 >= 1 && gridPosition.Item2 <= 3)
                                            {
                                                for (int i = 1; i < 4; i++)
                                                {
                                                    for (int j = 1; j < 4; j++)
                                                    {
                                                        if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                        {
                                                            if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                            {
                                                                tempSolved = false;
                                                                break;
                                                            }
                                                        }
                                                    }
                                                    if (tempSolved == false)
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                            else if (gridPosition.Item1 >= 4 && gridPosition.Item1 <= 6 && gridPosition.Item2 >= 1 && gridPosition.Item2 <= 3)
                                            {
                                                for (int i = 4; i < 7; i++)
                                                {
                                                    for (int j = 1; j < 4; j++)
                                                    {
                                                        if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                        {
                                                            if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                            {
                                                                tempSolved = false;
                                                                break;
                                                            }
                                                        }
                                                    }
                                                    if (tempSolved == false)
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                            else if (gridPosition.Item1 >= 7 && gridPosition.Item1 <= 9 && gridPosition.Item2 >= 1 && gridPosition.Item2 <= 3)
                                            {
                                                for (int i = 7; i < 10; i++)
                                                {
                                                    for (int j = 1; j < 4; j++)
                                                    {
                                                        if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                        {
                                                            if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                            {
                                                                tempSolved = false;
                                                                break;
                                                            }
                                                        }
                                                    }
                                                    if (tempSolved == false)
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                            else if (gridPosition.Item1 >= 1 && gridPosition.Item1 <= 3 && gridPosition.Item2 >= 4 && gridPosition.Item2 <= 6)
                                            {
                                                for (int i = 1; i < 4; i++)
                                                {
                                                    for (int j = 4; j < 7; j++)
                                                    {
                                                        if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                        {
                                                            if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                            {
                                                                tempSolved = false;
                                                                break;
                                                            }
                                                        }
                                                    }
                                                    if (tempSolved == false)
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                            else if (gridPosition.Item1 >= 4 && gridPosition.Item1 <= 6 && gridPosition.Item2 >= 4 && gridPosition.Item2 <= 6)
                                            {
                                                for (int i = 4; i < 7; i++)
                                                {
                                                    for (int j = 4; j < 7; j++)
                                                    {
                                                        if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                        {
                                                            if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                            {
                                                                tempSolved = false;
                                                                break;
                                                            }
                                                        }
                                                    }
                                                    if (tempSolved == false)
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                            else if (gridPosition.Item1 >= 7 && gridPosition.Item1 <= 9 && gridPosition.Item2 >= 4 && gridPosition.Item2 <= 6)
                                            {
                                                for (int i = 7; i < 10; i++)
                                                {
                                                    for (int j = 4; j < 7; j++)
                                                    {
                                                        if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                        {
                                                            if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                            {
                                                                tempSolved = false;
                                                                break;
                                                            }
                                                        }
                                                    }
                                                    if (tempSolved == false)
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                            else if (gridPosition.Item1 >= 1 && gridPosition.Item1 <= 3 && gridPosition.Item2 >= 7 && gridPosition.Item2 <= 9)
                                            {
                                                for (int i = 1; i < 4; i++)
                                                {
                                                    for (int j = 7; j < 10; j++)
                                                    {
                                                        if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                        {
                                                            if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                            {
                                                                tempSolved = false;
                                                                break;
                                                            }
                                                        }
                                                    }
                                                    if (tempSolved == false)
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                            else if (gridPosition.Item1 >= 4 && gridPosition.Item1 <= 6 && gridPosition.Item2 >= 7 && gridPosition.Item2 <= 9)
                                            {
                                                for (int i = 4; i < 7; i++)
                                                {
                                                    for (int j = 7; j < 10; j++)
                                                    {
                                                        if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                        {
                                                            if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                            {
                                                                tempSolved = false;
                                                                break;
                                                            }
                                                        }
                                                    }
                                                    if (tempSolved == false)
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                            else if (gridPosition.Item1 >= 7 && gridPosition.Item1 <= 9 && gridPosition.Item2 >= 7 && gridPosition.Item2 <= 9)
                                            {
                                                for (int i = 7; i < 10; i++)
                                                {
                                                    for (int j = 7; j < 10; j++)
                                                    {
                                                        if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                        {
                                                            if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                            {
                                                                tempSolved = false;
                                                                break;
                                                            }
                                                        }
                                                    }
                                                    if (tempSolved == false)
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                        if (tempSolved == false)
                                        {
                                            break;
                                        }
                                    }
                                    solved = tempSolved;
                                }
                                if (solved == true)
                                {
                                    SudokuGrid = tempSudoku;
                                    break;
                                }
                            }
                        }
                        if (solved == true)
                        {
                            break;
                        }
                    }
                    break;

                case 3:
                    for (int grid3 = 1; grid3 < 10; grid3++)
                    {
                        if (SudokuGrid[RemainingGridValue[3].Item1, RemainingGridValue[3].Item2].PossibleValues.Contains(grid3))
                        {
                            tempSudoku = SudokuGrid;
                            tempSudoku[RemainingGridValue[3].Item1, RemainingGridValue[3].Item2].Value = grid3;
                            for (int grid2 = 1; grid2 < 10; grid2++)
                            {
                                if (SudokuGrid[RemainingGridValue[2].Item1, RemainingGridValue[2].Item2].PossibleValues.Contains(grid2))
                                {
                                    tempSudoku = SudokuGrid;
                                    tempSudoku[RemainingGridValue[2].Item1, RemainingGridValue[2].Item2].Value = grid2;
                                    for (int grid1 = 1; grid1 < 10; grid1++)
                                    {
                                        if (SudokuGrid[RemainingGridValue[1].Item1, RemainingGridValue[1].Item2].PossibleValues.Contains(grid1))
                                        {
                                            tempSudoku = SudokuGrid;
                                            tempSudoku[RemainingGridValue[1].Item1, RemainingGridValue[1].Item2].Value = grid1;
                                            //Début du script de vérification de la solution du Sudoku... Un foreach serait envisageable mais il devra tout de même être utilisé dans chaque case à chaque modification de variable!
                                            bool tempSolved = true;
                                            foreach ((int, int) gridPosition in RemainingGridValue)
                                            {
                                                if (tempSolved == true)
                                                {
                                                    for (int i = 1; i < 10; i++)
                                                    {
                                                        if (i != gridPosition.Item1)
                                                        {
                                                            if (tempSudoku[i, gridPosition.Item2].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                            {
                                                                tempSolved = false;
                                                                break;
                                                            }
                                                        }
                                                    }
                                                }
                                                if (tempSolved == true)
                                                {
                                                    for (int j = 1; j < 10; j++)
                                                    {
                                                        if (j != gridPosition.Item2)
                                                        {
                                                            if (tempSudoku[gridPosition.Item1, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                            {
                                                                tempSolved = false;
                                                                break;
                                                            }
                                                        }
                                                    }
                                                }
                                                if (tempSolved == true)
                                                {
                                                    if (gridPosition.Item1 >= 1 && gridPosition.Item1 <= 3 && gridPosition.Item2 >= 1 && gridPosition.Item2 <= 3)
                                                    {
                                                        for (int i = 1; i < 4; i++)
                                                        {
                                                            for (int j = 1; j < 4; j++)
                                                            {
                                                                if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                                {
                                                                    if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                                    {
                                                                        tempSolved = false;
                                                                        break;
                                                                    }
                                                                }
                                                            }
                                                            if (tempSolved == false)
                                                            {
                                                                break;
                                                            }
                                                        }
                                                    }
                                                    else if (gridPosition.Item1 >= 4 && gridPosition.Item1 <= 6 && gridPosition.Item2 >= 1 && gridPosition.Item2 <= 3)
                                                    {
                                                        for (int i = 4; i < 7; i++)
                                                        {
                                                            for (int j = 1; j < 4; j++)
                                                            {
                                                                if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                                {
                                                                    if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                                    {
                                                                        tempSolved = false;
                                                                        break;
                                                                    }
                                                                }
                                                            }
                                                            if (tempSolved == false)
                                                            {
                                                                break;
                                                            }
                                                        }
                                                    }
                                                    else if (gridPosition.Item1 >= 7 && gridPosition.Item1 <= 9 && gridPosition.Item2 >= 1 && gridPosition.Item2 <= 3)
                                                    {
                                                        for (int i = 7; i < 10; i++)
                                                        {
                                                            for (int j = 1; j < 4; j++)
                                                            {
                                                                if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                                {
                                                                    if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                                    {
                                                                        tempSolved = false;
                                                                        break;
                                                                    }
                                                                }
                                                            }
                                                            if (tempSolved == false)
                                                            {
                                                                break;
                                                            }
                                                        }
                                                    }
                                                    else if (gridPosition.Item1 >= 1 && gridPosition.Item1 <= 3 && gridPosition.Item2 >= 4 && gridPosition.Item2 <= 6)
                                                    {
                                                        for (int i = 1; i < 4; i++)
                                                        {
                                                            for (int j = 4; j < 7; j++)
                                                            {
                                                                if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                                {
                                                                    if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                                    {
                                                                        tempSolved = false;
                                                                        break;
                                                                    }
                                                                }
                                                            }
                                                            if (tempSolved == false)
                                                            {
                                                                break;
                                                            }
                                                        }
                                                    }
                                                    else if (gridPosition.Item1 >= 4 && gridPosition.Item1 <= 6 && gridPosition.Item2 >= 4 && gridPosition.Item2 <= 6)
                                                    {
                                                        for (int i = 4; i < 7; i++)
                                                        {
                                                            for (int j = 4; j < 7; j++)
                                                            {
                                                                if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                                {
                                                                    if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                                    {
                                                                        tempSolved = false;
                                                                        break;
                                                                    }
                                                                }
                                                            }
                                                            if (tempSolved == false)
                                                            {
                                                                break;
                                                            }
                                                        }
                                                    }
                                                    else if (gridPosition.Item1 >= 7 && gridPosition.Item1 <= 9 && gridPosition.Item2 >= 4 && gridPosition.Item2 <= 6)
                                                    {
                                                        for (int i = 7; i < 10; i++)
                                                        {
                                                            for (int j = 4; j < 7; j++)
                                                            {
                                                                if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                                {
                                                                    if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                                    {
                                                                        tempSolved = false;
                                                                        break;
                                                                    }
                                                                }
                                                            }
                                                            if (tempSolved == false)
                                                            {
                                                                break;
                                                            }
                                                        }
                                                    }
                                                    else if (gridPosition.Item1 >= 1 && gridPosition.Item1 <= 3 && gridPosition.Item2 >= 7 && gridPosition.Item2 <= 9)
                                                    {
                                                        for (int i = 1; i < 4; i++)
                                                        {
                                                            for (int j = 7; j < 10; j++)
                                                            {
                                                                if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                                {
                                                                    if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                                    {
                                                                        tempSolved = false;
                                                                        break;
                                                                    }
                                                                }
                                                            }
                                                            if (tempSolved == false)
                                                            {
                                                                break;
                                                            }
                                                        }
                                                    }
                                                    else if (gridPosition.Item1 >= 4 && gridPosition.Item1 <= 6 && gridPosition.Item2 >= 7 && gridPosition.Item2 <= 9)
                                                    {
                                                        for (int i = 4; i < 7; i++)
                                                        {
                                                            for (int j = 7; j < 10; j++)
                                                            {
                                                                if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                                {
                                                                    if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                                    {
                                                                        tempSolved = false;
                                                                        break;
                                                                    }
                                                                }
                                                            }
                                                            if (tempSolved == false)
                                                            {
                                                                break;
                                                            }
                                                        }
                                                    }
                                                    else if (gridPosition.Item1 >= 7 && gridPosition.Item1 <= 9 && gridPosition.Item2 >= 7 && gridPosition.Item2 <= 9)
                                                    {
                                                        for (int i = 7; i < 10; i++)
                                                        {
                                                            for (int j = 7; j < 10; j++)
                                                            {
                                                                if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                                {
                                                                    if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                                    {
                                                                        tempSolved = false;
                                                                        break;
                                                                    }
                                                                }
                                                            }
                                                            if (tempSolved == false)
                                                            {
                                                                break;
                                                            }
                                                        }
                                                    }
                                                }
                                                if (tempSolved == false)
                                                {
                                                    break;
                                                }
                                            }
                                            solved = tempSolved;
                                        }
                                        if (solved == true)
                                        {
                                            SudokuGrid = tempSudoku;
                                            break;
                                        }
                                    }
                                    if (solved == true)
                                    {
                                        break;
                                    }
                                }
                            }
                            if (solved == true)
                            {
                                break;
                            }
                        }
                        if (solved == true)
                        {
                            break;
                        }
                    }
                    break;

                case 4:
                    for (int grid4 = 1; grid4 < 10; grid4++)
                    {
                        if (SudokuGrid[RemainingGridValue[4].Item1, RemainingGridValue[4].Item2].PossibleValues.Contains(grid4))
                        {
                            tempSudoku = SudokuGrid;
                            tempSudoku[RemainingGridValue[4].Item1, RemainingGridValue[4].Item2].Value = grid4;
                            for (int grid3 = 1; grid3 < 10; grid3++)
                            {
                                if (SudokuGrid[RemainingGridValue[3].Item1, RemainingGridValue[3].Item2].PossibleValues.Contains(grid3))
                                {
                                    tempSudoku = SudokuGrid;
                                    tempSudoku[RemainingGridValue[3].Item1, RemainingGridValue[3].Item2].Value = grid3;
                                    for (int grid2 = 1; grid2 < 10; grid2++)
                                    {
                                        if (SudokuGrid[RemainingGridValue[2].Item1, RemainingGridValue[2].Item2].PossibleValues.Contains(grid2))
                                        {
                                            tempSudoku = SudokuGrid;
                                            tempSudoku[RemainingGridValue[2].Item1, RemainingGridValue[2].Item2].Value = grid2;
                                            for (int grid1 = 1; grid1 < 10; grid1++)
                                            {
                                                if (SudokuGrid[RemainingGridValue[1].Item1, RemainingGridValue[1].Item2].PossibleValues.Contains(grid1))
                                                {
                                                    tempSudoku = SudokuGrid;
                                                    tempSudoku[RemainingGridValue[1].Item1, RemainingGridValue[1].Item2].Value = grid1;
                                                    //Début du script de vérification de la solution du Sudoku... Un foreach serait envisageable mais il devra tout de même être utilisé dans chaque case à chaque modification de variable!
                                                    bool tempSolved = true;
                                                    foreach ((int, int) gridPosition in RemainingGridValue)
                                                    {
                                                        if (tempSolved == true)
                                                        {
                                                            for (int i = 1; i < 10; i++)
                                                            {
                                                                if (i != gridPosition.Item1)
                                                                {
                                                                    if (tempSudoku[i, gridPosition.Item2].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                                    {
                                                                        tempSolved = false;
                                                                        break;
                                                                    }
                                                                }
                                                            }
                                                        }
                                                        if (tempSolved == true)
                                                        {
                                                            for (int j = 1; j < 10; j++)
                                                            {
                                                                if (j != gridPosition.Item2)
                                                                {
                                                                    if (tempSudoku[gridPosition.Item1, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                                    {
                                                                        tempSolved = false;
                                                                        break;
                                                                    }
                                                                }
                                                            }
                                                        }
                                                        if (tempSolved == true)
                                                        {
                                                            if (gridPosition.Item1 >= 1 && gridPosition.Item1 <= 3 && gridPosition.Item2 >= 1 && gridPosition.Item2 <= 3)
                                                            {
                                                                for (int i = 1; i < 4; i++)
                                                                {
                                                                    for (int j = 1; j < 4; j++)
                                                                    {
                                                                        if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                                        {
                                                                            if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                                            {
                                                                                tempSolved = false;
                                                                                break;
                                                                            }
                                                                        }
                                                                    }
                                                                    if (tempSolved == false)
                                                                    {
                                                                        break;
                                                                    }
                                                                }
                                                            }
                                                            else if (gridPosition.Item1 >= 4 && gridPosition.Item1 <= 6 && gridPosition.Item2 >= 1 && gridPosition.Item2 <= 3)
                                                            {
                                                                for (int i = 4; i < 7; i++)
                                                                {
                                                                    for (int j = 1; j < 4; j++)
                                                                    {
                                                                        if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                                        {
                                                                            if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                                            {
                                                                                tempSolved = false;
                                                                                break;
                                                                            }
                                                                        }
                                                                    }
                                                                    if (tempSolved == false)
                                                                    {
                                                                        break;
                                                                    }
                                                                }
                                                            }
                                                            else if (gridPosition.Item1 >= 7 && gridPosition.Item1 <= 9 && gridPosition.Item2 >= 1 && gridPosition.Item2 <= 3)
                                                            {
                                                                for (int i = 7; i < 10; i++)
                                                                {
                                                                    for (int j = 1; j < 4; j++)
                                                                    {
                                                                        if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                                        {
                                                                            if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                                            {
                                                                                tempSolved = false;
                                                                                break;
                                                                            }
                                                                        }
                                                                    }
                                                                    if (tempSolved == false)
                                                                    {
                                                                        break;
                                                                    }
                                                                }
                                                            }
                                                            else if (gridPosition.Item1 >= 1 && gridPosition.Item1 <= 3 && gridPosition.Item2 >= 4 && gridPosition.Item2 <= 6)
                                                            {
                                                                for (int i = 1; i < 4; i++)
                                                                {
                                                                    for (int j = 4; j < 7; j++)
                                                                    {
                                                                        if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                                        {
                                                                            if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                                            {
                                                                                tempSolved = false;
                                                                                break;
                                                                            }
                                                                        }
                                                                    }
                                                                    if (tempSolved == false)
                                                                    {
                                                                        break;
                                                                    }
                                                                }
                                                            }
                                                            else if (gridPosition.Item1 >= 4 && gridPosition.Item1 <= 6 && gridPosition.Item2 >= 4 && gridPosition.Item2 <= 6)
                                                            {
                                                                for (int i = 4; i < 7; i++)
                                                                {
                                                                    for (int j = 4; j < 7; j++)
                                                                    {
                                                                        if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                                        {
                                                                            if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                                            {
                                                                                tempSolved = false;
                                                                                break;
                                                                            }
                                                                        }
                                                                    }
                                                                    if (tempSolved == false)
                                                                    {
                                                                        break;
                                                                    }
                                                                }
                                                            }
                                                            else if (gridPosition.Item1 >= 7 && gridPosition.Item1 <= 9 && gridPosition.Item2 >= 4 && gridPosition.Item2 <= 6)
                                                            {
                                                                for (int i = 7; i < 10; i++)
                                                                {
                                                                    for (int j = 4; j < 7; j++)
                                                                    {
                                                                        if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                                        {
                                                                            if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                                            {
                                                                                tempSolved = false;
                                                                                break;
                                                                            }
                                                                        }
                                                                    }
                                                                    if (tempSolved == false)
                                                                    {
                                                                        break;
                                                                    }
                                                                }
                                                            }
                                                            else if (gridPosition.Item1 >= 1 && gridPosition.Item1 <= 3 && gridPosition.Item2 >= 7 && gridPosition.Item2 <= 9)
                                                            {
                                                                for (int i = 1; i < 4; i++)
                                                                {
                                                                    for (int j = 7; j < 10; j++)
                                                                    {
                                                                        if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                                        {
                                                                            if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                                            {
                                                                                tempSolved = false;
                                                                                break;
                                                                            }
                                                                        }
                                                                    }
                                                                    if (tempSolved == false)
                                                                    {
                                                                        break;
                                                                    }
                                                                }
                                                            }
                                                            else if (gridPosition.Item1 >= 4 && gridPosition.Item1 <= 6 && gridPosition.Item2 >= 7 && gridPosition.Item2 <= 9)
                                                            {
                                                                for (int i = 4; i < 7; i++)
                                                                {
                                                                    for (int j = 7; j < 10; j++)
                                                                    {
                                                                        if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                                        {
                                                                            if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                                            {
                                                                                tempSolved = false;
                                                                                break;
                                                                            }
                                                                        }
                                                                    }
                                                                    if (tempSolved == false)
                                                                    {
                                                                        break;
                                                                    }
                                                                }
                                                            }
                                                            else if (gridPosition.Item1 >= 7 && gridPosition.Item1 <= 9 && gridPosition.Item2 >= 7 && gridPosition.Item2 <= 9)
                                                            {
                                                                for (int i = 7; i < 10; i++)
                                                                {
                                                                    for (int j = 7; j < 10; j++)
                                                                    {
                                                                        if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                                        {
                                                                            if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                                            {
                                                                                tempSolved = false;
                                                                                break;
                                                                            }
                                                                        }
                                                                    }
                                                                    if (tempSolved == false)
                                                                    {
                                                                        break;
                                                                    }
                                                                }
                                                            }
                                                        }
                                                        if (tempSolved == false)
                                                        {
                                                            break;
                                                        }
                                                    }
                                                    solved = tempSolved;
                                                }
                                                if (solved == true)
                                                {
                                                    SudokuGrid = tempSudoku;
                                                    break;
                                                }
                                            }
                                            if (solved == true)
                                            {
                                                break;
                                            }
                                        }
                                    }
                                    if (solved == true)
                                    {
                                        break;
                                    }
                                }
                                if (solved == true)
                                {
                                    break;
                                }
                            }
                        }
                        if (solved == true)
                        {
                            break;
                        }
                    }
                    break;

                case 5:
                    for (int grid5 = 1; grid5 < 10; grid5++)
                    {
                        if (SudokuGrid[RemainingGridValue[5].Item1, RemainingGridValue[5].Item2].PossibleValues.Contains(grid5))
                        {
                            tempSudoku = SudokuGrid;
                            tempSudoku[RemainingGridValue[5].Item1, RemainingGridValue[5].Item2].Value = grid5;
                            for (int grid4 = 1; grid4 < 10; grid4++)
                            {
                                if (SudokuGrid[RemainingGridValue[4].Item1, RemainingGridValue[4].Item2].PossibleValues.Contains(grid4))
                                {
                                    tempSudoku = SudokuGrid;
                                    tempSudoku[RemainingGridValue[4].Item1, RemainingGridValue[4].Item2].Value = grid4;
                                    for (int grid3 = 1; grid3 < 10; grid3++)
                                    {
                                        if (SudokuGrid[RemainingGridValue[3].Item1, RemainingGridValue[3].Item2].PossibleValues.Contains(grid3))
                                        {
                                            tempSudoku = SudokuGrid;
                                            tempSudoku[RemainingGridValue[3].Item1, RemainingGridValue[3].Item2].Value = grid3;
                                            for (int grid2 = 1; grid2 < 10; grid2++)
                                            {
                                                if (SudokuGrid[RemainingGridValue[2].Item1, RemainingGridValue[2].Item2].PossibleValues.Contains(grid2))
                                                {
                                                    tempSudoku = SudokuGrid;
                                                    tempSudoku[RemainingGridValue[2].Item1, RemainingGridValue[2].Item2].Value = grid2;
                                                    for (int grid1 = 1; grid1 < 10; grid1++)
                                                    {
                                                        if (SudokuGrid[RemainingGridValue[1].Item1, RemainingGridValue[1].Item2].PossibleValues.Contains(grid1))
                                                        {
                                                            tempSudoku = SudokuGrid;
                                                            tempSudoku[RemainingGridValue[1].Item1, RemainingGridValue[1].Item2].Value = grid1;
                                                            //Début du script de vérification de la solution du Sudoku... Un foreach serait envisageable mais il devra tout de même être utilisé dans chaque case à chaque modification de variable!
                                                            bool tempSolved = true;
                                                            foreach ((int, int) gridPosition in RemainingGridValue)
                                                            {
                                                                if (tempSolved == true)
                                                                {
                                                                    for (int i = 1; i < 10; i++)
                                                                    {
                                                                        if (i != gridPosition.Item1)
                                                                        {
                                                                            if (tempSudoku[i, gridPosition.Item2].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                                            {
                                                                                tempSolved = false;
                                                                                break;
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                                if (tempSolved == true)
                                                                {
                                                                    for (int j = 1; j < 10; j++)
                                                                    {
                                                                        if (j != gridPosition.Item2)
                                                                        {
                                                                            if (tempSudoku[gridPosition.Item1, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                                            {
                                                                                tempSolved = false;
                                                                                break;
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                                if (tempSolved == true)
                                                                {
                                                                    if (gridPosition.Item1 >= 1 && gridPosition.Item1 <= 3 && gridPosition.Item2 >= 1 && gridPosition.Item2 <= 3)
                                                                    {
                                                                        for (int i = 1; i < 4; i++)
                                                                        {
                                                                            for (int j = 1; j < 4; j++)
                                                                            {
                                                                                if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                                                {
                                                                                    if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                                                    {
                                                                                        tempSolved = false;
                                                                                        break;
                                                                                    }
                                                                                }
                                                                            }
                                                                            if (tempSolved == false)
                                                                            {
                                                                                break;
                                                                            }
                                                                        }
                                                                    }
                                                                    else if (gridPosition.Item1 >= 4 && gridPosition.Item1 <= 6 && gridPosition.Item2 >= 1 && gridPosition.Item2 <= 3)
                                                                    {
                                                                        for (int i = 4; i < 7; i++)
                                                                        {
                                                                            for (int j = 1; j < 4; j++)
                                                                            {
                                                                                if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                                                {
                                                                                    if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                                                    {
                                                                                        tempSolved = false;
                                                                                        break;
                                                                                    }
                                                                                }
                                                                            }
                                                                            if (tempSolved == false)
                                                                            {
                                                                                break;
                                                                            }
                                                                        }
                                                                    }
                                                                    else if (gridPosition.Item1 >= 7 && gridPosition.Item1 <= 9 && gridPosition.Item2 >= 1 && gridPosition.Item2 <= 3)
                                                                    {
                                                                        for (int i = 7; i < 10; i++)
                                                                        {
                                                                            for (int j = 1; j < 4; j++)
                                                                            {
                                                                                if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                                                {
                                                                                    if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                                                    {
                                                                                        tempSolved = false;
                                                                                        break;
                                                                                    }
                                                                                }
                                                                            }
                                                                            if (tempSolved == false)
                                                                            {
                                                                                break;
                                                                            }
                                                                        }
                                                                    }
                                                                    else if (gridPosition.Item1 >= 1 && gridPosition.Item1 <= 3 && gridPosition.Item2 >= 4 && gridPosition.Item2 <= 6)
                                                                    {
                                                                        for (int i = 1; i < 4; i++)
                                                                        {
                                                                            for (int j = 4; j < 7; j++)
                                                                            {
                                                                                if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                                                {
                                                                                    if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                                                    {
                                                                                        tempSolved = false;
                                                                                        break;
                                                                                    }
                                                                                }
                                                                            }
                                                                            if (tempSolved == false)
                                                                            {
                                                                                break;
                                                                            }
                                                                        }
                                                                    }
                                                                    else if (gridPosition.Item1 >= 4 && gridPosition.Item1 <= 6 && gridPosition.Item2 >= 4 && gridPosition.Item2 <= 6)
                                                                    {
                                                                        for (int i = 4; i < 7; i++)
                                                                        {
                                                                            for (int j = 4; j < 7; j++)
                                                                            {
                                                                                if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                                                {
                                                                                    if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                                                    {
                                                                                        tempSolved = false;
                                                                                        break;
                                                                                    }
                                                                                }
                                                                            }
                                                                            if (tempSolved == false)
                                                                            {
                                                                                break;
                                                                            }
                                                                        }
                                                                    }
                                                                    else if (gridPosition.Item1 >= 7 && gridPosition.Item1 <= 9 && gridPosition.Item2 >= 4 && gridPosition.Item2 <= 6)
                                                                    {
                                                                        for (int i = 7; i < 10; i++)
                                                                        {
                                                                            for (int j = 4; j < 7; j++)
                                                                            {
                                                                                if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                                                {
                                                                                    if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                                                    {
                                                                                        tempSolved = false;
                                                                                        break;
                                                                                    }
                                                                                }
                                                                            }
                                                                            if (tempSolved == false)
                                                                            {
                                                                                break;
                                                                            }
                                                                        }
                                                                    }
                                                                    else if (gridPosition.Item1 >= 1 && gridPosition.Item1 <= 3 && gridPosition.Item2 >= 7 && gridPosition.Item2 <= 9)
                                                                    {
                                                                        for (int i = 1; i < 4; i++)
                                                                        {
                                                                            for (int j = 7; j < 10; j++)
                                                                            {
                                                                                if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                                                {
                                                                                    if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                                                    {
                                                                                        tempSolved = false;
                                                                                        break;
                                                                                    }
                                                                                }
                                                                            }
                                                                            if (tempSolved == false)
                                                                            {
                                                                                break;
                                                                            }
                                                                        }
                                                                    }
                                                                    else if (gridPosition.Item1 >= 4 && gridPosition.Item1 <= 6 && gridPosition.Item2 >= 7 && gridPosition.Item2 <= 9)
                                                                    {
                                                                        for (int i = 4; i < 7; i++)
                                                                        {
                                                                            for (int j = 7; j < 10; j++)
                                                                            {
                                                                                if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                                                {
                                                                                    if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                                                    {
                                                                                        tempSolved = false;
                                                                                        break;
                                                                                    }
                                                                                }
                                                                            }
                                                                            if (tempSolved == false)
                                                                            {
                                                                                break;
                                                                            }
                                                                        }
                                                                    }
                                                                    else if (gridPosition.Item1 >= 7 && gridPosition.Item1 <= 9 && gridPosition.Item2 >= 7 && gridPosition.Item2 <= 9)
                                                                    {
                                                                        for (int i = 7; i < 10; i++)
                                                                        {
                                                                            for (int j = 7; j < 10; j++)
                                                                            {
                                                                                if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                                                {
                                                                                    if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                                                    {
                                                                                        tempSolved = false;
                                                                                        break;
                                                                                    }
                                                                                }
                                                                            }
                                                                            if (tempSolved == false)
                                                                            {
                                                                                break;
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                                if (tempSolved == false)
                                                                {
                                                                    break;
                                                                }
                                                            }
                                                            solved = tempSolved;
                                                        }
                                                        if (solved == true)
                                                        {
                                                            SudokuGrid = tempSudoku;
                                                            break;
                                                        }
                                                    }
                                                    if (solved == true)
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                            if (solved == true)
                                            {
                                                break;
                                            }
                                        }
                                        if (solved == true)
                                        {
                                            break;
                                        }
                                    }
                                }
                                if (solved == true)
                                {
                                    break;
                                }
                            }
                        }
                        if (solved == true)
                        {
                            break;
                        }
                    }
                    break;

                case 6:
                    for (int grid6 = 1; grid6 < 10; grid6++)
                    {
                        if (SudokuGrid[RemainingGridValue[6].Item1, RemainingGridValue[6].Item2].PossibleValues.Contains(grid6))
                        {
                            tempSudoku = SudokuGrid;
                            tempSudoku[RemainingGridValue[6].Item1, RemainingGridValue[6].Item2].Value = grid6;
                            for (int grid5 = 1; grid5 < 10; grid5++)
                            {
                                if (SudokuGrid[RemainingGridValue[5].Item1, RemainingGridValue[5].Item2].PossibleValues.Contains(grid5))
                                {
                                    tempSudoku = SudokuGrid;
                                    tempSudoku[RemainingGridValue[5].Item1, RemainingGridValue[5].Item2].Value = grid5;
                                    for (int grid4 = 1; grid4 < 10; grid4++)
                                    {
                                        if (SudokuGrid[RemainingGridValue[4].Item1, RemainingGridValue[4].Item2].PossibleValues.Contains(grid4))
                                        {
                                            tempSudoku = SudokuGrid;
                                            tempSudoku[RemainingGridValue[4].Item1, RemainingGridValue[4].Item2].Value = grid4;
                                            for (int grid3 = 1; grid3 < 10; grid3++)
                                            {
                                                if (SudokuGrid[RemainingGridValue[3].Item1, RemainingGridValue[3].Item2].PossibleValues.Contains(grid3))
                                                {
                                                    tempSudoku = SudokuGrid;
                                                    tempSudoku[RemainingGridValue[3].Item1, RemainingGridValue[3].Item2].Value = grid3;
                                                    for (int grid2 = 1; grid2 < 10; grid2++)
                                                    {
                                                        if (SudokuGrid[RemainingGridValue[2].Item1, RemainingGridValue[2].Item2].PossibleValues.Contains(grid2))
                                                        {
                                                            tempSudoku = SudokuGrid;
                                                            tempSudoku[RemainingGridValue[2].Item1, RemainingGridValue[2].Item2].Value = grid2;
                                                            for (int grid1 = 1; grid1 < 10; grid1++)
                                                            {
                                                                if (SudokuGrid[RemainingGridValue[1].Item1, RemainingGridValue[1].Item2].PossibleValues.Contains(grid1))
                                                                {
                                                                    tempSudoku = SudokuGrid;
                                                                    tempSudoku[RemainingGridValue[1].Item1, RemainingGridValue[1].Item2].Value = grid1;
                                                                    //Début du script de vérification de la solution du Sudoku... Un foreach serait envisageable mais il devra tout de même être utilisé dans chaque case à chaque modification de variable!
                                                                    bool tempSolved = true;
                                                                    foreach ((int, int) gridPosition in RemainingGridValue)
                                                                    {
                                                                        if (tempSolved == true)
                                                                        {
                                                                            for (int i = 1; i < 10; i++)
                                                                            {
                                                                                if (i != gridPosition.Item1)
                                                                                {
                                                                                    if (tempSudoku[i, gridPosition.Item2].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                                                    {
                                                                                        tempSolved = false;
                                                                                        break;
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                        if (tempSolved == true)
                                                                        {
                                                                            for (int j = 1; j < 10; j++)
                                                                            {
                                                                                if (j != gridPosition.Item2)
                                                                                {
                                                                                    if (tempSudoku[gridPosition.Item1, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                                                    {
                                                                                        tempSolved = false;
                                                                                        break;
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                        if (tempSolved == true)
                                                                        {
                                                                            if (gridPosition.Item1 >= 1 && gridPosition.Item1 <= 3 && gridPosition.Item2 >= 1 && gridPosition.Item2 <= 3)
                                                                            {
                                                                                for (int i = 1; i < 4; i++)
                                                                                {
                                                                                    for (int j = 1; j < 4; j++)
                                                                                    {
                                                                                        if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                                                        {
                                                                                            if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                                                            {
                                                                                                tempSolved = false;
                                                                                                break;
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                    if (tempSolved == false)
                                                                                    {
                                                                                        break;
                                                                                    }
                                                                                }
                                                                            }
                                                                            else if (gridPosition.Item1 >= 4 && gridPosition.Item1 <= 6 && gridPosition.Item2 >= 1 && gridPosition.Item2 <= 3)
                                                                            {
                                                                                for (int i = 4; i < 7; i++)
                                                                                {
                                                                                    for (int j = 1; j < 4; j++)
                                                                                    {
                                                                                        if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                                                        {
                                                                                            if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                                                            {
                                                                                                tempSolved = false;
                                                                                                break;
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                    if (tempSolved == false)
                                                                                    {
                                                                                        break;
                                                                                    }
                                                                                }
                                                                            }
                                                                            else if (gridPosition.Item1 >= 7 && gridPosition.Item1 <= 9 && gridPosition.Item2 >= 1 && gridPosition.Item2 <= 3)
                                                                            {
                                                                                for (int i = 7; i < 10; i++)
                                                                                {
                                                                                    for (int j = 1; j < 4; j++)
                                                                                    {
                                                                                        if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                                                        {
                                                                                            if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                                                            {
                                                                                                tempSolved = false;
                                                                                                break;
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                    if (tempSolved == false)
                                                                                    {
                                                                                        break;
                                                                                    }
                                                                                }
                                                                            }
                                                                            else if (gridPosition.Item1 >= 1 && gridPosition.Item1 <= 3 && gridPosition.Item2 >= 4 && gridPosition.Item2 <= 6)
                                                                            {
                                                                                for (int i = 1; i < 4; i++)
                                                                                {
                                                                                    for (int j = 4; j < 7; j++)
                                                                                    {
                                                                                        if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                                                        {
                                                                                            if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                                                            {
                                                                                                tempSolved = false;
                                                                                                break;
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                    if (tempSolved == false)
                                                                                    {
                                                                                        break;
                                                                                    }
                                                                                }
                                                                            }
                                                                            else if (gridPosition.Item1 >= 4 && gridPosition.Item1 <= 6 && gridPosition.Item2 >= 4 && gridPosition.Item2 <= 6)
                                                                            {
                                                                                for (int i = 4; i < 7; i++)
                                                                                {
                                                                                    for (int j = 4; j < 7; j++)
                                                                                    {
                                                                                        if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                                                        {
                                                                                            if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                                                            {
                                                                                                tempSolved = false;
                                                                                                break;
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                    if (tempSolved == false)
                                                                                    {
                                                                                        break;
                                                                                    }
                                                                                }
                                                                            }
                                                                            else if (gridPosition.Item1 >= 7 && gridPosition.Item1 <= 9 && gridPosition.Item2 >= 4 && gridPosition.Item2 <= 6)
                                                                            {
                                                                                for (int i = 7; i < 10; i++)
                                                                                {
                                                                                    for (int j = 4; j < 7; j++)
                                                                                    {
                                                                                        if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                                                        {
                                                                                            if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                                                            {
                                                                                                tempSolved = false;
                                                                                                break;
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                    if (tempSolved == false)
                                                                                    {
                                                                                        break;
                                                                                    }
                                                                                }
                                                                            }
                                                                            else if (gridPosition.Item1 >= 1 && gridPosition.Item1 <= 3 && gridPosition.Item2 >= 7 && gridPosition.Item2 <= 9)
                                                                            {
                                                                                for (int i = 1; i < 4; i++)
                                                                                {
                                                                                    for (int j = 7; j < 10; j++)
                                                                                    {
                                                                                        if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                                                        {
                                                                                            if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                                                            {
                                                                                                tempSolved = false;
                                                                                                break;
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                    if (tempSolved == false)
                                                                                    {
                                                                                        break;
                                                                                    }
                                                                                }
                                                                            }
                                                                            else if (gridPosition.Item1 >= 4 && gridPosition.Item1 <= 6 && gridPosition.Item2 >= 7 && gridPosition.Item2 <= 9)
                                                                            {
                                                                                for (int i = 4; i < 7; i++)
                                                                                {
                                                                                    for (int j = 7; j < 10; j++)
                                                                                    {
                                                                                        if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                                                        {
                                                                                            if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                                                            {
                                                                                                tempSolved = false;
                                                                                                break;
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                    if (tempSolved == false)
                                                                                    {
                                                                                        break;
                                                                                    }
                                                                                }
                                                                            }
                                                                            else if (gridPosition.Item1 >= 7 && gridPosition.Item1 <= 9 && gridPosition.Item2 >= 7 && gridPosition.Item2 <= 9)
                                                                            {
                                                                                for (int i = 7; i < 10; i++)
                                                                                {
                                                                                    for (int j = 7; j < 10; j++)
                                                                                    {
                                                                                        if (i != gridPosition.Item1 && j != gridPosition.Item2)
                                                                                        {
                                                                                            if (tempSudoku[i, j].Value == tempSudoku[gridPosition.Item1, gridPosition.Item2].Value)
                                                                                            {
                                                                                                tempSolved = false;
                                                                                                break;
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                    if (tempSolved == false)
                                                                                    {
                                                                                        break;
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                        if (tempSolved == false)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                    solved = tempSolved;
                                                                }
                                                                if (solved == true)
                                                                {
                                                                    SudokuGrid = tempSudoku;
                                                                    break;
                                                                }
                                                            }
                                                            if (solved == true)
                                                            {
                                                                break;
                                                            }
                                                        }
                                                    }
                                                    if (solved == true)
                                                    {
                                                        break;
                                                    }
                                                }
                                                if (solved == true)
                                                {
                                                    break;
                                                }
                                            }
                                        }
                                        if (solved == true)
                                        {
                                            break;
                                        }
                                    }
                                }
                                if (solved == true)
                                {
                                    break;
                                }
                            }
                        }
                        if (solved == true)
                        {
                            break;
                        }
                    }
                    break;
            }

            /*
             * UneasySolvingAid(SudokuGrid, RemainingGridValue, RemainingGridValue.Count());
             * Il va falloir que je crée un code qui va être appelé sans arrêt pour tester si,
             * en faisant passer des valeurs de 1 à 9 dans chaque grille (excluant les chiffres
             * ne pouvant pas être placés dans cette case) et ce, en commençant par la première,
             * puis la seconde, puis celle d'après, etc... Si le simple fichier contenant ce code
             * n'existe pas encore lui non plus, ce n'est pas dû à un manque de temps, mais plutôt
             * à un manque d'idée sur comment le faire... Il est même possible que ce code-ci soit
             * entièrement retravaillé et que ce second script ne voit jamais le jour... À voir!
             *
             * Nouvelle piste d'idée envisageable: Peut-être faire un script dans la classe
             * GridValue... je sais plus...! C'est dur en vrai de résoudre les sudoku qui
             * auront besoin de ce script là en vrai, c'est encore plus dur de faire un script
             * pour le faire à notre place!
             *
             * (Rajouté durant le développement) Le script sera hyper complexe car il devra revérifier
             * si le sudoku est résolu mais pour toutes les cases! Du coup, la verification qui est déjà
             * complexe juste pour une case devra être répètée pour chaque case! (Si la vérification est
             * aussi complexe, c'est puisqu'il est impossible d'utiliser l'ancienne méthode qui consistait
             * juste à vérifier si chaque case avait une valeur d'attribuée, car une valeur potentielle sera
             * attribuée à chaque case restante, ce qui activerait cette condition même si le sudoku est
             * invalide...)
             */
            return SudokuGrid;
        }
    }
}