using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть числа, розділені пробілами:");
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');

        int[] array = Array.ConvertAll(numbers, int.Parse);

        int minIndex = Array.IndexOf(array, array.Min());
        int maxIndex = Array.LastIndexOf(array, array.Max());

        if (minIndex > maxIndex)
        {
            Console.WriteLine("Максимальний елемент зустрічається пізніше мінімального.");
        }
        else
        {
            int sum = array.Skip(minIndex + 1).Take(maxIndex - minIndex - 1).Sum();
            Console.WriteLine($"Сума елементів між першим і останнім мінімальними: {sum}");
        }
    }
}
