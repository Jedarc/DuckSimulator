using DuckSimulator.ClassesDerivadas;
using System;

namespace DuckSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("---------");
            PatoSelvagem patoSelvagem = new PatoSelvagem();
            patoSelvagem.Exibir();
            patoSelvagem.Grasnar();
            patoSelvagem.Nadar();
            Console.WriteLine("---------");

            Console.WriteLine("---------");
            PatoCabecaVermelha patoCabecaVermelha = new PatoCabecaVermelha();
            patoCabecaVermelha.Exibir();
            patoCabecaVermelha.Grasnar();
            patoCabecaVermelha.Nadar();
            Console.WriteLine("---------");

            Console.WriteLine("---------");
            PatoDeBorracha patoDeBorracha = new PatoDeBorracha();
            patoDeBorracha.Exibir();
            patoDeBorracha.Grasnar();
            patoDeBorracha.Nadar();
            Console.WriteLine("---------");

            Console.WriteLine("---------");
            PatoDeMadeira patoDeMadeira = new PatoDeMadeira();
            patoDeMadeira.Exibir();
            patoDeMadeira.Grasnar();
            patoDeMadeira.Nadar();
            Console.WriteLine("---------");

            Console.ReadKey();
        }
    }
}
