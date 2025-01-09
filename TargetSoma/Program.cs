using System;

class Program
{
    static void Main()
    {
        int index = 13, sum = 0, k = 0;
        while (k < index)
        {
            k++;
            sum += k;
        }
        Console.WriteLine("Soma total: " + sum);
    }
}
