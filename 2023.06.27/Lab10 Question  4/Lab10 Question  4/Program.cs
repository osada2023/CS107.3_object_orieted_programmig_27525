using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Question__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4.Question class work
             int[,] num = { { 10, 20 }, { 23, 43 } };
             int minimumvalue = num[0,0];
            int maximumvalue = num[1,0];
             for(int i=0; i<2; i++)
             {
             for(int j=0; j<2; j++)
            {
            if (num[i,j] < minimumvalue) 
            { 
             minimumvalue = num[i,j];
             }
             if (num[i, j] >  maximumvalue)
            {
             maximumvalue = num[i, j];
            }
            }
            }
            Console.WriteLine("Minimum value :" + minimumvalue);
            Console.WriteLine("Maximum value :" + maximumvalue);

            Console.ReadKey();

            
        }
    }
}
