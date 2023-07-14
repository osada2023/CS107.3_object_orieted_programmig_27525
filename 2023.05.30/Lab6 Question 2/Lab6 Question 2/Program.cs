using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab6_Question_2
{
    internal class Program
    {
        Public static void printname(string name, int age)
        {
            Console.WriteLine(name + " " + age);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter your name; ");
            string name = Console.ReadLine();
            Console.Write("Enter your age; ");
            int age = int.Parse(Console.ReadLine());

            printname(name, age);
            Console.ReadKey();

           


        }
    }
}
