using System;
using System.Collections.Generic;
using System.Text;

namespace this2
{
    public class Book
    {
        private string author;
        private string title;
        private string publisher;
        private DateTime publishedOn;
        private decimal price;

        public string Author { get => author; set => author = value; }
        public string Title { get => title; set => title = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public DateTime PublishedOn { get => publishedOn; set => publishedOn = value; }
        public decimal Price { get => price; set => price = value; }

        public Book(string author, string title, string publisher, DateTime pubdate, decimal price)
        {
            this.Author = author;
            this.Title = title;
            this.Publisher = publisher;
            this.PublishedOn = pubdate;
            this.Price = price;
        }

        //public decimal Price { get => price; }

        public decimal CalculateSalesPrice()
        {
            return (this.Price + BookPrice.FinalPrice(this));
        }

        //class Nested(){}
    }
}
