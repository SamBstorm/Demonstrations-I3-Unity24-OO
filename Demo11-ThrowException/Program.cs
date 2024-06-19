namespace Demo11_ThrowException
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Poisson p = null;
            do
            {
                try
                {
                    Console.WriteLine("Veuillez indiquer le nom de votre poisson :");
                    p = new Poisson(Console.ReadLine());
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (p is null);

            try
            {
                while (true)
                {
                    Console.WriteLine($"{p.Nickname} vieilli...");
                    p.Vieillir();
                }
            }
            catch (PoissonMortException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine($"{ex.PoissonMort.Nickname} : {ex.PoissonMort.CurrentPV} / {ex.PoissonMort.PVMax}");
            }
        }
    }
}
