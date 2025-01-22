using System;

namespace baekjoon
{
    class 사칙연산
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            Console.WriteLine(int.Parse(s[0]) + int.Parse(s[1]));
            Console.WriteLine(int.Parse(s[0]) - int.Parse(s[1]));
            Console.WriteLine(int.Parse(s[0]) * int.Parse(s[1]));
            Console.WriteLine(int.Parse(s[0]) / int.Parse(s[1]));
            Console.WriteLine(int.Parse(s[0]) % int.Parse(s[1]));
        }
    }
}