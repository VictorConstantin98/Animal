using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    enum TipMancare {HranaUmeda, HranaUscata};
    internal class MamiferTerestru : Mamifer
    {
        public MamiferTerestru(Culoare culoare, string denumire, string regiune, int varstaMaxima) : base(culoare, denumire, regiune, varstaMaxima)
        {
            this.culoare = culoare;
            this.denumire = denumire;
            this.regiune = regiune;
            this.varstaMaxima = varstaMaxima;
        }
    }
}
