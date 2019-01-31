using DuckSimulator.SuperClasse;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuckSimulator.ClassesDerivadas
{
    public class PatoSelvagem : Pato
    {
        public override void Exibir()
        {
            Console.WriteLine("Exibindo pato bravo.");
        }
    }
}
