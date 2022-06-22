using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinh_tam_giac
{
    class Program
    {
        static void Main(string[] args)
        {
            //nhap 3 canh cua tam giac
            Console.WriteLine("Nhap Canh A:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Nhap Canh B:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Nhap Canh C:");
            double c = double.Parse(Console.ReadLine());
            double chuvi = a + b + c;
            double P = chuvi / 2;
            double dienTich = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
            Console.WriteLine(@"CV = {0} DT = {1}", chuvi,dienTich);
            Console.WriteLine("Chu vi tam giac abc la: {0}", chuvi);
            Console.WriteLine("Dien tich hinh tam giac abc la: {0}", dienTich);

            Console.ReadKey();
        }
    }
}
