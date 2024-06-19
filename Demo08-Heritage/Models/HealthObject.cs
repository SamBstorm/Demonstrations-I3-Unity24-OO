using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08_Heritage.Models
{
    public class HealthObject : IHealth
    {
        public int HealthPoint { get; private set; }

        public HealthObject(int healthPoint)
        {
            HealthPoint = healthPoint;
        }
    }
}
