using System;

class Program
{
    static void ArrayRevers(int[] arr, int index)
    {
        if (index >= 0)
        {
            Console.Write(arr[index] + " ");
            ArrayRevers(arr, index - 1);
        }
    }

    static void Main()
    {
        Console.WriteLine("Введите элементы массива через пробел:");
        string input = Console.ReadLine();

        int[] myArray = Array.ConvertAll(input.Split(' '), int.Parse);

        Console.WriteLine("Обратный массив:");
        ArrayRevers(myArray, myArray.Length - 1);
    }
}