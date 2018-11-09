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
            SudokuDisplay(SudokuGrid);

            //Terminer le programme après l'appui de l'usager
            Console.ReadKey();
        }

        //Demander la valeur des cases déjà assignées
        //Vérifier si la case peut avoir tel ou tel nombre et si non, utiliser un .Remove()
        //Choisir le nombre le plus approprié pour chaque case
    }
}