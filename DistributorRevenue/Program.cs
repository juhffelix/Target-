using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Dados do faturamento por estado (valores alterados)
        Dictionary<string, double> faturamento = new Dictionary<string, double>()
        {
            { "SP", 100000.00 },
            { "RJ", 50000.00 },
            { "MG", 40000.00 },
            { "ES", 35000.00 },
            { "Outros", 25000.00 }
        };

        // Calcula o total de faturamento
        double totalFaturamento = 0;
        foreach (var valor in faturamento.Values)
        {
            totalFaturamento += valor;
        }

        // Exibe o valor total de faturamento
        Console.WriteLine("Total de faturamento mensal: R$ " + totalFaturamento.ToString("F2"));

        // Calcula e exibe o percentual de cada estado
        foreach (var estado in faturamento)
        {
            double percentual = (estado.Value / totalFaturamento) * 100;
            Console.WriteLine($"{estado.Key}: {percentual.ToString("F2")}%");
        }
    }
}
