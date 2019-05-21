using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MyGenericList<int, string>> arrObj = new List<MyGenericList<int, string>>();
            MyGenericList<int, string> obj1 = new MyGenericList<int, string>();
            MyGenericList<int, string> obj2 = new MyGenericList<int, string>();
            MyGenericList<int, string> obj3 = new MyGenericList<int, string>();
            obj1.Key = 1;
            obj1.Value = "aa";
            obj2.Key = 2;
            obj2.Value = "bb";
            obj3.Key = 3;
            obj3.Value = "cc";

            arrObj.Add(obj1);
            arrObj.Add(obj2);
            arrObj.Add(obj3);

            foreach(MyGenericList<int,string> temp in arrObj)
            {
                Console.WriteLine(temp.key + "--"+temp.value);
            }
            Console.ReadLine();
        }
    }

    public class MyGenericList<K, V>
    {
        public K key;
        public V value;

        public K Key
        {
            get
            {
                return key;
            }
            set
            {
                this.key = value;
            }
        }

        public V Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
            }
        }

    }
 }
