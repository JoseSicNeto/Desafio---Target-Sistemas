using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Trabalho.Exercicios
{
    public class FaturamentoMensal
    {
        private readonly string _caminhoArquivo;

        public FaturamentoMensal()
        {
            _caminhoArquivo = Path.Combine(Directory.GetCurrentDirectory(), "Exercicios/FaturamentoDiario.json");
            ProcessarFaturamento();
        }

        public void ProcessarFaturamento()
        {
            string json = File.ReadAllText(_caminhoArquivo);
            Dictionary<string, decimal?> faturamentoDiario = JsonConvert.DeserializeObject<Dictionary<string, decimal?>>(json);

            if (faturamentoDiario != null && faturamentoDiario.Count > 0)
            {
                decimal somaFaturamento = 0;
                int diasComFaturamento = 0;
                decimal maiorFaturamento = decimal.MinValue;
                decimal menorFaturamento = decimal.MaxValue;

                foreach (var dia in faturamentoDiario)
                {
                    if (dia.Value != null)
                    {
                        diasComFaturamento++;
                        somaFaturamento += (decimal)dia.Value;
                        if (dia.Value > maiorFaturamento)
                        {
                            maiorFaturamento = (decimal)dia.Value;
                        }
                        if (dia.Value < menorFaturamento)
                        {
                            menorFaturamento = (decimal)dia.Value;
                        }
                    }
                }

                if (diasComFaturamento > 0)
                {
                    decimal mediaFaturamento = somaFaturamento / diasComFaturamento;
                    int diasAcimaMedia = 0;

                    foreach (var dia in faturamentoDiario)
                    {
                        if (dia.Value == maiorFaturamento)
                        {
                            Console.WriteLine($"No dia: {dia.Key} teve o maior faturamento: {dia.Value}");
                        }

                        if (dia.Value == menorFaturamento)
                        {
                            Console.WriteLine($"No dia: {dia.Key} teve o menor faturamento: {dia.Value}");
                        }

                        if (dia.Value > mediaFaturamento)
                        {
                            diasAcimaMedia++;
                        }
                    }
                    Console.WriteLine($"Teve um total de {diasAcimaMedia} dias com faturamento acima da média mensal.");
                }
                else
                {
                    Console.WriteLine("Nenhum faturamento válido encontrado.");
                }
            }
            else
            {
                Console.WriteLine("O dicionário está vazio ou é nulo.");
            }
        }
    }
}
