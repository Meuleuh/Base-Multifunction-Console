using System;

namespace Console_multi_fonctionnelle_basique
{
    public partial class Calculatrice
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
        } //Version 2.0.1:1
    }
}