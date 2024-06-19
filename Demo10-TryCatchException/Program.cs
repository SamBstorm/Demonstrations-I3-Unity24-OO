namespace Demo10_TryCatchException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nb1;
            do
            {
                Console.WriteLine("Veuillez introduire un premier nombre :");
            } while (!int.TryParse(Console.ReadLine(), out nb1));
            
            Console.WriteLine("Veuillez introduire un second nombre :");
            try
            {
                int nb2 = int.Parse(Console.ReadLine());
                try
                {
                    Console.WriteLine($"Le résultat de la division de {nb1} par {nb2} est de {nb1 / nb2} reste {nb1 % nb2}");
                }
                catch (DivideByZeroException ex)
                {
                    //Console.WriteLine(ex.Message); //Nous utilisons la variable ex correspondant à notre Exception pour récupérer des informations concernant l'erreur et la traiter
                    //ex.Message donne par exemple un message par défaut correspondant à l'exception (Mais en anglais...)
                    Console.WriteLine("Attention, une division par 0 tend vers l'infini...");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Une erreur inattendue est survenue...");
                }
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("La valeur ne peut être null");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("La valeur récupérée n'est pas au bon format");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Votre valeur dépasse les valeurs autorisées...");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Une erreur inattendue est survenue lors de l'entrée...");
            }

            Console.WriteLine("Merci d'utiliser la calculatrice!");
        }
    }
}
