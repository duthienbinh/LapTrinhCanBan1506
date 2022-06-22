using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sudungham
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            XinChao();
            PhuongTrinhBac2();
            XinChao("Tèo");
            Ngaythangnamsinh();
            

            Console.ReadKey();
        }

        private static void Menu()
        {
            Console.WriteLine("====Menu====");
            Console.WriteLine("1. XinChao");
            Console.WriteLine("2. XinChao Tèo");
            Console.WriteLine("3. Phuong Trinh Bac 2");
            Console.WriteLine("4. Ngay Thang Nam Sinh");
            string Chon = Console.ReadLine();
            switch (Chon)
            {
                case "1": XinChao();break;
                case "2": XinChao("Tèo"); break;
                case "3": PhuongTrinhBac2(); break;
                case "4": Ngaythangnamsinh(); break;
                case "exit": return;

                
                    
            }
            Menu();
        }

        private static void Ngaythangnamsinh()
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
                    Console.WriteLine("Khoan Đã, vì đây là tháng 2 nên tôi cân thêm thông tin và đó là năm!");
                    Console.WriteLine("Vì Vây Hãy Nhâp Năm:");
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
        }

        private static void XinChao(string Hoten)
        {
            Console.WriteLine("Xin Chào {0}", Hoten);
        }

        private static void XinChao()
        {
            Console.WriteLine("Xin Chào!");
        }

        private static void PhuongTrinhBac2()
        {
            Console.WriteLine("Nhap So A:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap So B:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap So C:");
            double c = double.Parse(Console.ReadLine());
            double d = Math.Pow(b, 2) - 4 * a * c;
            try
            {
                if (d < 0)
                {
                    throw new Exception("VN");
                }
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("x1 = {0}, x2 = {1}", x1, x2);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            }

        }

        

        }

        
   

