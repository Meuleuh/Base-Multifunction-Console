using System;
using System.Collections.Generic;

namespace Console_multi_fonctionnelle_basique
{
    public partial class SudokuSolver
    {
        //Code d'initialisation
        public SudokuSolver()
        {
            Console.Clear();
            SudokuGridCreator(out GridValue[,] SudokuGrid);
            bool repeatQuerry = true;
            //Demander la valeur des cases déjà assignées
            do
            {
                (SudokuGrid, repeatQuerry) = SudokuQuerry(SudokuGrid, repeatQuerry);
            }
            while (repeatQuerry == true);
            SudokuDisplay(SudokuGrid);
            //Résolution du sudoku

            //Vérifier si la case a déjà une valeur. Si oui, on skip la valeur pour optimiser le calcul
            //Vérifier si la case peut avoir tel ou tel nombre et si non, utiliser un .Remove()
            //Choisir le nombre le plus approprié pour chaque case si possible (Si une seule valeur est possible, ou si c'est la seule case pouvant contenir une telle valeur dans la rangée / colonne / carré (3x3)
            //Recommencer

            //Terminer le programme après l'appui de l'usager
            Console.ReadKey();
        }
    } //Version Pre-Release
}