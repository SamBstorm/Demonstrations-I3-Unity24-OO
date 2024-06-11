using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo07_Operateurs
{
    public class Personne
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Personne Father { get; private set; }
        public Personne Mother { get; private set; }

        public Personne(string firstName, string lastName) {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public static Personne operator +(Personne mother, Personne father) { 
            Personne enfant = new Personne(
                $"Enfant de la famille {mother.LastName}-{father.LastName}",
                father.LastName);
            enfant.Mother = mother;
            enfant.Father = father;
            return enfant;
        }

        public static bool operator ==(Personne left, Personne right)
        {
            return left.FirstName == right.FirstName && left.LastName == right.LastName;
        }

        public static bool operator !=(Personne left, Personne right)
        {
            return !(left == right);
        }
    }
}
