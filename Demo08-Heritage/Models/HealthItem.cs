using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08_Heritage.Models
{
    public class HealthItem : InventoryItem
    {
        public int HealthPoint { get; private set; }
        public HealthItem(string name, int healthPoint) : base(name)
        {
            HealthPoint = healthPoint;
        }
    }
}
