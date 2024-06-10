using Demo06_Indexeur.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06_Indexeur.Models
{
    public class Carte
    {
        public Couleurs Couleur { get; private set; }
        public Valeurs Valeur { get; private set; }

        public Carte(Couleurs couleur, Valeurs valeur)
        {
            this.Couleur = couleur;
            this.Valeur = valeur;
        }
    }
}
