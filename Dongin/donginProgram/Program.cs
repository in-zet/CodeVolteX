﻿using Microsoft.VisualBasic;
using System.Collections;
using System.ComponentModel;

class Program
{
    static void Main()
    {
        StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

        int score = int.Parse(Console.ReadLine());

        switch (score)
        {
            case < 60:
                sw.WriteLine("F");
                break;
            case < 70:
                sw.WriteLine("D");
                break;
            case < 80:
                sw.WriteLine("C");
                break;
            case < 90:
                sw.WriteLine("B");
                break;
            default:
                sw.WriteLine("A");
                break;
        }

        sr.Close();
        sw.Close();
        return;
    }
}
