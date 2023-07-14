using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, tot = 0, i = 0;
            double avg;
            for (i = 0; i <= 9; i++)
            {
                Console.Write("Enter the " + (i + 1) + " number: ");
                num = Convert.ToInt32(Console.ReadLine());
                tot = tot + num;
            }
            avg = (double)tot / 10.0;
            Console.WriteLine("The average is " + avg);
            Console.ReadKey();

            int j = 10;
            for (i = 10; i > 0; i--)
            {
                Console.WriteLine(i);

                Console.ReadKey();




            }
        }
    }

    }

