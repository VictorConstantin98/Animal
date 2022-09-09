using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    enum Culoare {Alb, Negru, Gri};
    internal abstract class Mamifer : Animal
    {
        protected Culoare culoare;
        protected string denumire;
        protected string regiune;
        protected int varstaMaxima;

        public Mamifer(Culoare culoare, string denumire, string regiune, int varstaMaxima)
        {
            this.culoare = culoare;
            this.denumire = denumire;
            this.regiune = regiune;
            this.varstaMaxima = varstaMaxima;
        }
        public override void MentioneazaTipulDeDeplasare()
        {
            Console.WriteLine("Mamiferul se deplaseaza.");
        }

        public override void MentioneazaTipulDeReproducere()
        {
            Console.WriteLine("Mamiferul se reproduce.");
        }

        public override string ToString()
        {
            return "Mamiferul se deplaseaza si se reproduce";
        }

        public override bool Equals(object obj)
        {
            var item = obj as Mamifer;
            if(item == null)
            {
                return false;
            }
            return this.varstaMaxima.Equals(item.varstaMaxima);
        }
    }
}
