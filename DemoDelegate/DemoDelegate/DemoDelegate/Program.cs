using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegate
{
    //declare Delegate showString
    public delegate void showString(string s);
    public delegate void number(int a,int b);

    public class EvenTest
    {
        public event showString Click;
        public int age = 0;
        public void showEvent()
        {
            if(Click != null)
            {
                Click("Click here...");
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if(this.age != null && this.age != value)
                {
                    Click("Age was changed");
                }
                this.age = value;
            }
        }
    }

    class Program
    {

        public static void Main(string[] args)
        {
            EvenTest ev = new EvenTest();
            ev.Click += showStringProgram;
            ev.Age = 20;
            ev.Age = 22;

            ev.showEvent();
            
            //map ss with showStringProgram
            showString ss = new showString(showStringProgram);
            showString s2 = new showString(showStringPro);
            ss += s2;
            ss("Hello ss");

            ss.Invoke("Hello invoke");

            number nPlus = new number(numberPlus);
            number nMinus = new number(numberMinus);
            number nMultiply = new number(numberMultiply);
            number nDivide = new number(numberDivide);

            nPlus(3, 2);
            nPlus += nMultiply;
            nPlus(5, 6);
            nPlus += nMinus += nMultiply += nDivide;
            nPlus(10, 5);

            Console.ReadLine();
        }
        public static void showStringProgram(string x)
        {
            Console.WriteLine(x);
        }

        public static void showStringPro(string x)
        {
            Console.WriteLine("showStringPro " + x);
        }

        public static void numberPlus(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static void numberMinus(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        public static void numberMultiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        public static void numberDivide(int a, int b)
        {
            Console.WriteLine(a / b);
        }
    }
}
