using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho.Exercicios
{
    public class ReverterString
    {
        public ReverterString(string frase)
        {
            Frase = frase;
            ReverterStringManual();
        }

        public string Frase { private get; set; }

        public void ReverterStringManual()
        {
            if (Frase == null)
            {
                Console.WriteLine("Não há string.");
                return;
            }

            string fraseRevertida = "";
            for (int i = Frase.Length - 1; i >= 0; i--)
            {
                fraseRevertida += Frase[i];
            }

            Console.WriteLine($"String normal: {Frase}");
            Console.WriteLine($"String revertida: {fraseRevertida}");
        }
    }
}