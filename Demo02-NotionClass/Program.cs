namespace Demo02_NotionClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture maFerrari = new Voiture() { 
                nbRoues = 4, 
                couleur = "Rouge", 
                plaque = "1-ABC-123"
            };

            Console.WriteLine($"Je suis fier de vous présenter ma nouvelle voiture {maFerrari.couleur}, muni de {maFerrari.nbRoues}, et immatriculée {maFerrari.plaque}.");

            maFerrari.Klaxonner();

            Console.WriteLine($"Je présente ma voiture à ma mère qui me dit, la couleur {maFerrari.couleur}, lui fait penser à ses fraises de son potagé...");

            Voiture laFraise = maFerrari;

            Console.WriteLine("Je roule trop vite, et j'ai un accident, je perds une roue...");
            maFerrari.Avancer();

            maFerrari.nbRoues--;

            maFerrari.Freiner();
            Console.WriteLine($"Ma mère dit : \"Elle roulera moins bien avec seulement {laFraise.nbRoues}...\"");
        }
    }
}
