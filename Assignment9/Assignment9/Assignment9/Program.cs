using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment9
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input number of minutes: ");
            int min = Convert.ToInt32(Console.ReadLine());
            Thread hienGio = new Thread(RunThread);
            hienGio.Start(min);
            Console.ReadLine();
        }

       

        public static void Main2(string[] args)
        {
            Thread demNguoc = new Thread(RunThread2);
            demNguoc.Start();
            Console.ReadLine();
        }

        public static void RunThread2()
        {
            for (int j = 0; j<5; j++)
            {
                for (int i = 10; i > 0; i--)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(1000);
                }
                Console.WriteLine("Congratulation!");
                Thread.Sleep(1000);
                Console.Clear();
            }
            Console.WriteLine("THE END");
        }

        public static void RunThread(Object temp)
        {
            int t = (int)temp;
            showTime(t, 0);
            for (int j = t-1; j >= 0; j--)
            {
                for (int i = 59; i >= 0; i--)
                {
                    showTime(j,i);
                    Thread.Sleep(100);
                }
            }
            Console.WriteLine("BOOOMMMMMMM!!!!");
        }

        public static void showTime(int mm, int ss)
        {
            Console.WriteLine(mm.ToString("D2") + ":" + ss.ToString("D2"));
        }

    }
}
