namespace Demo12_Deleguate01
{
    public delegate void ValeurAleatoireDelegate(int val1, int val2);
    internal class Program
    {
        static Random RNG = new Random();
        static void Main(string[] args)
        {
            int nbLances;
            do
            {
                Console.WriteLine("Combien de lancé de dé?");
            } while (!int.TryParse(Console.ReadLine(), out nbLances));

            ValeurAleatoireDelegate lances = null;
            for (int i = 0; i < nbLances; i++)
            {
                if (lances is null) lances = LancerDe;
                else lances += LancerDe;
            }

            //if(!(lances is null)) {
            //    lances(1,6);
            //}

            lances?.Invoke(1,6);
        }

        static void LancerDe(int min, int max)
        {
            Console.WriteLine($"Le lancé vaut : {RNG.Next(min, max + 1)}");
        }
    }
}
