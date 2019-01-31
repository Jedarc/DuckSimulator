using DuckSimulator.Comportamentos.Grasnar;
using DuckSimulator.Comportamentos.Voar;
using DuckSimulator.SuperClasse;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuckSimulator.ClassesDerivadas
{
    public class PatoSelvagem : Pato
    {
        public PatoSelvagem()
        {
            VoarComportamento = new VoarComAsas();
            GrasnarComportamento = new GrasnarBarulho();
        }

        public override void Exibir()
        {
            Console.WriteLine("Exibindo pato bravo.");
        }
    }
}
