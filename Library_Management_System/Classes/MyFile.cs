using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Windows.Forms;

namespace Library_Management_System.Classes
{
    static class MyFile
    {
        public static void AddRecord(Book book,string path)// for add book in specific file
        {
            FileStream fileStream = new FileStream(path, FileMode.Append, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.WriteLine(book.ID + " | " + book.Name + " | " + book.Author + " | " + book.Quantity + " | " +book.Price +" | " + book.Year);
            MessageBox.Show("Book added", "Event!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            streamWriter.Close();
            fileStream.Close();
        }
        public static void DeleteRecord(Book book, string Path)// for delete book in specific file
        {
            bool flag = false;
            StreamReader sr = new StreamReader(Path);
            FileStream myFile = new FileStream(Path, FileMode.Open, FileAccess.Read);
            string record;
            //Example of book attributes : ID 0 | Name 1 | Author 2 | Quantity 3 | Price 4 | Year 5 (As Written in file)
            while ((record = sr.ReadLine()) != null)
            {
                string[] Fields = record.Split('|');
                if(book.ID == Fields[0])
                {
                    book.ID = " * ";
                    flag = true;
                }
            }
            if(!flag) MessageBox.Show("Book not found", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            sr.Close();
            myFile.Close();
        }
        public static void UpdateRecord(Book book, string Path)// for Update book in specific file
        {
            bool flag = false;
            StreamReader sr = new StreamReader(Path);
            FileStream myFile = new FileStream(Path, FileMode.Open, FileAccess.Read);
            string record;
            //Example of book attributes : ID 0 | Name 1 | Author 2 | Quantity 3 | Price 4 | Year 5 (As Written in file)
            while ((record = sr.ReadLine()) != null)
            {
                string[] Fields = record.Split('|');
                Book book2 = new Book(Fields[1], Fields[2], Fields[5], double.Parse(Fields[4]), int.Parse(Fields[3]));
                if (book.ID == book2.ID)
                {
                    book2.ID = book.ID;
                    book2.Name = book.Name;
                    book2.Author = book.Author;
                    book2.Quantity = book.Quantity;
                    book2.Price = book.Price;
                    book2.Year = book.Year;
                    flag = true;
                }
            }
            if (!flag) MessageBox.Show("Book not found", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            sr.Close();
            myFile.Close();
        }
        public static string ShowFile(string Path, TextBox Place)
        {
            Place.Text = "ID\r\t|\r\tName\r\t|\r\tAuthor\r\t|\r\tQuantity\r\t|\r\tPrice\r|\r\tYear\r\n\r\n";
            FileStream myFile = new FileStream(Path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(myFile);
            string record;
            //Example of book attributes : ID 0 | Name 1 | Author 2 | Quantity 3 | Price 4 | Year 5 (As Written in file)
            while ((record = sr.ReadLine()) != null)
            {
                string[] Fields = record.Split('|');
                Place.Text += Fields[0] + "\r\t|\r\t" + Fields[1] + "\r\t|\r\t" + Fields[2] + "\r\t|\r\t" + Fields[3] + "\r\t|\r\t" + double.Parse(Fields[4]) + "\r\t|\r\t" + int.Parse(Fields[5]) + "\r\n";
                
            }
            sr.Close();
            myFile.Close();
            return Place.Text;

        }
    }
}
