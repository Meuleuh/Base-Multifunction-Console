using System;

namespace Console_multi_fonctionnelle_basique
{
    public class Calculatrice
    {
        public Calculatrice()
        {
            Console.Title = "Calculatrice";
            Console.Clear();
            Console.WriteLine("Liste des opérations mathématiques");
            Console.WriteLine("- Addition (X + Y)");
            Console.WriteLine("- Soustraction (X - Y)");
            Console.WriteLine("- Multiplication (X × Y)");
            Console.WriteLine("- Division (X ÷ Y)");
            Console.WriteLine("- Exponentielle (X ^ Y)");
            Console.WriteLine("- Racine (X ^ (1/Y))");
            Console.WriteLine();
            Console.Write("Opération voulue: ");
            string OperationVoulue = Console.ReadLine();
            try
            {
                string VerifSelectionOperation;
                VerifSelectionOperation = OperationVoulue.ToLower();
            }
            catch
            {
                Console.WriteLine("La valeur donnée est invalide et a retourné une erreur. Appuyer sur une touche pour redémarrer la calculatrice...");
                Calculatrice calculatrice = new Calculatrice();
            }
            decimal reponse = 0;
            if (OperationVoulue.ToLower() == "addition" || OperationVoulue.ToLower() == "add" || OperationVoulue.ToLower() == "plus")
            {
                Addition(out reponse);
            }
            else if (OperationVoulue.ToLower() == "soustraction" || OperationVoulue.ToLower() == "minus" || OperationVoulue.ToLower() == "moins" || OperationVoulue.ToLower() == "substract")
            {
                Soustraction(out reponse);
            }
            else if (OperationVoulue.ToLower() == "multiplication" || OperationVoulue.ToLower() == "multiply")
            {
                Multiplication(out reponse);
            }
            else if (OperationVoulue.ToLower() == "division" || OperationVoulue.ToLower() == "divide")
            {
                Division(out reponse);
            }
            else if (OperationVoulue.ToLower() == "exponentielle" || OperationVoulue.ToLower() == "exponent")
            {
                Exponentielle(out reponse);
            }
            else if (OperationVoulue.ToLower() == "racine" || OperationVoulue.ToLower() == "root")
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
            Console.Title = "Calculatrice";
            Console.WriteLine("Réponse: " + reponse);
            Console.WriteLine();
            Console.WriteLine("Appuyez sur une touche pour fermer la calculatrice...");
            Console.ReadKey();
            Environment.Exit(0);
        }

        private decimal Addition(out decimal reponse)
        {
            Console.Title = "Calcultrice.Addition";
            ObtentionDesVariables(2, out decimal valX, out decimal valY, out _);
            reponse = (valX + valY);
            Console.Clear();
            Console.WriteLine(valX + " + " + valY);
            Console.WriteLine();
            return reponse;
        }

        private decimal Division(out decimal reponse)
        {
            Console.Title = "Calcultrice.Division";
            ObtentionDesVariables(2, out decimal valX, out decimal valY, out _);
            reponse = (valX / valY);
            Console.Clear();
            Console.WriteLine(valX + " ÷ " + valY);
            Console.WriteLine();
            return reponse;
        }

        private decimal Exponentielle(out decimal reponse)
        {
            Console.Title = "Calcultrice.Exponentielle";
            ObtentionDesVariables(2, out decimal valX, out decimal valY, out _);
            reponse = Convert.ToDecimal(Math.Pow(Convert.ToDouble(valX), Convert.ToDouble(valY)));
            Console.Clear();
            Console.WriteLine(Convert.ToDouble(valX) + " ^ " + Convert.ToDouble(valY));
            Console.WriteLine();
            return reponse;
        }

        private decimal Multiplication(out decimal reponse)
        {
            Console.Title = "Calcultrice.Multiplication";
            ObtentionDesVariables(2, out decimal valX, out decimal valY, out _);
            reponse = (valX * valY);
            Console.Clear();
            Console.WriteLine(valX + " × " + valY);
            Console.WriteLine();
            return reponse;
        }

        private (decimal, decimal, decimal) ObtentionDesVariables(int nbVal, out decimal valX, out decimal valY, out decimal valZ)
        {
            valX = 0;
            valY = 0;
            valZ = 0;
            if (nbVal == 1)
            {
                ObtentionValX(out valX);
            }
            else if (nbVal == 2)
            {
                ObtentionValX(out valX);
                ObtentionValY(out valY);
            }
            else if (nbVal == 3)
            {
                ObtentionValX(out valX);
                ObtentionValY(out valY);
                ObtentionValZ(out valZ);
            }
            else
            {
                Console.WriteLine("Une erreur s'est produite dans l'exécution de la fonction, veuillez le reporter sur le GitHub où vous avez trouver cette console pour aider le développeur à régler tout bug possible");
                Console.WriteLine("Après avoir rapporté cette erreur, appuyez sur une touche pour fermer la console...");
                Console.ReadKey();
                Environment.Exit(0);
            }
            return (valX, valY, valZ);
        }

        //Opérations générales
        private decimal ObtentionValX(out decimal valX)
        {
            bool exception = false;
            Console.Clear();
            Console.Write("Entrez la valeur de X: ");
            string valXTemp = Console.ReadLine();
            try
            {
                valX = Convert.ToDecimal(valXTemp);
            }
            catch (Exception)
            {
                exception = true;
                Console.WriteLine("La valeur entrée n'est pas valide...");
                Console.WriteLine("Appuyez sur une touche pour re-entrer la valeur de X...");
                Console.ReadKey();
                ObtentionValX(out valX);
            }
            if (exception == false)
            {
                valX = Convert.ToDecimal(valXTemp);
                return (valX);
            }
            else
            {
                return (0);
            }
        }

        private decimal ObtentionValY(out decimal valY)
        {
            bool exception = false;
            Console.Clear();
            Console.Write("Entrez la valeur de Y: ");
            string valYTemp = Console.ReadLine();
            try
            {
                valY = Convert.ToDecimal(valYTemp);
            }
            catch (Exception)
            {
                exception = true;
                Console.WriteLine("La valeur entrée n'est pas valide...");
                Console.WriteLine("Appuyez sur une touche pour re-entrer la valeur de Y...");
                Console.ReadKey();
                ObtentionValX(out valY);
            }
            if (exception == false)
            {
                valY = Convert.ToDecimal(valYTemp);
                return (valY);
            }
            else
            {
                return (0);
            }
        }

        private decimal ObtentionValZ(out decimal valZ)
        {
            bool exception = false;
            Console.Clear();
            Console.Write("Entrez la valeur de Z: ");
            string valZTemp = Console.ReadLine();
            try
            {
                valZ = Convert.ToDecimal(valZTemp);
            }
            catch (Exception)
            {
                exception = true;
                Console.WriteLine("La valeur entrée n'est pas valide...");
                Console.WriteLine("Appuyez sur une touche pour re-entrer la valeur de Z...");
                Console.ReadKey();
                ObtentionValZ(out valZ);
            }
            if (exception == false)
            {
                valZ = Convert.ToDecimal(valZTemp);
                return (valZ);
            }
            else
            {
                return (0);
            }
        }

        private decimal Racine(out decimal reponse)
        {
            Console.Title = "Calcultrice.Racine";
            ObtentionDesVariables(2, out decimal valX, out decimal valY, out _);
            reponse = Convert.ToDecimal(Math.Pow(Convert.ToDouble(valX), Convert.ToDouble(1 / valY)));
            Console.Clear();
            Console.WriteLine(Convert.ToDouble(valX) + " ^ 1/" + Convert.ToDouble(valY));
            Console.WriteLine();
            return reponse;
        }

        //Opérations mathématiques
        private decimal Soustraction(out decimal reponse)
        {
            Console.Title = "Calcultrice.Soustraction";
            ObtentionDesVariables(2, out decimal valX, out decimal valY, out _);
            reponse = (valX - valY);
            Console.Clear();
            Console.WriteLine(valX + " - " + valY);
            Console.WriteLine();
            return reponse;
        }
    } //Version 2.0.1
}