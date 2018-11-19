using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_multi_fonctionnelle_basique
{
    public partial class SudokuSolver
    {
        GridValue[,] UneasySolving(GridValue[,] SudokuGrid)
        {
            List<int> RemainingGridValue = new List<int>();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (SudokuGrid[i,j].AlreadySolved == false)
                    {
                        RemainingGridValue.Add((i*10)+j);
                    }
                }
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
             */
            return SudokuGrid;
        }
    }
}
