using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08_Heritage.Models
{
    public class Character
    {
        public int CurrentPV { get; protected set; }
        public int PVMax { get; private set; }

        public Character(int initPV)
        {
            PVMax = initPV;
            CurrentPV = PVMax;
        }
    }
}
