using System;
using System.Collections.Generic;
using System.Text;

namespace Ex3CaixaDeMercado
{
    public class Produto
    {

        private string nome;
        private double valor;
        private int tipo;

        public Produto(string nome, double valor, int tipo)
        {
            this.Nome = nome;
            this.Valor = valor;
            this.Tipo = tipo;
        }

        public string Nome { get => nome; set => nome = value; }
        public double Valor { get => valor; set => valor = value; }
        public int Tipo { get => tipo; set => tipo = value; }


        
    }
}
