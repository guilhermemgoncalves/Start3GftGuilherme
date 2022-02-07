using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1ContarLetras
{
    public class ContadorLetras
    {

        private string frase;
        private string ultimaPalavra;

        

        public ContadorLetras(string frase)
        {
            this.frase = frase;
        }

        public int ContaLetras()
        {
            string [] separaUltimaPalavra = this.frase.Split(' ');
            this.ultimaPalavra= separaUltimaPalavra[separaUltimaPalavra.Length-1];
              

            return this.ultimaPalavra.ToCharArray().Length;
        }
    }
}
