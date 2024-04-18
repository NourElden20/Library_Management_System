using System;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using Library_Management_System.Classes;

namespace Library_Management_System
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
            Library.ReadFromFile(Library.AvailableBooks, @"AvailableBooks.txt");
            Library.ReadFromFile(Library.BorrowedBooks, @"BorrowedBooks.txt");
            MyFile.CreateFileCustomer(Library.AvailableBooks, @"AvailableBooksCustomer.txt");
            string id = Library.AvailableBooks.Last().ID;
            Book.id = int.Parse(id) + 1;
        }            

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            RegisterForm form = new RegisterForm();
            this.Hide();
            form.ShowDialog();
           this.Close();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            
            if (UI.Login(txt_Email.Text,txt_Password.Text) == "Librarian")
            {
                LibrarianForm form = new LibrarianForm();
                form.ShowDialog();
                this.Hide();
            }
            else if(UI.Login(txt_Email.Text, txt_Password.Text) == "Customer")
            {
                CustomerForm form = new CustomerForm();
                form.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect email or password, register if you haven't an account","Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
        }
    }
}