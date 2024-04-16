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
    public partial class AddNewBookForm : Form
    {
        public AddNewBookForm()
        {
            InitializeComponent();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Book b2 = new Book(Book.EnterBookAttributes(Txt_BookName.Text, Txt_Author.Text, Txt_Pubdate.Text, double.Parse(Txt_Price.Text), int.Parse(Txt_Quantity.Text)));
            Library.AddBook(b2);
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            LibrarianForm librarianForm = new LibrarianForm();
            this.Hide();
            librarianForm.ShowDialog();
            this.Close();
        }
    }
}
