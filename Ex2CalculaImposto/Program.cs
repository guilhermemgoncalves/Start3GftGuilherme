using System;

namespace Ex2CalculaImposto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor: ");
            double valorDeCalculo = double.Parse(Console.ReadLine());
            calcularImposto(valorDeCalculo);


            void calcularImposto(double valorDeCalculo)
            {
                COFINS confins = new COFINS(valorDeCalculo);
                IPI ipi = new IPI(valorDeCalculo);
                ICMS icms = new ICMS(valorDeCalculo);

                double descontoTotal = icms.calculaImposto(valorDeCalculo);
                descontoTotal += ipi.calculaImposto(valorDeCalculo);
                descontoTotal += confins.calculaImposto(valorDeCalculo);
                Console.WriteLine($"Valor Final: {descontoTotal+valorDeCalculo}");


            }


        }

    }
}
