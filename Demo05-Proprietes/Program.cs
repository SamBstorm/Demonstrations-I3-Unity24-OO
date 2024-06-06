namespace Demo05_Proprietes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Login user1 = new Login();

            Console.WriteLine( user1.NbAttempt ); 

            Console.WriteLine("INSCRIPTION :");
            Console.WriteLine("E-Mail:");
            user1.Email = Console.ReadLine();
            Console.WriteLine("Mot de passe :");
            user1.Password = Console.ReadLine();
            Console.WriteLine($"Utilisateur 1 : Votre email et mot de passe sont maintenant sauvegardé!");
        }
    }
}
