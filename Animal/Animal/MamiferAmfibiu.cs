using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class MamiferAmfibiu : Mamifer
    {
        public MamiferAmfibiu(Culoare culoare, string denumire, string regiune, int varstaMaxima) : base(culoare, denumire, regiune, varstaMaxima)
        {
            this.culoare = culoare;
            this.denumire = denumire;
            this.regiune = regiune;
            this.varstaMaxima = varstaMaxima;
        }
    }
}
