using Microsoft.VisualBasic;
using System.Collections;
using System.ComponentModel;

class Program
{
    static void Main()
    {
        StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

        int[] ints = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

        sr.Close();
        sw.Close();
        return;
    }
}
