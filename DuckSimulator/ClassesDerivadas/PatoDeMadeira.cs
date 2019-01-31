using DuckSimulator.SuperClasse;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuckSimulator.ClassesDerivadas
{
    public class PatoDeMadeira : Pato
    {
        public override void Exibir()
        {
            Console.WriteLine("Exibindo pato de madeira.");
        }

        public override void Grasnar()
        {
            Console.WriteLine("Não grasna.");
        }
    }
}
