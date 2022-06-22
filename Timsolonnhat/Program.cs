using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timsolonnhat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c");
            int c = int.Parse(Console.ReadLine());
            int max = a;
            if (max < b)
            {
                max = b;
            }
            if (max < c)
            {
                max = c;
            }
            Console.WriteLine("So Lon Nhat La: {0}", max);
            int min = a;
            if (min > b)
            {
                min = b;
            }
            if (min > c)
            {
                min = c;
            }
            Console.WriteLine("So Nho Nhat La: {0}", min);
            
            Console.ReadKey();


        }
    }
}
