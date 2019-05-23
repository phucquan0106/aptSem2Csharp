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
            Thread demNguoc = new Thread(RunThread);
            demNguoc.Start();
            Console.ReadLine();
        }

        public static void RunThread()
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

        
    }
}
