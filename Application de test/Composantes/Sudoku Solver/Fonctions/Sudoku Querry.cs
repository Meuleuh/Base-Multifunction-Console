using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_multi_fonctionnelle_basique
{
    public partial class SudokuSolver
    {
        (GridValue[,], bool) SudokuQuerry(GridValue[,] SudokuGrid, bool repeatQuerry)
        {
            SudokuDisplay(SudokuGrid);
            bool exception = false;
            Console.WriteLine("Entrez des valeurs à afficher dans la grille ou écrivez 'Terminé' lorsque vous avez fini");
            Console.WriteLine("Exemple d'écriture des nombres: 1,1,3 pour écrire le nombre 3 dans la case 1 : 1");
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "terminé")
            {
                Console.Clear();
                return (SudokuGrid, false);
            }
            else
            {
                try
                {
                    char x = userInput[0];
                    char y = userInput[2];
                    char z = userInput[4];
                }
                catch
                {
                    exception = true;
                    Console.WriteLine("La valeur entrée n'était pas correcte (Êtes vous sûr d'avoir écrit de la façon x,y,z ?), appuyez sur une touche pour recommencer l'entrée des valeurs");
                    Console.ReadKey();
                    Console.Clear();
                    SudokuQuerry(SudokuGrid, repeatQuerry);
                }
                if (exception == false)
                {
                    char x = userInput[0];
                    char y = userInput[2];
                    char z = userInput[4];
                    //Exception si la valeur en X donne une erreur
                    try
                    {
                        int xnum = Convert.ToInt16(Char.GetNumericValue(x));
                    }
                    catch
                    {
                        exception = true;
                        Console.WriteLine("La première valeur entrée n'était pas un nombre, appuyez sur une touche pour recommencer l'entrée des valeurs");
                        Console.ReadKey();
                        Console.Clear();
                        SudokuQuerry(SudokuGrid, true);
                    }
                    //Exception si la valeur en Y donne une erreur
                    try
                    {
                        int ynum = Convert.ToInt16(Char.GetNumericValue(y));
                    }
                    catch
                    {
                        exception = true;
                        Console.WriteLine("La deuxième valeur entrée n'était pas un nombre OU la valeur entrée n'était pas correcte (Êtes vous sûr d'avoir écrit de la façon x,y,z ?), appuyez sur une touche pour recommencer l'entrée des valeurs");
                        Console.ReadKey();
                        Console.Clear();
                        SudokuQuerry(SudokuGrid, repeatQuerry);
                    }
                    //Exception si la valeur en Z donne une erreur
                    try
                    {
                        int znum = Convert.ToInt16(Char.GetNumericValue(z));
                    }
                    catch
                    {
                        exception = true;
                        Console.WriteLine("La troisième valeur entrée n'était pas un nombre OU la valeur entrée n'était pas correcte (Êtes vous sûr d'avoir écrit de la façon x,y,z ?), appuyez sur une touche pour recommencer l'entrée des valeurs");
                        Console.ReadKey();
                        Console.Clear();
                        SudokuQuerry(SudokuGrid, repeatQuerry);
                    }
                    //Petite condition qui peut sembler inutile mais qui m'a déjà sauvé la mise dans le passé
                    if (exception == false)
                    {
                        int xnum = Convert.ToInt16(Char.GetNumericValue(x)) - 1; //Il faut réduire de 1 car l'utilisateur sait pas que la case 1:1 équivaut à la case 0:0 dans le code
                        int ynum = Convert.ToInt16(Char.GetNumericValue(y)) - 1; //Même chose ici
                        int znum = Convert.ToInt16(Char.GetNumericValue(z));
                        SudokuGrid[xnum, ynum].Value = znum;
                        SudokuGrid[xnum, ynum].AlreadySolved = true;
                        for (int i = 1; i < 10; i++)
                        {
                            if (SudokuGrid[xnum, ynum].Value != i)
                            {

                                SudokuGrid[xnum, ynum].PossibleValues.Remove(i);
                            }
                        }
                    }
                }
                Console.Clear();
                return (SudokuGrid, true);
            }
        }
    }
}
