using System;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine(); // 77 77 7777
        
        string[] numbers = input.Split(' '); // 77 77 7777
        long a = long.Parse(numbers[0]);
        long b = long.Parse(numbers[1]);
        long c = long.Parse(numbers[2]); // 7731

        long sum = a + b + c;
        
        Console.WriteLine(sum);
    }
}