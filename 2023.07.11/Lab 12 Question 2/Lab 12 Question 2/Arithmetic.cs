using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12_Question_2
{
    internal class Arithmetic
    {
        private double number1;
        private double number2;

        public void setAns(double num1, double num2)
        {
            number1 = num1;
            number2 = num2;
        }
        public double Summation()
        { 
            return number1+number2; 
        }
        public double Difference()
        {
            return number1 - number2;
        }
        public double Multiplication()
        {
            return number1 * number2;
        }
        public double Division()
        {
            return number1 / number2;
        }

    }
}
