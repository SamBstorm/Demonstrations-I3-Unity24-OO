using Demo01_Namespace.Enums;

namespace Demo01_Namespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez piocher une carte :");
            Console.WriteLine("Appuyez sur Enter pour piocher...");
            Console.ReadLine();
            Random RNG = new Random();
            Carte maCarte;
            maCarte.valeur = Enum.GetValues<Valeurs>()[RNG.Next(0,14)];
            maCarte.couleur = Enum.GetValues<Couleurs>()[RNG.Next(0,4)];
            Console.WriteLine($"Votre carte était : Le {maCarte.valeur} de {maCarte.couleur}");
        }
    }
}
