using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08_Heritage.Models
{
    public class Heroes : Character
    {

        public string Name { get; private set; }
        public Heroes(int initPV, string name) : base(initPV, 4)
        {
            Name = name;
        }

    }
}
