using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<News> listNews = new List<News>();
            string choice;
            while (true)
            {
                Console.WriteLine("MENU: ");
                Console.WriteLine("1. Insert news");
                Console.WriteLine("2. View list news");
                Console.WriteLine("3. Average rate");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Your choice: ");
                choice = Console.ReadLine().Trim();
                switch (choice)
                {
                    case ("1")://==============Insert News========
                        News news = insertNews();
                        listNews.Add(news);
                        break;
                    case ("2")://=========View list news==========
                        foreach(News n in listNews)
                        {
                            n.Display();
                        }
                        break;
                    case ("3")://============Average Rate=====
                        foreach (News n in listNews)
                        {
                            n.Calculate();
                            n.Display();
                        }
                        break;
                    case ("4")://======Exit=======
                        return;
                    default:
                        Console.WriteLine("Wrong input!");
                        break;
                }
            }
            Console.ReadLine();
        }

        public static News insertNews()
        {
            
            string title, publishDate, author, content;
            Console.WriteLine("Please input News: ");
            Console.WriteLine("Title: ");
            title = Console.ReadLine().Trim();
            Console.WriteLine("PublishDate: ");
            publishDate = Console.ReadLine().Trim();
            Console.WriteLine("Author: ");
            author = Console.ReadLine().Trim();
            Console.WriteLine("Content: ");
            content = Console.ReadLine().Trim();
            News news = new News(title, publishDate, author, content);
            Console.WriteLine("Please input 3 Rates: ");
            for (int i = 0; i < news.RateList.Length; i++)
            {
                Console.WriteLine("Rate " + (i + 1) + ": ");
                news.RateList[i]=Convert.ToInt32(Console.ReadLine());
            }
            return news;
        }

        
    }
    
}
