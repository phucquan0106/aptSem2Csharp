using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOverride
{
    public class Asian : Human, HumanInterface, IHuman
    {
        public Asian()
        {
            this.id = 10;
        }

        public override void Run()
        {

        }

        public new void Run(int number)
        {

        }

        public void Jump()
        {

        }

    }
}
