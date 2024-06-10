using Demo06_Indexeur.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06_Indexeur.Models
{
    public class Deck
    {
        private List<Carte> _cartes;

        public Carte[] Cartes { get { return _cartes.ToArray(); } }

        public Carte this[int index]
        {
            get {
                return _cartes[index];
            }
            set {
                _cartes.Add(_cartes[_cartes.Count - 1]);
                for (int i = _cartes.Count - 3 ; i >= index; i--)
                {
                    _cartes[i + 1] = _cartes[i];
                }
                _cartes[index] = value;
            }
        }
        public Deck()
        {
            _cartes = new List<Carte>();
            for (int i = 0; i < 52; i++)
            {
                _cartes.Add(new Carte((Couleurs)(i%4), (Valeurs)(i%13)));
            }
        }
    }
}
