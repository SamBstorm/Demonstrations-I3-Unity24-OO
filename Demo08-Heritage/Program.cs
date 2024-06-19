using Demo08_Heritage.Models;

namespace Demo08_Heritage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPlayer player = new Heroes(10, "Samuel");

            player.AddItem(new EquipmentItem("La masse du C#", 0, 100));
            player.UseItem(player.Inventory[0]);

            Character fighter1 = (Heroes)player;
            Character fighter2 = new Monster();

            do
            {
                fighter2.Hit(fighter1);
                if(fighter1 is Heroes)
                {
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
            if( fighter1 is Heroes)
            {
                /*player.AddItem(new HealthItem("Potion", 10));
                player.UseItem(player.Inventory[1]);*/
                IHealth fontaine = new HealthObject(100);
                player.Healing(fontaine);
            }
        }
    }
}
