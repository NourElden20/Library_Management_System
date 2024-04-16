using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public interface ILibrarian
    {
        public void ShowAllBooks();
        public void AddNewBook();
        public void DeleteBook();
        public void UpdateBook();

    }
}
