using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOverride
{
    class Human
    {
        public int id;
        public string name;
        public int age;

        public Human()
        {
        }

        public virtual void Run()
        {

        }

        public void Run(int number)
        {

        }

        public void Run(string str)
        {

        }
    }
}
