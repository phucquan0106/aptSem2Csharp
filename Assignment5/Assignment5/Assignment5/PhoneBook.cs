using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class PhoneBook : Phone
    {
        private List<Contact> phoneList = new List<Contact>();

        public PhoneBook(List<Contact> phoneList)
        {
            this.phoneList = phoneList;
        }

        public List<Contact> PhoneList
        {
            get
            {
                return phoneList;
            }
            set
            {
                this.phoneList= value;
            }
        }

        public Boolean existPhone(string oldNumber, string newNumber)
        {
            string[] arrNumber = oldNumber.Split(':');
            foreach(string temp in arrNumber)
            {
                if (temp.Equals(newNumber))
                {
                    return true;
                }
            }
            return false;
        }

        public override void insertPhone(string name, string phone)
        {
            int temp = 0;
            for (int i = 0; i < this.PhoneList.Count(); i++)
            {
                if (this.PhoneList[i].Name.Equals(name))
                {
                    
                    temp++;
                    if (!existPhone(this.PhoneList[i].Phone, phone))
                    {
                        this.PhoneList[i].Phone = this.PhoneList[i].Phone + ":" + phone;
                    }
                    break;
                }
            }
            if (temp == 0)
            {
                Contact c = new Contact(name, phone);
                this.PhoneList.Add(c);
            }
            printPhoneList(this.PhoneList);
        }

        public override void removePhone(string name)
        {
            int temp = 0;
            for (int i = 0; i < this.PhoneList.Count(); i++)
            {
                if (this.PhoneList[i].Name.Equals(name))
                {
                    this.PhoneList.RemoveAt(i);
                    temp++;
                    break;
                }
            }
            if (temp == 0)
            {
                Console.WriteLine("Name does not exist!");
            }
            printPhoneList(this.PhoneList);
        }

        public override void searchPhone(string name)
        {
            int temp = 0;
            for (int i = 0; i < this.PhoneList.Count(); i++)
            {
                if (this.PhoneList[i].Name.Equals(name))
                {
                    Console.WriteLine("Name: " + name + "--Phone: " + this.PhoneList[i].Phone);
                    temp++;
                    break;
                }
            }
            if (temp == 0)
            {
                Console.WriteLine("Name does not exist!");
            }
        }

        public override void updatePhone(string name, string newphone)
        {
            int temp = 0;
            for (int i = 0; i < this.PhoneList.Count(); i++)
            {
                if (this.PhoneList[i].Name.Equals(name))
                {
                    this.PhoneList[i].Phone =newphone;
                    temp++;
                    break;
                }
            }
            if (temp == 0)
            {
                Console.WriteLine("Name does not exist!");
            }
            printPhoneList(this.PhoneList);
        }
        public void printPhoneList(List<Contact> arrContact)
        {
            Console.WriteLine("PhoneList: ");
            for (int i = 0; i < arrContact.Count(); i++)
            {
                Console.WriteLine("Name: " + arrContact[i].Name + " -- Phone: " + arrContact[i].Phone);
            }
        }
    }
}
