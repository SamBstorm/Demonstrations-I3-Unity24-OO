using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08_Heritage.Models
{
    public class Character
    {
        public int CurrentPV { get; private set; }
        public int PVMax { get; private set; }
        public int Attack { get; private set; }
        public Character(int initPV, int attackBase)
        {
            PVMax = initPV;
            CurrentPV = PVMax;
            Attack = attackBase;
        }
        public void Hit(Character opponent)
        {
            opponent.Hurt(Attack);
        }
        /// <summary>
        /// Hurt est une méthode permettant de blesser le Héros.
        /// </summary>
        /// <param name="damage">Correspond au point de dégat, soustrait au PV actuel.</param>
        /// <returns>Si true, alors le héros est toujours en vie, sinon le héros est mort.</returns>
        public bool Hurt(int damage)
        {
            CurrentPV -= damage;
            return CurrentPV > 0;
        }
    }
}
