using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal abstract class Pasare : Animal
    {
        protected string denumire;
        protected string regiune;
        protected int varstaMaxima;
        protected bool zboara;

        public Pasare(string denumire, string regiune, int varstaMaxima, bool zboara)
        {
            this.denumire = denumire;
            this.regiune = regiune;
            this.varstaMaxima = varstaMaxima;
            this.zboara = zboara;
        }
        public override void MentioneazaTipulDeDeplasare()
        {
            Console.WriteLine("Pasarea zboara.");
        }

        public override void MentioneazaTipulDeReproducere()
        {
            Console.WriteLine("Pasarea se reproduce.");
        }

        public override string ToString()
        {
            return "Pasarea zboara si se reproduce";
        }
    }
}
