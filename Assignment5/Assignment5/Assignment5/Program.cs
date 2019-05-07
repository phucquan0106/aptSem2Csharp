using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            String choice, name, phone, exit;
            List<Contact> arrContact = new List<Contact>();
            PhoneBook phoneBook = new PhoneBook(arrContact);
            while (true)
            {
                Console.WriteLine("PHONEBOOK MANAGEMENT SYSTEM:" + "\n"
                                    + "1. Insert Phone" + "\n"
                                    + "2. Remove Phone" + "\n"
                                    + "3. Update Phone" + "\n"
                                    + "4. Search Phone" + "\n"
                                    + "0. Exit" + "\n"
                                    + "Your choice: "
                );
                choice = Console.ReadLine().Trim();
                switch (choice)
                {
                    case ("1")://================Insert Phone==============
                        Console.WriteLine("Please input Name and Phone to Insert: ");
                        Console.WriteLine("Name: ");
                        name = Console.ReadLine();
                        Console.WriteLine("Phone: ");
                        phone = Console.ReadLine();
                        phoneBook.insertPhone(name, phone);

                        break;
                    case ("2")://================Remove Phone==============
                        Console.WriteLine("Please input Name to Remove: ");
                        name = Console.ReadLine();
                        phoneBook.removePhone(name);

                        break;
                    case ("3")://================Update Phone==============
                        Console.WriteLine("Please input Name to Update: ");
                        Console.WriteLine("Name: ");
                        name = Console.ReadLine();
                        Console.WriteLine("New Phone: ");
                        phone = Console.ReadLine();
                        phoneBook.updatePhone(name, phone);
                        break;
                    case ("4")://================Search Phone==============
                        Console.WriteLine("Please input Name to Search: ");
                        Console.WriteLine("Name: ");
                        name = Console.ReadLine();
                        phoneBook.searchPhone(name);
                        break;
                    
                    case ("0")://================EXIT==============
                        return;
                    default://=============Wrong Choice==============
                        Console.WriteLine("Wrong Choice!");
                        break;
                }

            }
            Console.ReadKey();
        }
    }
}
