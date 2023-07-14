using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab__10
{
    internal class Program
    {
        static void Main(string[] args)
        {
             //Class work
             int[] num = new int[10];
             int  sum = 0;   

             for  (int i = 0; i < num.Length; i++)
             {
             Console.Write("Enter Value :  ");
            num[i] =  int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < num.Length; i++)
            {
            sum = sum + num[i]; 
            Console.WriteLine(sum);
             }
            Console.ReadKey();

            

        }
    }
}
    


