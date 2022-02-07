using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2CalculaImposto
{
    public class COFINS
    {
        double valor;

        public COFINS(double valor)
        {
            this.valor = valor;
        }

        public double calculaImposto(double valor)
        {
            double taxa = 0;
            if (valor > 17000)
            {
                taxa = 0.08;
            }
            else
            {
                taxa = 0.0;
            }
            double desconto = taxa * valor;
            Console.WriteLine($"COFINS: {desconto}");
            return desconto;
        }

    }
}
