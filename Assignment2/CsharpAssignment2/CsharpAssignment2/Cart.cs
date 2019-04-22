using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignment2
{
    class Cart
    {
        public int id;
        public string customer;
        public double grandTotal;
        List<Product> productList;
        public string city;
        public string country;

        public Cart()
        {
        }

        public Cart(int id, string customer, double grandTotal, List<Product> productList, string city, string country)
        {
            this.id = id;
            this.customer = customer;
            this.grandTotal = grandTotal;
            this.productList = productList;
            this.city = city;
            this.country = country;
        }

        public void addCart()
        {
            Console.WriteLine("Please input product details to add: ");
            Console.WriteLine("id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("name: ");
            string name = Console.ReadLine();
            Console.WriteLine("price: ");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("qty: ");
            int qty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("image: ");
            string image = Console.ReadLine();
            Console.WriteLine("desc: ");
            string desc = Console.ReadLine();
            Console.WriteLine("gallery: ");
            List<string> gallery = new List<string>();
            gallery.Add(Console.ReadLine());
            Product product = new Product(id, name, price, qty, image, desc, gallery);

            this.productList.Add(product);
        }

        public void deleteProduct(int temp)
        {
            bool found = false;
            
            for(int i=0;i < this.productList.Count;i++)
                {
                    if (this.productList[i].id == temp)
                    {
                        this.productList.RemoveAt(i);
                        found = true;
                    }
                }
            
            if (!found)
            {
                Console.WriteLine("Product not found!");
            }
            else
            {
                Console.WriteLine("Delete succesfully!");
            }
        }

        public double checkTotal()
        {
            double temp = 0;
            foreach (Product p in productList)
            {
                temp += p.price * p.qty;
            }
            if (city.Equals("Hanoi"))
            {
                temp *= 1.01;
            }
            if (city.Equals("HCM"))
            {
                temp *= 1.02;
            }
            if (!country.Equals("Vietnam"))
            {
                temp *= 1.05;
            }
            return temp;
        }
    }
}
