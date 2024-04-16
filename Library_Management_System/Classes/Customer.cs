using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class Customer : ICustomer
    {
        public void Purchase()
        {
            Console.Write("Enter Name of book: ");
            string name = Console.ReadLine();
            Console.Write("Enter quantity: ");
            int quantity =int.Parse( Console.ReadLine() );
            Library.PurchaseBook( name, quantity );
        }
        public void Borrow()
        {
            Console.Write("Enter Name of book: ");
            string name = Console.ReadLine();
            Library.BorrowBook( name );
        }
        public void ShowAvailableBooks()
        {

            Console.WriteLine("\n=====================Available Books=====================");
            foreach (Book book in Library.AvailableBooks)
            {
                Console.WriteLine($"ID: {book.ID} | Name: {book.Name} | Author name: {book.Author} | Price: {book.Price} | Quantity: {book.Quantity}");
            }
            Console.WriteLine  ("=========================================================");


        }
    }
}
