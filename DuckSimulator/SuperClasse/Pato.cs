using DuckSimulator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuckSimulator.SuperClasse
{
    public abstract class Pato
    {
        public IVoarComportamento VoarComportamento { get; set; }
        public IGrasnarComportamento GrasnarComportamento { get; set; }


        public void Nadar()
        {
            Console.WriteLine("Nadando.");
        }

        public abstract void Exibir();




        public void PerformarVoo()
        {
            VoarComportamento.Voar();
        }

        public void PerformarGrasnido()
        {
            GrasnarComportamento.Grasnar();
        }
    }
}
