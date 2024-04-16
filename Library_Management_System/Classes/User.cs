using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace Library_Management_System
{
   public class Person
    {
        public string Username;
        public string Password;

        public Person SetPerson(string username, string password)
        {
            Username = username;
            Password = password;
            return this;
        }
    }
    class User
    {
        public static bool IsLibrarian(Person p)
        {       
            string Path = @"Librarian.txt";
            StreamReader sr = new StreamReader(Path);
            FileStream myFile = new FileStream(Path,FileMode.Open, FileAccess.Read);
            string record ;
            while ((record = sr.ReadLine()) != null)
            {             
                string[] Fields = record.Split('|');
                if (Fields[0] == p.Username && Fields[1] == p.Password)
                {
                    return true;
                }
            }          
            sr.Close();
            myFile.Close();
            return false;
        }
        public static bool IsCustomer(Person p)
        {
         
            string Path = @"Customers.txt";
            StreamReader sr = new StreamReader(Path);
            FileStream myFile = new FileStream(Path, FileMode.Open, FileAccess.Read);
            string record;
            while ((record = sr.ReadLine()) != null)
            {              
                string[] Fields = record.Split('|');
                if (Fields[0] == p.Username && Fields[1] == p.Password)
                {
                    return true;
                }
            }
            sr.Close();
            myFile.Close();
            return false;
        }

        public static int CheckUser()
        {
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            Person p = new Person();
            
            if (IsLibrarian(p.SetPerson(username, password)))
            {
                return 1;
            }
            else if (IsCustomer(p))
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
    }
}
