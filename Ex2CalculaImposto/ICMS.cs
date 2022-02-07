using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2CalculaImposto
{
    internal class ICMS: IImposto
    {

        
        double valor;
        

        public ICMS(double valor)
        {
            this.valor = valor;
        }

        public double calculaImposto(double valor)
        {
            double taxa = 0.30;
            double desconto = taxa * valor;
            Console.WriteLine($"ICMS: {desconto}");
            return desconto;
        }

        
            
        

    }
}
