using System;
using System.IO;
using Newtonsoft.Json;

class Program
{
    public class MonthlyRevenue
    {
        public double[] DailyRevenues { get; set; }
    }

    static void Main()
    {
        // Caminho para o arquivo JSON
        string filePath = "revenue.json"; // Altere o caminho se necessário
        
        // Leitura do arquivo JSON
        string json = File.ReadAllText(filePath);
        var revenueData = JsonConvert.DeserializeObject<MonthlyRevenue>(json);

        // Inicializando as variáveis
        double minRevenue = double.MaxValue;
        double maxRevenue = double.MinValue;
        double totalRevenue = 0;
        int validDays = 0;

        // Iterando pelos valores de faturamento diário
        foreach (var revenue in revenueData.DailyRevenues)
        {
            if (revenue > 0) // Ignorando dias sem faturamento
            {
                // Menor e maior faturamento
                if (revenue < minRevenue) minRevenue = revenue;
                if (revenue > maxRevenue) maxRevenue = revenue;

                totalRevenue += revenue;
                validDays++;
            }
        }

        // Cálculo da média de faturamento
        double averageRevenue = totalRevenue / validDays;

        // Contando os dias com faturamento superior à média
        int daysAboveAverage = 0;
        foreach (var revenue in revenueData.DailyRevenues)
        {
            if (revenue > averageRevenue)
            {
                daysAboveAverage++;
            }
        }

        // Exibindo os resultados
        Console.WriteLine($"Menor faturamento: {minRevenue:C}");
        Console.WriteLine($"Maior faturamento: {maxRevenue:C}");
        Console.WriteLine($"Dias com faturamento acima da média: {daysAboveAverage}");
    }
}
