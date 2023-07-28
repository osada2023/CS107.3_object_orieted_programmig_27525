using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_Question_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int[] num = new int[10];
            Console.WriteLine("Enter 10 numbers");
            for (i = 0; i < 10; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }

            
            for (i = 0; i < 10; i++)
            {
                Console.Write($"{num[i]} "); 
            }

            int min = num[0];
            int max = num[0];
            for (i = 0; i < num.Length; i++)
            {
                if (num[i] < min)
                {
                    min = num[i];
                }
                if (num[i] > max)
                {
                    max = num[i];
                }
            }

            int tot = 0;
            for (i = 0; i < num.Length; i++)
            {
                tot = tot + num[i];
            }
            float avg = (float)tot / num.Length;

            
            int[] reversedNum = new int[num.Length];
            for (i = 0; i < num.Length; i++)
            {
                reversedNum[i] = num[num.Length - 1 - i];
            }

            
            Console.WriteLine($"The minimum number is {min}");
            Console.WriteLine($"The maximum number is {max}");
            Console.WriteLine($"The average is {avg}");

            Console.Write("The reversed array is ");
            for (i = 0; i < num.Length; i++)
            {
                Console.Write($"{reversedNum[i]} ");
            }

            Console.ReadKey();
        }
    }
}

