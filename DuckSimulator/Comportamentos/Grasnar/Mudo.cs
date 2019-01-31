using DuckSimulator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuckSimulator.Comportamentos.Grasnar
{
    public class Mudo : IGrasnarComportamento
    {
        public void Grasnar()
        {
            Console.WriteLine("Não pode grasnar.");
        }
    }
}
