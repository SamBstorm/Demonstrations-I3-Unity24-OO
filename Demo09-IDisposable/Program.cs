namespace Demo09_IDisposable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (Communication c1 = new Communication("Samuel"))
            {
                c1.AjoutTexte("Bonjour les Games24!");
                c1.AjoutTexte("Aujourd'hui, nous finissons l'OO!");
                c1.AjoutTexte("Comme c'est excitant!");
                c1.AjoutTexte("PS : c'est naze ça...");
            }
        }
    }
}
