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
        public Heroes(int initPV, string name) : base(initPV)
        {
            Name = name;
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
