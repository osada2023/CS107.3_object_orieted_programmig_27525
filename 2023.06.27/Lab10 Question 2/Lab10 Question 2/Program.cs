using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.Question class work
            int[] num = { 122, 45, 65, 56, 49, 326, 15, 45, 945, 153 };
            int smallest = num[0];
            int biggest = num[0];

            for (int i = 0; i < num.Length; i++)
            {
                if (smallest > num[i])
                {
                    smallest = num[i];
                }

                if (biggest < num[i])
                {
                    biggest = num[i];
                }
            }

            Console.WriteLine("Minimum element is " + smallest);
            Console.WriteLine("Maximum element is " + biggest);

            Console.ReadKey();
        }
    }
}
