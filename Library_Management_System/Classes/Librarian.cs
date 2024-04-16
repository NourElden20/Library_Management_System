using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{

    public class Librarian :  ILibrarian
    {

        public void AddNewBook()
        {
            Book book = new Book( Book.EnterBookAttributes() );
            Library.AddBook( book );
            Console.WriteLine("BookAdded");
        }

        public void DeleteBook()
        {
            Console.WriteLine("Enter id of book to remove");
            int i = int.Parse( Console.ReadLine() );
            Library.RemoveBook(i);
            Console.WriteLine("Book Removed");
        }

        public void ShowAllBooks()
        {
            Console.WriteLine("\n=====================All Books=====================");
            foreach (Book book in Library.AllBooks)
            {              
                Console.WriteLine($"ID: {book.ID} | Name: {book.Name} | Author name: {book.Author} | Price: {book.Price} | Quantity: {book.Quantity}");
            }
            Console.WriteLine("===================================================");

        }

        public void UpdateBook()
        {
            Console.WriteLine("Enter id of book to update");
            int i = int.Parse(Console.ReadLine());
            Library.UpdateBook(i);
        }
    }
}
