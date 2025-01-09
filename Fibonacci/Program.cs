using System;

class Program
{
    static bool IsFibonacci(int number)
    {
        int previous = 0, current = 1;
        while (current < number)
        {
            int temp = previous;
            previous = current;
            current = temp + current;
        }
        return number == current || number == 0;
    }

    static void Main()
    {
        Console.Write("Digite um número para verificar se ele pertence à sequência de Fibonacci: ");
        int inputNumber = int.Parse(Console.ReadLine());

        if (IsFibonacci(inputNumber))
            Console.WriteLine($"O número {inputNumber} pertence à sequência de Fibonacci.");
        else
            Console.WriteLine($"O número {inputNumber} não pertence à sequência de Fibonacci.");
    }
}
