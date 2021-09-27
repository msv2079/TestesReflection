using System;

namespace TestesReflection
{
	public class Humano
    {
        public string TipoSanguineo { get; set; }

        public int Idade { get; set; }

        public Double Altura { get; set; }

        public Double Peso { get; set; }

        public string Nome { get; set; }

        public void Respirar()
        {
            Console.WriteLine("Respirar 1...2...3");
        }

        public void PensarAlgo(string pensamentos, DateTime quando)
        {
            Console.WriteLine("Estou pensando em : " + pensamentos + " pensei nisso agora : " + quando.ToShortTimeString());
        }
    }
}
