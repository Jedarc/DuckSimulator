using DuckSimulator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuckSimulator.Comportamentos.Grasnar
{
    public class Chiar : IGrasnarComportamento
    {
        public void Grasnar()
        {
            Console.WriteLine("Faz barulho de borracha.");
        }
    }
}
