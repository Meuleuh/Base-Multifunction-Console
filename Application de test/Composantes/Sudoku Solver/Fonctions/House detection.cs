using System;
using System.Collections.Generic;

namespace Console_multi_fonctionnelle_basique
{
    public partial class SudokuSolver
    {
        GridValue[,] HouseDetection(GridValue[,] SudokuGrid, int i, int j)
        {
            //Contrairement à la détection de la rangée et à la détection de la colonne, on va commencer par vérifier dans quel "maison" appartient la case
            if ((i == 0 || i == 1 || i == 2) && (j == 0 || j == 1 | j == 2))
            {
                for (int hi = 0; hi < 3; hi++)
                {
                    //On va devoir vérifier une section 2D de la matrice alors il va falloir faire des boucles pour chaque valeurs!
                    for (int hj = 0; hj < 3; hj++)
                    {
                        //Bon, on le script va être copié plusieurs fois mais on va pas utiliser une autre fonction pour économiser du code pour autant car ça servirait pas suffisament (autant niveau espace de stockage que niveau performance)
                        if (SudokuGrid[hi,hj].AlreadySolved == true)
                        {
                            if (SudokuGrid[i, j].PossibleValues.Contains(SudokuGrid[hi, hj].Value))
                            {
                                SudokuGrid[i, j].PossibleValues.Remove(SudokuGrid[hi, hj].Value); 
                            }
                        }
                    }
                }
            } //Maison numéro 1 (x = {1,2,3} et y = {1,2,3})
            if ((i == 5 || i == 4 || i == 5) && (j == 0 || j == 1 | j == 2))
            {
                for (int hi = 3; hi < 6; hi++)
                {
                    //On va devoir vérifier une section 2D de la matrice alors il va falloir faire des boucles pour chaque valeurs!
                    for (int hj = 0; hj < 3; hj++)
                    {
                        //Bon, on le script va être copié plusieurs fois mais on va pas utiliser une autre fonction pour économiser du code pour autant car ça servirait pas suffisament (autant niveau espace de stockage que niveau performance)
                        if (SudokuGrid[hi, hj].AlreadySolved == true)
                        {
                            if (SudokuGrid[i, j].PossibleValues.Contains(SudokuGrid[hi, hj].Value))
                            {
                                SudokuGrid[i, j].PossibleValues.Remove(SudokuGrid[hi, hj].Value);
                            }
                        }
                    }
                }
            } //Maison numéro 2 (x = {4,5,6} et y = {1,2,3})
            if ((i == 6 || i == 7 || i == 8) && (j == 0 || j == 1 | j == 2))
            {
                for (int hi = 6; hi < 9; hi++)
                {
                    //On va devoir vérifier une section 2D de la matrice alors il va falloir faire des boucles pour chaque valeurs!
                    for (int hj = 0; hj < 3; hj++)
                    {
                        //Bon, on le script va être copié plusieurs fois mais on va pas utiliser une autre fonction pour économiser du code pour autant car ça servirait pas suffisament (autant niveau espace de stockage que niveau performance)
                        if (SudokuGrid[hi, hj].AlreadySolved == true)
                        {
                            if (SudokuGrid[i, j].PossibleValues.Contains(SudokuGrid[hi, hj].Value))
                            {
                                SudokuGrid[i, j].PossibleValues.Remove(SudokuGrid[hi, hj].Value);
                            }
                        }
                    }
                }
            } //Maison numéro 3 (x = {7,8,9} et y = {1,2,3})
            if ((i == 0 || i == 1 || i == 2) && (j == 3 || j == 4 | j == 5))
            {
                for (int hi = 0; hi < 3; hi++)
                {
                    //On va devoir vérifier une section 2D de la matrice alors il va falloir faire des boucles pour chaque valeurs!
                    for (int hj = 3; hj < 6; hj++)
                    {
                        //Bon, on le script va être copié plusieurs fois mais on va pas utiliser une autre fonction pour économiser du code pour autant car ça servirait pas suffisament (autant niveau espace de stockage que niveau performance)
                        if (SudokuGrid[hi, hj].AlreadySolved == true)
                        {
                            if (SudokuGrid[i, j].PossibleValues.Contains(SudokuGrid[hi, hj].Value))
                            {
                                SudokuGrid[i, j].PossibleValues.Remove(SudokuGrid[hi, hj].Value);
                            }
                        }
                    }
                }
            } //Maison numéro 4 (x = {1,2,3} et y = {4,5,6})
            if ((i == 3 || i == 4 || i == 5) && (j == 3 || j == 4 | j == 5))
            {
                for (int hi = 3; hi < 6; hi++)
                {
                    //On va devoir vérifier une section 2D de la matrice alors il va falloir faire des boucles pour chaque valeurs!
                    for (int hj = 3; hj < 6; hj++)
                    {
                        //Bon, on le script va être copié plusieurs fois mais on va pas utiliser une autre fonction pour économiser du code pour autant car ça servirait pas suffisament (autant niveau espace de stockage que niveau performance)
                        if (SudokuGrid[hi, hj].AlreadySolved == true)
                        {
                            if (SudokuGrid[i, j].PossibleValues.Contains(SudokuGrid[hi, hj].Value))
                            {
                                SudokuGrid[i, j].PossibleValues.Remove(SudokuGrid[hi, hj].Value);
                            }
                        }
                    }
                }
            } //Maison numéro 5 (x = {4,5,6} et y = {4,5,6})
            if ((i == 6 || i == 7 || i == 8) && (j == 3 || j == 4 | j == 5))
            {
                for (int hi = 6; hi < 9; hi++)
                {
                    //On va devoir vérifier une section 2D de la matrice alors il va falloir faire des boucles pour chaque valeurs!
                    for (int hj = 3; hj < 6; hj++)
                    {
                        //Bon, on le script va être copié plusieurs fois mais on va pas utiliser une autre fonction pour économiser du code pour autant car ça servirait pas suffisament (autant niveau espace de stockage que niveau performance)
                        if (SudokuGrid[hi, hj].AlreadySolved == true)
                        {
                            if (SudokuGrid[i, j].PossibleValues.Contains(SudokuGrid[hi, hj].Value))
                            {
                                SudokuGrid[i, j].PossibleValues.Remove(SudokuGrid[hi, hj].Value);
                            }
                        }
                    }
                }
            } //Maison numéro 6 (x = {7,8,9} et y = {4,5,6})
            if ((i == 0 || i == 1 || i == 2) && (j == 6 || j == 7 | j == 8))
            {
                for (int hi = 0; hi < 3; hi++)
                {
                    //On va devoir vérifier une section 2D de la matrice alors il va falloir faire des boucles pour chaque valeurs!
                    for (int hj = 6; hj < 9; hj++)
                    {
                        //Bon, on le script va être copié plusieurs fois mais on va pas utiliser une autre fonction pour économiser du code pour autant car ça servirait pas suffisament (autant niveau espace de stockage que niveau performance)
                        if (SudokuGrid[hi, hj].AlreadySolved == true)
                        {
                            if (SudokuGrid[i, j].PossibleValues.Contains(SudokuGrid[hi, hj].Value))
                            {
                                SudokuGrid[i, j].PossibleValues.Remove(SudokuGrid[hi, hj].Value);
                            }
                        }
                    }
                }
            } //Maison numéro 7 (x = {1,2,3} et y = {7,8,9})
            if ((i == 3 || i == 4 || i == 5) && (j == 6 || j == 7 | j == 8))
            {
                for (int hi = 3; hi < 6; hi++)
                {
                    //On va devoir vérifier une section 2D de la matrice alors il va falloir faire des boucles pour chaque valeurs!
                    for (int hj = 6; hj < 9; hj++)
                    {
                        //Bon, on le script va être copié plusieurs fois mais on va pas utiliser une autre fonction pour économiser du code pour autant car ça servirait pas suffisament (autant niveau espace de stockage que niveau performance)
                        if (SudokuGrid[hi, hj].AlreadySolved == true)
                        {
                            if (SudokuGrid[i, j].PossibleValues.Contains(SudokuGrid[hi, hj].Value))
                            {
                                SudokuGrid[i, j].PossibleValues.Remove(SudokuGrid[hi, hj].Value);
                            }
                        }
                    }
                }
            } //Maison numéro 8 (x = {4,5,6} et y = {7,8,9})
            if ((i == 6 || i == 7 || i == 8) && (j == 6 || j == 7 | j == 8))
            {
                for (int hi = 6; hi < 9; hi++)
                {
                    //On va devoir vérifier une section 2D de la matrice alors il va falloir faire des boucles pour chaque valeurs!
                    for (int hj = 6; hj < 9; hj++)
                    {
                        //Bon, on le script va être copié plusieurs fois mais on va pas utiliser une autre fonction pour économiser du code pour autant car ça servirait pas suffisament (autant niveau espace de stockage que niveau performance)
                        if (SudokuGrid[hi, hj].AlreadySolved == true)
                        {
                            if (SudokuGrid[i, j].PossibleValues.Contains(SudokuGrid[hi, hj].Value))
                            {
                                SudokuGrid[i, j].PossibleValues.Remove(SudokuGrid[hi, hj].Value);
                            }
                        }
                    }
                }
            } //Maison numéro 9 (x = {7,8,9} et y = {7,8,9})
            return SudokuGrid;
        }
    }
}