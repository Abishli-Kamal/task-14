using System;
using System.Collections.Generic;
using System.Text;

namespace task
{
    internal class NewsPaper:Product
    {
        public string Advertisement;
        public string Article;
        

        public NewsPaper(string name, int price, string releaseDate, int count, string advertisement, string article):base( name, price,releaseDate, count)
        {
            Advertisement = advertisement;
            Article = article;
            
        }
        public void Newspapers()
        {
            Console.WriteLine($"Advertisement:{Advertisement} Article:{Article}");
        }
    }
}
