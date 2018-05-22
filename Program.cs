using System;

namespace Rekursia
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string max = "";
            string number = "";

            for (int i = 0; i < input.Length; i++)
            {
                bool start = false;
                if (input[i] >= '0' && input[i] <= '9')
                {
                    start = true;
                    number += input[i];
                }
                if (start == false || i == input.Length - 1)
                {
                    if (max == "") { max = number; }
                    else
                    {
                        if (number.Length > max.Length) { max = number; }
                        else
                        {
                            if (number.Length == max.Length)
                            {
                                for (int j = 0; j < number.Length; j++)
                                {
                                    if (Convert.ToInt16(max[j]) < Convert.ToInt16(number[j])) { max = number; number = ""; break; }
                                }
                            }
                        }
                    }
                    number = "";
                }
            }
            if (max == "") { Console.WriteLine(0); }
            else { Console.WriteLine(max); }
        }
    }
}
//Arhimed zadacha C

using System;

namespace sdsd
{
    class Program
    {
        static string[,] matryx;
        static void Recursion(int x, int y)
        {

        }
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int h = Convert.ToInt32(input[0]);
            int w = Convert.ToInt32(input[1]);
            matryx = new string[h, w];
            input = Console.ReadLine().Split();
            matryx[Convert.ToInt32(input[0]), Convert.ToInt32(input[1])] = "+";
            input = Console.ReadLine().Split();
            matryx[Convert.ToInt32(input[0]), Convert.ToInt32(input[1])] = "-";


        }
    }
}
