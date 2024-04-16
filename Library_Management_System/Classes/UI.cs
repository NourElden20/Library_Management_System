using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    static class UI
    {
        static public void Login()
        {
            int check = User.CheckUser();
            if (check == 1)
            {
                Console.WriteLine("Librarian");
            }
            else if(check == 2)
            {
                Console.WriteLine("Customer");
            }
            else
            {
                Console.WriteLine("Invalid username or password");
            }
        }

    }
}
