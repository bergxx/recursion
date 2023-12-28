using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите неотрицательное m: ");
        int number2;
        while (!int.TryParse(Console.ReadLine(), out number2) || number2 < 0)
        {
            Console.WriteLine("m должна быть неотрицательным числом. Введите m");
        }

        Console.WriteLine("Введите неотрицательное n: ");
        int number;
        while (!int.TryParse(Console.ReadLine(), out number) || number < 0)
        {
            Console.WriteLine("n должна быть неотрицательным числом. Введите n");
        }

        Console.WriteLine($"A({number2},{number}) = {funct1(number, number2)}");

    }

    static ulong funct1(int n, int m)
    {
        if (n == 0)
        {
            return (ulong)(m + 1);
        }
        else if (m == 0)
        {
            return funct1(n - 1, 1);
        }
        else
        {
            return funct1(n - 1, (int)funct1(n, m - 1));
        }
    }
}