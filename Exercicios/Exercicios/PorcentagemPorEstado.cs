using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho.Exercicios
{
    public class PorcentagemPorEstado
    {
        public PorcentagemPorEstado()
        {
            CalcularPorcentagem();
        }

        Dictionary<string, decimal> estados = new Dictionary<string, decimal>
        {
            {"SP", 67836.43M}, {"RJ", 36678.66M}, {"MG", 29229.88M}, {"ES", 27165.48M}, {"Outros", 19849.53M}, 
        };

        public void CalcularPorcentagem()
        {
            decimal total = 0;
            foreach (var valores in estados.Values)
            {
                total += valores;
            }
            Console.WriteLine(total);
            foreach (var estado in estados)
            {
                int porcentagem = Convert.ToInt32((estado.Value / total) * 100);
                Console.WriteLine($"{estado.Key} = {porcentagem}%");
            }
        }
    }
}