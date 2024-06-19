using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo11_ThrowException
{
    internal class Poisson
    {
        private int _currentPV;
        public int CurrentPV {

            get {
                return _currentPV;
            }
            private set {
                if (value < 0) _currentPV = 0;
                else if( value > PVMax) _currentPV = PVMax;
                else _currentPV = value;
            } 
        }
        public int PVMax {  get; private set; }

        public string Nickname {  get; private set; }

        public Poisson(string nickname)
        {
            if(nickname is null)
                throw new ArgumentNullException(nameof(nickname),"Notre poisson ne peut pas avoir un surnom null...");
            if (nickname.Length == 0) 
                throw new ArgumentException("Pas assez de caractères pour le surnom", nameof(nickname));
            _currentPV = PVMax = 10;
            Nickname = nickname;
        }

        public void Vieillir()
        {
            if (CurrentPV == 0) throw new PoissonMortException(this);
            CurrentPV--;
        }
    }
}
