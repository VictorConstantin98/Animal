using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Catel : MamiferTerestru
    {
        public Catel(Culoare culoare, string denumire, string regiune, int varstaMaxima) : base (culoare, denumire, regiune, varstaMaxima)
        {
            this.culoare = culoare;
            this.denumire = denumire;
            this.regiune = regiune;
            this.varstaMaxima = varstaMaxima;
        }

        public override void MentioneazaTipulDeDeplasare()
        {
            Console.WriteLine("Catelul se deplaseaza prin mers.");
        }

        public override void MentioneazaTipulDeReproducere()
        {
            Console.WriteLine("Catelul se reproduce prin pui.");
        }
    }
}
