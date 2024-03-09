using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть числа, розділені пробілами:");
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');

        int sum = 0;

        foreach (var number in numbers)
        {
            int num = int.Parse(number);
            if (num % 2 == 0)
            {
                sum += num * num;
            }
        }

        Console.WriteLine($"Сума квадратів парних елементів: {sum}");
    }
}
