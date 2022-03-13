using System;

namespace task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Book", 25, "10.10.2022", 100);
            Book book = new Book("Born of Crime", 25, "15.11.2016", 12, "Trevor Noah", "Comedey");
            NewsPaper newsPaper = new NewsPaper("Ekinchi", 21, "11.11.2022", 25, "Planetler", "Kontakt home");
            book.Books();
            newsPaper.Newspapers();
            newsPaper.Pr();
            book.Pr();
            //book.Shell();
            //newsPaper.Shell();
        }
    }
}
