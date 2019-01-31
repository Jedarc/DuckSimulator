using DuckSimulator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuckSimulator.Comportamentos.Voar
{
    public class VoarComAsas : IVoarComportamento
    {
        public void Voar()
        {
            Console.WriteLine("Voando com as asas.");
        }
    }
}
