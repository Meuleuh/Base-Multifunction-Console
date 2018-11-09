using System;
using System.Collections.Generic;

namespace Console_multi_fonctionnelle_basique
{
    public partial class SudokuSolver
    {
        //Stocker toutes les variables nécessaires à chaque case
        private class GridValue
        {
            /*
            public bool CanBe1 { get; set; } = false;
            public bool CanBe2 { get; set; } = false;
            public bool CanBe3 { get; set; } = false;
            public bool CanBe4 { get; set; } = false;
            public bool CanBe5 { get; set; } = false;
            public bool CanBe6 { get; set; } = false;
            public bool CanBe7 { get; set; } = false;
            public bool CanBe8 { get; set; } = false;
            public bool CanBe9 { get; set; } = false;
            */
            public List<int> PossibleValues = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            public bool AlreadySolved { get; set; } = false;
            public int Value { get; set; } = 0;
        }
    }
}