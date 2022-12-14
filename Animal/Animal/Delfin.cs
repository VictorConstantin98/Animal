using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Delfin : MamiferAmfibiu
    {
        public Delfin(Culoare culoare, string denumire, string regiune, int varstaMaxima) : base(culoare, denumire, regiune, varstaMaxima)
        {
            this.culoare = culoare;
            this.denumire = denumire;
            this.regiune = regiune;
            this.varstaMaxima = varstaMaxima;
        }

        public override void MentioneazaTipulDeDeplasare()
        {
            Console.WriteLine("Delfinul se deplaseaza prin innot.");
        }

        public override void MentioneazaTipulDeReproducere()
        {
            Console.WriteLine("Delfinul se reproduce prin pui.");
        }
    }
}
