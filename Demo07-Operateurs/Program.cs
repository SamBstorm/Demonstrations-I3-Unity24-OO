namespace Demo07_Operateurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personne p1 = new Personne("Alfred", "Daudet");
            Personne p2 = new Personne("Mary", "Poppins");

            Console.WriteLine($"Voici une première personne : {p1.FirstName} {p1.LastName}");
            Console.WriteLine($"Voici une seconde personne : {p2.FirstName} {p2.LastName}");

            Console.WriteLine("Leur union permet d'obtenir une troisième personne :");
            Personne p3 = p2 + p1;

            Console.WriteLine($"{p3.FirstName} {p3.LastName}");
            Console.WriteLine($"Il sait que sa mère est = {p3.Mother.FirstName} {p3.Mother.LastName}");
            Console.WriteLine($"Il sait que son père est = {p3.Father.FirstName} {p3.Father.LastName}");

            //p3 correspond à l'enfant de p1 et p2

            Console.WriteLine("Veuillez donner le prénom d'une personne recherchée :");
            string prenom = Console.ReadLine();
            Console.WriteLine("Et son nom de famille :");
            string nom = Console.ReadLine();
            Personne personneRecherchee = new Personne(prenom, nom);

            if(p1 == personneRecherchee) { 
                Console.WriteLine("Nous l'avons trouvé, c'est p1!"); 
            }
            else if(p2 == personneRecherchee) { 
                Console.WriteLine("Nous l'avons trouvé, c'est p2!"); 
            }
            else if(p3 == personneRecherchee) { 
                Console.WriteLine("Nous l'avons trouvé, c'est p3!"); 
            }
            else
            {
                Console.WriteLine("Personne ne correspond...");
            }
        }
    }
}
