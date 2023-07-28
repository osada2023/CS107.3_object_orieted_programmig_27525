using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labday11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arsize;
            Console.Write("Enter the size of the array: ");
            arsize = Convert.ToInt32(Console.ReadLine());

            TheOtherClass obj1 = new TheOtherClass();
            obj1.Thearray(arsize);

            
        }
    }
}
