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
    public partial class UpdateBook : Form
    {
        public UpdateBook()
        {
            InitializeComponent();
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            Book b2 = new Book(Book.EnterBookAttributes(Txt_BookName.Text,Txt_Author.Text,Txt_Pubdate.Text, double.Parse(Txt_Price.Text),int.Parse(Txt_Quantity.Text)));
            Library.UpdateBook(int.Parse(Txt_ID.Text), b2);
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            LibrarianForm librarianForm = new LibrarianForm();
            this.Hide();
            librarianForm.ShowDialog();
            this.Close();
        }

        private void UpdateBook_Load(object sender, EventArgs e)
        {

        }
    }
}
