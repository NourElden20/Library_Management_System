using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class Book
    {
        public static int id = 0;

        int Bookid;
        string name = string.Empty;
        string author = string.Empty;
        string year = string.Empty;
        double price;
        double quantity;
        public Book(string name, string author, string year, double price, double quantity)
        {
            this.name = name;
            this.author = author;
            this.year = year;
            this.price = price;
            this.quantity = quantity;

        }
        public Book(Book book)
        {
            this.name = book.Name;
            this.author = book.Author;
            this.year = book.Year;
            this.price = book.Price;
        }
        public string Name {
            get { return name; }

            set { name = value; }
        }
        public string Author
        {
            get { return author; }

            set { author = value; }
        }
        public string Year
        {
            get { return year; }

            set { year = value; }
        }
        public int ID
        {
            get { return Bookid; }

            set { Bookid = value; }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (price > 0) price = value;
                else price = double.Parse(Console.ReadLine());
            }
        }
        public double Quantity
        {
            get { return quantity; }
            set
            {
                if (quantity > 0) quantity = value;
                else quantity = double.Parse(Console.ReadLine());
            }
        }

        public static Book EnterBookAttributes(string Name,string Author,string Year,double Price,int quantity)
        {           
            Book book = new Book(Name, Author, Year, Price, quantity);
            return book;
        }
        

    }
}
