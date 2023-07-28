using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labday11
{
    internal class TheOtherClass
    {
        public int Thearray(int arsize)
        {
            int[] arr = new int[arsize];

            int i = 0;
            for (i = 0; i < arsize; i++)
            {
                Console.Write("Enter the element " + (i + 1) + ": ");
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The data that you entered are,");
            for(i=0;i < arr.Length; i++)
            {
                if(i==0 || i%2==0)
                    Console.WriteLine(arr[i]);
                else
                    Console.WriteLine("0");
            }
            Console.ReadKey();
            return arr[arsize];
        }
    }
}
