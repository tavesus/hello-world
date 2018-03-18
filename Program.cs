using System;
using System.Text;

namespace cSuper
{
    class Program
    {       
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = Convert.ToInt32(input[0]);
            int m = Convert.ToInt32(input[1]);
            double S = Convert.ToDouble(input[2]);
            double a = Math.Pow(S,1.0 / n);

            double d1 = n * (a * a);
            double d2 = 4 * Math.Tan(Math.PI / n);
            double d3 = d1 / d2;

            Console.WriteLine(d3);
        }
    }
}
