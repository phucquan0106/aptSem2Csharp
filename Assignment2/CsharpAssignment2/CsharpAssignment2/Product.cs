using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignment2
{
    class Product
    {
        public int id;
        public string name;
        public int price;
        public int qty;
        public string image;
        public string desc;
        public List<string> gallery;

        public Product()
        {
        }

        public Product(int id, string name, int price, int qty, string image, string desc, List<string> gallery)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
            this.image = image;
            this.desc = desc;
            this.gallery = gallery;
        }

        public void getInfo()
        {
            Console.WriteLine("id: " + id);
            Console.WriteLine("name: " + name);
            Console.WriteLine("price: " + price);
            Console.WriteLine("qty: " + qty);
            Console.WriteLine("image: " + image);
            Console.WriteLine("desc: " + desc);
            Console.WriteLine("Gallery: ");
            int i = 0;
            foreach (string s in gallery)
            {
                i++;
                Console.WriteLine(i+". "+s);
            }
            Console.WriteLine();
        }

        public void checkStock()
        {
            if (gallery.Count > 0)
            {
                Console.WriteLine("In Stock!");
            }
            else {
                Console.WriteLine("Out of Stock!");
            }
        }

        public void insertGallery(string s)
        {
            if (gallery.Count > 10)
            {
                Console.WriteLine("Full! Please delete items to add more!");
                return;
            }
            this.gallery.Add(s);
        }

        public void deleteGallery()
        {
            Console.WriteLine("Gallery: ");
            int i = 0;
            foreach (string s in gallery)
            {
                i++;
                Console.WriteLine(i + ". " + s);
            }
            Console.WriteLine("Please input No. of Gallery to delete:");
            int temp = Convert.ToInt32(Console.ReadLine());
            this.gallery.RemoveAt(temp - 1);
            Console.WriteLine("Gallery after delete: ");
            i = 0;
            foreach (string s in gallery)
            {
                i++;
                Console.WriteLine(i + ". " + s);
            }
        }
    }
}
