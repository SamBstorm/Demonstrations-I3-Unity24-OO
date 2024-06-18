using Demo08_Heritage.Models;

namespace Demo08_Heritage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character fighter1 = new Heroes(10,"Samuel");
            Character fighter2 = new Monster();

            do
            {
                fighter2.Hit(fighter1);
                if(fighter1 is Heroes player)
                {
                    //Heroes player = (Heroes)fighter1;
                    Console.WriteLine($"Notre héro {player.Name} a une vie de : {player.CurrentPV} / {player.PVMax}");
                }
                else
                {
                    Console.WriteLine($"Le monstre a une vie de : {fighter1.CurrentPV} / {fighter1.PVMax}");
                }
                Character temp = fighter1;
                fighter1 = fighter2;
                fighter2 = temp;
            } while (fighter1.CurrentPV > 0 && fighter2.CurrentPV > 0);
            if( fighter1 is Heroes hero)
            {
                hero.AddItem(new HealthItem("Potion", 10));
                hero.UseItem(hero.Inventory[0]);
            }
        }
    }
}
