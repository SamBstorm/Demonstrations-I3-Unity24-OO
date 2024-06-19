using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo11_ThrowException
{
    internal class PoissonMortException : Exception
    {
        public Poisson PoissonMort { get; private set; }
        public PoissonMortException() : base("Le poisson est mort")
        {
        }

        public PoissonMortException(Poisson poissonMort) : base($"Le poisson {poissonMort.Nickname} est mort")
        {
            PoissonMort = poissonMort;
        }
    }
}
