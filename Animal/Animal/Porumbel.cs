using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Porumbel : Pasare
    {
        public Porumbel(string denumire, string regiune, int varstaMaxima, bool zboara) : base(denumire, regiune, varstaMaxima, zboara)
        {
            this.denumire = denumire;
            this.regiune = regiune;
            this.varstaMaxima = varstaMaxima;
            this.zboara = zboara;
        }

        public override void MentioneazaTipulDeDeplasare()
        {
            Console.WriteLine("Porumbelul zboara.");
        }

        public override void MentioneazaTipulDeReproducere()
        {
            Console.WriteLine("Porumbelul se reproduce prin oua.");
        }
    }
}
