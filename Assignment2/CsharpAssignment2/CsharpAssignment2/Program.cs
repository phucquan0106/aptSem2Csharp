using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CsharpAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = null;
            string choice;
            string exit;
            int id;
            string name;
            int price;
            int qty;
            string image;
            string desc;
            List<string> gallery=new List<string>();
            
            while (true)
            {
                Console.WriteLine("=========MENU========");
                Console.WriteLine("1. Create Product.");
                Console.WriteLine("2. Display product info.");
                Console.WriteLine("3. Check stock.");
                Console.WriteLine("4. Insert gallery");
                Console.WriteLine("5. Delete gallery");
                Console.WriteLine("6. Exit");
                Console.WriteLine("Your choice: ");
                choice = Console.ReadLine().Trim();
                switch (choice)
                {
                    case ("1")://================Create Product==============
                        if (product != null)
                        {
                            Console.WriteLine("Product exits!");
                            continue;
                        }

                        Console.WriteLine("Please input product details: ");
                        Console.WriteLine("id: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("name: ");
                        name = Console.ReadLine();
                        Console.WriteLine("price: ");
                        price = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("qty: ");
                        qty = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("image: ");
                        image = Console.ReadLine();
                        Console.WriteLine("desc: ");
                        desc = Console.ReadLine();
                        Console.WriteLine("gallery: ");
                        gallery.Add(Console.ReadLine());
                        product = new Product(id, name, price, qty, image, desc, gallery);

                        Console.WriteLine("Enter number 1 to go back Menu or any other to EXIT");
                        exit = Console.ReadLine().Trim();
                        if (exit.Equals("1")) 
                        {
                            continue;
                        }
                        else
                        {
                            return;
                        }
                    case ("2")://================Display product info==============
                        Console.WriteLine("Product info.: ");
                        product.getInfo();

                        Console.WriteLine("Enter number 1 to go back Menu or any other to EXIT");
                        exit = Console.ReadLine().Trim();
                        if (exit.Equals("1"))
                        {
                            continue;
                        }
                        else
                        {
                            return;
                        }
                    case ("3")://================Check stock==============
                        Console.WriteLine("Check stock: ");
                        product.checkStock();

                        Console.WriteLine("Enter number 1 to go back Menu or any other to EXIT");
                        exit = Console.ReadLine().Trim();
                        if (exit.Equals("1"))
                        {
                            continue;
                        }
                        else
                        {
                            return;
                        }
                    case ("4")://================Insert gallery==============
                        Console.WriteLine("input gallery name to insert:");
                        product.insertGallery(Console.ReadLine());

                        Console.WriteLine("Enter number 1 to go back Menu or any other to EXIT");
                        exit = Console.ReadLine().Trim();
                        if (exit.Equals("1"))
                        {
                            continue;
                        }
                        else
                        {
                            return;
                        }
                    case ("5")://================Delete gallery==============
                       
                        product.deleteGallery();

                        Console.WriteLine("Enter number 1 to go back Menu or any other to EXIT");
                        exit = Console.ReadLine().Trim();
                        if (exit.Equals("1"))
                        {
                            continue;
                        }
                        else
                        {
                            return;
                        }
                    case ("6")://===================Exit====================
                        return;

                    default://=============Wrong Choice==============
                        Console.WriteLine("Wrong Choice!");
                        Console.WriteLine("Enter number 1 to go back Menu or any other to EXIT");
                        exit = Console.ReadLine().Trim();
                        if (exit.Equals("1"))
                        {
                            continue;
                        }
                        else
                        {
                            return;
                        }

                }
            }
        }
    }
}
