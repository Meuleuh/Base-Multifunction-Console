using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_de_test
{
    partial class Program
    {
        /*static void Calculatrice()
        {
            void Old()
            {
                string StatutEnCours = "Debut";
                Console.Clear();
                Console.WriteLine("Voici les opérations pouvant être sélectionnées");
                FonctionsSelectionnables();
                Console.Write("Fonction voulue: ");
                string FonctionSelectionne = Console.ReadLine();
                if (FonctionSelectionne.ToLower() == "addition" || FonctionSelectionne.ToLower() == "add" || FonctionSelectionne.ToLower() == "plus")
                {
                    Addition();
                }
                else if (FonctionSelectionne.ToLower() == "soustraction" || FonctionSelectionne.ToLower() == "moins" || FonctionSelectionne.ToLower() == "minus")
                {
                    Soustraction();
                }
                else
                {
                    Console.WriteLine("Cette fonction n'existe pas dans le contexte donné");
                    Console.WriteLine("Appuyez sur une touche pour recommencer");
                    Console.ReadKey();
                    RepriseApresErreur();
                }

                //Les fonctions essentielles et universelles de la calculatrice

                (decimal, decimal) GetTwoVariable(out decimal valX, out decimal valY)
                {
                    Console.Clear();
                    Console.WriteLine("Quel est la valeur de X ?");
                    string valXTemp = Console.ReadLine();
                    try
                    {
                        decimal valXError = Convert.ToDecimal(valXTemp);
                    }
                    catch
                    {
                        ExceptionCaughtInTheVariable();
                        valXTemp = "0";
                    }
                    valX = Convert.ToDecimal(valXTemp);
                    Console.WriteLine("Quel est la valeur de Y ?");
                    string valYTemp = Console.ReadLine();
                    try
                    {
                        decimal valYError = Convert.ToDecimal(valYTemp);
                    }
                    catch
                    {
                        ExceptionCaughtInTheVariable();
                        valYTemp = "0";
                    }
                    valY = Convert.ToDecimal(valYTemp);
                    return (valX, valY);
                }

                void ExceptionCaughtInTheVariable()
                {
                    Console.WriteLine("La variable ne peut pas être autre chose qu'un nombre");
                    Console.WriteLine("Appuyez sur une touche pour recommencer la fonction en cours");
                    Console.ReadKey();
                    RepriseApresErreur();
                }
                //Fonction utile pour éviter les répétition d'un message d'erreur dans le code.
                //Il va falloir que l'on rajoutes le fait de recommencer la fonction en cours au lieu de recommencer la calculatrice

                void FonctionsSelectionnables()
                {
                    Console.WriteLine("- Addition");
                    Console.WriteLine("- Soustraction");
                } //Fonction pour écrire toutes les fonctions sélectionnables

                void RepriseApresErreur()
                {
                    if (StatutEnCours == "Addition")
                    {
                        Addition();
                    }
                    else if (StatutEnCours == "Soustraction")
                    {
                        Soustraction();
                    }
                }

                //Les fonctions de la calculatrice

                void Addition()
                {
                    StatutEnCours = "Addition";
                    GetTwoVariable(out decimal valX, out decimal valY);
                    Console.Clear();
                    Console.WriteLine("Valeur de X: " + valX);
                    Console.WriteLine("Valeur de Y: " + valY);
                    Console.WriteLine("Somme (X + Y): " + (valX + valY));
                    Console.WriteLine("Appuyez sur une touche pour fermer la console");
                    Console.ReadKey();
                    Environment.Exit(0); //À remplacer lorsque la mémoire sera mise en place ou que l'on voudra que la calculatrice ne se ferme pas après l'exécution
                }

                void Soustraction()
                {
                    StatutEnCours = "Soustraction";
                    GetTwoVariable(out decimal valX, out decimal valY);
                    Console.Clear();
                    Console.WriteLine("Valeur de X: " + valX);
                    Console.WriteLine("Valeur de Y: " + valY);
                    Console.WriteLine("Différence (X - Y): " + (valX - valY));
                    Console.WriteLine("Appuyez sur une touche pour fermer la console");
                    Console.ReadKey();
                    Environment.Exit(0); //À remplacer lorsque la mémoire sera mise en place ou que l'on voudra que la calculatrice ne se ferme pas après l'exécution
                }
            }
        } //Version 1.1.1 */
        public class Calculatrice
        {
            public Calculatrice()
            {
                Console.Clear();
                Console.WriteLine("Liste des opérations mathématiques");
                //Console.WriteLine("- Addition");
                //Console.WriteLine("- Soustraction");
                //Console.WriteLine("- Multiplication");
                //Console.WriteLine("- Division");
                //Console.WriteLine("- Exponentielle");
                //Console.WriteLine("- Racine");
                Console.WriteLine("");
                Console.Write("Opération voulue: ");
                string OperationVoulue = Console.ReadLine();
                try
                {
                string VerifSelectionOperation;
                VerifSelectionOperation = OperationVoulue.ToLower();
                }
                catch
                {
                    //Insérez ici une réponse au code d'erreur qui fait redémarrer la calculatrice
                }
                decimal reponse = 0;
                if (OperationVoulue.ToLower() == "addition")
                {
                    Addition(out reponse);
                }
                else if (OperationVoulue.ToLower() == "soustraction")
                {
                    Soustraction(out reponse);
                }
                else if (OperationVoulue.ToLower() == "multiplication")
                {
                    Multiplication(out reponse);
                }
                else if (OperationVoulue.ToLower() == "division")
                {
                    Division(out reponse);
                }
                else if (OperationVoulue.ToLower() == "exponentielle")
                {
                    Exponentielle(out reponse);
                }
                else if (OperationVoulue.ToLower() == "racine")
                {
                    Racine(out reponse);
                }
                else
                {
                    Console.WriteLine("La fonction demandée n'existe pas.");
                    Console.WriteLine("Appuyez sur une touche pour ré-écrire le nom de l'opération voulue");
                    Console.ReadKey();
                    Calculatrice calculatrice = new Calculatrice();
                }
                Console.WriteLine("Réponse: " + reponse);
                Console.WriteLine();
                Console.WriteLine("Appuyez sur une touche pour fermer la calculatrice...");
                Console.ReadKey();
            }

            //Opérations générales

            //Ici

            //Opérations mathématiques

            decimal Addition(out decimal reponse)
            {
                reponse = 0;
                return reponse;
            }

            decimal Soustraction(out decimal reponse)
            {
                reponse = 0;
                return reponse;
            }

            decimal Multiplication(out decimal reponse)
            {
                reponse = 0;
                return reponse;
            }

            decimal Division(out decimal reponse)
            {
                reponse = 0;
                return reponse;
            }

            decimal Exponentielle(out decimal reponse)
            {
                reponse = 0;
                return reponse;
            }

            decimal Racine(out decimal reponse)
            {
                reponse = 0;
                return reponse;
            }
        }
    }
}
