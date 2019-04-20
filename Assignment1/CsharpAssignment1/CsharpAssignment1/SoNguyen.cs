using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignment1
{
    class SoNguyen
    {
        public int a;

        public void nhapMotSo()
        {
            Console.WriteLine("Moi ban nhap mot so nguyen: ");
            a = Convert.ToInt32(Console.ReadLine());

        }

        public Boolean kiemTraNguyenTo(int n)
        {
            if (n < 2)
            {
                return false;
            }
            int canBacHai = (int)Math.Sqrt(n);
            for (int i = 2; i <= canBacHai; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public void bai1Assignment2(int n)
        {
            Console.WriteLine("Danh sach cac so Nguyen to nho hon " + n + " la: ");
            for (int i = 0; i < n; i++)
            {
                if (kiemTraNguyenTo(i))
                {
                    Console.Write(i + "   ");
                }
            }
        }

        public int bai2Assignment2(int n)
        {
            int f1 = 0;
            int f2 = 1;
            int fn, sum = 0;
            if (n <= 1)
            {
                return 0;
            }
            if (n == 2)
            {
                return 1;
            }
            if (n >= 3)
            {
                sum = 1;
                for (int i = 3; i <= n; i++)
                {
                    fn = f1 + f2;
                    f1 = f2;
                    f2 = fn;
                    sum += fn;
                }

            }
            return sum;
        }
    }
}
