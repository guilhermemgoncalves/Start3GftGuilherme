using System;

namespace Ex3CaixaDeMercado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto banana = new Produto("banana",0.99,2);
            Produto energetico = new Produto("energetico",5.49,3);
            Produto arroz = new Produto("arroz",20,1);
            Produto chocolate = new Produto("chocolate",4.50,1);
            Produto leite = new Produto("leite",3.73,3);
            Produto abacaxi = new Produto("abacaxi",2.40,2);


            Caixa caixa = new Caixa();

            Console.WriteLine(caixa.ToString(banana, caixa.calculaValorFinal(banana, 3)));
            Console.WriteLine(caixa.ToString(energetico, caixa.calculaValorFinal(energetico, 7)));
            Console.WriteLine(caixa.ToString(arroz, caixa.calculaValorFinal(arroz, 1)));
            Console.WriteLine(caixa.ToString(chocolate, caixa.calculaValorFinal(chocolate, 12)));
            Console.WriteLine(caixa.ToString(leite, caixa.calculaValorFinal(leite, 5)));
            Console.WriteLine(caixa.ToString(abacaxi, caixa.calculaValorFinal(abacaxi, 2)));

        }
    }
}
