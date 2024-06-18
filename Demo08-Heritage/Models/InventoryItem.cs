using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08_Heritage.Models
{
    public class InventoryItem
    {
        public string Name { get; private set; }
        public InventoryItem(string name)
        {
            Name = name;
        }
    }
}
