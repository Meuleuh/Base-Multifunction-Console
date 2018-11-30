using System;
using System.Collections.Generic;

namespace Console_multi_fonctionnelle_basique
{
    public partial class SudokuSolver
    {
        //Code d'initialisation
        public SudokuSolver()
        {
            Console.Title = "Sudoku Solver";
            Console.Clear();
            SudokuGridCreator(out GridValue[,] SudokuGrid);
            bool repeatQuerry = true;
            bool solved = false;
            int iteration = 0;
            //Demander la valeur des cases déjà assignées
            do
            {
                (SudokuGrid, repeatQuerry) = SudokuQuerry(SudokuGrid, repeatQuerry);
            }
            while (repeatQuerry == true);
            SudokuDisplay(SudokuGrid);
            //Résolution du sudoku
            GridValue[,] tempSudokuGrid = new GridValue[9, 9];
            do
            {
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        //Vérifier si la case a déjà une valeur. Si oui, on skip la valeur pour optimiser le calcul
                        if (SudokuGrid[i, j].AlreadySolved == false)
                        {
                            //Vérifier si la case peut avoir tel ou tel nombre et si non, utiliser un .Remove()
                            SudokuGrid = RowDetection(SudokuGrid, i, j);
                            SudokuGrid = ColumnDetection(SudokuGrid, i, j);
                            SudokuGrid = HouseDetection(SudokuGrid, i, j);
                            SudokuGrid = ObviousSolving(SudokuGrid, i, j);
                            if (SudokuGrid[i, j].AlreadySolved == true)
                            {
                                Console.Clear();
                                SudokuDisplay(SudokuGrid);
                            }
                        }
                    }
                }
                bool breakThrough = false;
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (SudokuGrid[i, j].AlreadySolved == false)
                        {
                            SudokuGrid = RowSolving(SudokuGrid, i, j);
                        }
                        if (SudokuGrid[i, j].AlreadySolved == false)
                        {
                            SudokuGrid = ColumnSolving(SudokuGrid, i, j);
                        }
                        if (SudokuGrid[i, j].AlreadySolved == false)
                        {
                            SudokuGrid = HouseSolving(SudokuGrid, i, j);
                        }
                        if (SudokuGrid[i,j].AlreadySolved == true)
                        {
                            breakThrough = true;
                        }
                        if (breakThrough == true)
                        {
                            break;
                        }
                    }
                    if (breakThrough == true)
                    {
                        break;
                    }
                }
                bool tempSolved = true;
                for (int tempI = 0; tempI < 9; tempI++)
                {
                    for (int tempJ = 0; tempJ < 9; tempJ++)
                    {
                        if (SudokuGrid [tempI,tempJ].AlreadySolved == false)
                        {
                            tempSolved = false;
                            break;
                        }
                    }
                    if (tempSolved == false)
                    {
                        break;
                    }
                }
                solved = tempSolved;
                if (tempSudokuGrid == SudokuGrid)
                {
                    AlmostRandomSolving(SudokuGrid);
                }
                else
                {
                    tempSudokuGrid = SudokuGrid;
                }

                if (iteration > 1000)
                {
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                iteration++;
            }
            while (solved == false);
            //Choisir le nombre le plus approprié pour chaque case si possible (Si une seule valeur est possible, ou si c'est la seule case pouvant contenir une telle valeur dans la rangée / colonne / carré (3x3)
            //Recommencer

            //Terminer le programme après l'appui de l'usager
            Console.ReadKey();
        } //Version 1.0.0
    }
}