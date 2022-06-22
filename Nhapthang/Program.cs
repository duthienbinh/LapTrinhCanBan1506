using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhapthang
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Nhap Thang:");
                int Thang;
                bool kt = int.TryParse(Console.ReadLine(), out Thang);
                if (kt == false)
                {
                    throw new Exception("Ban nhap chua dung dinh danh!");
                }
                if (Thang <= 0 || Thang > 12)
                {
                    throw new Exception("Thang Khong Hop Le");
                }
                Console.WriteLine("Thang Hop le la thang: {0}", Thang);
                int nam;
                if (Thang == 2)
                {
                    kt = int.TryParse(Console.ReadLine(), out nam);
                    if (kt == false)
                    {
                        throw new Exception("Nam Khong Dung Dinh Dang !!!");

                    }
                    if (nam % 4 == 0)
                    {
                        Console.WriteLine("29 ngày");
                    }
                    else
                    {
                        Console.WriteLine("28 ngày");
                    }
                }
                else
                {
                    int ngay = 31;
                    if (Thang == 4 || Thang == 6 || Thang == 11 || Thang == 9)
                    {
                        ngay = 30;
                    }
                    Console.WriteLine("So ngay: {0}", ngay);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
