using DuckSimulator.Comportamentos.Grasnar;
using DuckSimulator.Comportamentos.Voar;
using DuckSimulator.SuperClasse;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuckSimulator.ClassesDerivadas
{
    public class PatoDeBorracha : Pato
    {
        public PatoDeBorracha()
        {
            VoarComportamento = new VoarIncapaz();
            GrasnarComportamento = new Chiar();
        }

        public override void Exibir()
        {
            Console.WriteLine("Exibindo pato de borracha.");
        }

    }
}
