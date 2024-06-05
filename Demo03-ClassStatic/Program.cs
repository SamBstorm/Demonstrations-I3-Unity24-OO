namespace Demo03_ClassStatic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture v1 = new Voiture();
            v1.nbRoues = 4;
            Voiture v2 = new Voiture();
            v2.nbRoues = 6;

            Voiture.model = "Twingo";

            Console.WriteLine($"Toute les voitures de mon application sont des {Voiture.model}.");
            Console.WriteLine($"Actuellement, j'ai une seule voiture avec {v1.nbRoues} roues.");
            Console.WriteLine("Seule ma voiture peut rouler :");
            v1.Avance();
            Console.WriteLine($"Mais toutes voitures peut calculer la distance parcourue : pour 60km/h en 2 heures, j'ai parcouru : {Voiture.CalculKilometrique(60, 7200)}");
        }
    }
}
