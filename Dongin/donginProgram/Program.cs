using Microsoft.VisualBasic;
using System.Collections;
using System.ComponentModel;

class Program
{
    static void Main()
    {
        int a;
        a = int.Parse(Console.ReadLine());

        Console.WriteLine(Factorial(a));
        List<int> aasd = new List<int>();

        aasd.Add(123);
        aasd.Remove(123);


    }

    static int Factorial(int x)
    {
        if (x == 0)
        {
            return 1;
        }
        return x * Factorial(x - 1);
    }
}
