using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class News : INews
    {
        private int id;
        private string title;
        private string publishDate;
        private string author;
        private string content;
        public float averageRate;

        private float[] rateList = new float[3];

        public float[] RateList
        {
            get
            {
                return rateList;
            }
            set
            {
                this.rateList = value;
            }
        }

        public int ID
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

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                this.title = value;
            }
        }
        public string PublishDate
        {
            get
            {
                return publishDate;
            }
            set
            {
                this.publishDate = value;
            }
        }

        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                this.author = value;
            }
        }

        public string Content
        {
            get
            {
                return content;
            }
            set
            {
                this.content = value;
            }
        }

        public News()
        {
        }

        public News(int id, string title, string publishDate, string author, string content, float averageRate)
        {
            this.id = id;
            this.title = title;
            this.publishDate = publishDate;
            this.author = author;
            this.content = content;
            this.averageRate = averageRate;
        }

        public void Display()
        {
            Console.WriteLine("Title: "+ title);
            Console.WriteLine("PublishDate: " + publishDate);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Content: " + content);
            Console.WriteLine("AverageRate: " + averageRate);

        }   

        public void Calculate()
        {
            this.averageRate = (RateList[0] + RateList[1] + RateList[2]) / 3;
            Console.WriteLine("Average Rate: " + averageRate);
        }
    }
}
