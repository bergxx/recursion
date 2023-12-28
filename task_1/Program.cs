using System;

class Program
{
    static void NaturalNumbers(int M, int N)
    {
        if (M > N)
        {
            return;
        }

        Console.Write(M);

        if (M < N)
        {
            Console.Write(", ");
        }

        NaturalNumbers(M + 1, N);
    }

    static void Main()
    {
        Console.WriteLine("Введите значение M: ");
        int M = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите значение N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        if (M <= 0 || N <= 0)
        {
            Console.WriteLine("Ошибка: Введите положительные значения для M и N.");
        }
        else
        {
            NaturalNumbers(M, N);
        }
    }
}