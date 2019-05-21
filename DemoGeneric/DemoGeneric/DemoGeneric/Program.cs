using System;
using System.Collections.Generic;
namespace DemoGeneric
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Number<int> number = new Number<int>();
            number.number_one = 20;
            number.number_two = 122;
            number.total();

            number.genericMethod("param for generic method");

            Number<float> number2 = new Number<float>();
            number2.number_one = 12;
            number2.number_two = (float)3.14;
            number2.total();
            // List<int> aa = new List<int>();
            MyGeneric<int, string> xyz = new MyGeneric<int, string>();

            Console.ReadLine();
        }
    }
    public class MyGeneric<K, V>
    {

    }


    public class Number<T>
    {
        public T number_one;
        public T number_two;

        public void total()
        {
            if (number_one is int)
            {
                int x = Convert.ToInt32(number_one);
                int y = Convert.ToInt32(number_two);
                Console.WriteLine(x + y);
            }
            else if (number_one is double || number_one is float)
            {
                double x = Convert.ToDouble(number_one);
                double y = Convert.ToDouble(number_two);
                Console.WriteLine(x + y);
            }
        }

        public E genericMethod<E>(E val)
        {
            return val;
        }

        public B gemericMethod2<B>(B val1, B val2)
        {
            if (val1.Equals(val2))
            {
                return val1;
            }
            else
            {
                return val2;
            }
        }

        public int genericMethod3<C>(C val1, C val2)
        {
            if (val1.Equals(val2))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

    }

}