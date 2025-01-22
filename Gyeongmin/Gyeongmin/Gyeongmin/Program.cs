using System;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');

        long N = long.Parse(numbers[0]);
        long M = long.Parse(numbers[1]);

        long difference = Math.Abs(N - M);

        Console.WriteLine(difference);
    }
}
