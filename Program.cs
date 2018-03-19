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
            double S1 = Convert.ToDouble(input[2]);
            double a1 = Math.Sqrt( (4 * S1 * Math.Tan(Math.PI / n)) / n );
            double P = a1 * n;

            double a2 = P / m;
            double S2 = (m * (a2 * a2)) / ( 4 * Math.Tan(Math.PI / m) );

            string otvet = S2.ToString();
            if(S2 == 0) { Console.WriteLine("0,000"); }
            else
            {
                for (int i = 0; i < otvet.Length; i++)
                {
                    Console.Write(otvet[i]);
                    if (otvet[i] == ',') { Console.Write(otvet[i + 1]); Console.Write(otvet[i + 2]); Console.Write(otvet[i + 3]); break; }
                }
            }
        }
    }
}
