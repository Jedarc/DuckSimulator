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
            patoSelvagem.PerformarGrasnido();
            patoSelvagem.Nadar();
            patoSelvagem.PerformarVoo();
            Console.WriteLine("---------");

            Console.WriteLine("---------");
            PatoCabecaVermelha patoCabecaVermelha = new PatoCabecaVermelha();
            patoCabecaVermelha.Exibir();
            patoCabecaVermelha.PerformarGrasnido();
            patoCabecaVermelha.Nadar();
            patoCabecaVermelha.PerformarVoo();
            Console.WriteLine("---------");

            Console.WriteLine("---------");
            PatoDeBorracha patoDeBorracha = new PatoDeBorracha();
            patoDeBorracha.Exibir();
            patoDeBorracha.PerformarGrasnido();
            patoDeBorracha.Nadar();
            patoDeBorracha.PerformarVoo();
            Console.WriteLine("---------");

            Console.WriteLine("---------");
            PatoDeMadeira patoDeMadeira = new PatoDeMadeira();
            patoDeMadeira.Exibir();
            patoDeMadeira.PerformarGrasnido();
            patoDeMadeira.Nadar();
            patoDeMadeira.PerformarVoo();
            Console.WriteLine("---------");

            Console.ReadKey();
        }
    }
}
