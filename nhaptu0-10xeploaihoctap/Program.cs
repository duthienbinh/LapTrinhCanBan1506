using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nhaptu0_10xeploaihoctap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap Diem Can Xet");
            double diemxet = double.Parse(Console.ReadLine());

            if (diemxet >= 0 && diemxet < 3.5)
            {
                Console.WriteLine("kem");
            }
            if (diemxet >= 3.5 && diemxet < 5.0)
            {
                Console.WriteLine("yeu");
            }
            if (diemxet >= 5.0 && diemxet < 6.5)
            {
                Console.WriteLine("trung binh");
            }
            if (diemxet >= 6.5 && diemxet < 8.5) 
            {
                Console.WriteLine("kha");
            }
            if (diemxet >= 8.5 && diemxet <= 10)
            {
                Console.WriteLine("gioi");
            }
            //cach 2
            if (diemxet < 3.5)
            {
                Console.WriteLine("kem");
            }
            else if (diemxet < 5.0)
            {
                Console.WriteLine("yeu");
            }
            else if (diemxet < 6.5)
            {
                Console.WriteLine("trung binh");
            }
            else if (diemxet < 8.5)
            {
                Console.WriteLine("trung binh kha");
            }
            else  
            {
                Console.WriteLine("kha gioi");
            }

            Console.ReadKey();
            {
                
            


            }
        }
    }
}
