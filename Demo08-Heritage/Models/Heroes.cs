using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08_Heritage.Models
{
    public class Heroes : Character
    {
        private List<InventoryItem> _inventory;
        public InventoryItem[] Inventory
        {
            get { return _inventory.ToArray(); }
        }

        private List<EquipmentItem> _equipments;

        public EquipmentItem[] Equipments
        {
            get { return _equipments.ToArray(); }
        }

        public string Name { get; private set; }
        public Heroes(int initPV, string name) : base(initPV, 4)
        {
            Name = name;
            _inventory = new List<InventoryItem>();
            _equipments = new List<EquipmentItem>();
        }

        public void AddItem(InventoryItem newItem)
        {
            _inventory.Add(newItem);
        }

        public void Healing(HealthItem healthItem)
        {
            CurrentPV += healthItem.HealthPoint;
            CurrentPV = (CurrentPV > PVMax) ? PVMax : CurrentPV;
        }

        public void UseItem(InventoryItem item)
        {
            if (!Inventory.Contains(item)) return;
            switch (item)
            {
                case HealthItem hi:
                    //HealthItem hi = (HealthItem)item;
                    if (CurrentPV >= PVMax) return;
                    Healing(hi);
                    _inventory.Remove(hi);
                    break;
                case EquipmentItem ei :
                    if (_equipments.Contains(ei)) _equipments.Remove(ei);
                    else _equipments.Add(ei);
                    break;
            }
        }

        public override void Hit(Character opponent)
        {
            //Automatisme de l'override (appel de la méthode du parent grâce à base)
            //base.Hit(opponent);

            int bonusAttack = 0;
            foreach (EquipmentItem ei in Equipments)
            {
                bonusAttack += ei.AtkBonus;
            }
            opponent.Hurt(Attack + bonusAttack);
        }

    }
}
