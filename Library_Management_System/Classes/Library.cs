using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public static class Library
    {
       public static List<Book>  AllBooks      = new List<Book>();
       public static List<Book>  AvailableBooks = new List<Book>();
       public static List<Book>  BorrowedBooks = new List<Book>();

        public static void RemoveBook(int id)
        {
            foreach (Book book in AvailableBooks)
            {
                if(book.ID == id)
                {
                    AllBooks.Remove(book);
                    AvailableBooks.Remove(book);
                    Console.WriteLine($"Book has ID {id} has been removed");
                    return;
                }
            }
            Console.WriteLine("Book not found");
        }
        public static void UpdateBook(int id)
        {
            foreach (Book book in AvailableBooks)
            {
                if (book.ID == id)
                {
                   Book b2 = new Book(Book.EnterBookAttributes());
                    book.Name = b2.Name;
                    book.Author = b2.Author;
                    book.Year = b2.Year;
                    book.Price = b2.Price;
                    book.Quantity = b2.Quantity;
                    return;
                }
            }
            Console.WriteLine("Book not found");
        }
        public static void AddBook(Book book)
        {       
            AllBooks.Add(book);
            AvailableBooks.Add(book);
            book.ID = ++Book.id;    
        }
        public static void PurchaseBook(string name , int quantity)
        {
            foreach (Book book in AvailableBooks)
            {
                if (book.Name == name)
                {
                   if(book.Quantity > quantity)
                    {
                        Console.WriteLine("Book Purchased Successfully");
                        book.Quantity -= quantity;
                        if (book.Quantity == 0)
                            RemoveBook(book.ID);

                        return;
                    }
                }
            }
            Console.WriteLine("Book not found");
        }
        public static void BorrowBook(string name)
        {
            foreach (Book book in AvailableBooks)
            {
                if (book.Name == name)
                {
                    if (book.Quantity > 1)
                    {
                        BorrowedBooks.Add(book);
                        Console.WriteLine("Book Borrowed Successfully");
                        book.Quantity -= 1;
                        

                        return;
                    }
                    else if (book.Quantity == 1)
                    {
                        Console.WriteLine("We cannot lend it");
                        AvailableBooks.Remove(book);
                    }
                }
            }
            Console.WriteLine("Book not found");
        }
    }
}
