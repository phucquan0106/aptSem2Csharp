using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Contact
    {
        private string name;
        private string phone;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                this.phone = value;
            }
        }

        public Contact()
        {
        }

        public Contact(string name, string phone)
        {
            this.name = name;
            this.phone = phone;
        }
    }
}
