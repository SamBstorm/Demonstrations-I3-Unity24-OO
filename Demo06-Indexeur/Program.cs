using Demo06_Indexeur.Models;

namespace Demo06_Indexeur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deck paquet = new Deck();

            Console.WriteLine("Voici mon paquet de cartes :");
            foreach (Carte carte in paquet.Cartes)
            {
                Console.WriteLine($"{carte.Valeur} de {carte.Couleur}");
            }

            Random RNG = new Random();
            int numeroAleatoire = RNG.Next(52);
            Console.WriteLine($"Je pioche la carte en position {numeroAleatoire + 1} :");

            Carte cartePiochee = paquet[numeroAleatoire];

            Console.WriteLine($"{cartePiochee.Valeur} de {cartePiochee.Couleur}");

            paquet[0] = cartePiochee;

            Console.WriteLine("Voici mon paquet de cartes :");
            foreach (Carte carte in paquet.Cartes)
            {
                Console.WriteLine($"{carte.Valeur} de {carte.Couleur}");
            }
        }
    }
}
