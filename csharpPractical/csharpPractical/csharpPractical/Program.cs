using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpPractical
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] arrProduct = new Product[6];

            arrProduct[0] = new Book(1,"book1",100,"producer1");
            arrProduct[1] = new Book(2,"book2",200,"producer2");
            arrProduct[2] = new Book(3,"book3",300,"producer3");

            arrProduct[3] = new MobilePhone(4, "phone1", 100, "producer4");
            arrProduct[4] = new MobilePhone(5, "phone2", 200, "producer5");
            arrProduct[5] = new MobilePhone(6, "phone3", 300, "producer6");

            double taxBooks = 0;
            double taxMobilePhone = 0;
            double totalTax = 0;

            for(int i = 0; i < arrProduct.Length; i++)
            {
                if(arrProduct[i] is Book)
                {
                    taxBooks += arrProduct[i].computeTax();
                }
                else
                {
                    taxMobilePhone += arrProduct[i].computeTax();
                }
            }

            totalTax = taxMobilePhone + taxBooks;

            Console.WriteLine("Total tax of Books: " + taxBooks);
            Console.WriteLine("Total tax of MobilePhones: " + taxMobilePhone);
            Console.WriteLine("Total tax of all items: " + totalTax);
            Console.ReadLine();
        }
    }
}
