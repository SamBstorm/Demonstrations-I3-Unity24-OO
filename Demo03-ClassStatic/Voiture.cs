using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03_ClassStatic
{
    internal class Voiture
    {
        public int nbRoues;
        public static string model;

        public void Avance()
        {
            Console.WriteLine("Vroum! Vroum!");
        }

        public static double CalculKilometrique( int vitesse, int temps)
        {
            return vitesse * (temps / 3600D);
        }
    }
}
