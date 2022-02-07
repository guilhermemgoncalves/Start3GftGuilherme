using System;

namespace Ex1ContarLetras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase separando as palavras por espaço:");

            string coletaFrase = Console.ReadLine();

            ContadorLetras Frase = new ContadorLetras(coletaFrase);

            Console.WriteLine(Frase.ContaLetras());
        }
    }
}
