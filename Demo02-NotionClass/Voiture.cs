using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02_NotionClass
{
    internal class Voiture
    {
        public int nbRoues;
        public string couleur;
        public string plaque;

        public void Avancer()
        {
            Console.WriteLine("VroumVroum!");
        }

        public void Klaxonner()
        {
            Console.WriteLine("Tut!Tut!");
        }

        public void Freiner()
        {
            Console.WriteLine("Crrreeeeewwwwww!");
        }
    }
}
