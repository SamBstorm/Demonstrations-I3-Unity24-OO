using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08_Heritage.Models
{
    public class Monster : Character
    {

        public int Attack { get; private set; }
        public Monster() : base(4)
        {
            Attack = 2;
        }

        public void Hit(Heroes heroe)
        {
            heroe.Hurt(Attack);
        }
    }
}
