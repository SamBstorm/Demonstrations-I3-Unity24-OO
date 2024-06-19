using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08_Heritage.Models
{
    public interface IPlayer
    {
        string Name { get; }
        int CurrentPV {  get; }
        int PVMax { get; }
        InventoryItem[] Inventory { get; }
        void Hit(Character opponent);
        void Healing(IHealth healthItem);
        void AddItem(InventoryItem item);
        void UseItem(InventoryItem item);
    }
}
