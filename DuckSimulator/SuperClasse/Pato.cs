using System;
using System.Collections.Generic;
using System.Text;

namespace DuckSimulator.SuperClasse
{
    public abstract class Pato
    {
        public virtual void Grasnar()
        {
            Console.WriteLine("Grasnando.");
        }

        public void Nadar()
        {
            Console.WriteLine("Nadando.");
        }

        public abstract void Exibir();

    }
}
