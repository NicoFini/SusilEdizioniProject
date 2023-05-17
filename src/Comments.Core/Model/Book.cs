using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunsilEdizioni.Core.Model
{
    public class Book
    {
        public int _id;
        public string _title;
        public string _author;
        public decimal _price;
        public string _publisher;
        public int _yearPublished;
        public string _ISBN;

        public Book(int id, string title, string author, decimal price, string publisher, int yearPublished, string ISBN)
        {
            _id = id;
            _title = title;
            _author = author;
            _price = price;
            _publisher = publisher;
            _yearPublished = yearPublished;
            _ISBN = ISBN;
        }
    }
}
