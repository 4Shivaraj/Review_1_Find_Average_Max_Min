// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Welcome To Review Day -1 Problems");

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingAverageMaxMin;
class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome To Day-1 Assisgnment");
        Console.WriteLine("1 For Average of five number");
        Console.WriteLine("2 For Max minimum of five number");

        int problem = Convert.ToInt32(Console.ReadLine());
        switch (problem)
        {
            case 1:
                FindingAverageMax findingaverage = new FindingAverageMax();
                findingaverage.AverageCompuation();
                break;
            case 2:
                FindingAverageMax findingmax = new FindingAverageMax();
                findingmax.AverageMaxMin();
                break;
        }

    }
}
