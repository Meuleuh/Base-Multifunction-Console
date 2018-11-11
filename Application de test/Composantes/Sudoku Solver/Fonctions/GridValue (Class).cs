using System;
using System.Collections.Generic;

namespace Console_multi_fonctionnelle_basique
{
    public partial class SudokuSolver
    {
        //Stocker toutes les variables nécessaires à chaque case
        private class GridValue
        {
            public List<int> PossibleValues = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            public bool AlreadySolved { get; set; } = false;
            public int Value { get; set; } = 0;
        }
    }
}