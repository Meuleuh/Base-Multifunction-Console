using System;

namespace Console_multi_fonctionnelle_basique
{
    public partial class SingleUseStuff
    {
        public SingleUseStuff()
        {
            Console.Title = "Single Use Stuff";
            Console.Clear();
            Console.WriteLine("Comment êtes vous au courant de cette fonction?");
            Console.WriteLine("Vous avez sûrement dû aller chercher dans le code...");
            Console.WriteLine("En tout cas... Sachez que tout ce qui se trouve ici");
            Console.WriteLine("risque de disparaître dans la prochaine version...");
            Console.WriteLine("En fait, tout ce qui se trouve ici n'est supposé d'avoir");
            Console.WriteLine("une seule utilité, d'où le nom Single Use Stuff...");
            Console.WriteLine("En tout cas, ce qui sera bon restera dans le code et sera");
            Console.WriteLine("soit utilisé sous forme d'une nouvelle composante, soit comme");
            Console.WriteLine("partie d'une composante déjà existante... Il s'agit en gros");
            Console.WriteLine("de la section prototype de la console...");
            Console.WriteLine("Appuyez sur une touche pour afficher les fonctions...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}