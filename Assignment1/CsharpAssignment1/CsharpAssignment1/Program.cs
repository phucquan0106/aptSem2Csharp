using System;

namespace CsharpAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            SoNguyen soNguyen = new SoNguyen();
            Console.WriteLine("Bai 1 Assignment2: ");
            soNguyen.nhapMotSo();
            soNguyen.bai1Assignment2(soNguyen.a);
            Console.WriteLine("");
            Console.WriteLine("Bai 2 Assignment2: ");
            Console.WriteLine("Luu y : day so Fibonacci: 0,1,1,2,3,5,8,13,21,... bat dau tu 0.");
            soNguyen.nhapMotSo();
            Console.WriteLine("Tong cua " + soNguyen.a + " so dau tien cua day Fibonacci la: " + soNguyen.bai2Assignment2(soNguyen.a));
            Console.ReadLine();
        }
    }
}
