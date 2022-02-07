using System;

namespace Ex4TrabalhandoComArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TArrays array = new TArrays();
            int[] arrayT = { 10, 15, 20, -30, 15 }; // dados mocados para o teste da main

            array.recebeArray(arrayT);
            Console.Write("Soma de todos os numeros: ");
            Console.WriteLine(array.SomaTodos());
            Console.Write("Maior numero: ");
            Console.WriteLine(array.MaiorNumero());
            Console.Write("Menor numero: ");
            Console.WriteLine(array.MenorNumero());
            Console.Write("Media dos valores: ");
            Console.WriteLine(Convert.ToDouble(array.SomaTodos())/array.ContaTodos());
            



        }
    }
}
