using Library_Management_System.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.Librarian_Folder
{
    public partial class ShowAllBooks : Form
    {
        public ShowAllBooks()
        {
            InitializeComponent();
        }

        private void Btn_ShowAvailableBooks_Click(object sender, EventArgs e)
        {
            MyFile.ShowFile(@"AvailableBooks.txt", textBox1);
        }

        private void Btn_ShowBorrowedBooks_Click(object sender, EventArgs e)
        {
            MyFile.ShowFile(@"BorrowedBooks.txt", textBox1);
        }

       

        private void Btn_Back_Click_1(object sender, EventArgs e)
        {
            LibrarianForm librarianForm = new LibrarianForm();
            this.Hide();
            librarianForm.Show();
            this.Close();
        }
    }
}
