using System;
using System.Collections.Generic;

namespace Trabalho.Exercicios
{
    public class Fibonacci
    {
        public string Sequencia { get; set; }

        /// <summary>
        /// Entre com uma sequencia como o exemplo
        /// Exemplo: (0 0 0 0 0)
        /// </summary>
        public Fibonacci(string sequencia)
        {
            Sequencia = sequencia;
            VerificarSequencia();
        }

        public void VerificarSequencia()
        {
            List<int> numeros = ConverterSequenciaParaLista(Sequencia);
            if (numeros == null || numeros.Count < 3)
            {
                Console.WriteLine($"Não é uma sequência válida: {Sequencia}");
                return;
            }

            bool ehFibonacci = VerificarSeEhFibonacci(numeros);
            ImprimirResultado(ehFibonacci);
        }

        private List<int> ConverterSequenciaParaLista(string sequencia)
        {
            string[] partes = sequencia.Split(' ');
            List<int> numeros = new List<int>();

            foreach (string parte in partes)
            {
                if (int.TryParse(parte, out int numero))
                {
                    numeros.Add(numero);
                }
                else
                {
                    return null;
                }
            }

            return numeros;
        }

        private bool VerificarSeEhFibonacci(List<int> numeros)
        {
            for (int i = 0; i < numeros.Count - 2; i++)
            {
                if ((numeros[i] + numeros[i + 1]) != numeros[i + 2])
                {
                    return false;
                }
            }
            return true;
        }

        private void ImprimirResultado(bool ehFibonacci)
        {
            Console.WriteLine($"A sequência: {Sequencia} {(ehFibonacci ? "pertence" : "não pertence")}");
        }
    }
}