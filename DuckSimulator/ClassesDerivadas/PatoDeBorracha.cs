using DuckSimulator.SuperClasse;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuckSimulator.ClassesDerivadas
{
    public class PatoDeBorracha : Pato
    {
        public override void Exibir()
        {
            Console.WriteLine("Exibindo pato de borracha.");
        }

        public override void Grasnar()
        {
            Console.WriteLine("Fazendo barulho de borracha.");
        }
    }
}
