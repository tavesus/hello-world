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
//zadacha I arhimed
using System;
using System.Text;

namespace sdsd
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            StringBuilder start_number = new StringBuilder(Console.ReadLine());
            string static_start_number = start_number.ToString();
            StringBuilder max_number = new StringBuilder("");

            for (int i = 0; i < n; i++)
            {
                int[] max = { 0, 0 };
                for (int j = 0; j < n; j++)
                {
                    if (start_number[j] != '*' && max[0] < Convert.ToInt32(start_number[j].ToString())) { max[0] = Convert.ToInt32(start_number[j].ToString()); max[1] = j; }
                }
                max_number.Append(max[0]); 
                start_number[max[1]] = '*';
            }
            string max_number0 = max_number.ToString();
            for (int i = n-1; i > 0; i--)
            {
                if (max_number[i - 1] != max_number[i]) 
                {
                    char ch = max_number[i - 1];
                    max_number[i - 1] = max_number[i];
                    max_number[i] = ch;
                    break;
                } 
            }
            if (max_number0 == max_number.ToString() || max_number.ToString() == static_start_number) { Console.WriteLine("No"); }
            else { Console.WriteLine(max_number); }
        }
    }
}
