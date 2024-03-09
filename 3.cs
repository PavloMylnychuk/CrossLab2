using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть розмірність матриці:");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        Console.WriteLine("Введіть елементи матриці:");

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            string[] row = input.Split(' ');

            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = int.Parse(row[j]);
            }
        }

        int norm = 0;

        for (int j = 0; j < n; j++)
        {
            int max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                if (matrix[i, j] > max)
                {
                    max = matrix[i, j];
                }
            }

            norm += max;
        }

        Console.WriteLine($"Норма матриці: {norm}");
    }
}
