using System;

namespace this2
{
    class Program
    {
        static void Main(string[] args)
        {
            Book bookOne = new Book("AuthorOne", "TitleOne", "PublisherOne", new DateTime(2020, 01, 01), 49.95m);

            decimal price = bookOne.CalculateSalesPrice();

            Console.WriteLine($"Author: {bookOne.Author}");
            Console.WriteLine($"Title: {bookOne.Title}");
            Console.WriteLine($"Publisher: {bookOne.Publisher}");
            Console.WriteLine($"Published Date: {bookOne.PublishedOn}");
            Console.WriteLine($"Price: {bookOne.Price}");
        }
    }
}
