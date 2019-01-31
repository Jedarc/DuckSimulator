using DuckSimulator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuckSimulator.Comportamentos.Grasnar
{
    public class GrasnarBarulho : IGrasnarComportamento
    {
        public void Grasnar()
        {
            Console.WriteLine("Grasnando.");
        }
    }
}
