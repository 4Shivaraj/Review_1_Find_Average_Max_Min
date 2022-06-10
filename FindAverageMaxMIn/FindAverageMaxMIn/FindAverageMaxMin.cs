using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingAverageMaxMin
{

    public class FindingAverageMax
    {
        double firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber, Average;

        public void AverageCompuation()
        {

            Console.WriteLine("Enter the first number: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            thirdNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the fourth number: ");
            fourthNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the fifth number: ");
            fifthNumber = Convert.ToInt32(Console.ReadLine());

            double Average = (firstNumber + secondNumber + thirdNumber + fourthNumber + fifthNumber) / 5;
            Console.WriteLine("The Average of Five numbers:" + Average);
        }
        public void AverageMaxMin()
        {
            int a, b, c, d, e;
            Console.WriteLine("Enter the first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the fourth number: ");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the fifth number: ");
            e = Convert.ToInt32(Console.ReadLine());

            List<int> numbers = new List<int>();
            numbers.Add(a);
            numbers.Add(b);
            numbers.Add(c);
            numbers.Add(d);
            numbers.Add(e);

            Console.WriteLine("Max : " + numbers.Max());
            Console.WriteLine("Min : " + numbers.Min());

        }
    }
}



//Result

//Welcome To Day-1 Assisgnment
//1 For Average of five number
//2 For Max minimum of five number
//2
//Enter the first number:
//1
//Enter the second number:
//2
//Enter the third number:
//3
//Enter the fourth number:
//4
//Enter the fifth number:
//5
//Large Number is:
//The Max of Five numbers:5
//The Min of Five numbers:1

//-----------------------------------------------------//

//welcome To Day-1 Assisgnment
//1 For Average of five number
//2 For Max minimum of five number
//2
//Enter the first number:
//5
//Enter the second number:
//7
//Enter the third number:
//9
//Enter the fourth number:
//4
//Enter the fifth number:
//7
//Max: 9
//Min: 4



