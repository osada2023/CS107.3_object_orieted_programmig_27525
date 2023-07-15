using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator \n");
            Findvalues obj = new Findvalues();

            Console.WriteLine("Please enter the two numbers: ");

            Console.WriteLine("Number 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Number 2: ");
            int num2 = int.Parse(Console.ReadLine());

            double answer = 0;

            Console.WriteLine("Enter your choice (1 to 4 calculate sum): ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                answer = obj.Addition(num1, num2);
            }
            else if (input == "2")
            {
                answer = obj.Subtraction(num1, num2);
            }
            else if (input == "3")
            {
                answer = obj.Multiplication(num1, num2);
            }
            else if (input == "4")
            {
                answer = obj.Divide(num1, num2);
            }
            else
            {
                Console.WriteLine("Invalid choice!");
                return; 
            }
            
            Console.WriteLine("Answer: " + answer);
            Console.ReadKey();



        }
    }
}
