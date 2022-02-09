using System;
using System.Collections.Generic;
using System.Text;

namespace Ex3CaixaDeMercado
{
    public class Caixa
    {
        private int quantidade;

        public Caixa()
        {

        }

        public double calculaValorFinal(Produto produto, int quantidade)
        {
            this.quantidade = quantidade;
            double valorFinal = produto.Valor * quantidade;

            if (produto.Tipo == 1)
            {
                valorFinal = valorFinal * 0.9;
            }
            else if (produto.Tipo == 2)
            {
                valorFinal = valorFinal * 0.8;

            }
            else if (produto.Tipo == 3 && quantidade > 5)
            {
                valorFinal = valorFinal * 0.9;
            }


            return valorFinal;
        }

        public string ToString(Produto produto, double valorFinal)
        {
            return $"-----------------------------" +
                $"\n{produto.Nome.ToUpper()}" +
                $"\n-----------------------------\n" +
                $"Tipo: {produto.Tipo}\nValor: {produto.Valor}\nQuantidade: {this.quantidade}\nValorFinal: {valorFinal}";
        }

    }
}


