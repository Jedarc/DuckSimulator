using DuckSimulator.Comportamentos.Grasnar;
using DuckSimulator.Comportamentos.Voar;
using DuckSimulator.SuperClasse;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuckSimulator.ClassesDerivadas
{
    public class PatoDeMadeira : Pato
    {
        public PatoDeMadeira()
        {
            VoarComportamento = new VoarIncapaz();
            GrasnarComportamento = new Mudo();
        }

        public override void Exibir()
        {
            Console.WriteLine("Exibindo pato de madeira.");
        }

    }
}
