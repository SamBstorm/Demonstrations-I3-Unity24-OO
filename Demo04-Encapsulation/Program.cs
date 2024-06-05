namespace Demo04_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Login compteBstorm = new Login();
            compteBstorm.SetEmailAndPassword("sam@fait.rire", "Test1234=");
            if(compteBstorm.CheckLogin("a@a","toto"))
            {
                Console.WriteLine("Bienvenue!");
            }
            else
            {
                Console.WriteLine("Mauvais identifiant...");
            }
        }
    }
}
