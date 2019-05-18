using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    public delegate void showString(string s);

    public class Product
    {
        public string name;
        public int price = 0;
        public event showString Click;

        public void ShowEvent()
        {
            if (Click != null)
            {
                Click("Click here...");
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }

        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                if (this.price != 0 && this.price != value)
                {
                    Click("Price was changed: " + value);
                }
                this.price = value;
            }
        }

    }
    class Program
    {
        public static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.Click += showStringProgram;
            p1.Price = 10;
            p1.Price = 20;
            Console.ReadLine();
        }
        public static void showStringProgram(string x)
        {
            Console.WriteLine("show: "+x);
        }
    }
}
