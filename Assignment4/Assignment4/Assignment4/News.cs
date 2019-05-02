using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class News : INews
    {
        public int ID;
        public string Title;
        public string PublishDate;
        public string Author;
        public string Content;
        public float AverageRate;
        public int[] RateList = new int[3];

        public News(String title, String publishDate, String author, String content)
        {

            this.Title = title;
            this.PublishDate = publishDate;
            this.Author = author;
            this.Content = content;
        }

        public void Display()
        {
            Console.WriteLine("Title:" + Title);            
            Console.WriteLine("PublishDate:" + PublishDate);            
            Console.WriteLine("Author:" + Author);            
            Console.WriteLine("Content:" + Content);            
            Console.WriteLine("AverageRate:" + AverageRate);            
        }

        public void Calculate()
        {
            this.AverageRate = (RateList[0] + RateList[1] + RateList[2]) / 3;
        }

    }
}
