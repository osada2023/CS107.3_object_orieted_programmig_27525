using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the radius : ");
            double radius = double.Parse(Console.ReadLine());   

            Findvalues obj = new Findvalues  ();
            double  area =  obj.findArea(radius);
             Console.WriteLine("area :" + area);

            double  circumference  = obj.findcircumference(radius);
            Console.WriteLine("circumference :"+  circumference);
            Console.ReadKey();

          
            

           




        }
    }
}
