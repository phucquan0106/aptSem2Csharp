using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpPractical
{
    public abstract class Product
    {
        private int id;
        private string name;
        private int price;
        private string producer;

        protected Product(int id, string name, int price, string producer)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.producer = producer;
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                this.id = value;
            }
        }

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

        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                this.price = value;
            }
        }

        public string Producer
        {
            get
            {
                return producer;
            }
            set
            {
                this.producer = value;
            }
        }

        public abstract double computeTax();
    }
}
