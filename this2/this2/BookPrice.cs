using System;
using System.Collections.Generic;
using System.Text;

namespace this2
{
    class BookPrice
    {
        public static decimal FinalPrice(Book book)
        {
            return book.Price * 0.06m;
        }
    }
}
