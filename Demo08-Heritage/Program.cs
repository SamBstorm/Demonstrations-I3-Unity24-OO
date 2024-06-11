using Demo08_Heritage.Models;

namespace Demo08_Heritage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Heroes player = new Heroes(10,"Samuel");

            Console.WriteLine($"Notre héros {player.Name} ({player.CurrentPV}/{player.PVMax}) se ballade.");

            Monster m1 = new Monster();

            Console.WriteLine($"Un monstre apparait! ({m1.CurrentPV}/{m1.PVMax})");
            Console.WriteLine($"Le monstre attaque {player.Name}!");
            m1.Hit(player);
            Console.WriteLine($"Notre héros {player.Name} ({player.CurrentPV}/{player.PVMax}) a survécu!");

        }
    }
}
