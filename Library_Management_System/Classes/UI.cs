using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    static class UI
    {
        static public string Login(string P1 , string P2)
        {
            int check = User.CheckUser(P1,P2);
            if (check == 1)
            {
                return("Librarian");
            }
            else if(check == 2)
            {
                return ("Customer");
            }
            return "";
        }

    }
}
