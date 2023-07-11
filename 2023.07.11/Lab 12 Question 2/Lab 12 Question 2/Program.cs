using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12_Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            double num1=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            double num2=double.Parse(Console.ReadLine());   

            Arithmetic objarith = new Arithmetic(); 
            objarith.setAns(num1,num2);

            Console.WriteLine("sum: "+ objarith.Summation());
            Console.WriteLine("sub: " + objarith.Difference());
            Console.WriteLine("Multi: " + objarith.Multiplication());
            Console.WriteLine("Div: " + objarith.Division());

            Console.ReadKey();
        }
    }
}
