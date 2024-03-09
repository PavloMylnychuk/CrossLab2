using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть розмірність матриці:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть елементи матриці:");

        int[,] matrix = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            string[] row = input.Split(' ');

            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = int.Parse(row[j]);
            }
        }

        Console.WriteLine("Введіть k1 та k2:");

        int k1 = int.Parse(Console.ReadLine());
        int k2 = int.Parse(Console.ReadLine());

        int[] products = new int[n];

        for (int j = 0; j < n; j++)
        {
            int product = 1;

            for (int i = k1; i <= k2; i++)
            {
                product *= matrix[i, j];
            }

            products[j] = product;
        }

        Console.WriteLine("Добуток елементів з номерами від k1 до k2 для кожного стовпця:");
        Console.WriteLine(string.Join(" ", products));
    }
}
