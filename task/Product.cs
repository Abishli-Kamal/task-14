using System;
using System.Collections.Generic;
using System.Text;

namespace task
{
    internal class Product
    {
        public string Name;
        public int Price;
        public string ReleaseDate;
        public int Count;

        public Product(string name, int price, string releaseDate, int count)
        {
            Name = name;
            Price = price;
            ReleaseDate = releaseDate;
            Count = count;
        }
        public void Pr()
        {
            Console.WriteLine($"Name:{Name} Price:{Price} ReleaseDate:{ReleaseDate} Count:{Count}");
        }

        public void Shell()
        {
            while (Count > 1)
            {
                Count--;
                Console.WriteLine(Count);
            }
            Console.WriteLine("satis prosesi heyata kecmedi ");
            
        }
    }
}
