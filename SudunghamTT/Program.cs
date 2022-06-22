using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudunghamTT
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            Console.ReadKey();
        }

        private static void SuDungVongLap()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Xin Chào");
                Console.WriteLine(i + 1);

            }
        }

        private static void Menu()
        {
            Console.WriteLine("====MENU====");
            Console.WriteLine("1. Su Dung Vong Lap");
            Console.WriteLine("2. Tim So Lon Nhat");
            Console.WriteLine("3. Tinh Tong Cac So tu 1 / N");
            Console.WriteLine("4. Tinh N dai thua");
            Console.WriteLine("5. Tinh Tong Tu 1 -> N");
            Console.WriteLine("Luu Y: nho Ghi So neu muon mo");
            string chon = Console.ReadLine();
            switch (chon)
            {
                case "1":
                    SuDungVongLap();
                    break;
                case "2":
                    TimSoLonNhat();
                    break;
                case "3":
                    TinhTongCacSoTu1chiaN();
                    break;
                case "4":
                    TinhNdaithua();
                    break;
                case "5":
                    TinhTongToiN();
                    break;
                case "exit": return; 
            }
        }

        private static void TinhNdaithua()
        {
            try
            {
                Console.WriteLine("Chao Mung Ban Den Voi Tinh N giai thua!");
                Console.WriteLine("de tinh N giai thua ta can phai nhap so nguyen N!");
                Console.WriteLine("Nhap So Nguyen N:");
                int n;
                bool kt = int.TryParse(Console.ReadLine(), out n);
                if (kt == false)
                {
                    throw new Exception("BAN NHAP KHONG DUNG DINH DANG !!!");
                }
                if (n <= 0)
                {
                    throw new Exception("N phai lon hon 0!");
                }
                int giaithua = 1;
                for (int i = 1; i <= n; i++)
                {
                    giaithua = giaithua * i;
                }
                Console.WriteLine("N1 = {0}", giaithua);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        private static void TinhTongToiN()
        {
            
            try
            {
                Console.WriteLine("Nhap So Nguyen:");
                int N = int.Parse(Console.ReadLine());
                int tong = 0;
                for (int i = 0; i <= N; i++)
                {
                    tong = tong + i;
                }
                Console.WriteLine("Tong tu 1 toi N la: {0}", tong);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }

        private static void TinhTongCacSoTu1chiaN()
        {
            try
            {
                Console.WriteLine("Chao Mung Ban Den Voi Tinh Tong Cac So Tu 1 / N!");
                Console.WriteLine("de tinh tu 1 / N ta can phai nhap so nguyen N!");
                Console.WriteLine("Nhap So Nguyen N:");
                int n;
                bool kt = int.TryParse(Console.ReadLine(), out n);
                if (kt == false)
                {
                    throw new Exception("BAN NHAP KHONG DUNG DINH DANG !!!");
                }
                if (n <= 0)
                {
                    throw new Exception("N phai lon hon 0!");
                }
                double giaithua = 0;
                for (int i = 1; i <= n; i++)
                {
                    giaithua = giaithua + 1.0/i;
                }
                Console.WriteLine("N1 = {0}", giaithua);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        private static void TimSoLonNhat()
        {
            Console.WriteLine("Chao Mung Ban Den Voi Tim So Lon Nhat Va Nho Nhat!");
            Console.WriteLine("De Tim So Lon Nhat Va Nho Nhat Ban Can Nhap So A, B, C!");
            Console.WriteLine("Nhap a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c:");
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
        }
    }
}
