using System;

namespace Animal
{
    public class Program
    {
        static void Main(string[] args)
        {
            Catel catel1 = new Catel("Bichon", "Malta", 10, Culoare.Alb);
            Delfin delfin1 = new Delfin("King", "Marea Neagra", 30, Culoare.Gri);
            Porumbel porumbel1 = new Porumbel("Speed", "Romania", 8, true);
        }
    }
}