using Library_Management_System.Classes;
using System;
using System.Collections.Generic;
using System.IO;
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

        public static void ReadFromFile(List<Book> list,string Path)
        {          
            StreamReader sr = new StreamReader(Path);
            FileStream myFile = new FileStream(Path, FileMode.Open, FileAccess.Read);
            string record;
            //Example of book attributes : ID 0 | Name 1 | Author 2 | Quantity 3 | Price 4 | Year 5 (As Written in file)
            while ((record = sr.ReadLine()) != null)
            {
                string[] Fields = record.Split('|');
                Book book = new Book(Fields[1], Fields[2], Fields[5], double.Parse(Fields[4]), int.Parse(Fields[3]));
                list.Add(book);
            }
            sr.Close();
            myFile.Close();
          
        }
        
        public static void WriteOnFile(List<Book> list,string Path) // For write lists in files (# un necessary) ( take books from list and write it as record in a file)
        {
            StreamWriter sr = new StreamWriter(Path);
            FileStream fileStream = new FileStream(Path,FileMode.Append, FileAccess.Write);
            foreach(Book book in list)
            {
                string record = book.ID +" | " + book.Name + " | " + book.Author + " | " + book.Quantity + " | " + book.Price + " | " + book.Year;
                sr.WriteLine(record);
            }
            fileStream.Close();
            sr.Close();
        }
        public static void RemoveBook(int id)
        {
            foreach (Book book in AvailableBooks)
            {
                if(book.ID == id.ToString())
                {
                    MyFile.DeleteRecord(book, @"AvailableBooks.txt");
                    AllBooks.Remove(book);
                    AvailableBooks.Remove(book);
                    return;
                }
            }
        }
        public static void UpdateBook(int id, Book b2)
        {
            foreach (Book book in AvailableBooks)
            {
                if (book.ID == id.ToString())
                {
                    MyFile.UpdateRecord(book, @"AvailableBooks.txt");                    
                    return;
                }
            }
           
        }
        public static void AddBook(Book book)
        {
            book.ID =  (++Book.id).ToString();   
            AvailableBooks.Add(book);
            AllBooks.Add(book);
            MyFile.AddRecord(book, @"AvailableBooks.txt");          
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
                            RemoveBook(int.Parse(book.ID));

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
