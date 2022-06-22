using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ngoaile
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Nhap so nguyen A:");
                int a;
                bool kt = int.TryParse(Console.ReadLine(), out a);
                if (kt == false)
                {
                    throw new Exception("Ban Nhap Khong Dung!!!");
                }
                
                Console.WriteLine("a la: {0}", a);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);


            }
            Console.ReadKey();
        }
    }
}
