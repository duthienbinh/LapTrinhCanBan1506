using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phuongtrinhbac2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap So A:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Nhap So B:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Nhap So C:");
            double c = double.Parse(Console.ReadLine());
            double d = b * b - 4 * a * c;
            if (d < 0)
            {
                Console.WriteLine("VN");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("{0}x^2 + {1}x + {2:f2} = 0", a, b, c);
                Console.WriteLine("x1 = {0}, x2 = {1}", x1, x2);

            }
            Console.ReadKey(); 
        }
        
    }
}
