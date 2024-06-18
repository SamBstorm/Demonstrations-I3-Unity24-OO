using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08_Heritage.Models
{
    public class EquipmentItem : InventoryItem
    {
        public int DefBonus {  get; private set; }
        public int AtkBonus {  get; private set; }
        public EquipmentItem(string name, int defBonus, int atkBonus) : base(name)
        {
            DefBonus = defBonus;
            AtkBonus = atkBonus;
        }
    }
}
