using System;
using System.Collections.Generic;
using System.Text;

namespace Ex4TrabalhandoComArray
{
    public class TArrays
    {
        int[] ArrayRec = new int[100];


        public void recebeArray (int[] arrayrecebido)
        {
            this.ArrayRec = arrayrecebido;
        }

        

        public int SomaTodos()
            
        {
            int somatoria = 0;
            foreach (var item in ArrayRec)
            {
                somatoria += item;
            }
            return somatoria;
        }

        public int MaiorNumero()
        {
            int maiorNumero = ArrayRec[0];
            foreach(var item in ArrayRec)
            {
                if (item > maiorNumero)
                    maiorNumero = item;

            }
            return maiorNumero;

        } 
        public int MenorNumero()
        {
            int menorNumero = ArrayRec[0];
            foreach(var item in ArrayRec)
            {
                if (item < menorNumero)
                    menorNumero = item;

            }
            return menorNumero;

        }

        public double ContaTodos()
        {
            int contaItens = 0;
            foreach (var item in ArrayRec)
            {
                if (item !=0)
                {
                    contaItens++;
                }
                            }

            return contaItens;
        }

       
    }
}
