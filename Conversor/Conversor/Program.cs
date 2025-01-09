using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma string para inverter: ");
        string inputString = Console.ReadLine();

        string reversedString = string.Empty;
        for (int i = inputString.Length - 1; i >= 0; i--)
        {
            reversedString += inputString[i];
        }

        Console.WriteLine($"String invertida: {reversedString}");
    }
}
