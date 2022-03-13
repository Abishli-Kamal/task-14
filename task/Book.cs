using System;
using System.Collections.Generic;
using System.Text;

namespace task
{
    internal class Book:Product
    {
        public string Author;
        public string Genre;

        public Book(string name, int price, string releaseDate, int count, string author, string genre):base(name,price,releaseDate,count)
        {
            Author = author;
            Genre = genre;
        }
        public void Books()
        {
            Console.WriteLine($"Author:{Author} Genre:{Genre} ");
        }
    }
}
