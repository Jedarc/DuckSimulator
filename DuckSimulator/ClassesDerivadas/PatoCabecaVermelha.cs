using DuckSimulator.SuperClasse;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuckSimulator.ClassesDerivadas
{
    public class PatoCabecaVermelha : Pato
    {
        public override void Exibir()
        {
            Console.WriteLine("Exibindo pato cabeça vermelha.");
        }
    }
}
