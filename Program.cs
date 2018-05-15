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
// zadacha #40
using System;
using System.Text;

namespace Rekursia
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = Convert.ToInt32(input[0]);
            int m = Convert.ToInt32(input[1]);
            int k = Convert.ToInt32(input[2]);

            int[,] field = new int[n + 2, m + 2];
            for (int i = 0; i < k; i++)
            {
                string[] str = Console.ReadLine().Split();
                int y = Convert.ToInt32(str[1]);
                int x = Convert.ToInt32(str[2]);
                if (str[0] == "Color")
                {
                    field[y, x] = 1;
                }
                else
                {
                    int counter = 0;
                    string[] cord = new string[4];
                    //up

                    for (int f = y - 1; f >= 1; f--)
                    {
                        if (field[f, x] == 0) { cord[counter] = f.ToString() + " " + x.ToString(); counter++; break; }
                    }

                    //down

                    for (int f = y + 1; f <= n; f++)
                    {
                        if (field[f, x] == 0) { cord[counter] = f + " " + x; counter++; break; }
                    }

                    //right

                    for (int f = x + 1; f <= m; f++)
                    {
                        if (field[y, f] == 0) { cord[counter] = y + " " + f; counter++; break; }
                    }

                    //left

                    //for (int f = x; f <= m; f++)
                    //{
                    //    if (field[y, f] == 0) { cord[counter] = y + " " + f; counter++; break; }
                    //}

                    //output

                    Console.WriteLine(counter); 

                    for (int j = 0; j < 4; j++)
                    {
                        Console.WriteLine(cord[j]);
                    }
                    Console.WriteLine();
                }
            }
            for (int i = 0; i < n + 2; i++)
            {
                for (int j = 0; j < m + 2; j++)
                {
                    Console.Write(field[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
