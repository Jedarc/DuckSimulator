using DuckSimulator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuckSimulator.Comportamentos.Voar
{
    public class VoarIncapaz : IVoarComportamento
    {
        public void Voar()
        {
            Console.WriteLine("Incapaz de voar.");
        }
    }
}
