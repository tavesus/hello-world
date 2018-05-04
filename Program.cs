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
