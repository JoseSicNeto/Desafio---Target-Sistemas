using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho.Exercicios
{
    public class SomaAbaixoDoIndice
    {
        public int Indice { private get; set; }
        private int soma = 0;

        public SomaAbaixoDoIndice(int indice)
        {
            Indice = indice;
            CalcularSomaAbaixoDoIndice();
        }

        public void CalcularSomaAbaixoDoIndice()
        {
            int k = 0;
            while (k < Indice)
            {
                k++;
                soma += k;
            }
            ImprimirSomaTotal();
        }

        private void ImprimirSomaTotal()
        {
            Console.WriteLine($"Valor dos números abaixo do Indice: {soma}");
        }
    }
}