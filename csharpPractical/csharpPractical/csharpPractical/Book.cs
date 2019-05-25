using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpPractical
{
    public class Book : Product
    {
        public Book(int id, string name, int price, string producer) : base(id, name, price, producer)
        {
        }

        public override double computeTax()
        {
            return (double)this.Price*0.08;
        }
    }
}
